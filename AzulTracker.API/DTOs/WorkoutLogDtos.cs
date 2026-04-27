namespace AzulTracker.API.DTOs;

public class WorkoutLogDto
{
    public int Id { get; set; }
    public int? ProgramExerciseId { get; set; }
    public string ExerciseName { get; set; } = string.Empty; // resolved display name
    public DateTime Date { get; set; }
    public int SetNumber { get; set; }
    public double Weight { get; set; }
    public int RepsCompleted { get; set; }
    public int? RPE { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class CreateWorkoutLogDto
{
    public int? ProgramExerciseId { get; set; }
    public string? CustomExerciseName { get; set; } // used only when ProgramExerciseId is null
    public DateTime Date { get; set; }
    public int SetNumber { get; set; }
    public double Weight { get; set; }
    public int RepsCompleted { get; set; }
    public int? RPE { get; set; }
    public string? Notes { get; set; }
}