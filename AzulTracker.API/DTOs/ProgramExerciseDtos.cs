namespace AzulTracker.API.DTOs;

public class ProgramExerciseDto
{
    public int Id { get; set; }
    public int ProgramDayId { get; set; }
    public int? ExerciseLibraryId { get; set; }
    public string? ExerciseName { get; set; }
    public string? CustomExerciseName { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public int OrderIndex { get; set; }
    public string? Notes { get; set; }
    public string? VideoUrl { get; set; }
}

public class CreateProgramExerciseDto
{
    public int? ExerciseLibraryId { get; set; }
    public string? CustomExerciseName { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public int OrderIndex { get; set; }
    public string? Notes { get; set; }
    public string? VideoUrl { get; set; }
}

public class UpdateProgramExerciseDto
{
    public int? ExerciseLibraryId { get; set; }
    public string? CustomExerciseName { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public int OrderIndex { get; set; }
    public string? Notes { get; set; }
    public string? VideoUrl { get; set; }
}