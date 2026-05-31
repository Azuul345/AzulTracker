using System.ComponentModel.DataAnnotations;

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
    [Required(ErrorMessage = "Program name is required.")]
    [MinLength(2, ErrorMessage = "Program name must be at least 2 characters.")]
    [MaxLength(100, ErrorMessage = "Program name cannot exceed 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
    public string? Description { get; set; }

    [Range(1, 7, ErrorMessage = "DaysPerWeek must be between 1 and 7.")]
    public int DaysPerWeek { get; set; }
}

public class UpdateTrainingProgramDto
{
    [Required(ErrorMessage = "Program name is required.")]
    [MinLength(2, ErrorMessage = "Program name must be at least 2 characters.")]
    [MaxLength(100, ErrorMessage = "Program name cannot exceed 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
    public string? Description { get; set; }

    [Range(1, 7, ErrorMessage = "DaysPerWeek must be between 1 and 7.")]
    public int DaysPerWeek { get; set; }
}