using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzulTracker.API.Migrations
{
    public partial class UpdateMuscleImageUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var baseUrl = "https://azulstoress23u277wpfnw.blob.core.windows.net/muscle-images/";

            var updates = new[]
            {
                // Chest (1-2)
                (1, "pectoralis-major.png"),
                (2, "pectoralis-minor.png"),
                // Back (3-6)
                (3, "latissimus-dorsi.png"),
                (4, "rhomboids.png"),
                (5, "erector-spinae.png"),
                (6, "teres-major.png"),
                // Shoulders (7-11)
                (7, "lateral-deltoid.png"),
                (8, "anterior-deltoid.png"),
                (9, "posterior-deltoid.png"),
                (10, "trapezius.png"),
                (11, "rotator-cuff.png"),
                // Arms (12-15, 30)
                (12, "biceps-brachii.png"),
                (13, "brachialis.png"),
                (14, "triceps-brachii.png"),
                (15, "forearms.png"),
                (30, "brachioradialis.png"),
                // Core (16-19)
                (16, "rectus-abdominis.png"),
                (17, "obliques.png"),
                (18, "transverse-abdominis.png"),
                (19, "serratus-anterior.png"),
                // Legs (20-23, 29)
                (20, "quadriceps.png"),
                (21, "hamstrings.png"),
                (22, "adductors.png"),
                (23, "abductors.png"),
                (29, "hip-flexors.png"),
                // Glutes (24-25)
                (24, "gluteus-maximus.png"),
                (25, "gluteus-medius.png"),
                // Calves (26-28)
                (26, "gastrocnemius.png"),
                (27, "soleus.png"),
                (28, "tibialis-anterior.png")
            };

            foreach (var update in updates)
            {
                migrationBuilder.Sql($@"
                    UPDATE Muscles 
                    SET ImageUrl = '{baseUrl}{update.Item2}' 
                    WHERE Id = {update.Item1};
                ");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Muscles SET ImageUrl = NULL;");
        }
    }
}