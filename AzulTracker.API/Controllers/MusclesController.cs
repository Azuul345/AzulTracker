using AzulTracker.API.DTOs;
using AzulTracker.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace AzulTracker.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
[EnableRateLimiting("GeneralPolicy")]
public class MusclesController : ControllerBase
{
    private readonly MuscleService _muscleService;

    public MusclesController(MuscleService muscleService)
    {
        _muscleService = muscleService;
    }

    // POST /api/muscles
    [HttpPost]
    public async Task<IActionResult> CreateMuscle([FromBody] CreateMuscleDto dto)
    {
        var result = await _muscleService.CreateMuscleAsync(dto);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetMuscles([FromQuery] bool? approved)
    {
        var result = await _muscleService.GetMusclesAsync(approved);
        return Ok(result);
    }

    
}