using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace AzulTracker.API.Services;

public class BlobStorageService(IConfiguration configuration)
{
    private readonly string _connectionString =
        configuration["AzureStorage:ConnectionString"]!;

    public async Task<string> UploadMuscleImageAsync(IFormFile file, string fileName)
    {
        var containerClient = new BlobContainerClient(_connectionString, "muscle-images");
        await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);

        var blobClient = containerClient.GetBlobClient(fileName);

        using var stream = file.OpenReadStream();
        await blobClient.UploadAsync(stream, overwrite: true);

        return blobClient.Uri.ToString();
    }
}