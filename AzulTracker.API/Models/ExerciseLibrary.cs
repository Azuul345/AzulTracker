namespace AzulTracker.API.Models;

public class ExerciseLibrary
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? VideoUrl { get; set; }
    public bool IsApproved { get; set; }
    public bool IsCustom { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int? SubmittedByUserId { get; set; }
    public User? SubmittedBy { get; set; }

    public ICollection<ExerciseMuscle> ExerciseMuscles { get; set; } = [];
}