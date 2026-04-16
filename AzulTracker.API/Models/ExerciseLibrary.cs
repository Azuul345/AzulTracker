namespace AzulTracker.API.Models;

public class ExerciseLibrary
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string MuscleGroup { get; set; } = string.Empty;
    public string? MuscleGroupImage { get; set; }
    public string? Description { get; set; }

    public ICollection<ProgramExercise> ProgramExercises { get; set; } = [];
}