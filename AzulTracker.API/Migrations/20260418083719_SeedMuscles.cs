using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedMuscles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Muscles",
                columns: new[] { "Id", "ImageUrl", "MuscleGroup", "Name" },
                values: new object[,]
                {
                    { 1, null, "Chest", "Pectoralis Major" },
                    { 2, null, "Chest", "Pectoralis Minor" },
                    { 3, null, "Back", "Latissimus Dorsi" },
                    { 4, null, "Back", "Rhomboids" },
                    { 5, null, "Back", "Erector Spinae" },
                    { 6, null, "Back", "Teres Major" },
                    { 7, null, "Shoulders", "Lateral Deltoid" },
                    { 8, null, "Shoulders", "Anterior Deltoid" },
                    { 9, null, "Shoulders", "Posterior Deltoid" },
                    { 10, null, "Shoulders", "Trapezius" },
                    { 11, null, "Shoulders", "Rotator Cuff" },
                    { 12, null, "Arms", "Biceps Brachii" },
                    { 13, null, "Arms", "Brachialis" },
                    { 14, null, "Arms", "Triceps Brachii" },
                    { 15, null, "Arms", "Forearms" },
                    { 16, null, "Core", "Rectus Abdominis" },
                    { 17, null, "Core", "Obliques" },
                    { 18, null, "Core", "Transverse Abdominis" },
                    { 19, null, "Core", "Serratus Anterior" },
                    { 20, null, "Legs", "Quadriceps" },
                    { 21, null, "Legs", "Hamstrings" },
                    { 22, null, "Legs", "Adductors" },
                    { 23, null, "Legs", "Abductors" },
                    { 24, null, "Glutes", "Gluteus Maximus" },
                    { 25, null, "Glutes", "Gluteus Medius" },
                    { 26, null, "Calves", "Gastrocnemius" },
                    { 27, null, "Calves", "Soleus" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
