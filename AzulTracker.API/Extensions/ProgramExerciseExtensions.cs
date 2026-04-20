using AzulTracker.API.DTOs;
using AzulTracker.API.Models;

namespace AzulTracker.API.Extensions;

public static class ProgramExerciseExtensions
{
    public static ProgramExerciseDto ToDto(this ProgramExercise exercise) => new()
    {
        Id = exercise.Id,
        ProgramDayId = exercise.ProgramDayId,
        ExerciseLibraryId = exercise.ExerciseLibraryId,
        CustomExerciseName = exercise.CustomExerciseName,
        Sets = exercise.Sets,
        Reps = exercise.Reps,
        OrderIndex = exercise.OrderIndex,
        Notes = exercise.Notes,
        VideoUrl = exercise.VideoUrl
    };

    public static ProgramExercise ToEntity(this CreateProgramExerciseDto dto, int programDayId) => new()
    {
        ProgramDayId = programDayId,
        ExerciseLibraryId = dto.ExerciseLibraryId,
        CustomExerciseName = dto.CustomExerciseName,
        Sets = dto.Sets,
        Reps = dto.Reps,
        OrderIndex = dto.OrderIndex,
        Notes = dto.Notes,
        VideoUrl = dto.VideoUrl
    };
}