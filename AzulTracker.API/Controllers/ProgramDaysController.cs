using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using AzulTracker.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzulTracker.API.Controllers;

[ApiController]
[Route("api/training-programs/{trainingProgramId}/days")]
[Authorize]
public class ProgramDaysController(ProgramDayService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(int trainingProgramId)
    {
        var userId = User.GetUserId();
        var days = await service.GetAllAsync(trainingProgramId, userId);
        return Ok(days);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int trainingProgramId, int id)
    {
        var userId = User.GetUserId();
        var day = await service.GetByIdAsync(id, trainingProgramId, userId);
        return day is null ? NotFound() : Ok(day);
    }

    [HttpPost]
    public async Task<IActionResult> Create(int trainingProgramId, CreateProgramDayDto dto)
    {
        var userId = User.GetUserId();
        var (result, error) = await service.CreateAsync(dto, trainingProgramId, userId);

        if (error is not null) return NotFound(new { message = error });

        return CreatedAtAction(nameof(GetById),
            new { trainingProgramId, id = result!.Id }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int trainingProgramId, int id, UpdateProgramDayDto dto)
    {
        var userId = User.GetUserId();
        var (result, error) = await service.UpdateAsync(id, dto, trainingProgramId, userId);

        if (error is not null) return NotFound(new { message = error });
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int trainingProgramId, int id)
    {
        var userId = User.GetUserId();
        var deleted = await service.DeleteAsync(id, trainingProgramId, userId);
        return deleted ? NoContent() : NotFound();
    }
}