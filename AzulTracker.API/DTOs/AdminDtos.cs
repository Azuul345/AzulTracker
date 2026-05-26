using System.ComponentModel.DataAnnotations;

namespace AzulTracker.API.DTOs;

// ── User Management 

public class AdminUserDto
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class UpdateUserStatusDto
{
    [Required]
    public bool IsActive { get; set; }
}

public class UpdateUserRoleDto
{
    [Required(ErrorMessage = "Role is required.")]
    [RegularExpression(@"^(User|Admin)$", ErrorMessage = "Role must be 'User' or 'Admin'.")]
    public string Role { get; set; } = string.Empty;
}

// ── Platform Stats 

public class AdminStatsDto
{
    public int TotalUsers { get; set; }
    public int ActiveUsers { get; set; }
    public int TotalWorkoutLogs { get; set; }
    public List<PopularExerciseDto> TopExercises { get; set; } = [];
}

public class PopularExerciseDto
{
    public string Name { get; set; } = string.Empty;
    public int LogCount { get; set; }
}

// ── Video Moderation

public class AdminVideoUrlDto
{
    public int Id { get; set; }
    public string Url { get; set; } = string.Empty;
    public bool IsBlocked { get; set; }
    public DateTime CreatedAt { get; set; }
    public int SubmittedByUserId { get; set; }
    public string SubmittedByUsername { get; set; } = string.Empty;
}

// ── Exercise Moderation 

public class PendingExerciseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? VideoUrl { get; set; }
    public int? SubmittedByUserId { get; set; }
    public string? SubmittedByUsername { get; set; }
    public DateTime CreatedAt { get; set; }
}

// ── Muscle Management

public class CreateMuscleDto
{
    [Required(ErrorMessage = "Muscle name is required.")]
    [MinLength(2, ErrorMessage = "Muscle name must be at least 2 characters.")]
    [MaxLength(100, ErrorMessage = "Muscle name cannot exceed 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Muscle group is required.")]
    [MaxLength(100, ErrorMessage = "Muscle group cannot exceed 100 characters.")]
    public string MuscleGroup { get; set; } = string.Empty;

    [Url(ErrorMessage = "ImageUrl must be a valid URL.")]
    [MaxLength(500, ErrorMessage = "ImageUrl cannot exceed 500 characters.")]
    public string? ImageUrl { get; set; }
}

public class MuscleDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string MuscleGroup { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
}

public class AssignMusclesDto
{
    [Required]
    [MinLength(1, ErrorMessage = "At least one muscle assignment is required.")]
    public List<MuscleAssignmentDto> Muscles { get; set; } = [];
}

public class MuscleAssignmentDto
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "MuscleId must be a valid positive integer.")]
    public int MuscleId { get; set; }
    public bool IsPrimary { get; set; }
}

public class AdminExerciseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? VideoUrl { get; set; }
    public bool IsApproved { get; set; }
    public List<ExerciseMuscleDto> Muscles { get; set; } = [];
}

// ExerciseMuscleDto already exists in ExerciseLibraryDtos.cs — do NOT add it again

public class UpdateExerciseDto
{
    [Required(ErrorMessage = "Exercise name is required.")]
    [MinLength(2, ErrorMessage = "Exercise name must be at least 2 characters.")]
    [MaxLength(200, ErrorMessage = "Exercise name cannot exceed 200 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Category is required.")]
    [MaxLength(100, ErrorMessage = "Category cannot exceed 100 characters.")]
    public string Category { get; set; } = string.Empty;

    [Url(ErrorMessage = "VideoUrl must be a valid URL.")]
    [MaxLength(500, ErrorMessage = "VideoUrl cannot exceed 500 characters.")]
    public string? VideoUrl { get; set; }
}