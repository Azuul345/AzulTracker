namespace AzulTracker.API.Models;

public class VideoUrl
{
    public int Id { get; set; }
    public string Url { get; set; } = string.Empty;
    public bool IsBlocked { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int SubmittedByUserId { get; set; }
    public User SubmittedBy { get; set; } = null!;

    public int? ReviewedByAdminId { get; set; }
    public User? ReviewedByAdmin { get; set; }
}