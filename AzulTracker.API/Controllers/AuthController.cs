using AzulTracker.API.DTOs;
using AzulTracker.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AzulTracker.API.Extensions;

namespace AzulTracker.API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly UserService _userService;

    public AuthController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto dto)
    {
        var result = await _userService.RegisterAsync(dto);

        if (result == null)
            return BadRequest("Email is already in use.");

        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto dto)
    {
        var result = await _userService.LoginAsync(dto);

        if (result == null)
            return Unauthorized("Invalid email or password.");

        return Ok(result);
    }

    [HttpGet("me")]
    [Authorize]
    public IActionResult Me()
    {
        var username = User.Identity?.Name;
        var role = User.FindFirst(System.Security.Claims.ClaimTypes.Role)?.Value;
        return Ok(new { username, role });
    }

    [HttpPatch("settings")]
    [Authorize]
    public async Task<IActionResult> UpdateSettings([FromBody] UpdateUserSettingsDto dto)
    {
        var userId = User.GetUserId();
        var (success, error) = await _userService.UpdateSettingsAsync(userId, dto);

        if (!success)
            return BadRequest(new { message = error });

        return NoContent();
    }
}