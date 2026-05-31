using AzulTracker.API.Data;
using AzulTracker.API.DTOs;
using AzulTracker.API.Models;
using AzulTracker.API.Services;
using Microsoft.EntityFrameworkCore;

namespace AzulTracker.Tests;

public class AdminServiceTests
{
    // This helper creates a fresh in-memory database for each test.
    // Each test gets its own clean DB so tests never interfere with each other.
    private AppDbContext CreateDb(string dbName)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(dbName)
            .Options;
        return new AppDbContext(options);
    }

    // ── Test 1 ───────────────────────────────────────────────────────
    // UpdateUserRoleAsync should reject any role that isn't "User" or "Admin"
    [Fact]
    public async Task UpdateUserRole_WithInvalidRole_ReturnsError()
    {
        // ARRANGE — set up the database and service
        using var db = CreateDb(nameof(UpdateUserRole_WithInvalidRole_ReturnsError));
        var service = new AdminService(db);

        // ACT — try to set an invalid role
        var (success, error) = await service.UpdateUserRoleAsync(1, "SuperAdmin");

        // ASSERT — it should have failed with an error message
        Assert.False(success);
        Assert.Equal("Role must be 'User' or 'Admin'.", error);
    }

    // ── Test 2 ───────────────────────────────────────────────────────
    // UpdateUserRoleAsync should succeed when given a valid role
    [Fact]
    public async Task UpdateUserRole_WithValidRole_Succeeds()
    {
        // ARRANGE — create a real user in the in-memory DB
        using var db = CreateDb(nameof(UpdateUserRole_WithValidRole_Succeeds));
        db.Users.Add(new User
        {
            Id = 1,
            Username = "testuser",
            Email = "test@test.com",
            PasswordHash = "hash",
            Role = "User"
        });
        await db.SaveChangesAsync();

        var service = new AdminService(db);

        // ACT — promote to Admin
        var (success, error) = await service.UpdateUserRoleAsync(1, "Admin");

        // ASSERT — it should have succeeded
        Assert.True(success);
        Assert.Equal(string.Empty, error);

        // Also verify the DB was actually updated
        var user = await db.Users.FindAsync(1);
        Assert.Equal("Admin", user!.Role);
    }

    // ── Test 3 ───────────────────────────────────────────────────────
    // UpdateUserStatusAsync should return an error if the user doesn't exist
    [Fact]
    public async Task UpdateUserStatus_UserNotFound_ReturnsError()
    {
        // ARRANGE — empty database, no users
        using var db = CreateDb(nameof(UpdateUserStatus_UserNotFound_ReturnsError));
        var service = new AdminService(db);

        // ACT — try to update a user that doesn't exist
        var (success, error) = await service.UpdateUserStatusAsync(999, false);

        // ASSERT
        Assert.False(success);
        Assert.Equal("User not found.", error);
    }

    // ── Test 4 ───────────────────────────────────────────────────────
    // ApproveExerciseAsync should reject if already approved
    [Fact]
    public async Task ApproveExercise_AlreadyApproved_ReturnsError()
    {
        // ARRANGE — create an exercise that is already approved
        using var db = CreateDb(nameof(ApproveExercise_AlreadyApproved_ReturnsError));
        db.ExerciseLibrary.Add(new ExerciseLibrary
        {
            Id = 1,
            Name = "Bench Press",
            Category = "Chest",
            IsApproved = true,   // already approved
            IsCustom = false
        });
        await db.SaveChangesAsync();

        var service = new AdminService(db);

        // ACT — try to approve it again
        var (success, error) = await service.ApproveExerciseAsync(1);

        // ASSERT
        Assert.False(success);
        Assert.Equal("Exercise is already approved.", error);
    }

    // ── Test 5 ───────────────────────────────────────────────────────
    // ApproveExerciseAsync should succeed for a pending exercise
    [Fact]
    public async Task ApproveExercise_PendingExercise_Succeeds()
    {
        // ARRANGE — create an unapproved exercise
        using var db = CreateDb(nameof(ApproveExercise_PendingExercise_Succeeds));
        db.ExerciseLibrary.Add(new ExerciseLibrary
        {
            Id = 1,
            Name = "Custom Curl",
            Category = "Arms",
            IsApproved = false,  // pending approval
            IsCustom = true
        });
        await db.SaveChangesAsync();

        var service = new AdminService(db);

        // ACT
        var (success, error) = await service.ApproveExerciseAsync(1);

        // ASSERT — succeeded and IsApproved is now true in the DB
        Assert.True(success);
        var exercise = await db.ExerciseLibrary.FindAsync(1);
        Assert.True(exercise!.IsApproved);
    }
}