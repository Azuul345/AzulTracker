namespace AzulTracker.API.Models;

public class ProgramDay
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int DayOrder { get; set; }

    public int TrainingProgramId { get; set; }
    public TrainingProgram TrainingProgram { get; set; } = null!;

    public ICollection<ProgramExercise> ProgramExercises { get; set; } = [];
}