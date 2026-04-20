using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using AzulTracker.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzulTracker.API.Controllers;

[ApiController]
[Route("api/exercises")]
[Authorize]
public class ExerciseLibraryController(ExerciseLibraryService exerciseLibraryService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Search([FromQuery] string? query)
    {
        var results = await exerciseLibraryService.SearchAsync(query);
        return Ok(results);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var exercise = await exerciseLibraryService.GetByIdAsync(id);

        if (exercise is null)
            return NotFound();

        return Ok(exercise);
    }

    [HttpPost]
    public async Task<IActionResult> Submit([FromBody] CreateExerciseLibraryDto dto)
    {
        var userId = User.GetUserId();
        var result = await exerciseLibraryService.SubmitCustomAsync(userId, dto);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateExerciseLibraryDto dto)
    {
        var (result, error) = await exerciseLibraryService.UpdateAsync(id, dto);

        if (error is not null)
            return NotFound();

        return Ok(result);
    }

    [HttpPost("{id}/video")]
    public async Task<IActionResult> SubmitVideo(int id, [FromBody] SubmitVideoUrlDto dto)
    {
        var userId = User.GetUserId();
        var (result, error) = await exerciseLibraryService.SubmitVideoUrlAsync(id, userId, dto);

        if (error is not null)
            return NotFound();

        return Created(string.Empty, result);
    }
}