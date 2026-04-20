using Microsoft.EntityFrameworkCore;
using AzulTracker.API.Models;

namespace AzulTracker.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<ExerciseLibrary> ExerciseLibrary => Set<ExerciseLibrary>();
    public DbSet<TrainingProgram> TrainingPrograms => Set<TrainingProgram>();
    public DbSet<ProgramDay> ProgramDays => Set<ProgramDay>();
    public DbSet<ProgramExercise> ProgramExercises => Set<ProgramExercise>();
    public DbSet<WorkoutLog> WorkoutLogs => Set<WorkoutLog>();
    public DbSet<Muscle> Muscles { get; set; }
    public DbSet<ExerciseMuscle> ExerciseMuscles { get; set; }
    public DbSet<VideoUrl> VideoUrls { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Preserve WorkoutLogs when a ProgramExercise is deleted
        modelBuilder.Entity<WorkoutLog>()
            .HasOne(w => w.ProgramExercise)
            .WithMany(p => p.WorkoutLogs)
            .HasForeignKey(w => w.ProgramExerciseId)
            .OnDelete(DeleteBehavior.SetNull);

        // Preserve WorkoutLogs when a User is deleted
        modelBuilder.Entity<WorkoutLog>()
            .HasOne(w => w.User)
            .WithMany(u => u.WorkoutLogs)
            .HasForeignKey(w => w.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<VideoUrl>()
           .HasOne(v => v.SubmittedBy)
           .WithMany()
           .HasForeignKey(v => v.SubmittedByUserId)
           .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<VideoUrl>()
            .HasOne(v => v.ReviewedByAdmin)
            .WithMany()
            .HasForeignKey(v => v.ReviewedByAdminId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Muscle>().HasData(
            // Chest
            new Muscle { Id = 1, Name = "Pectoralis Major", MuscleGroup = "Chest", ImageUrl = null },
            new Muscle { Id = 2, Name = "Pectoralis Minor", MuscleGroup = "Chest", ImageUrl = null },

            // Back
            new Muscle { Id = 3, Name = "Latissimus Dorsi", MuscleGroup = "Back", ImageUrl = null },
            new Muscle { Id = 4, Name = "Rhomboids", MuscleGroup = "Back", ImageUrl = null },
            new Muscle { Id = 5, Name = "Erector Spinae", MuscleGroup = "Back", ImageUrl = null },
            new Muscle { Id = 6, Name = "Teres Major", MuscleGroup = "Back", ImageUrl = null },

            // Shoulders
            new Muscle { Id = 7, Name = "Lateral Deltoid", MuscleGroup = "Shoulders", ImageUrl = null },
            new Muscle { Id = 8, Name = "Anterior Deltoid", MuscleGroup = "Shoulders", ImageUrl = null },
            new Muscle { Id = 9, Name = "Posterior Deltoid", MuscleGroup = "Shoulders", ImageUrl = null },
            new Muscle { Id = 10, Name = "Trapezius", MuscleGroup = "Shoulders", ImageUrl = null },
            new Muscle { Id = 11, Name = "Rotator Cuff", MuscleGroup = "Shoulders", ImageUrl = null },

            // Arms
            new Muscle { Id = 12, Name = "Biceps Brachii", MuscleGroup = "Arms", ImageUrl = null },
            new Muscle { Id = 13, Name = "Brachialis", MuscleGroup = "Arms", ImageUrl = null },
            new Muscle { Id = 14, Name = "Triceps Brachii", MuscleGroup = "Arms", ImageUrl = null },
            new Muscle { Id = 15, Name = "Forearms", MuscleGroup = "Arms", ImageUrl = null },
            new Muscle { Id = 30, Name = "Brachioradialis", MuscleGroup = "Arms", ImageUrl = null },

            // Core
            new Muscle { Id = 16, Name = "Rectus Abdominis", MuscleGroup = "Core", ImageUrl = null },
            new Muscle { Id = 17, Name = "Obliques", MuscleGroup = "Core", ImageUrl = null },
            new Muscle { Id = 18, Name = "Transverse Abdominis", MuscleGroup = "Core", ImageUrl = null },
            new Muscle { Id = 19, Name = "Serratus Anterior", MuscleGroup = "Core", ImageUrl = null },

            // Legs
            new Muscle { Id = 20, Name = "Quadriceps", MuscleGroup = "Legs", ImageUrl = null },
            new Muscle { Id = 21, Name = "Hamstrings", MuscleGroup = "Legs", ImageUrl = null },
            new Muscle { Id = 22, Name = "Adductors", MuscleGroup = "Legs", ImageUrl = null },
            new Muscle { Id = 23, Name = "Abductors", MuscleGroup = "Legs", ImageUrl = null },
            new Muscle { Id = 29, Name = "Hip Flexors", MuscleGroup = "Legs", ImageUrl = null},

            // Glutes
            new Muscle { Id = 24, Name = "Gluteus Maximus", MuscleGroup = "Glutes", ImageUrl = null },
            new Muscle { Id = 25, Name = "Gluteus Medius", MuscleGroup = "Glutes", ImageUrl = null },

            // Calves
            new Muscle { Id = 26, Name = "Gastrocnemius", MuscleGroup = "Calves", ImageUrl = null },
            new Muscle { Id = 27, Name = "Soleus", MuscleGroup = "Calves", ImageUrl = null },
            new Muscle { Id = 28, Name = "Tibialis Anterior", MuscleGroup = "Calves",ImageUrl = null}

        );

        modelBuilder.Entity<ExerciseLibrary>().HasData(
                    new ExerciseLibrary
                    {
                        Id = 1,
                        Name = "Barbell Bench Press",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 2,
                        Name = "Incline Barbell Bench Press",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 3,
                        Name = "Decline Barbell Bench Press",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 4,
                        Name = "Dumbbell Bench Press",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 5,
                        Name = "Incline Dumbbell Bench Press",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 6,
                        Name = "Decline Dumbbell Bench Press",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 7,
                        Name = "Dumbbell Flyes",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 8,
                        Name = "Incline Dumbbell Flyes",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 9,
                        Name = "Cable Crossover",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 10,
                        Name = "Incline Cable Flyes",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 11,
                        Name = "Low Cable Crossover",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 12,
                        Name = "Push-Up",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 13,
                        Name = "Wide Grip Push-Up",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 14,
                        Name = "Dip",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 15,
                        Name = "Pec Deck",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 16,
                        Name = "Pull-Up",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 17,
                        Name = "Chin-Up",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 18,
                        Name = "Wide Grip Pull-Up",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 19,
                        Name = "Barbell Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 20,
                        Name = "Pendlay Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 21,
                        Name = "Dumbbell Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 22,
                        Name = "Cable Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 23,
                        Name = "Lat Pulldown",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 24,
                        Name = "Close Grip Lat Pulldown",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 25,
                        Name = "Straight Arm Pulldown",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 26,
                        Name = "Face Pull",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 27,
                        Name = "Deadlift",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 28,
                        Name = "Rack Pull",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 29,
                        Name = "T-Bar Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 30,
                        Name = "Meadows Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 31,
                        Name = "Chest Supported Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 32,
                        Name = "Seal Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 33,
                        Name = "Inverted Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 34,
                        Name = "Single Arm Cable Row",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 35,
                        Name = "Rope Pullover",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 36,
                        Name = "Overhead Press",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 37,
                        Name = "Dumbbell Shoulder Press",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 38,
                        Name = "Arnold Press",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 39,
                        Name = "Lateral Raise",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 40,
                        Name = "Cable Lateral Raise",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 41,
                        Name = "Front Raise",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 42,
                        Name = "Reverse Pec Deck",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 43,
                        Name = "Rear Delt Flyes",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 44,
                        Name = "Upright Row",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 45,
                        Name = "Shrug",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 46,
                        Name = "Landmine Press",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 47,
                        Name = "Push Press",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 48,
                        Name = "Behind The Neck Press",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 49,
                        Name = "Cable Front Raise",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 50,
                        Name = "Machine Shoulder Press",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 51,
                        Name = "Barbell Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 52,
                        Name = "Dumbbell Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 53,
                        Name = "Incline Dumbbell Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 54,
                        Name = "Hammer Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 55,
                        Name = "Preacher Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 56,
                        Name = "Cable Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 57,
                        Name = "Concentration Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 58,
                        Name = "Spider Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 59,
                        Name = "Reverse Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 60,
                        Name = "Zottman Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 61,
                        Name = "Cross Body Hammer Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 62,
                        Name = "Bayesian Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 63,
                        Name = "Close Grip Bench Press",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 64,
                        Name = "Skull Crusher",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 65,
                        Name = "Tricep Pushdown",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 66,
                        Name = "Overhead Tricep Extension",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 67,
                        Name = "Tricep Kickback",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 68,
                        Name = "Diamond Push-Up",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 69,
                        Name = "Rope Tricep Pushdown",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 70,
                        Name = "Single Arm Overhead Tricep Extension",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 71,
                        Name = "Tate Press",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 72,
                        Name = "JM Press",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 73,
                        Name = "Wrist Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 74,
                        Name = "Reverse Wrist Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 75,
                        Name = "Behind The Back Wrist Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 76,
                        Name = "Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 77,
                        Name = "Front Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 78,
                        Name = "Hack Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 79,
                        Name = "Leg Press",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 80,
                        Name = "Bulgarian Split Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 81,
                        Name = "Lunge",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 82,
                        Name = "Walking Lunge",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 83,
                        Name = "Romanian Deadlift",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 84,
                        Name = "Stiff Leg Deadlift",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 85,
                        Name = "Nordic Curl",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 86,
                        Name = "Lying Leg Curl",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 87,
                        Name = "Seated Leg Curl",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 88,
                        Name = "Leg Extension",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 89,
                        Name = "Step Up",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 90,
                        Name = "Goblet Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 91,
                        Name = "Sissy Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 92,
                        Name = "Adductor Machine",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 93,
                        Name = "Reverse Lunge",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 94,
                        Name = "Lateral Lunge",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 95,
                        Name = "Box Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 96,
                        Name = "Pause Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 97,
                        Name = "Safety Bar Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 98,
                        Name = "Leg Press Single Leg",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 99,
                        Name = "Kneeling Leg Curl",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 100,
                        Name = "Standing Leg Curl",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 101,
                        Name = "Glute Ham Raise",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 102,
                        Name = "Reverse Hyper",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 103,
                        Name = "Zercher Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 104,
                        Name = "Cyclist Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 105,
                        Name = "Dumbbell Romanian Deadlift",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 106,
                        Name = "Single Leg Romanian Deadlift",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 107,
                        Name = "Landmine Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 108,
                        Name = "Pendulum Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 109,
                        Name = "Smith Machine Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 110,
                        Name = "Spanish Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 111,
                        Name = "Hip Thrust",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 112,
                        Name = "Barbell Glute Bridge",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 113,
                        Name = "Cable Kickback",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 114,
                        Name = "Sumo Deadlift",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 115,
                        Name = "Sumo Squat",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 116,
                        Name = "Abductor Machine",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 117,
                        Name = "Glute Kickback Machine",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 118,
                        Name = "Single Leg Hip Thrust",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 119,
                        Name = "Dumbbell Hip Thrust",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 120,
                        Name = "Smith Machine Hip Thrust",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 121,
                        Name = "Cable Pull Through",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 122,
                        Name = "Frog Pump",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 123,
                        Name = "Donkey Kick",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 124,
                        Name = "Fire Hydrant",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 125,
                        Name = "Banded Hip Thrust",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 126,
                        Name = "Standing Calf Raise",
                        Category = "Calves",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 127,
                        Name = "Seated Calf Raise",
                        Category = "Calves",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 128,
                        Name = "Leg Press Calf Raise",
                        Category = "Calves",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 129,
                        Name = "Donkey Calf Raise",
                        Category = "Calves",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 130,
                        Name = "Single Leg Calf Raise",
                        Category = "Calves",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 131,
                        Name = "Smith Machine Calf Raise",
                        Category = "Calves",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 132,
                        Name = "Tibialis Raise",
                        Category = "Calves",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 133,
                        Name = "Jump Rope",
                        Category = "Calves",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 134,
                        Name = "Plank",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 135,
                        Name = "Side Plank",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 136,
                        Name = "Ab Wheel Rollout",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 137,
                        Name = "Hanging Leg Raise",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 138,
                        Name = "Cable Crunch",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 139,
                        Name = "Crunch",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 140,
                        Name = "Decline Sit-Up",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 141,
                        Name = "Russian Twist",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 142,
                        Name = "Pallof Press",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 143,
                        Name = "Dead Bug",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 144,
                        Name = "Hollow Body Hold",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 145,
                        Name = "Dragon Flag",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 146,
                        Name = "Toes To Bar",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 147,
                        Name = "Hanging Knee Raise",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 148,
                        Name = "Bicycle Crunch",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 149,
                        Name = "Windshield Wiper",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 150,
                        Name = "Landmine Rotation",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 151,
                        Name = "Suitcase Carry",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 152,
                        Name = "Stir The Pot",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 153,
                        Name = "Copenhagen Plank",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 154,
                        Name = "Farmers Walk",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 155,
                        Name = "Clean and Press",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 156,
                        Name = "Kettlebell Swing",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 157,
                        Name = "Thruster",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 158,
                        Name = "Power Clean",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 159,
                        Name = "Snatch",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 160,
                        Name = "Turkish Get-Up",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 161,
                        Name = "Trap Bar Deadlift",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 162,
                        Name = "Hang Clean",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 163,
                        Name = "Push Jerk",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 164,
                        Name = "Split Jerk",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 165,
                        Name = "Sandbag Carry",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 166,
                        Name = "Sled Push",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 167,
                        Name = "Sled Pull",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 168,
                        Name = "Battle Ropes",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 169,
                        Name = "Box Jump",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 170,
                        Name = "Burpee",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 171,
                        Name = "Svend Press",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 172,
                        Name = "Chest Dip",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 173,
                        Name = "Smith Machine Bench Press",
                        Category = "Chest",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 174,
                        Name = "Banded Pull Apart",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 175,
                        Name = "Straight Arm Dumbbell Pullover",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 176,
                        Name = "Seated Cable Row Wide Grip",
                        Category = "Back",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 177,
                        Name = "Dumbbell Shrug",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 178,
                        Name = "Barbell Front Raise",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 179,
                        Name = "Prone Y Raise",
                        Category = "Shoulders",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 180,
                        Name = "Cable Hammer Curl",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 181,
                        Name = "Overhead Cable Tricep Extension",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 182,
                        Name = "Dumbbell Skull Crusher",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 183,
                        Name = "Reverse Grip Tricep Pushdown",
                        Category = "Arms",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 184,
                        Name = "Single Leg Press",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 185,
                        Name = "Narrow Stance Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 186,
                        Name = "Wide Stance Squat",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 187,
                        Name = "Box Step Down",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 188,
                        Name = "Barbell Hip Hinge",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 189,
                        Name = "Dumbbell Lunge",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 190,
                        Name = "Cable Romanian Deadlift",
                        Category = "Legs",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 191,
                        Name = "Resistance Band Kickback",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 192,
                        Name = "Weighted Donkey Kick",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 193,
                        Name = "45 Degree Hip Extension",
                        Category = "Glutes",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 194,
                        Name = "V-Up",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 195,
                        Name = "Flutter Kick",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 196,
                        Name = "Hanging Oblique Raise",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 197,
                        Name = "Cable Woodchop",
                        Category = "Core",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 198,
                        Name = "Dumbbell Thruster",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 199,
                        Name = "Kettlebell Clean",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    },
                    new ExerciseLibrary
                    {
                        Id = 200,
                        Name = "Prowler Push",
                        Category = "Full Body",
                        IsApproved = true,
                        IsCustom = false,
                        SubmittedByUserId = null,
                        CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    }
        );


        

        modelBuilder.Entity<ExerciseMuscle>().HasData(
                    new ExerciseMuscle
                    {
                        Id = 1,
                        ExerciseLibraryId = 1,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 2,
                        ExerciseLibraryId = 1,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 3,
                        ExerciseLibraryId = 1,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 4,
                        ExerciseLibraryId = 1,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 5,
                        ExerciseLibraryId = 1,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 6,
                        ExerciseLibraryId = 2,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 7,
                        ExerciseLibraryId = 2,
                        MuscleId = 2,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 8,
                        ExerciseLibraryId = 2,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 9,
                        ExerciseLibraryId = 2,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 10,
                        ExerciseLibraryId = 2,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 11,
                        ExerciseLibraryId = 3,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 12,
                        ExerciseLibraryId = 3,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 13,
                        ExerciseLibraryId = 3,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 14,
                        ExerciseLibraryId = 3,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 15,
                        ExerciseLibraryId = 4,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 16,
                        ExerciseLibraryId = 4,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 17,
                        ExerciseLibraryId = 4,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 18,
                        ExerciseLibraryId = 4,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 19,
                        ExerciseLibraryId = 4,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 20,
                        ExerciseLibraryId = 5,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 21,
                        ExerciseLibraryId = 5,
                        MuscleId = 2,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 22,
                        ExerciseLibraryId = 5,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 23,
                        ExerciseLibraryId = 5,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 24,
                        ExerciseLibraryId = 5,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 25,
                        ExerciseLibraryId = 6,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 26,
                        ExerciseLibraryId = 6,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 27,
                        ExerciseLibraryId = 6,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 28,
                        ExerciseLibraryId = 6,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 29,
                        ExerciseLibraryId = 7,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 30,
                        ExerciseLibraryId = 7,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 31,
                        ExerciseLibraryId = 7,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 32,
                        ExerciseLibraryId = 7,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 33,
                        ExerciseLibraryId = 8,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 34,
                        ExerciseLibraryId = 8,
                        MuscleId = 2,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 35,
                        ExerciseLibraryId = 8,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 36,
                        ExerciseLibraryId = 8,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 37,
                        ExerciseLibraryId = 9,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 38,
                        ExerciseLibraryId = 9,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 39,
                        ExerciseLibraryId = 9,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 40,
                        ExerciseLibraryId = 9,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 41,
                        ExerciseLibraryId = 10,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 42,
                        ExerciseLibraryId = 10,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 43,
                        ExerciseLibraryId = 10,
                        MuscleId = 2,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 44,
                        ExerciseLibraryId = 11,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 45,
                        ExerciseLibraryId = 11,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 46,
                        ExerciseLibraryId = 11,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 47,
                        ExerciseLibraryId = 12,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 48,
                        ExerciseLibraryId = 12,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 49,
                        ExerciseLibraryId = 12,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 50,
                        ExerciseLibraryId = 12,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 51,
                        ExerciseLibraryId = 12,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 52,
                        ExerciseLibraryId = 13,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 53,
                        ExerciseLibraryId = 13,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 54,
                        ExerciseLibraryId = 13,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 55,
                        ExerciseLibraryId = 13,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 56,
                        ExerciseLibraryId = 14,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 57,
                        ExerciseLibraryId = 14,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 58,
                        ExerciseLibraryId = 14,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 59,
                        ExerciseLibraryId = 14,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 60,
                        ExerciseLibraryId = 15,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 61,
                        ExerciseLibraryId = 15,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 62,
                        ExerciseLibraryId = 15,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 63,
                        ExerciseLibraryId = 16,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 64,
                        ExerciseLibraryId = 16,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 65,
                        ExerciseLibraryId = 16,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 66,
                        ExerciseLibraryId = 16,
                        MuscleId = 13,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 67,
                        ExerciseLibraryId = 16,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 68,
                        ExerciseLibraryId = 17,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 69,
                        ExerciseLibraryId = 17,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 70,
                        ExerciseLibraryId = 17,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 71,
                        ExerciseLibraryId = 17,
                        MuscleId = 13,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 72,
                        ExerciseLibraryId = 18,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 73,
                        ExerciseLibraryId = 18,
                        MuscleId = 6,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 74,
                        ExerciseLibraryId = 18,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 75,
                        ExerciseLibraryId = 18,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 76,
                        ExerciseLibraryId = 19,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 77,
                        ExerciseLibraryId = 19,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 78,
                        ExerciseLibraryId = 19,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 79,
                        ExerciseLibraryId = 19,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 80,
                        ExerciseLibraryId = 19,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 81,
                        ExerciseLibraryId = 19,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 82,
                        ExerciseLibraryId = 20,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 83,
                        ExerciseLibraryId = 20,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 84,
                        ExerciseLibraryId = 20,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 85,
                        ExerciseLibraryId = 20,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 86,
                        ExerciseLibraryId = 20,
                        MuscleId = 9,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 87,
                        ExerciseLibraryId = 20,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 88,
                        ExerciseLibraryId = 21,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 89,
                        ExerciseLibraryId = 21,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 90,
                        ExerciseLibraryId = 21,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 91,
                        ExerciseLibraryId = 21,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 92,
                        ExerciseLibraryId = 21,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 93,
                        ExerciseLibraryId = 22,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 94,
                        ExerciseLibraryId = 22,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 95,
                        ExerciseLibraryId = 22,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 96,
                        ExerciseLibraryId = 22,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 97,
                        ExerciseLibraryId = 22,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 98,
                        ExerciseLibraryId = 23,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 99,
                        ExerciseLibraryId = 23,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 100,
                        ExerciseLibraryId = 23,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 101,
                        ExerciseLibraryId = 23,
                        MuscleId = 13,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 102,
                        ExerciseLibraryId = 23,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 103,
                        ExerciseLibraryId = 24,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 104,
                        ExerciseLibraryId = 24,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 105,
                        ExerciseLibraryId = 24,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 106,
                        ExerciseLibraryId = 24,
                        MuscleId = 13,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 107,
                        ExerciseLibraryId = 25,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 108,
                        ExerciseLibraryId = 25,
                        MuscleId = 6,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 109,
                        ExerciseLibraryId = 25,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 110,
                        ExerciseLibraryId = 26,
                        MuscleId = 9,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 111,
                        ExerciseLibraryId = 26,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 112,
                        ExerciseLibraryId = 26,
                        MuscleId = 11,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 113,
                        ExerciseLibraryId = 26,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 114,
                        ExerciseLibraryId = 27,
                        MuscleId = 5,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 115,
                        ExerciseLibraryId = 27,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 116,
                        ExerciseLibraryId = 27,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 117,
                        ExerciseLibraryId = 27,
                        MuscleId = 9,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 118,
                        ExerciseLibraryId = 27,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 119,
                        ExerciseLibraryId = 27,
                        MuscleId = 3,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 120,
                        ExerciseLibraryId = 28,
                        MuscleId = 5,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 121,
                        ExerciseLibraryId = 28,
                        MuscleId = 9,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 122,
                        ExerciseLibraryId = 28,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 123,
                        ExerciseLibraryId = 28,
                        MuscleId = 3,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 124,
                        ExerciseLibraryId = 28,
                        MuscleId = 20,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 125,
                        ExerciseLibraryId = 29,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 126,
                        ExerciseLibraryId = 29,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 127,
                        ExerciseLibraryId = 29,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 128,
                        ExerciseLibraryId = 29,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 129,
                        ExerciseLibraryId = 29,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 130,
                        ExerciseLibraryId = 30,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 131,
                        ExerciseLibraryId = 30,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 132,
                        ExerciseLibraryId = 30,
                        MuscleId = 4,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 133,
                        ExerciseLibraryId = 30,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 134,
                        ExerciseLibraryId = 31,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 135,
                        ExerciseLibraryId = 31,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 136,
                        ExerciseLibraryId = 31,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 137,
                        ExerciseLibraryId = 31,
                        MuscleId = 9,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 138,
                        ExerciseLibraryId = 31,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 139,
                        ExerciseLibraryId = 32,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 140,
                        ExerciseLibraryId = 32,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 141,
                        ExerciseLibraryId = 32,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 142,
                        ExerciseLibraryId = 32,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 143,
                        ExerciseLibraryId = 33,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 144,
                        ExerciseLibraryId = 33,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 145,
                        ExerciseLibraryId = 33,
                        MuscleId = 6,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 146,
                        ExerciseLibraryId = 33,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 147,
                        ExerciseLibraryId = 33,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 148,
                        ExerciseLibraryId = 34,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 149,
                        ExerciseLibraryId = 34,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 150,
                        ExerciseLibraryId = 34,
                        MuscleId = 6,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 151,
                        ExerciseLibraryId = 34,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 152,
                        ExerciseLibraryId = 35,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 153,
                        ExerciseLibraryId = 35,
                        MuscleId = 6,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 154,
                        ExerciseLibraryId = 35,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 155,
                        ExerciseLibraryId = 36,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 156,
                        ExerciseLibraryId = 36,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 157,
                        ExerciseLibraryId = 36,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 158,
                        ExerciseLibraryId = 36,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 159,
                        ExerciseLibraryId = 37,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 160,
                        ExerciseLibraryId = 37,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 161,
                        ExerciseLibraryId = 37,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 162,
                        ExerciseLibraryId = 37,
                        MuscleId = 11,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 163,
                        ExerciseLibraryId = 38,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 164,
                        ExerciseLibraryId = 38,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 165,
                        ExerciseLibraryId = 38,
                        MuscleId = 9,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 166,
                        ExerciseLibraryId = 38,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 167,
                        ExerciseLibraryId = 39,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 168,
                        ExerciseLibraryId = 39,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 169,
                        ExerciseLibraryId = 39,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 170,
                        ExerciseLibraryId = 40,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 171,
                        ExerciseLibraryId = 40,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 172,
                        ExerciseLibraryId = 40,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 173,
                        ExerciseLibraryId = 41,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 174,
                        ExerciseLibraryId = 41,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 175,
                        ExerciseLibraryId = 41,
                        MuscleId = 7,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 176,
                        ExerciseLibraryId = 42,
                        MuscleId = 9,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 177,
                        ExerciseLibraryId = 42,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 178,
                        ExerciseLibraryId = 42,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 179,
                        ExerciseLibraryId = 43,
                        MuscleId = 9,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 180,
                        ExerciseLibraryId = 43,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 181,
                        ExerciseLibraryId = 43,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 182,
                        ExerciseLibraryId = 44,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 183,
                        ExerciseLibraryId = 44,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 184,
                        ExerciseLibraryId = 44,
                        MuscleId = 10,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 185,
                        ExerciseLibraryId = 44,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 186,
                        ExerciseLibraryId = 45,
                        MuscleId = 10,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 187,
                        ExerciseLibraryId = 45,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 188,
                        ExerciseLibraryId = 46,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 189,
                        ExerciseLibraryId = 46,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 190,
                        ExerciseLibraryId = 46,
                        MuscleId = 7,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 191,
                        ExerciseLibraryId = 46,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 192,
                        ExerciseLibraryId = 47,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 193,
                        ExerciseLibraryId = 47,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 194,
                        ExerciseLibraryId = 47,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 195,
                        ExerciseLibraryId = 47,
                        MuscleId = 20,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 196,
                        ExerciseLibraryId = 48,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 197,
                        ExerciseLibraryId = 48,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 198,
                        ExerciseLibraryId = 48,
                        MuscleId = 9,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 199,
                        ExerciseLibraryId = 48,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 200,
                        ExerciseLibraryId = 49,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 201,
                        ExerciseLibraryId = 49,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 202,
                        ExerciseLibraryId = 49,
                        MuscleId = 7,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 203,
                        ExerciseLibraryId = 50,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 204,
                        ExerciseLibraryId = 50,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 205,
                        ExerciseLibraryId = 50,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 206,
                        ExerciseLibraryId = 51,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 207,
                        ExerciseLibraryId = 51,
                        MuscleId = 13,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 208,
                        ExerciseLibraryId = 51,
                        MuscleId = 15,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 209,
                        ExerciseLibraryId = 52,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 210,
                        ExerciseLibraryId = 52,
                        MuscleId = 13,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 211,
                        ExerciseLibraryId = 52,
                        MuscleId = 15,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 212,
                        ExerciseLibraryId = 53,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 213,
                        ExerciseLibraryId = 53,
                        MuscleId = 13,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 214,
                        ExerciseLibraryId = 53,
                        MuscleId = 15,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 215,
                        ExerciseLibraryId = 54,
                        MuscleId = 13,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 216,
                        ExerciseLibraryId = 54,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 217,
                        ExerciseLibraryId = 54,
                        MuscleId = 30,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 218,
                        ExerciseLibraryId = 55,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 219,
                        ExerciseLibraryId = 55,
                        MuscleId = 13,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 220,
                        ExerciseLibraryId = 55,
                        MuscleId = 15,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 221,
                        ExerciseLibraryId = 56,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 222,
                        ExerciseLibraryId = 56,
                        MuscleId = 13,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 223,
                        ExerciseLibraryId = 56,
                        MuscleId = 15,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 224,
                        ExerciseLibraryId = 57,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 225,
                        ExerciseLibraryId = 57,
                        MuscleId = 13,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 226,
                        ExerciseLibraryId = 58,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 227,
                        ExerciseLibraryId = 58,
                        MuscleId = 13,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 228,
                        ExerciseLibraryId = 59,
                        MuscleId = 30,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 229,
                        ExerciseLibraryId = 59,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 230,
                        ExerciseLibraryId = 59,
                        MuscleId = 13,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 231,
                        ExerciseLibraryId = 60,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 232,
                        ExerciseLibraryId = 60,
                        MuscleId = 13,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 233,
                        ExerciseLibraryId = 60,
                        MuscleId = 30,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 234,
                        ExerciseLibraryId = 61,
                        MuscleId = 13,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 235,
                        ExerciseLibraryId = 61,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 236,
                        ExerciseLibraryId = 61,
                        MuscleId = 30,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 237,
                        ExerciseLibraryId = 62,
                        MuscleId = 12,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 238,
                        ExerciseLibraryId = 62,
                        MuscleId = 13,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 239,
                        ExerciseLibraryId = 63,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 240,
                        ExerciseLibraryId = 63,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 241,
                        ExerciseLibraryId = 63,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 242,
                        ExerciseLibraryId = 64,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 243,
                        ExerciseLibraryId = 65,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 244,
                        ExerciseLibraryId = 66,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 245,
                        ExerciseLibraryId = 67,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 246,
                        ExerciseLibraryId = 68,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 247,
                        ExerciseLibraryId = 68,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 248,
                        ExerciseLibraryId = 68,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 249,
                        ExerciseLibraryId = 69,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 250,
                        ExerciseLibraryId = 70,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 251,
                        ExerciseLibraryId = 71,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 252,
                        ExerciseLibraryId = 71,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 253,
                        ExerciseLibraryId = 72,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 254,
                        ExerciseLibraryId = 72,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 255,
                        ExerciseLibraryId = 73,
                        MuscleId = 15,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 256,
                        ExerciseLibraryId = 74,
                        MuscleId = 15,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 257,
                        ExerciseLibraryId = 75,
                        MuscleId = 15,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 258,
                        ExerciseLibraryId = 76,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 259,
                        ExerciseLibraryId = 76,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 260,
                        ExerciseLibraryId = 76,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 261,
                        ExerciseLibraryId = 76,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 262,
                        ExerciseLibraryId = 76,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 263,
                        ExerciseLibraryId = 77,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 264,
                        ExerciseLibraryId = 77,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 265,
                        ExerciseLibraryId = 77,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 266,
                        ExerciseLibraryId = 77,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 267,
                        ExerciseLibraryId = 78,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 268,
                        ExerciseLibraryId = 78,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 269,
                        ExerciseLibraryId = 78,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 270,
                        ExerciseLibraryId = 79,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 271,
                        ExerciseLibraryId = 79,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 272,
                        ExerciseLibraryId = 79,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 273,
                        ExerciseLibraryId = 79,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 274,
                        ExerciseLibraryId = 80,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 275,
                        ExerciseLibraryId = 80,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 276,
                        ExerciseLibraryId = 80,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 277,
                        ExerciseLibraryId = 80,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 278,
                        ExerciseLibraryId = 81,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 279,
                        ExerciseLibraryId = 81,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 280,
                        ExerciseLibraryId = 81,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 281,
                        ExerciseLibraryId = 81,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 282,
                        ExerciseLibraryId = 81,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 283,
                        ExerciseLibraryId = 82,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 284,
                        ExerciseLibraryId = 82,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 285,
                        ExerciseLibraryId = 82,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 286,
                        ExerciseLibraryId = 82,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 287,
                        ExerciseLibraryId = 82,
                        MuscleId = 26,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 288,
                        ExerciseLibraryId = 82,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 289,
                        ExerciseLibraryId = 83,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 290,
                        ExerciseLibraryId = 83,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 291,
                        ExerciseLibraryId = 83,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 292,
                        ExerciseLibraryId = 84,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 293,
                        ExerciseLibraryId = 84,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 294,
                        ExerciseLibraryId = 84,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 295,
                        ExerciseLibraryId = 85,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 296,
                        ExerciseLibraryId = 86,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 297,
                        ExerciseLibraryId = 86,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 298,
                        ExerciseLibraryId = 87,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 299,
                        ExerciseLibraryId = 87,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 300,
                        ExerciseLibraryId = 88,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 301,
                        ExerciseLibraryId = 89,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 302,
                        ExerciseLibraryId = 89,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 303,
                        ExerciseLibraryId = 89,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 304,
                        ExerciseLibraryId = 89,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 305,
                        ExerciseLibraryId = 90,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 306,
                        ExerciseLibraryId = 90,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 307,
                        ExerciseLibraryId = 90,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 308,
                        ExerciseLibraryId = 91,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 309,
                        ExerciseLibraryId = 92,
                        MuscleId = 22,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 310,
                        ExerciseLibraryId = 93,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 311,
                        ExerciseLibraryId = 93,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 312,
                        ExerciseLibraryId = 93,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 313,
                        ExerciseLibraryId = 93,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 314,
                        ExerciseLibraryId = 93,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 315,
                        ExerciseLibraryId = 94,
                        MuscleId = 22,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 316,
                        ExerciseLibraryId = 94,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 317,
                        ExerciseLibraryId = 94,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 318,
                        ExerciseLibraryId = 95,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 319,
                        ExerciseLibraryId = 95,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 320,
                        ExerciseLibraryId = 95,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 321,
                        ExerciseLibraryId = 95,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 322,
                        ExerciseLibraryId = 96,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 323,
                        ExerciseLibraryId = 96,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 324,
                        ExerciseLibraryId = 96,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 325,
                        ExerciseLibraryId = 97,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 326,
                        ExerciseLibraryId = 97,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 327,
                        ExerciseLibraryId = 97,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 328,
                        ExerciseLibraryId = 97,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 329,
                        ExerciseLibraryId = 98,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 330,
                        ExerciseLibraryId = 98,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 331,
                        ExerciseLibraryId = 98,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 332,
                        ExerciseLibraryId = 99,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 333,
                        ExerciseLibraryId = 100,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 334,
                        ExerciseLibraryId = 101,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 335,
                        ExerciseLibraryId = 101,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 336,
                        ExerciseLibraryId = 102,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 337,
                        ExerciseLibraryId = 102,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 338,
                        ExerciseLibraryId = 102,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 339,
                        ExerciseLibraryId = 103,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 340,
                        ExerciseLibraryId = 103,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 341,
                        ExerciseLibraryId = 103,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 342,
                        ExerciseLibraryId = 103,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 343,
                        ExerciseLibraryId = 104,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 344,
                        ExerciseLibraryId = 104,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 345,
                        ExerciseLibraryId = 105,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 346,
                        ExerciseLibraryId = 105,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 347,
                        ExerciseLibraryId = 105,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 348,
                        ExerciseLibraryId = 106,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 349,
                        ExerciseLibraryId = 106,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 350,
                        ExerciseLibraryId = 106,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 351,
                        ExerciseLibraryId = 107,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 352,
                        ExerciseLibraryId = 107,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 353,
                        ExerciseLibraryId = 107,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 354,
                        ExerciseLibraryId = 108,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 355,
                        ExerciseLibraryId = 108,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 356,
                        ExerciseLibraryId = 109,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 357,
                        ExerciseLibraryId = 109,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 358,
                        ExerciseLibraryId = 109,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 359,
                        ExerciseLibraryId = 110,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 360,
                        ExerciseLibraryId = 110,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 361,
                        ExerciseLibraryId = 111,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 362,
                        ExerciseLibraryId = 111,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 363,
                        ExerciseLibraryId = 111,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 364,
                        ExerciseLibraryId = 112,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 365,
                        ExerciseLibraryId = 112,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 366,
                        ExerciseLibraryId = 112,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 367,
                        ExerciseLibraryId = 113,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 368,
                        ExerciseLibraryId = 113,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 369,
                        ExerciseLibraryId = 114,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 370,
                        ExerciseLibraryId = 114,
                        MuscleId = 22,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 371,
                        ExerciseLibraryId = 114,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 372,
                        ExerciseLibraryId = 114,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 373,
                        ExerciseLibraryId = 114,
                        MuscleId = 3,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 374,
                        ExerciseLibraryId = 115,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 375,
                        ExerciseLibraryId = 115,
                        MuscleId = 22,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 376,
                        ExerciseLibraryId = 115,
                        MuscleId = 20,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 377,
                        ExerciseLibraryId = 116,
                        MuscleId = 23,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 378,
                        ExerciseLibraryId = 116,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 379,
                        ExerciseLibraryId = 117,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 380,
                        ExerciseLibraryId = 117,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 381,
                        ExerciseLibraryId = 118,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 382,
                        ExerciseLibraryId = 118,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 383,
                        ExerciseLibraryId = 118,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 384,
                        ExerciseLibraryId = 119,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 385,
                        ExerciseLibraryId = 119,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 386,
                        ExerciseLibraryId = 120,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 387,
                        ExerciseLibraryId = 120,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 388,
                        ExerciseLibraryId = 120,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 389,
                        ExerciseLibraryId = 121,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 390,
                        ExerciseLibraryId = 121,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 391,
                        ExerciseLibraryId = 121,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 392,
                        ExerciseLibraryId = 122,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 393,
                        ExerciseLibraryId = 122,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 394,
                        ExerciseLibraryId = 123,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 395,
                        ExerciseLibraryId = 123,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 396,
                        ExerciseLibraryId = 124,
                        MuscleId = 25,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 397,
                        ExerciseLibraryId = 124,
                        MuscleId = 23,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 398,
                        ExerciseLibraryId = 125,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 399,
                        ExerciseLibraryId = 125,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 400,
                        ExerciseLibraryId = 126,
                        MuscleId = 26,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 401,
                        ExerciseLibraryId = 126,
                        MuscleId = 27,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 402,
                        ExerciseLibraryId = 127,
                        MuscleId = 27,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 403,
                        ExerciseLibraryId = 127,
                        MuscleId = 26,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 404,
                        ExerciseLibraryId = 128,
                        MuscleId = 26,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 405,
                        ExerciseLibraryId = 128,
                        MuscleId = 27,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 406,
                        ExerciseLibraryId = 129,
                        MuscleId = 26,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 407,
                        ExerciseLibraryId = 129,
                        MuscleId = 27,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 408,
                        ExerciseLibraryId = 130,
                        MuscleId = 26,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 409,
                        ExerciseLibraryId = 130,
                        MuscleId = 27,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 410,
                        ExerciseLibraryId = 131,
                        MuscleId = 26,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 411,
                        ExerciseLibraryId = 131,
                        MuscleId = 27,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 412,
                        ExerciseLibraryId = 132,
                        MuscleId = 28,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 413,
                        ExerciseLibraryId = 133,
                        MuscleId = 26,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 414,
                        ExerciseLibraryId = 133,
                        MuscleId = 27,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 415,
                        ExerciseLibraryId = 134,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 416,
                        ExerciseLibraryId = 134,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 417,
                        ExerciseLibraryId = 134,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 418,
                        ExerciseLibraryId = 135,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 419,
                        ExerciseLibraryId = 135,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 420,
                        ExerciseLibraryId = 135,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 421,
                        ExerciseLibraryId = 136,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 422,
                        ExerciseLibraryId = 136,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 423,
                        ExerciseLibraryId = 136,
                        MuscleId = 3,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 424,
                        ExerciseLibraryId = 136,
                        MuscleId = 4,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 425,
                        ExerciseLibraryId = 137,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 426,
                        ExerciseLibraryId = 137,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 427,
                        ExerciseLibraryId = 137,
                        MuscleId = 18,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 428,
                        ExerciseLibraryId = 137,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 429,
                        ExerciseLibraryId = 138,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 430,
                        ExerciseLibraryId = 138,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 431,
                        ExerciseLibraryId = 139,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 432,
                        ExerciseLibraryId = 139,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 433,
                        ExerciseLibraryId = 140,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 434,
                        ExerciseLibraryId = 140,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 435,
                        ExerciseLibraryId = 140,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 436,
                        ExerciseLibraryId = 141,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 437,
                        ExerciseLibraryId = 141,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 438,
                        ExerciseLibraryId = 141,
                        MuscleId = 18,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 439,
                        ExerciseLibraryId = 142,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 440,
                        ExerciseLibraryId = 142,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 441,
                        ExerciseLibraryId = 142,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 442,
                        ExerciseLibraryId = 143,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 443,
                        ExerciseLibraryId = 143,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 444,
                        ExerciseLibraryId = 143,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 445,
                        ExerciseLibraryId = 144,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 446,
                        ExerciseLibraryId = 144,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 447,
                        ExerciseLibraryId = 144,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 448,
                        ExerciseLibraryId = 145,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 449,
                        ExerciseLibraryId = 145,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 450,
                        ExerciseLibraryId = 145,
                        MuscleId = 3,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 451,
                        ExerciseLibraryId = 146,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 452,
                        ExerciseLibraryId = 146,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 453,
                        ExerciseLibraryId = 146,
                        MuscleId = 18,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 454,
                        ExerciseLibraryId = 146,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 455,
                        ExerciseLibraryId = 147,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 456,
                        ExerciseLibraryId = 147,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 457,
                        ExerciseLibraryId = 147,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 458,
                        ExerciseLibraryId = 148,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 459,
                        ExerciseLibraryId = 148,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 460,
                        ExerciseLibraryId = 149,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 461,
                        ExerciseLibraryId = 149,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 462,
                        ExerciseLibraryId = 149,
                        MuscleId = 18,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 463,
                        ExerciseLibraryId = 150,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 464,
                        ExerciseLibraryId = 150,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 465,
                        ExerciseLibraryId = 150,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 466,
                        ExerciseLibraryId = 151,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 467,
                        ExerciseLibraryId = 151,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 468,
                        ExerciseLibraryId = 151,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 469,
                        ExerciseLibraryId = 152,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 470,
                        ExerciseLibraryId = 152,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 471,
                        ExerciseLibraryId = 152,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 472,
                        ExerciseLibraryId = 153,
                        MuscleId = 22,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 473,
                        ExerciseLibraryId = 153,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 474,
                        ExerciseLibraryId = 153,
                        MuscleId = 18,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 475,
                        ExerciseLibraryId = 154,
                        MuscleId = 10,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 476,
                        ExerciseLibraryId = 154,
                        MuscleId = 15,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 477,
                        ExerciseLibraryId = 154,
                        MuscleId = 18,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 478,
                        ExerciseLibraryId = 154,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 479,
                        ExerciseLibraryId = 155,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 480,
                        ExerciseLibraryId = 155,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 481,
                        ExerciseLibraryId = 155,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 482,
                        ExerciseLibraryId = 155,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 483,
                        ExerciseLibraryId = 155,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 484,
                        ExerciseLibraryId = 156,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 485,
                        ExerciseLibraryId = 156,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 486,
                        ExerciseLibraryId = 156,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 487,
                        ExerciseLibraryId = 156,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 488,
                        ExerciseLibraryId = 157,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 489,
                        ExerciseLibraryId = 157,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 490,
                        ExerciseLibraryId = 157,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 491,
                        ExerciseLibraryId = 157,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 492,
                        ExerciseLibraryId = 158,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 493,
                        ExerciseLibraryId = 158,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 494,
                        ExerciseLibraryId = 158,
                        MuscleId = 10,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 495,
                        ExerciseLibraryId = 158,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 496,
                        ExerciseLibraryId = 158,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 497,
                        ExerciseLibraryId = 159,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 498,
                        ExerciseLibraryId = 159,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 499,
                        ExerciseLibraryId = 159,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 500,
                        ExerciseLibraryId = 159,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 501,
                        ExerciseLibraryId = 159,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 502,
                        ExerciseLibraryId = 159,
                        MuscleId = 3,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 503,
                        ExerciseLibraryId = 160,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 504,
                        ExerciseLibraryId = 160,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 505,
                        ExerciseLibraryId = 160,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 506,
                        ExerciseLibraryId = 160,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 507,
                        ExerciseLibraryId = 160,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 508,
                        ExerciseLibraryId = 160,
                        MuscleId = 20,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 509,
                        ExerciseLibraryId = 161,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 510,
                        ExerciseLibraryId = 161,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 511,
                        ExerciseLibraryId = 161,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 512,
                        ExerciseLibraryId = 161,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 513,
                        ExerciseLibraryId = 161,
                        MuscleId = 3,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 514,
                        ExerciseLibraryId = 161,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 515,
                        ExerciseLibraryId = 162,
                        MuscleId = 10,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 516,
                        ExerciseLibraryId = 162,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 517,
                        ExerciseLibraryId = 162,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 518,
                        ExerciseLibraryId = 162,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 519,
                        ExerciseLibraryId = 163,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 520,
                        ExerciseLibraryId = 163,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 521,
                        ExerciseLibraryId = 163,
                        MuscleId = 20,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 522,
                        ExerciseLibraryId = 163,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 523,
                        ExerciseLibraryId = 164,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 524,
                        ExerciseLibraryId = 164,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 525,
                        ExerciseLibraryId = 164,
                        MuscleId = 20,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 526,
                        ExerciseLibraryId = 164,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 527,
                        ExerciseLibraryId = 164,
                        MuscleId = 22,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 528,
                        ExerciseLibraryId = 165,
                        MuscleId = 10,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 529,
                        ExerciseLibraryId = 165,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 530,
                        ExerciseLibraryId = 165,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 531,
                        ExerciseLibraryId = 165,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 532,
                        ExerciseLibraryId = 166,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 533,
                        ExerciseLibraryId = 166,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 534,
                        ExerciseLibraryId = 166,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 535,
                        ExerciseLibraryId = 166,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 536,
                        ExerciseLibraryId = 167,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 537,
                        ExerciseLibraryId = 167,
                        MuscleId = 3,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 538,
                        ExerciseLibraryId = 167,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 539,
                        ExerciseLibraryId = 167,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 540,
                        ExerciseLibraryId = 168,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 541,
                        ExerciseLibraryId = 168,
                        MuscleId = 7,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 542,
                        ExerciseLibraryId = 168,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 543,
                        ExerciseLibraryId = 168,
                        MuscleId = 18,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 544,
                        ExerciseLibraryId = 168,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 545,
                        ExerciseLibraryId = 169,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 546,
                        ExerciseLibraryId = 169,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 547,
                        ExerciseLibraryId = 169,
                        MuscleId = 26,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 548,
                        ExerciseLibraryId = 170,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 549,
                        ExerciseLibraryId = 170,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 550,
                        ExerciseLibraryId = 170,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 551,
                        ExerciseLibraryId = 170,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 552,
                        ExerciseLibraryId = 170,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 553,
                        ExerciseLibraryId = 171,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 554,
                        ExerciseLibraryId = 171,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 555,
                        ExerciseLibraryId = 172,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 556,
                        ExerciseLibraryId = 172,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 557,
                        ExerciseLibraryId = 172,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 558,
                        ExerciseLibraryId = 172,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 559,
                        ExerciseLibraryId = 173,
                        MuscleId = 1,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 560,
                        ExerciseLibraryId = 173,
                        MuscleId = 2,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 561,
                        ExerciseLibraryId = 173,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 562,
                        ExerciseLibraryId = 173,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 563,
                        ExerciseLibraryId = 174,
                        MuscleId = 9,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 564,
                        ExerciseLibraryId = 174,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 565,
                        ExerciseLibraryId = 174,
                        MuscleId = 11,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 566,
                        ExerciseLibraryId = 175,
                        MuscleId = 3,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 567,
                        ExerciseLibraryId = 175,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 568,
                        ExerciseLibraryId = 175,
                        MuscleId = 19,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 569,
                        ExerciseLibraryId = 175,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 570,
                        ExerciseLibraryId = 176,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 571,
                        ExerciseLibraryId = 176,
                        MuscleId = 9,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 572,
                        ExerciseLibraryId = 176,
                        MuscleId = 3,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 573,
                        ExerciseLibraryId = 176,
                        MuscleId = 6,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 574,
                        ExerciseLibraryId = 176,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 575,
                        ExerciseLibraryId = 177,
                        MuscleId = 10,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 576,
                        ExerciseLibraryId = 177,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 577,
                        ExerciseLibraryId = 178,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 578,
                        ExerciseLibraryId = 178,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 579,
                        ExerciseLibraryId = 178,
                        MuscleId = 7,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 580,
                        ExerciseLibraryId = 179,
                        MuscleId = 9,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 581,
                        ExerciseLibraryId = 179,
                        MuscleId = 4,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 582,
                        ExerciseLibraryId = 179,
                        MuscleId = 10,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 583,
                        ExerciseLibraryId = 179,
                        MuscleId = 11,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 584,
                        ExerciseLibraryId = 180,
                        MuscleId = 13,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 585,
                        ExerciseLibraryId = 180,
                        MuscleId = 12,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 586,
                        ExerciseLibraryId = 180,
                        MuscleId = 30,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 587,
                        ExerciseLibraryId = 181,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 588,
                        ExerciseLibraryId = 182,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 589,
                        ExerciseLibraryId = 183,
                        MuscleId = 14,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 590,
                        ExerciseLibraryId = 183,
                        MuscleId = 15,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 591,
                        ExerciseLibraryId = 184,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 592,
                        ExerciseLibraryId = 184,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 593,
                        ExerciseLibraryId = 184,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 594,
                        ExerciseLibraryId = 185,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 595,
                        ExerciseLibraryId = 185,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 596,
                        ExerciseLibraryId = 186,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 597,
                        ExerciseLibraryId = 186,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 598,
                        ExerciseLibraryId = 186,
                        MuscleId = 22,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 599,
                        ExerciseLibraryId = 187,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 600,
                        ExerciseLibraryId = 187,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 601,
                        ExerciseLibraryId = 188,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 602,
                        ExerciseLibraryId = 188,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 603,
                        ExerciseLibraryId = 188,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 604,
                        ExerciseLibraryId = 189,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 605,
                        ExerciseLibraryId = 189,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 606,
                        ExerciseLibraryId = 189,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 607,
                        ExerciseLibraryId = 190,
                        MuscleId = 21,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 608,
                        ExerciseLibraryId = 190,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 609,
                        ExerciseLibraryId = 190,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 610,
                        ExerciseLibraryId = 191,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 611,
                        ExerciseLibraryId = 191,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 612,
                        ExerciseLibraryId = 192,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 613,
                        ExerciseLibraryId = 192,
                        MuscleId = 25,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 614,
                        ExerciseLibraryId = 193,
                        MuscleId = 24,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 615,
                        ExerciseLibraryId = 193,
                        MuscleId = 21,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 616,
                        ExerciseLibraryId = 193,
                        MuscleId = 5,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 617,
                        ExerciseLibraryId = 194,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 618,
                        ExerciseLibraryId = 194,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 619,
                        ExerciseLibraryId = 194,
                        MuscleId = 17,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 620,
                        ExerciseLibraryId = 195,
                        MuscleId = 16,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 621,
                        ExerciseLibraryId = 195,
                        MuscleId = 18,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 622,
                        ExerciseLibraryId = 195,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 623,
                        ExerciseLibraryId = 196,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 624,
                        ExerciseLibraryId = 196,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 625,
                        ExerciseLibraryId = 196,
                        MuscleId = 18,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 626,
                        ExerciseLibraryId = 196,
                        MuscleId = 29,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 627,
                        ExerciseLibraryId = 197,
                        MuscleId = 17,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 628,
                        ExerciseLibraryId = 197,
                        MuscleId = 18,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 629,
                        ExerciseLibraryId = 197,
                        MuscleId = 16,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 630,
                        ExerciseLibraryId = 198,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 631,
                        ExerciseLibraryId = 198,
                        MuscleId = 8,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 632,
                        ExerciseLibraryId = 198,
                        MuscleId = 14,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 633,
                        ExerciseLibraryId = 198,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 634,
                        ExerciseLibraryId = 199,
                        MuscleId = 10,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 635,
                        ExerciseLibraryId = 199,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 636,
                        ExerciseLibraryId = 199,
                        MuscleId = 24,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 637,
                        ExerciseLibraryId = 199,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 638,
                        ExerciseLibraryId = 200,
                        MuscleId = 20,
                        IsPrimary = true
                    },
                    new ExerciseMuscle
                    {
                        Id = 639,
                        ExerciseLibraryId = 200,
                        MuscleId = 1,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 640,
                        ExerciseLibraryId = 200,
                        MuscleId = 8,
                        IsPrimary = false
                    },
                    new ExerciseMuscle
                    {
                        Id = 641,
                        ExerciseLibraryId = 200,
                        MuscleId = 14,
                        IsPrimary = false
                    }
        );


    }
}