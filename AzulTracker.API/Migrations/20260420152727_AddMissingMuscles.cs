using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingMuscles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Muscles",
                columns: new[] { "Id", "ImageUrl", "MuscleGroup", "Name" },
                values: new object[,]
                {
                    { 28, null, "Calves", "Tibialis Anterior" },
                    { 29, null, "Legs", "Hip Flexors" },
                    { 30, null, "Arms", "Brachioradialis" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
