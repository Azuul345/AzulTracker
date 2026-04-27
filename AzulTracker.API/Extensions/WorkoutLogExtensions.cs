using AzulTracker.API.DTOs;
using AzulTracker.API.Models;

namespace AzulTracker.API.Extensions;

public static class WorkoutLogExtensions
{
    public static WorkoutLogDto ToDto(this WorkoutLog log, string exerciseName)
    {
        return new WorkoutLogDto
        {
            Id = log.Id,
            ProgramExerciseId = log.ProgramExerciseId,
            ExerciseName = exerciseName,
            Date = log.Date,
            SetNumber = log.SetNumber,
            Weight = log.Weight,
            RepsCompleted = log.RepsCompleted,
            RPE = log.RPE,
            Notes = log.Notes,
            CreatedAt = log.CreatedAt
        };
    }

    public static WorkoutLog ToEntity(this CreateWorkoutLogDto dto, int userId)
    {
        return new WorkoutLog
        {
            UserId = userId,
            ProgramExerciseId = dto.ProgramExerciseId,
            CustomExerciseName = dto.CustomExerciseName,
            Date = dto.Date,
            SetNumber = dto.SetNumber,
            Weight = dto.Weight,
            RepsCompleted = dto.RepsCompleted,
            RPE = dto.RPE,
            Notes = dto.Notes,
            CreatedAt = DateTime.UtcNow
        };
    }
}