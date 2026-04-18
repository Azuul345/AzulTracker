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
    }
}