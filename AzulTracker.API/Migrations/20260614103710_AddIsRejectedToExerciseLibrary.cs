using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class AddIsRejectedToExerciseLibrary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRejected",
                table: "ExerciseLibrary",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 21,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 22,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 23,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 24,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 25,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 26,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 27,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 28,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 29,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 30,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 31,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 32,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 33,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 34,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 35,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 36,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 37,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 38,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 39,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 40,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 41,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 42,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 43,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 44,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 45,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 46,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 47,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 48,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 49,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 50,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 51,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 52,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 53,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 54,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 55,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 56,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 57,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 58,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 59,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 60,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 61,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 62,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 63,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 64,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 65,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 66,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 67,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 68,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 69,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 70,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 71,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 72,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 73,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 74,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 75,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 76,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 77,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 78,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 79,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 80,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 81,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 82,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 83,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 84,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 85,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 86,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 87,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 88,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 89,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 90,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 91,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 92,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 93,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 94,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 95,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 96,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 97,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 98,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 99,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 100,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 101,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 102,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 103,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 104,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 105,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 106,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 107,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 108,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 109,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 110,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 111,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 112,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 113,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 114,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 115,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 116,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 117,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 118,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 119,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 120,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 121,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 122,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 123,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 124,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 125,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 126,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 127,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 128,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 129,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 130,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 131,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 132,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 133,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 134,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 135,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 136,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 137,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 138,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 139,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 140,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 141,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 142,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 143,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 144,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 145,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 146,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 147,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 148,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 149,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 150,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 151,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 152,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 153,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 154,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 155,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 156,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 157,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 158,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 159,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 160,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 161,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 162,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 163,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 164,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 165,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 166,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 167,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 168,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 169,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 170,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 171,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 172,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 173,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 174,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 175,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 176,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 177,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 178,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 179,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 180,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 181,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 182,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 183,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 184,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 185,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 186,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 187,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 188,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 189,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 190,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 191,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 192,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 193,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 194,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 195,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 196,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 197,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 198,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 199,
                column: "IsRejected",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseLibrary",
                keyColumn: "Id",
                keyValue: 200,
                column: "IsRejected",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRejected",
                table: "ExerciseLibrary");
        }
    }
}
