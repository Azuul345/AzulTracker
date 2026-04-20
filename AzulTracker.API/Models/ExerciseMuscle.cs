namespace AzulTracker.API.Models;

public class ExerciseMuscle
{
    public int Id { get; set; }
    public bool IsPrimary { get; set; }

    public int ExerciseLibraryId { get; set; }
    public ExerciseLibrary ExerciseLibrary { get; set; } = null!;

    public int MuscleId { get; set; }
    public Muscle Muscle { get; set; } = null!;
}