using System.ComponentModel.DataAnnotations;

namespace AzulTracker.API.DTOs;

public class ExerciseLibraryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? VideoUrl { get; set; }
    public string? Description { get; set; }
    public bool IsCustom { get; set; }
    public bool IsApproved { get; set; }
    public List<ExerciseMuscleDto> Muscles { get; set; } = [];
}

public class ExerciseMuscleDto
{
    public int MuscleId { get; set; }
    public string MuscleName { get; set; } = string.Empty;
    public string MuscleGroup { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public bool IsPrimary { get; set; }
}

public class CreateExerciseLibraryDto
{
    [Required(ErrorMessage = "Exercise name is required.")]
    [MinLength(2, ErrorMessage = "Exercise name must be at least 2 characters.")]
    [MaxLength(200, ErrorMessage = "Exercise name cannot exceed 200 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Category is required.")]
    [MaxLength(100, ErrorMessage = "Category cannot exceed 100 characters.")]
    public string Category { get; set; } = string.Empty;

    [Url(ErrorMessage = "VideoUrl must be a valid URL.")]
    [MaxLength(500, ErrorMessage = "VideoUrl cannot exceed 500 characters.")]
    public string? VideoUrl { get; set; }
}

public class UpdateExerciseLibraryDto
{
    [Required(ErrorMessage = "Exercise name is required.")]
    [MinLength(2, ErrorMessage = "Exercise name must be at least 2 characters.")]
    [MaxLength(200, ErrorMessage = "Exercise name cannot exceed 200 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Category is required.")]
    [MaxLength(100, ErrorMessage = "Category cannot exceed 100 characters.")]
    public string Category { get; set; } = string.Empty;

    [Url(ErrorMessage = "VideoUrl must be a valid URL.")]
    [MaxLength(500, ErrorMessage = "VideoUrl cannot exceed 500 characters.")]
    public string? VideoUrl { get; set; }
}

public class SubmitVideoUrlDto
{
    [Required(ErrorMessage = "URL is required.")]
    [Url(ErrorMessage = "Must be a valid URL.")]
    [MaxLength(500, ErrorMessage = "URL cannot exceed 500 characters.")]
    public string Url { get; set; } = string.Empty;
}

public class VideoUrlDto
{
    public int Id { get; set; }
    public string Url { get; set; } = string.Empty;
    public bool IsBlocked { get; set; }
    public DateTime CreatedAt { get; set; }
}