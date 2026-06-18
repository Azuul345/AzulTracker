param location string = resourceGroup().location
param sqlServerName string
param sqlDatabaseName string
param keyVaultName string
param storageAccountName string = 'azulstore${uniqueString(resourceGroup().id)}'

@secure()
param sqlAdminLogin string

@secure()
param sqlAdminPassword string

// SQL Server
resource sqlServer 'Microsoft.Sql/servers@2023-08-01-preview' = {
  name: sqlServerName
  location: location
  properties: {
    administratorLogin: sqlAdminLogin
    administratorLoginPassword: sqlAdminPassword
    minimalTlsVersion: '1.2'
  }
}

// SQL Database
resource sqlDatabase 'Microsoft.Sql/servers/databases@2023-08-01-preview' = {
  parent: sqlServer
  name: sqlDatabaseName
  location: location
  sku: {
    name: 'Basic'
    tier: 'Basic'
  }
  properties: {
    collation: 'SQL_Latin1_General_CP1_CI_AS'
    requestedBackupStorageRedundancy: 'Local'
  }
}




// Create the Storage Account
resource storageAccount 'Microsoft.Storage/storageAccounts@2022-09-01' = {
  name: storageAccountName
  location: location 
  sku: {
    name: 'Standard_LRS' // Locally-redundant storage for lowest cost
  }
  kind: 'StorageV2'
  properties: {
    allowBlobPublicAccess: true // This MUST be true to allow the container to be public
    minimumTlsVersion: 'TLS1_2'
  }
}

// Access the Blob Service within the Storage Account
resource blobService 'Microsoft.Storage/storageAccounts/blobServices@2022-09-01' = {
  parent: storageAccount
  name: 'default'
}

// Create the 'muscle-images' container and set access to Blob (read only for blobs)
resource muscleImagesContainer 'Microsoft.Storage/storageAccounts/blobServices/containers@2022-09-01' = {
  parent: blobService
  name: 'muscle-images'
  properties: {
    publicAccess: 'Blob' // Sets the access level so frontend can render images via URL
  }
}

// Allow Azure services to connect (App Service needs this)
resource sqlFirewallAzureServices 'Microsoft.Sql/servers/firewallRules@2023-08-01-preview' = {
  parent: sqlServer
  name: 'AllowAzureServices'
  properties: {
    startIpAddress: '0.0.0.0'
    endIpAddress: '0.0.0.0'
  }
}

// Key Vault
resource keyVault 'Microsoft.KeyVault/vaults@2023-07-01' = {
  name: keyVaultName
  location: location
  properties: {
    sku: {
      family: 'A'
      name: 'standard'
    }
    tenantId: subscription().tenantId
    enableRbacAuthorization: true
    softDeleteRetentionInDays: 7
    enableSoftDelete: true
  }
}

// Outputs (non-sensitive only)
output sqlServerFqdn string = sqlServer.properties.fullyQualifiedDomainName
output keyVaultUri string = keyVault.properties.vaultUri
