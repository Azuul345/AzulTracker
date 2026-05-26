using System.ComponentModel.DataAnnotations;

namespace AzulTracker.API.DTOs;

public class WorkoutLogDto
{
    public int Id { get; set; }
    public int? ProgramExerciseId { get; set; }
    public string ExerciseName { get; set; } = string.Empty;
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

    [MaxLength(200, ErrorMessage = "Custom exercise name cannot exceed 200 characters.")]
    public string? CustomExerciseName { get; set; }

    [Required(ErrorMessage = "Date is required.")]
    public DateTime Date { get; set; }

    [Range(1, 20, ErrorMessage = "Set number must be between 1 and 20.")]
    public int SetNumber { get; set; }

    [Range(0, 1000, ErrorMessage = "Weight must be between 0 and 1000.")]
    public double Weight { get; set; }

    [Range(1, 100, ErrorMessage = "Reps completed must be between 1 and 100.")]
    public int RepsCompleted { get; set; }

    [Range(1, 10, ErrorMessage = "RPE must be between 1 and 10.")]
    public int? RPE { get; set; }

    [MaxLength(500, ErrorMessage = "Notes cannot exceed 500 characters.")]
    public string? Notes { get; set; }
}