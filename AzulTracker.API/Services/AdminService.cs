using AzulTracker.API.Data;
using AzulTracker.API.DTOs;
using AzulTracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AzulTracker.API.Services;

public class AdminService(AppDbContext db)
{
    // ── User Management ──────────────────────────────────────────────

    public async Task<List<AdminUserDto>> GetAllUsersAsync()
    {
        return await db.Users
            .Select(u => new AdminUserDto
            {
                Id = u.Id,
                Username = u.Username,
                Email = u.Email,
                Role = u.Role,
                IsActive = u.IsActive,
                CreatedAt = u.CreatedAt
            })
            .OrderBy(u => u.CreatedAt)
            .ToListAsync();
    }

    public async Task<(bool Success, string Error)> UpdateUserStatusAsync(int userId, bool isActive)
    {
        var user = await db.Users.FindAsync(userId);
        if (user is null) return (false, "User not found.");

        user.IsActive = isActive;
        await db.SaveChangesAsync();
        return (true, string.Empty);
    }

    public async Task<(bool Success, string Error)> UpdateUserRoleAsync(int userId, string role)
    {
        if (role != "User" && role != "Admin")
            return (false, "Role must be 'User' or 'Admin'.");

        var user = await db.Users.FindAsync(userId);
        if (user is null) return (false, "User not found.");

        user.Role = role;
        await db.SaveChangesAsync();
        return (true, string.Empty);
    }

    // ── Platform Stats ───────────────────────────────────────────────

    public async Task<AdminStatsDto> GetStatsAsync()
    {
        var totalUsers = await db.Users.CountAsync();
        var activeUsers = await db.Users.CountAsync(u => u.IsActive);
        var totalLogs = await db.WorkoutLogs.CountAsync();

        var topExercises = await db.WorkoutLogs
            .Where(l => l.ProgramExerciseId != null)
            .Include(l => l.ProgramExercise!)
                .ThenInclude(pe => pe.ExerciseLibrary!)
            .GroupBy(l => l.ProgramExercise!.ExerciseLibrary!.Name)
            .Select(g => new PopularExerciseDto
            {
                Name = g.Key,
                LogCount = g.Count()
            })
            .OrderByDescending(e => e.LogCount)
            .Take(5)
            .ToListAsync();

        return new AdminStatsDto
        {
            TotalUsers = totalUsers,
            ActiveUsers = activeUsers,
            TotalWorkoutLogs = totalLogs,
            TopExercises = topExercises
        };
    }

    // ── Video Moderation ─────────────────────────────────────────────

    public async Task<List<AdminVideoUrlDto>> GetPendingVideosAsync()
    {
        return await db.VideoUrls
            .Where(v => !v.IsBlocked)
            .Include(v => v.SubmittedBy)
            .Select(v => new AdminVideoUrlDto
            {
                Id = v.Id,
                Url = v.Url,
                IsBlocked = v.IsBlocked,
                CreatedAt = v.CreatedAt,
                SubmittedByUserId = v.SubmittedByUserId,
                SubmittedByUsername = v.SubmittedBy!.Username
            })
            .OrderBy(v => v.CreatedAt)
            .ToListAsync();
    }

    public async Task<(bool Success, string Error)> BlockVideoAsync(int videoId, int adminId)
    {
        var video = await db.VideoUrls.FindAsync(videoId);
        if (video is null) return (false, "Video URL not found.");

        video.IsBlocked = true;
        video.ReviewedByAdminId = adminId;
        await db.SaveChangesAsync();
        return (true, string.Empty);
    }

    // ── Exercise Moderation ──────────────────────────────────────────

    public async Task<List<PendingExerciseDto>> GetPendingExercisesAsync()
    {
        return await db.ExerciseLibrary
            .Where(e => !e.IsApproved)
            .Include(e => e.SubmittedBy)
            .Select(e => new PendingExerciseDto
            {
                Id = e.Id,
                Name = e.Name,
                Category = e.Category,
                VideoUrl = e.VideoUrl,
                SubmittedByUserId = e.SubmittedByUserId,
                SubmittedByUsername = e.SubmittedBy != null ? e.SubmittedBy.Username : null,
                CreatedAt = e.CreatedAt
            })
            .OrderBy(e => e.CreatedAt)
            .ToListAsync();
    }

    public async Task<(bool Success, string Error)> ApproveExerciseAsync(int exerciseId)
    {
        var exercise = await db.ExerciseLibrary.FindAsync(exerciseId);
        if (exercise is null) return (false, "Exercise not found.");
        if (exercise.IsApproved) return (false, "Exercise is already approved.");

        exercise.IsApproved = true;
        await db.SaveChangesAsync();
        return (true, string.Empty);
    }

    // ── Muscle Management ────────────────────────────────────────────

    public async Task<MuscleDto> AddMuscleAsync(CreateMuscleDto dto)
    {
        var muscle = new Muscle
        {
            Name = dto.Name,
            MuscleGroup = dto.MuscleGroup,
            ImageUrl = dto.ImageUrl
        };

        db.Muscles.Add(muscle);
        await db.SaveChangesAsync();

        return new MuscleDto
        {
            Id = muscle.Id,
            Name = muscle.Name,
            MuscleGroup = muscle.MuscleGroup,
            ImageUrl = muscle.ImageUrl
        };
    }

    public async Task<(bool Success, string Error)> AssignMusclesAsync(int exerciseId, AssignMusclesDto dto)
    {
        var exercise = await db.ExerciseLibrary.FindAsync(exerciseId);
        if (exercise is null) return (false, "Exercise not found.");

        var muscleIds = dto.Muscles.Select(m => m.MuscleId).ToList();
        var validMuscles = await db.Muscles
            .Where(m => muscleIds.Contains(m.Id))
            .Select(m => m.Id)
            .ToListAsync();

        var invalidIds = muscleIds.Except(validMuscles).ToList();
        if (invalidIds.Count > 0)
            return (false, $"Muscle IDs not found: {string.Join(", ", invalidIds)}");

        var existing = await db.ExerciseMuscles
            .Where(em => em.ExerciseLibraryId == exerciseId)
            .ToListAsync();

        db.ExerciseMuscles.RemoveRange(existing);

        var newAssignments = dto.Muscles.Select(m => new ExerciseMuscle
        {
            ExerciseLibraryId = exerciseId,
            MuscleId = m.MuscleId,
            IsPrimary = m.IsPrimary
        }).ToList();

        db.ExerciseMuscles.AddRange(newAssignments);
        await db.SaveChangesAsync();
        return (true, string.Empty);
    }
}