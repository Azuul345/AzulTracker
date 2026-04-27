using AzulTracker.API.DTOs;
using AzulTracker.API.Extensions;
using AzulTracker.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzulTracker.API.Controllers;

[ApiController]
[Route("api/admin")]
[Authorize(Roles = "Admin")]
public class AdminController(AdminService adminService) : ControllerBase
{
    // ── User Management ──────────────────────────────────────────────

    [HttpGet("users")]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await adminService.GetAllUsersAsync();
        return Ok(users);
    }

    [HttpPut("users/{id}/status")]
    public async Task<IActionResult> UpdateUserStatus(int id, UpdateUserStatusDto dto)
    {
        var (success, error) = await adminService.UpdateUserStatusAsync(id, dto.IsActive);
        if (!success) return NotFound(error);
        return NoContent();
    }

    [HttpPut("users/{id}/role")]
    public async Task<IActionResult> UpdateUserRole(int id, UpdateUserRoleDto dto)
    {
        var (success, error) = await adminService.UpdateUserRoleAsync(id, dto.Role);
        if (!success) return BadRequest(error);
        return NoContent();
    }

    // ── Platform Stats ───────────────────────────────────────────────

    [HttpGet("stats")]
    public async Task<IActionResult> GetStats()
    {
        var stats = await adminService.GetStatsAsync();
        return Ok(stats);
    }

    // ── Video Moderation ─────────────────────────────────────────────

    [HttpGet("videos/pending")]
    public async Task<IActionResult> GetPendingVideos()
    {
        var videos = await adminService.GetPendingVideosAsync();
        return Ok(videos);
    }

    [HttpPut("videos/{id}/block")]
    public async Task<IActionResult> BlockVideo(int id)
    {
        var adminId = User.GetUserId();
        var (success, error) = await adminService.BlockVideoAsync(id, adminId);
        if (!success) return NotFound(error);
        return NoContent();
    }

    // ── Exercise Moderation ──────────────────────────────────────────

    [HttpGet("exercises/pending")]
    public async Task<IActionResult> GetPendingExercises()
    {
        var exercises = await adminService.GetPendingExercisesAsync();
        return Ok(exercises);
    }

    [HttpPut("exercises/{id}/approve")]
    public async Task<IActionResult> ApproveExercise(int id)
    {
        var (success, error) = await adminService.ApproveExerciseAsync(id);
        if (!success) return BadRequest(error);
        return NoContent();
    }

    // ── Muscle Management ────────────────────────────────────────────

    [HttpPost("muscles")]
    public async Task<IActionResult> AddMuscle(CreateMuscleDto dto)
    {
        var result = await adminService.AddMuscleAsync(dto);
        return CreatedAtAction(nameof(AddMuscle), new { id = result.Id }, result);
    }

    [HttpPut("exercises/{id}/muscles")]
    public async Task<IActionResult> AssignMuscles(int id, AssignMusclesDto dto)
    {
        var (success, error) = await adminService.AssignMusclesAsync(id, dto);
        if (!success) return BadRequest(error);
        return NoContent();
    }
}