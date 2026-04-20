using AzulTracker.API.DTOs;
using AzulTracker.API.Models;

namespace AzulTracker.API.Extensions;

public static class TrainingProgramExtensions
{
    public static TrainingProgramDto ToDto(this TrainingProgram program) => new()
    {
        Id = program.Id,
        Name = program.Name,
        Description = program.Description,
        DaysPerWeek = program.DaysPerWeek,
        IsActive = program.IsActive,
        CreatedAt = program.CreatedAt
    };

    public static TrainingProgram ToEntity(this CreateTrainingProgramDto dto, int userId) => new()
    {
        Name = dto.Name,
        Description = dto.Description,
        DaysPerWeek = dto.DaysPerWeek,
        UserId = userId,
        IsActive = false,
        CreatedAt = DateTime.UtcNow
    };
}