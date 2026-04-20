namespace AzulTracker.API.DTOs;

public class ExerciseLibraryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? VideoUrl { get; set; }
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
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? VideoUrl { get; set; }
}

public class UpdateExerciseLibraryDto
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? VideoUrl { get; set; }
}

public class SubmitVideoUrlDto
{
    public string Url { get; set; } = string.Empty;
}

public class VideoUrlDto
{
    public int Id { get; set; }
    public string Url { get; set; } = string.Empty;
    public bool IsBlocked { get; set; }
    public DateTime CreatedAt { get; set; }
}