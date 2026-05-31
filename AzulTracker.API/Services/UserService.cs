using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AzulTracker.API.Data;
using AzulTracker.API.DTOs;
using AzulTracker.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace AzulTracker.API.Services;

public class UserService
{
    private readonly AppDbContext _context;
    private readonly IConfiguration _config;

    public UserService(AppDbContext context, IConfiguration config)
    {
        _context = context;
        _config = config;
    }

    public async Task<AuthResponseDto?> RegisterAsync(RegisterDto dto)
    {
        // Check if email already exists
        if (await _context.Users.AnyAsync(u => u.Email == dto.Email))
            return null;

        var user = new User
        {
            Username = dto.Username,
            Email = dto.Email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
            Role = "User",
            CreatedAt = DateTime.UtcNow
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return GenerateAuthResponse(user);
    }

    public async Task<AuthResponseDto?> LoginAsync(LoginDto dto)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);

        if (user == null) return null;
        if (!user.IsActive) return null;

        if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
            return null;

        return GenerateAuthResponse(user);
    }

    private AuthResponseDto GenerateAuthResponse(User user)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expiry = DateTime.UtcNow.AddMinutes(double.Parse(_config["Jwt:ExpiryMinutes"]!));

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: expiry,
            signingCredentials: creds
        );

        return new AuthResponseDto
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            Username = user.Username,
            Role = user.Role,
            PreferredWorkoutView = user.PreferredWorkoutView,
            RestTimerEnabled = user.RestTimerEnabled
        };
    }

    public async Task<(bool Success, string Error)> UpdateSettingsAsync(int userId, UpdateUserSettingsDto dto)
    {
        var user = await _context.Users.FindAsync(userId);
        if (user == null)
            return (false, "User not found.");

        var validViews = new[] { "FullDay", "Guided" };
        if (!validViews.Contains(dto.PreferredWorkoutView))
            return (false, "PreferredWorkoutView must be 'FullDay' or 'Guided'.");

        user.PreferredWorkoutView = dto.PreferredWorkoutView;
        user.RestTimerEnabled = dto.RestTimerEnabled;

        await _context.SaveChangesAsync();
        return (true, string.Empty);
    }

    public async Task<(bool Success, string Error)> ChangePasswordAsync(int userId, ChangePasswordDto dto)
    {
        // Validate new passwords match before touching the DB
        if (dto.NewPassword != dto.ConfirmNewPassword)
            return (false, "New passwords do not match.");

        if (string.IsNullOrWhiteSpace(dto.NewPassword) || dto.NewPassword.Length < 8)
            return (false, "New password must be at least 8 characters.");

        var hasUpper = dto.NewPassword.Any(char.IsUpper);
        var hasLower = dto.NewPassword.Any(char.IsLower);
        var hasDigit = dto.NewPassword.Any(char.IsDigit);
        if (!hasUpper || !hasLower || !hasDigit)
            return (false, "Password must contain at least one uppercase letter, one lowercase letter, and one number.");


        var user = await _context.Users.FindAsync(userId);
        if (user == null)
            return (false, "User not found.");

        // Verify current password against stored hash
        if (!BCrypt.Net.BCrypt.Verify(dto.CurrentPassword, user.PasswordHash))
            return (false, "Current password is incorrect.");

        // Hash and save the new password
        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.NewPassword);
        await _context.SaveChangesAsync();

        return (true, string.Empty);
    }


}

