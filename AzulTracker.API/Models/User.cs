namespace AzulTracker.API.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "User";
    public string PreferredWorkoutView { get; set; } = "FullDay"; // "FullDay" or "Guided"
    public bool RestTimerEnabled { get; set; } = false;
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<TrainingProgram> TrainingPrograms { get; set; } = [];
    public ICollection<WorkoutLog> WorkoutLogs { get; set; } = [];
}