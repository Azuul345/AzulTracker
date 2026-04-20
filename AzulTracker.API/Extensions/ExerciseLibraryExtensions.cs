using AzulTracker.API.DTOs;
using AzulTracker.API.Models;

namespace AzulTracker.API.Extensions;

public static class ExerciseLibraryExtensions
{
    public static ExerciseLibraryDto ToDto(this ExerciseLibrary exercise)
    {
        return new ExerciseLibraryDto
        {
            Id = exercise.Id,
            Name = exercise.Name,
            Category = exercise.Category,
            VideoUrl = exercise.VideoUrl,
            IsCustom = exercise.IsCustom,
            IsApproved = exercise.IsApproved,
            Muscles = exercise.ExerciseMuscles?
                .Select(em => new ExerciseMuscleDto
                {
                    MuscleId = em.MuscleId,
                    MuscleName = em.Muscle.Name,
                    MuscleGroup = em.Muscle.MuscleGroup,
                    ImageUrl = em.Muscle.ImageUrl,
                    IsPrimary = em.IsPrimary
                })
                .ToList() ?? []
        };
    }

    public static ExerciseLibrary ToEntity(this CreateExerciseLibraryDto dto, int userId)
    {
        return new ExerciseLibrary
        {
            Name = dto.Name,
            Category = dto.Category,
            VideoUrl = dto.VideoUrl,
            IsCustom = true,
            IsApproved = false,
            SubmittedByUserId = userId,
            CreatedAt = DateTime.UtcNow
        };
    }
}