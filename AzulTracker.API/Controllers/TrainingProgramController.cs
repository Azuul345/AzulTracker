using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using AzulTracker.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzulTracker.API.Controllers;

[ApiController]
[Route("api/training-programs")]
[Authorize]
public class TrainingProgramsController(TrainingProgramService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var userId = User.GetUserId();
        var programs = await service.GetAllAsync(userId);
        return Ok(programs);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var userId = User.GetUserId();
        var program = await service.GetByIdAsync(id, userId);
        return program is null ? NotFound() : Ok(program);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTrainingProgramDto dto)
    {
        var userId = User.GetUserId();
        var (result, error) = await service.CreateAsync(dto, userId);

        if (error is not null)
            return BadRequest(new { message = error });

        return CreatedAtAction(nameof(GetById), new { id = result!.Id }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateTrainingProgramDto dto)
    {
        var userId = User.GetUserId();
        var (result, error) = await service.UpdateAsync(id, dto, userId);

        if (error is not null) return NotFound(new { message = error });
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var userId = User.GetUserId();
        var deleted = await service.DeleteAsync(id, userId);
        return deleted ? NoContent() : NotFound();
    }

    [HttpPut("{id}/activate")]
    public async Task<IActionResult> Activate(int id)
    {
        var userId = User.GetUserId();
        var (result, error) = await service.SetActiveAsync(id, userId);

        if (error is not null) return NotFound(new { message = error });
        return Ok(result);
    }
}