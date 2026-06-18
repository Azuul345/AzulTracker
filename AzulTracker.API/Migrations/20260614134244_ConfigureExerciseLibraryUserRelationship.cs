using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureExerciseLibraryUserRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseLibrary_Users_SubmittedById",
                table: "ExerciseLibrary");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseLibrary_SubmittedById",
                table: "ExerciseLibrary");

            migrationBuilder.DropColumn(
                name: "SubmittedById",
                table: "ExerciseLibrary");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseLibrary_SubmittedByUserId",
                table: "ExerciseLibrary",
                column: "SubmittedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseLibrary_Users_SubmittedByUserId",
                table: "ExerciseLibrary",
                column: "SubmittedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseLibrary_Users_SubmittedByUserId",
                table: "ExerciseLibrary");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseLibrary_SubmittedByUserId",
                table: "ExerciseLibrary");

            migrationBuilder.AddColumn<int>(
                name: "SubmittedById",
                table: "ExerciseLibrary",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 6,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 7,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 8,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 9,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 10,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 11,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 12,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 13,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 14,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 15,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 16,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 17,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 18,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 19,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 20,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 21,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 22,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 23,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 24,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 25,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 26,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 27,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 28,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 29,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 30,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 31,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 32,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 33,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 34,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 35,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 36,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 37,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 38,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 39,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 40,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 41,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 42,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 43,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 44,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 45,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 46,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 47,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 48,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 49,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 50,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 51,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 52,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 53,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 54,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 55,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 56,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 57,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 58,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 59,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 60,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 61,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 62,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 63,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 64,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 65,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 66,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 67,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 68,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 69,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 70,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 71,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 72,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 73,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 74,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 75,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 76,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 77,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 78,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 79,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 80,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 81,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 82,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 83,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 84,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 85,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 86,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 87,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 88,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 89,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 90,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 91,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 92,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 93,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 94,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 95,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 96,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 97,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 98,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 99,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 100,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 101,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 102,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 103,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 104,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 105,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 106,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 107,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 108,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 109,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 110,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 111,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 112,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 113,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 114,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 115,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 116,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 117,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 118,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 119,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 120,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 121,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 122,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 123,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 124,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 125,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 126,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 127,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 128,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 129,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 130,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 131,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 132,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 133,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 134,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 135,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 136,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 137,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 138,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 139,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 140,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 141,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 142,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 143,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 144,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 145,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 146,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 147,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 148,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 149,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 150,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 151,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 152,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 153,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 154,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 155,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 156,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 157,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 158,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 159,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 160,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 161,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 162,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 163,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 164,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 165,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 166,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 167,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 168,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 169,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 170,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 171,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 172,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 173,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 174,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 175,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 176,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 177,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 178,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 179,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 180,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 181,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 182,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 183,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 184,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 185,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 186,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 187,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 188,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 189,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 190,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 191,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 192,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 193,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 194,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 195,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 196,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 197,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 198,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 199,
                column: "SubmittedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 200,
                column: "SubmittedById",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseLibrary_SubmittedById",
                table: "ExerciseLibrary",
                column: "SubmittedById");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseLibrary_Users_SubmittedById",
                table: "ExerciseLibrary",
                column: "SubmittedById",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
