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
            new Muscle { Id = 1, Name = "Pectoralis Major", MuscleGroup = "Chest" },
            new Muscle { Id = 2, Name = "Pectoralis Minor", MuscleGroup = "Chest" },

            // Back
            new Muscle { Id = 3, Name = "Latissimus Dorsi", MuscleGroup = "Back" },
            new Muscle { Id = 4, Name = "Rhomboids", MuscleGroup = "Back" },
            new Muscle { Id = 5, Name = "Erector Spinae", MuscleGroup = "Back" },
            new Muscle { Id = 6, Name = "Teres Major", MuscleGroup = "Back" },

            // Shoulders
            new Muscle { Id = 7, Name = "Lateral Deltoid", MuscleGroup = "Shoulders" },
            new Muscle { Id = 8, Name = "Anterior Deltoid", MuscleGroup = "Shoulders" },
            new Muscle { Id = 9, Name = "Posterior Deltoid", MuscleGroup = "Shoulders" },
            new Muscle { Id = 10, Name = "Trapezius", MuscleGroup = "Shoulders" },
            new Muscle { Id = 11, Name = "Rotator Cuff", MuscleGroup = "Shoulders" },

            // Arms
            new Muscle { Id = 12, Name = "Biceps Brachii", MuscleGroup = "Arms" },
            new Muscle { Id = 13, Name = "Brachialis", MuscleGroup = "Arms" },
            new Muscle { Id = 14, Name = "Triceps Brachii", MuscleGroup = "Arms" },
            new Muscle { Id = 15, Name = "Forearms", MuscleGroup = "Arms" },

            // Core
            new Muscle { Id = 16, Name = "Rectus Abdominis", MuscleGroup = "Core" },
            new Muscle { Id = 17, Name = "Obliques", MuscleGroup = "Core" },
            new Muscle { Id = 18, Name = "Transverse Abdominis", MuscleGroup = "Core" },
            new Muscle { Id = 19, Name = "Serratus Anterior", MuscleGroup = "Core" },

            // Legs
            new Muscle { Id = 20, Name = "Quadriceps", MuscleGroup = "Legs" },
            new Muscle { Id = 21, Name = "Hamstrings", MuscleGroup = "Legs" },
            new Muscle { Id = 22, Name = "Adductors", MuscleGroup = "Legs" },
            new Muscle { Id = 23, Name = "Abductors", MuscleGroup = "Legs" },

            // Glutes
            new Muscle { Id = 24, Name = "Gluteus Maximus", MuscleGroup = "Glutes" },
            new Muscle { Id = 25, Name = "Gluteus Medius", MuscleGroup = "Glutes" },

            // Calves
            new Muscle { Id = 26, Name = "Gastrocnemius", MuscleGroup = "Calves" },
            new Muscle { Id = 27, Name = "Soleus", MuscleGroup = "Calves" }
        );


    }
}