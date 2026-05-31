namespace AzulTracker.API.Models;

public class ProgramExercise
{
    public int Id { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public string? Notes { get; set; }
    public string? CustomExerciseName { get; set; }
    public int OrderIndex { get; set; }
    public string? VideoUrl { get; set; }

    public int ProgramDayId { get; set; }
    public ProgramDay ProgramDay { get; set; } = null!;

    public int? ExerciseLibraryId { get; set; }
    public ExerciseLibrary ExerciseLibrary { get; set; } = null!;

    public ICollection<WorkoutLog> WorkoutLogs { get; set; } = [];
}