namespace AzulTracker.API.DTOs;

public class TrainingProgramDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int DaysPerWeek { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class CreateTrainingProgramDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int DaysPerWeek { get; set; }
}

public class UpdateTrainingProgramDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int DaysPerWeek { get; set; }
}

