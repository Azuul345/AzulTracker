using AzulTracker.API.Data;
using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using Microsoft.EntityFrameworkCore;

namespace AzulTracker.API.Services;

public class ProgramDayService(AppDbContext db)
{
    public async Task<List<ProgramDayDto>> GetAllAsync(int trainingProgramId, int userId)
    {
        var programExists = await db.TrainingPrograms
            .AnyAsync(p => p.Id == trainingProgramId && p.UserId == userId);

        if (!programExists) return [];

        return await db.ProgramDays
            .Where(d => d.TrainingProgramId == trainingProgramId)
            .OrderBy(d => d.DayOrder)
            .Select(d => d.ToDto())
            .ToListAsync();
    }

    public async Task<ProgramDayDto?> GetByIdAsync(int id, int trainingProgramId, int userId)
    {
        var programExists = await db.TrainingPrograms
            .AnyAsync(p => p.Id == trainingProgramId && p.UserId == userId);

        if (!programExists) return null;

        var day = await db.ProgramDays
            .FirstOrDefaultAsync(d => d.Id == id && d.TrainingProgramId == trainingProgramId);

        return day?.ToDto();
    }

    public async Task<(ProgramDayDto? Result, string? Error)> CreateAsync(
        CreateProgramDayDto dto, int trainingProgramId, int userId)
    {
        var programExists = await db.TrainingPrograms
            .AnyAsync(p => p.Id == trainingProgramId && p.UserId == userId);

        if (!programExists)
            return (null, "Program not found.");

        var day = dto.ToEntity(trainingProgramId);
        db.ProgramDays.Add(day);
        await db.SaveChangesAsync();

        return (day.ToDto(), null);
    }

    public async Task<(ProgramDayDto? Result, string? Error)> UpdateAsync(
        int id, UpdateProgramDayDto dto, int trainingProgramId, int userId)
    {
        var programExists = await db.TrainingPrograms
            .AnyAsync(p => p.Id == trainingProgramId && p.UserId == userId);

        if (!programExists)
            return (null, "Program not found.");

        var day = await db.ProgramDays
            .FirstOrDefaultAsync(d => d.Id == id && d.TrainingProgramId == trainingProgramId);

        if (day is null)
            return (null, "Day not found.");

        day.Name = dto.Name;
        day.DayOrder = dto.DayOrder;

        await db.SaveChangesAsync();
        return (day.ToDto(), null);
    }

    public async Task<bool> DeleteAsync(int id, int trainingProgramId, int userId)
    {
        var programExists = await db.TrainingPrograms
            .AnyAsync(p => p.Id == trainingProgramId && p.UserId == userId);

        if (!programExists) return false;

        var day = await db.ProgramDays
            .FirstOrDefaultAsync(d => d.Id == id && d.TrainingProgramId == trainingProgramId);

        if (day is null) return false;

        db.ProgramDays.Remove(day);
        await db.SaveChangesAsync();
        return true;
    }
}