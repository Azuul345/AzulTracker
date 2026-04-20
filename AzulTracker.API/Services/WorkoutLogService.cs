using AzulTracker.API.Data;
using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using AzulTracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AzulTracker.API.Services;

public class WorkoutLogService(AppDbContext db)
{
    public async Task<(WorkoutLogDto? Result, string? Error)> LogSetAsync(
        int userId, CreateWorkoutLogDto dto)
    {
        // Validate: must have either a ProgramExerciseId or a CustomExerciseName
        if (dto.ProgramExerciseId is null && string.IsNullOrWhiteSpace(dto.CustomExerciseName))
            return (null, "Either ProgramExerciseId or CustomExerciseName is required.");

        string exerciseName;

        if (dto.ProgramExerciseId is not null)
        {
            // Verify the ProgramExercise exists and belongs to this user
            var programExercise = await db.ProgramExercises
                .Include(pe => pe.ExerciseLibrary)
                .Include(pe => pe.ProgramDay)
                    .ThenInclude(pd => pd.TrainingProgram)
                .FirstOrDefaultAsync(pe =>
                    pe.Id == dto.ProgramExerciseId &&
                    pe.ProgramDay.TrainingProgram.UserId == userId);

            if (programExercise is null)
                return (null, "Exercise not found.");

            // Resolve the display name — library name takes priority over custom name
            exerciseName = programExercise.ExerciseLibrary?.Name
                ?? programExercise.CustomExerciseName
                ?? "Unknown Exercise";
        }
        else
        {
            exerciseName = dto.CustomExerciseName!;
        }

        var log = dto.ToEntity(userId);
        db.WorkoutLogs.Add(log);
        await db.SaveChangesAsync();

        return (log.ToDto(exerciseName), null);
    }
    public async Task<List<WorkoutLogDto>> GetByDateAsync(int userId, DateTime date)
    {
        var logs = await db.WorkoutLogs
            .Include(l => l.ProgramExercise)
                .ThenInclude(pe => pe!.ExerciseLibrary)
            .Where(l => l.UserId == userId && l.Date.Date == date.Date)
            .OrderBy(l => l.Date)
            .ThenBy(l => l.SetNumber)
            .ToListAsync();

        return logs.Select(l => l.ToDto(ResolveExerciseName(l))).ToList();
    }

    public async Task<List<WorkoutLogDto>> GetHistoryAsync(int userId)
    {
        var logs = await db.WorkoutLogs
            .Include(l => l.ProgramExercise)
                .ThenInclude(pe => pe!.ExerciseLibrary)
            .Where(l => l.UserId == userId)
            .OrderByDescending(l => l.Date)
            .ThenBy(l => l.SetNumber)
            .ToListAsync();

        return logs.Select(l => l.ToDto(ResolveExerciseName(l))).ToList();
    }

    public async Task<string> GetCsvExportAsync(int userId)
    {
        var logs = await db.WorkoutLogs
            .Include(l => l.ProgramExercise)
                .ThenInclude(pe => pe!.ExerciseLibrary)
            .Include(l => l.ProgramExercise)
                .ThenInclude(pe => pe!.ProgramDay)
                    .ThenInclude(pd => pd.TrainingProgram)
            .Where(l => l.UserId == userId)
            .OrderBy(l => l.Date)
            .ThenBy(l => l.SetNumber)
            .ToListAsync();

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("Date,ProgramName,DayLabel,ExerciseName,Set,Weight,Reps,RPE");

        foreach (var log in logs)
        {
            var date = log.Date.ToString("yyyy-MM-dd");
            var programName = log.ProgramExercise?.ProgramDay?.TrainingProgram?.Name ?? "Custom";
            var dayLabel = log.ProgramExercise?.ProgramDay?.Name ?? "Custom";
            var exerciseName = ResolveExerciseName(log);
            var rpe = log.RPE.HasValue ? log.RPE.Value.ToString() : "";

            sb.AppendLine($"{date},{programName},{dayLabel},{exerciseName},{log.SetNumber},{log.Weight},{log.RepsCompleted},{rpe}");
        }

        return sb.ToString();
    }

    // Private helper — resolves the display name from a loaded log entity
    private static string ResolveExerciseName(WorkoutLog log)
    {
        if (log.ProgramExercise is null)
            return log.CustomExerciseName ?? "Custom Exercise";

        return log.ProgramExercise.ExerciseLibrary?.Name
            ?? log.ProgramExercise.CustomExerciseName
            ?? "Unknown Exercise";
    }
}