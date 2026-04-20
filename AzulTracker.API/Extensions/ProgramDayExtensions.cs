using AzulTracker.API.DTOs;
using AzulTracker.API.Models;

namespace AzulTracker.API.Extensions;

public static class ProgramDayExtensions
{
    public static ProgramDayDto ToDto(this ProgramDay day) => new()
    {
        Id = day.Id,
        Name = day.Name,
        DayOrder = day.DayOrder,
        TrainingProgramId = day.TrainingProgramId
    };

    public static ProgramDay ToEntity(this CreateProgramDayDto dto, int trainingProgramId) => new()
    {
        Name = dto.Name,
        DayOrder = dto.DayOrder,
        TrainingProgramId = trainingProgramId
    };
}