using AzulTracker.API.Data;
using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using Microsoft.EntityFrameworkCore;

namespace AzulTracker.API.Services;

public class ProgramExerciseService(AppDbContext db)
{
    public async Task<List<ProgramExerciseDto>> GetAllAsync(int programDayId, int userId)
    {
        var dayBelongsToUser = await db.ProgramDays
            .AnyAsync(d => d.Id == programDayId
                && d.TrainingProgram.UserId == userId);

        if (!dayBelongsToUser) return [];

        var exercises = await db.ProgramExercises
            .Include(e => e.ExerciseLibrary)
            .Where(e => e.ProgramDayId == programDayId)
            .OrderBy(e => e.OrderIndex)
            .ToListAsync();

        return exercises.Select(e => e.ToDto()).ToList();
    }

    public async Task<(ProgramExerciseDto? Result, string? Error)> CreateAsync(
        CreateProgramExerciseDto dto, int programDayId, int userId)
    {
        var dayBelongsToUser = await db.ProgramDays
            .AnyAsync(d => d.Id == programDayId
                && d.TrainingProgram.UserId == userId);

        if (!dayBelongsToUser)
            return (null, "Day not found.");

        if (dto.ExerciseLibraryId is null && string.IsNullOrWhiteSpace(dto.CustomExerciseName))
            return (null, "Either ExerciseLibraryId or CustomExerciseName must be provided.");

        var exercise = dto.ToEntity(programDayId);
        db.ProgramExercises.Add(exercise);
        await db.SaveChangesAsync();

        return (exercise.ToDto(), null);
    }

    public async Task<(ProgramExerciseDto? Result, string? Error)> UpdateAsync(
        int id, UpdateProgramExerciseDto dto, int programDayId, int userId)
    {
        var dayBelongsToUser = await db.ProgramDays
            .AnyAsync(d => d.Id == programDayId
                && d.TrainingProgram.UserId == userId);

        if (!dayBelongsToUser)
            return (null, "Day not found.");

        if (dto.ExerciseLibraryId is null && string.IsNullOrWhiteSpace(dto.CustomExerciseName))
            return (null, "Either ExerciseLibraryId or CustomExerciseName must be provided.");

        var exercise = await db.ProgramExercises
            .FirstOrDefaultAsync(e => e.Id == id && e.ProgramDayId == programDayId);

        if (exercise is null)
            return (null, "Exercise not found.");

        exercise.ExerciseLibraryId = dto.ExerciseLibraryId;
        exercise.CustomExerciseName = dto.CustomExerciseName;
        exercise.Sets = dto.Sets;
        exercise.Reps = dto.Reps;
        exercise.OrderIndex = dto.OrderIndex;
        exercise.Notes = dto.Notes;
        exercise.VideoUrl = dto.VideoUrl;

        await db.SaveChangesAsync();
        return (exercise.ToDto(), null);
    }

    public async Task<bool> DeleteAsync(int id, int programDayId, int userId)
    {
        var dayBelongsToUser = await db.ProgramDays
            .AnyAsync(d => d.Id == programDayId
                && d.TrainingProgram.UserId == userId);

        if (!dayBelongsToUser) return false;

        var exercise = await db.ProgramExercises
            .FirstOrDefaultAsync(e => e.Id == id && e.ProgramDayId == programDayId);

        if (exercise is null) return false;

        db.ProgramExercises.Remove(exercise);
        await db.SaveChangesAsync();
        return true;
    }
}