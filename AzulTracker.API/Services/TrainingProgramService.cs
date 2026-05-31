using AzulTracker.API.Data;
using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using AzulTracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AzulTracker.API.Services;

public class TrainingProgramService(AppDbContext db)
{
    // ── Training Programs ────────────────────────────────────────────

    public async Task<List<TrainingProgramDto>> GetAllAsync(int userId)
    {
        return await db.TrainingPrograms
            .Where(p => p.UserId == userId)
            .Select(p => p.ToDto())
            .ToListAsync();
    }

    public async Task<TrainingProgramDto?> GetByIdAsync(int id, int userId)
    {
        var program = await db.TrainingPrograms
            .FirstOrDefaultAsync(p => p.Id == id && p.UserId == userId);

        return program?.ToDto();
    }

    public async Task<(TrainingProgramDto? Result, string? Error)> CreateAsync(
        CreateTrainingProgramDto dto, int userId)
    {
        var count = await db.TrainingPrograms.CountAsync(p => p.UserId == userId);
        if (count >= 3)
            return (null, "You can have a maximum of 3 training programs.");

        var program = dto.ToEntity(userId);
        db.TrainingPrograms.Add(program);
        await db.SaveChangesAsync();

        return (program.ToDto(), null);
    }

    public async Task<(TrainingProgramDto? Result, string? Error)> UpdateAsync(
        int id, UpdateTrainingProgramDto dto, int userId)
    {
        var program = await db.TrainingPrograms
            .FirstOrDefaultAsync(p => p.Id == id && p.UserId == userId);

        if (program is null)
            return (null, "Program not found.");

        program.Name = dto.Name;
        program.Description = dto.Description;
        program.DaysPerWeek = dto.DaysPerWeek;

        await db.SaveChangesAsync();
        return (program.ToDto(), null);
    }

    public async Task<bool> DeleteAsync(int id, int userId)
    {
        var program = await db.TrainingPrograms
            .FirstOrDefaultAsync(p => p.Id == id && p.UserId == userId);

        if (program is null) return false;

        db.TrainingPrograms.Remove(program);
        await db.SaveChangesAsync();
        return true;
    }

    public async Task<(TrainingProgramDto? Result, string? Error)> SetActiveAsync(
        int id, int userId)
    {
        var programs = await db.TrainingPrograms
            .Where(p => p.UserId == userId)
            .ToListAsync();

        var target = programs.FirstOrDefault(p => p.Id == id);
        if (target is null)
            return (null, "Program not found.");

        foreach (var p in programs)
            p.IsActive = false;

        target.IsActive = true;

        await db.SaveChangesAsync();
        return (target.ToDto(), null);
    }
}