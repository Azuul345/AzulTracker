namespace AzulTracker.API.Models;

public class Muscle
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string MuscleGroup { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }

    public ICollection<ExerciseMuscle> ExerciseMuscles { get; set; } = [];
}