using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using AzulTracker.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzulTracker.API.Controllers;

[ApiController]
[Route("api/training-programs/{trainingProgramId}/days/{programDayId}/exercises")]
[Authorize]
public class ProgramExercisesController(ProgramExerciseService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(int programDayId)
    {
        var userId = User.GetUserId();
        var exercises = await service.GetAllAsync(programDayId, userId);
        return Ok(exercises);
    }

    [HttpPost]
    public async Task<IActionResult> Create(int programDayId, CreateProgramExerciseDto dto)
    {
        var userId = User.GetUserId();
        var (result, error) = await service.CreateAsync(dto, programDayId, userId);

        if (error is not null) return BadRequest(new { message = error });
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int programDayId, int id, UpdateProgramExerciseDto dto)
    {
        var userId = User.GetUserId();
        var (result, error) = await service.UpdateAsync(id, dto, programDayId, userId);

        if (error is not null) return NotFound(new { message = error });
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int programDayId, int id)
    {
        var userId = User.GetUserId();
        var deleted = await service.DeleteAsync(id, programDayId, userId);
        return deleted ? NoContent() : NotFound();
    }
}