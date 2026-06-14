using AzulTracker.API.Data;
using AzulTracker.API.DTOs;
using AzulTracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AzulTracker.API.Services;

public class MuscleService
{
    private readonly AppDbContext _context;

    public MuscleService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<MuscleDto> CreateMuscleAsync(CreateMuscleDto dto)
    {
        var muscle = new Muscle
        {
            Name = dto.Name,
            MuscleGroup = dto.MuscleGroup,
            IsApproved = false
        };

        _context.Muscles.Add(muscle);
        await _context.SaveChangesAsync();

        return new MuscleDto
        {
            Id = muscle.Id,
            Name = muscle.Name,
            MuscleGroup = muscle.MuscleGroup,
            ImageUrl = muscle.ImageUrl,
            IsApproved = muscle.IsApproved
        };
    }

    public async Task<List<MuscleDto>> GetMusclesAsync(bool? approved)
    {
        var query = _context.Muscles.AsQueryable();

        if (approved.HasValue)
            query = query.Where(m => m.IsApproved == approved.Value);

        return await query
            .OrderBy(m => m.MuscleGroup)
            .ThenBy(m => m.Name)
            .Select(m => new MuscleDto
            {
                Id = m.Id,
                Name = m.Name,
                MuscleGroup = m.MuscleGroup,
                ImageUrl = m.ImageUrl,
                IsApproved = m.IsApproved
            })
            .ToListAsync();
    }
}