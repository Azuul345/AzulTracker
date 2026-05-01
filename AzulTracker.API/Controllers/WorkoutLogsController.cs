using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using AzulTracker.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzulTracker.API.Controllers;

[ApiController]
[Route("api/logs")]
[Authorize]
public class WorkoutLogsController(WorkoutLogService workoutLogService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> LogSet([FromBody] CreateWorkoutLogDto dto)
    {
        var userId = User.GetUserId();
        var (result, error) = await workoutLogService.LogSetAsync(userId, dto);

        if (error is not null)
            return BadRequest(new { message = error });

        return CreatedAtAction(nameof(GetByDate),
            new { date = result!.Date.ToString("yyyy-MM-dd") }, result);
    }

    [HttpGet]
    public async Task<IActionResult> GetByDate([FromQuery] DateTime date)
    {
        var userId = User.GetUserId();
        var logs = await workoutLogService.GetByDateAsync(userId, date);
        return Ok(logs);
    }

    [HttpGet("history")]
    public async Task<IActionResult> GetHistory()
    {
        var userId = User.GetUserId();
        var logs = await workoutLogService.GetHistoryAsync(userId);
        return Ok(logs);
    }

    [HttpGet("export/csv")]
    public async Task<IActionResult> ExportCsv()
    {
        var userId = User.GetUserId();
        var csv = await workoutLogService.GetCsvExportAsync(userId);

        var bytes = System.Text.Encoding.UTF8.GetBytes(csv);
        var filename = $"azultracker-export-{DateTime.UtcNow:yyyy-MM-dd}.csv";

        return File(bytes, "text/csv", filename);
    }
}