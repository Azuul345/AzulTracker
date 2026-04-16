namespace AzulTracker.API.Models;

public class TrainingProgram
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<ProgramDay> ProgramDays { get; set; } = [];
}