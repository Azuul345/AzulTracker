using AzulTracker.API.Data;
using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using AzulTracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AzulTracker.API.Services;

public class ExerciseLibraryService(AppDbContext db)
{
    public async Task<List<ExerciseLibraryDto>> SearchAsync(string? query)
    {
        var ids = await db.ExerciseLibrary
            .Where(e => e.IsApproved &&
                (query == null || e.Name.Contains(query)))
            .OrderBy(e => e.Name)
            .Take(20)
            .Select(e => e.Id)
            .ToListAsync();

        var exercises = await db.ExerciseLibrary
            .Include(e => e.ExerciseMuscles)
                .ThenInclude(em => em.Muscle)
            .Where(e => ids.Contains(e.Id))
            .OrderBy(e => e.Name)
            .ToListAsync();

        return exercises.Select(e => e.ToDto()).ToList();
    }

    public async Task<ExerciseLibraryDto?> GetByIdAsync(int id)
    {
        var exercise = await db.ExerciseLibrary
            .Include(e => e.ExerciseMuscles)
                .ThenInclude(em => em.Muscle)
            .FirstOrDefaultAsync(e => e.Id == id && e.IsApproved);

        return exercise?.ToDto();
    }
    public async Task<ExerciseLibraryDto> SubmitCustomAsync(
    int userId, CreateExerciseLibraryDto dto)
    {
        var exercise = dto.ToEntity(userId);
        db.ExerciseLibrary.Add(exercise);
        await db.SaveChangesAsync();

        // Reload with muscle includes for the response
        // (new entity has no muscles yet — empty list is correct)
        return exercise.ToDto();
    }

    public async Task<(ExerciseLibraryDto? Result, string? Error)> UpdateAsync(
        int id, UpdateExerciseLibraryDto dto)
    {
        var exercise = await db.ExerciseLibrary
            .FirstOrDefaultAsync(e => e.Id == id);

        if (exercise is null)
            return (null, "Exercise not found.");

        // Patch only the editable fields — never touch IsApproved,
        // IsCustom, SubmittedByUserId, or CreatedAt
        exercise.Name = dto.Name;
        exercise.Category = dto.Category;
        exercise.VideoUrl = dto.VideoUrl;

        await db.SaveChangesAsync();

        return (exercise.ToDto(), null);
    }

    public async Task<(VideoUrlDto? Result, string? Error)> SubmitVideoUrlAsync(
    int exerciseId, int userId, SubmitVideoUrlDto dto)
    {
        // Verify the exercise exists and is approved
        var exercise = await db.ExerciseLibrary
            .FirstOrDefaultAsync(e => e.Id == exerciseId && e.IsApproved);

        if (exercise is null)
            return (null, "Exercise not found.");

        var videoUrl = new VideoUrl
        {
            Url = dto.Url,
            SubmittedByUserId = userId,
            IsBlocked = false,
            CreatedAt = DateTime.UtcNow
        };

        db.VideoUrls.Add(videoUrl);
        await db.SaveChangesAsync();

        return (new VideoUrlDto
        {
            Id = videoUrl.Id,
            Url = videoUrl.Url,
            IsBlocked = videoUrl.IsBlocked,
            CreatedAt = videoUrl.CreatedAt
        }, null);
    }
}