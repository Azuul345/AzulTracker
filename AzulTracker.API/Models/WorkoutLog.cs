namespace AzulTracker.API.Models;

public class WorkoutLog
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int SetNumber { get; set; }
    public double Weight { get; set; }
    public int RepsCompleted { get; set; }
    public int? RPE { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string? CustomExerciseName { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int? ProgramExerciseId { get; set; }
    public ProgramExercise? ProgramExercise { get; set; }
}
