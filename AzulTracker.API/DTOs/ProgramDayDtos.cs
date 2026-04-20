namespace AzulTracker.API.DTOs;

public class ProgramDayDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int DayOrder { get; set; }
    public int TrainingProgramId { get; set; }
}

public class CreateProgramDayDto
{
    public string Name { get; set; } = string.Empty;
    public int DayOrder { get; set; }
}

public class UpdateProgramDayDto
{
    public string Name { get; set; } = string.Empty;
    public int DayOrder { get; set; }
}