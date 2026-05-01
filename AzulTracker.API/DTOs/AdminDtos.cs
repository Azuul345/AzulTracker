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
    public bool IsActive { get; set; }
}

public class UpdateUserRoleDto
{
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
    public string Name { get; set; } = string.Empty;
    public string MuscleGroup { get; set; } = string.Empty;
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
    public List<MuscleAssignmentDto> Muscles { get; set; } = [];
}

public class MuscleAssignmentDto
{
    public int MuscleId { get; set; }
    public bool IsPrimary { get; set; }
}