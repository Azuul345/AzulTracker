using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class FixExerciseMuscleSeedMappings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 63,
                column: "MuscleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 64,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 65,
                column: "MuscleId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 16, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 16, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 68,
                column: "MuscleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 17, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 17, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 72,
                column: "MuscleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 73,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 18, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 18, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 78,
                column: "MuscleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 19, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 19, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 19, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 20, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 20, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 20, true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 20, true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 20, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 21, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 21, true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ExerciseLibraryId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ExerciseLibraryId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ExerciseLibraryId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ExerciseLibraryId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 22, true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 22, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 22, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 23, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 23, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 23, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 24, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 24, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 24, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 108,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 25, false, 19 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 110,
                column: "MuscleId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 112,
                column: "MuscleId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 114,
                column: "MuscleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 115,
                column: "MuscleId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 116,
                column: "MuscleId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 27, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 27, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 121,
                column: "ExerciseLibraryId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 28, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 28, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 28, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 29, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 29, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 29, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 29, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 30, false, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 30, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 135,
                column: "IsPrimary",
                value: true);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 31, false, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 31, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 139,
                column: "MuscleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 32, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 143,
                column: "MuscleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 145,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 33, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 33, false, 19 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 148,
                column: "MuscleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 34, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 153,
                column: "IsPrimary",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 154,
                column: "MuscleId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 155,
                column: "MuscleId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 156,
                column: "MuscleId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 157,
                column: "MuscleId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 158,
                column: "MuscleId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 37, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 160,
                column: "MuscleId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 11 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 38, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 164,
                column: "MuscleId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 165,
                column: "MuscleId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 166,
                column: "MuscleId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 167,
                column: "MuscleId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 169,
                column: "MuscleId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 170,
                column: "MuscleId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 171,
                column: "MuscleId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 172,
                column: "MuscleId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 41, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 42, true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 42, true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 42, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 43, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 43, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 43, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 44, true, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 44, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 44, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 44, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 45, true, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 45, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 188,
                column: "ExerciseLibraryId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 46, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 46, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 191,
                column: "ExerciseLibraryId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 47, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 193,
                column: "ExerciseLibraryId",
                value: 47);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 47, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 47, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 196,
                column: "ExerciseLibraryId",
                value: 48);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 48, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 48, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 48, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 49, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 49, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 49, false, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 50, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 50, true, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 50, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 51, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 51, true, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 51, false, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 52, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 52, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 52, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 53, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 53, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 53, false, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 54, true, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 54, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 54, true, 30 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 55, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 55, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 55, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 56, true, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 56, true, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 56, false, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 57, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 57, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 58, true, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 58, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 59, true, 30 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 59, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 59, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 60, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 60, true, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 60, 30 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 61, true, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 61, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 61, 30 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 62, true, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 62, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 63, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 63, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 63, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 64, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 65, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 66, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 67, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 68, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 68, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 68, false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 69, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 70, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 71, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 71, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 72, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 72, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 73, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 74, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 75, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 76, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 76, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 76, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 76, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 76, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 77, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 77, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 77, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 77, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 78, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 78, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 78, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 79, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 79, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 79, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 79, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 80, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 80, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 80, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 80, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 81, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 81, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 81, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 81, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 81, false, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 82, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 82, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 82, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 82, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 82, false, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 82, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 83, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 83, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 83, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 84, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 84, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 86, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 298,
                column: "MuscleId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 87, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 304,
                column: "MuscleId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 90, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 307,
                column: "MuscleId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 91, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 92, true, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 310,
                column: "ExerciseLibraryId",
                value: 93);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 93, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 93, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 93, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 93, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 94, true, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 94, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 94, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 95, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 95, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 95, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 95, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 96, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 96, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 96, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 325,
                column: "ExerciseLibraryId",
                value: 97);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 326,
                column: "ExerciseLibraryId",
                value: 97);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 327,
                column: "ExerciseLibraryId",
                value: 97);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 97, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 98, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 98, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 98, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 99, true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 333,
                column: "ExerciseLibraryId",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 101, true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 101, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 102, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 102, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 102, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 103, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 103, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 103, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 103, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 104, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 104, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 105, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 105, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 105, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 106, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 106, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 107, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 107, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 353,
                column: "ExerciseLibraryId",
                value: 107);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 108, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 108, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 109, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 109, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 109, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 110, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 360,
                column: "ExerciseLibraryId",
                value: 110);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 111, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 111, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 363,
                column: "ExerciseLibraryId",
                value: 111);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 112, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 112, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 366,
                column: "ExerciseLibraryId",
                value: 112);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 113, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 113, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 114, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 114, true, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 114, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 114, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 374,
                column: "ExerciseLibraryId",
                value: 115);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 375,
                column: "MuscleId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 376,
                column: "MuscleId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 116, true, 23 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 379,
                column: "ExerciseLibraryId",
                value: 117);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 117, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 118, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 118, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 118, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 119, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 119, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 120, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 120, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 120, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 121, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 121, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 121, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 122, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 122, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 123, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 123, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 124, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 124, true, 23 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 125, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 125, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 126, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 126, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 127, true, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 127, false, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 128, true, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 128, false, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 129, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 129, false, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 130, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 130, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 131, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 131, false, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 132, true, 28 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 133, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 133, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 134, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 134, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 134, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 135, true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 135, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 135, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 136, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 136, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 136, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 136, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 137, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 137, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 137, false, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 137, false, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 138, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 138, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 139, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 139, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 140, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 140, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 140, false, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 141, true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 141, false, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 141, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 142, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 142, true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 142, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 143, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 143, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 143, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 144, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 144, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 144, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 145, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 145, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 145, false, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 146, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 146, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 146, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 146, false, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 147, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 147, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 147, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 148, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 148, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 149, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 149, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 149, false, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 150, true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 150, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 150, false, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 151, true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 151, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 151, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 152, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 152, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 153, true, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 473,
                column: "MuscleId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 474,
                column: "MuscleId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 475,
                column: "MuscleId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 154, false, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 154, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 155, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 155, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 155, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 155, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 155, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 156, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 156, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 156, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 156, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 157, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 157, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 157, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 157, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 158, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 158, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 158, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 158, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 158, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 159, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 159, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 159, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 159, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 159, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 159, false, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 160, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 504,
                column: "ExerciseLibraryId",
                value: 160);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 505,
                column: "ExerciseLibraryId",
                value: 160);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 160, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 160, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 160, false, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 161, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 161, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 161, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 161, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 161, false, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 161, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 162, true, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 162, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 162, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 162, false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 163, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 163, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 163, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 163, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 164, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 164, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 164, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 164, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 164, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 165, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 165, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 165, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 165, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 166, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 166, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 166, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 166, false, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 167, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 167, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 167, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 167, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 168, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 168, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 168, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 168, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 168, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 169, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 169, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 169, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 548,
                column: "ExerciseLibraryId",
                value: 170);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 170, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 550,
                column: "ExerciseLibraryId",
                value: 170);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 170, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 170, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 171, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 171, 2 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 172, true, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 172, true, 2 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 172, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 172, false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 173, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 173, true, 2 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 173, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 173, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 174, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 174, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 174, false, 11 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 175, true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 175, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 175, 19 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 175, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 176, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 176, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 176, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 176, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 176, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 575,
                column: "ExerciseLibraryId",
                value: 177);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 177, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 178, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 178, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 178, false, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 179, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 179, true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 179, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 179, false, 11 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 180, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 180, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 180, 30 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 181, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 182, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 183, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 183, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 184, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 184, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 184, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 185, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 185, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 596,
                column: "ExerciseLibraryId",
                value: 186);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 186, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 186, true, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 187, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 187, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 188, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 188, true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 188, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 189, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 189, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 189, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 190, true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 190, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 190, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 191, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 191, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 192, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 192, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 193, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 193, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 193, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 194, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 194, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 194, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 195, false, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 195, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 624,
                column: "MuscleId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 196, false, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 196, false, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 197, false, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 630,
                column: "MuscleId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 198, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 198, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 198, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 199, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 199, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 199, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 199, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 200, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 200, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 200, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 200, 14 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 63,
                column: "MuscleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 64,
                column: "MuscleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 65,
                column: "MuscleId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 17, true, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 17, true, 2 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 68,
                column: "MuscleId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 18, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 18, true, 2 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 72,
                column: "MuscleId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 73,
                column: "MuscleId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 19, true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 19, true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 78,
                column: "MuscleId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 20, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 20, true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 20, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 21, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 21, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 21, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 22, true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 22, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 22, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ExerciseLibraryId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 22, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ExerciseLibraryId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ExerciseLibraryId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ExerciseLibraryId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 23, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 23, true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 23, true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 24, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 24, true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 24, true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 24, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 25, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 25, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 25, true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 108,
                column: "MuscleId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 26, true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 110,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 112,
                column: "MuscleId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 114,
                column: "MuscleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 115,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 116,
                column: "MuscleId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 28, true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 28, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 19 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 121,
                column: "ExerciseLibraryId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 29, true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 29, 11 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 29, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 30, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 30, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 30, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 30, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 30, true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 31, true, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 31, true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 135,
                column: "IsPrimary",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 32, true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 32, true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 139,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 33, true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 143,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 145,
                column: "MuscleId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 34, true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 34, true, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 148,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 35, true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 153,
                column: "IsPrimary",
                value: true);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 154,
                column: "MuscleId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 155,
                column: "MuscleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 156,
                column: "MuscleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 157,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 158,
                column: "MuscleId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 36, false, 19 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 160,
                column: "MuscleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 37, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 164,
                column: "MuscleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 165,
                column: "MuscleId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 166,
                column: "MuscleId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 167,
                column: "MuscleId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 169,
                column: "MuscleId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 170,
                column: "MuscleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 171,
                column: "MuscleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 172,
                column: "MuscleId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 40, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 41, false, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 41, false, 6 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 41, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 42, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 42, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 42, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 42, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 42, false, 11 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 43, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 43, true, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 43, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 43, 11 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 188,
                column: "ExerciseLibraryId",
                value: 44);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 44, true, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 44, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 191,
                column: "ExerciseLibraryId",
                value: 44);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 44, false, 11 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 193,
                column: "ExerciseLibraryId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 45, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 45, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 196,
                column: "ExerciseLibraryId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 46, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 46, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 47, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 47, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 47, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 48, true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 48, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 48, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 49, true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 49, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 49, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 50, true, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 50, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 50, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 50, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 51, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 51, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 52, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 52, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 52, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 52, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 53, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 53, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 53, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 53, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 53, false, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 54, true, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 54, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 54, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 54, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 55, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 55, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 55, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 56, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 56, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 56, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 57, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 57, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 58, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 58, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 58, false, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 59, true, 9 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 59, 4 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 59, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 59, 11 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 60, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 60, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 60, false, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 61, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 61, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 61, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 62, true, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 62, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 62, false, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 63, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 63, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 63, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 64, true, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 64, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 64, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 65, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 65, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 65, false, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 66, true, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 66, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 67, true, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 67, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 68, true, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 68, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 68, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 69, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 69, true, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 69, true, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 70, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 70, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 70, true, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 71, true, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 71, false, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 72, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 72, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 72, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 73, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 74, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 75, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 76, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 77, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 77, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 77, false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 78, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 79, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 80, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 80, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 81, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 81, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 82, true, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 83, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 85, true, 13 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 85, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 298,
                column: "MuscleId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 88, true, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 304,
                column: "MuscleId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 89, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 307,
                column: "MuscleId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 90, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 90, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 310,
                column: "ExerciseLibraryId",
                value: 91);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 91, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 91, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 92, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 92, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 92, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 92, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 93, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 93, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 93, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 93, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 94, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 94, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 94, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 94, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 325,
                column: "ExerciseLibraryId",
                value: 95);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 326,
                column: "ExerciseLibraryId",
                value: 95);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 327,
                column: "ExerciseLibraryId",
                value: 95);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 95, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 95, false, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 96, true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 96, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 96, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 333,
                column: "ExerciseLibraryId",
                value: 97);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 97, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 97, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 98, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 99, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 99, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 100, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 100, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 101, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 102, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 102, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 102, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 103, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 103, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 103, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 104, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 105, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 106, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 106, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 353,
                column: "ExerciseLibraryId",
                value: 106);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 107, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 107, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 107, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 108, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 108, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 108, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 360,
                column: "ExerciseLibraryId",
                value: 108);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 109, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 109, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 363,
                column: "ExerciseLibraryId",
                value: 109);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 110, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 110, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 366,
                column: "ExerciseLibraryId",
                value: 110);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 110, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 111, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 111, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 111, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 112, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 113, true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 374,
                column: "ExerciseLibraryId",
                value: 114);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 375,
                column: "MuscleId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 376,
                column: "MuscleId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 115, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 379,
                column: "ExerciseLibraryId",
                value: 116);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 116, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 116, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 117, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 117, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 118, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 118, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 118, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 119, true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 119, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 119, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 120, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 120, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 120, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 121, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 121, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 122, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 122, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 122, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 123, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 123, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 124, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 124, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 124, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 125, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 125, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 126, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 126, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 126, true, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 127, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 127, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 128, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 128, true, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 128, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 129, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 129, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 129, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 130, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 130, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 130, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 131, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 131, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 131, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 132, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 132, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 132, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 133, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 133, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 134, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 134, true, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 134, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 134, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 134, false, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 135, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 135, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 135, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 136, true, 23 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 136, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 137, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 137, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 138, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 138, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 138, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 139, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 139, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 140, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 140, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 140, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 141, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 141, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 141, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 142, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 142, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 143, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 143, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 144, true, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 144, 23 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 145, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 145, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 146, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 146, false, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 147, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 147, 25 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 148, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 148, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 148, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 149, true, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 149, false, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 150, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 150, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 151, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 151, false, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { true, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 152, false, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 473,
                column: "MuscleId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 474,
                column: "MuscleId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 475,
                column: "MuscleId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 156, true, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 156, true, 27 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 157, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 157, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 157, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 158, true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 158, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 158, false, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 159, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 159, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 159, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 159, false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 160, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 160, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 160, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 161, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 161, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 162, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 162, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 163, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 163, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 164, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 164, false, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 164, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 165, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 165, true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 165, false, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 504,
                column: "ExerciseLibraryId",
                value: 166);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 505,
                column: "ExerciseLibraryId",
                value: 166);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 166, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 167, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 167, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 167, false, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 168, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 168, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 168, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 169, true, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 169, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 169, false, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 170, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 170, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 171, true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 171, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 172, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 172, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 172, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 173, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 173, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 173, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 174, true, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 174, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 174, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 175, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 175, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 175, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 176, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 176, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 176, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 177, true, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 177, 15 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 177, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 177, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 178, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 178, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 178, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 178, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 178, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 179, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 179, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 179, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 179, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 548,
                column: "ExerciseLibraryId",
                value: 180);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 180, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 550,
                column: "ExerciseLibraryId",
                value: 180);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 180, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 181, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 181, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 181, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 181, false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 181, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 182, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 182, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 182, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 182, false, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 182, false, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 182, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 183, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 183, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 183, true, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 183, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 183, 17 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 183, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 184, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 184, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 184, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 184, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 184, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 184, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 575,
                column: "ExerciseLibraryId",
                value: 185);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 185, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 185, false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 185, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 186, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 186, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 186, false, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 186, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 187, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 187, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 187, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 187, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 187, false, 22 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 188, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 188, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 188, 5 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 188, false, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 189, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 189, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 189, false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 189, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 596,
                column: "ExerciseLibraryId",
                value: 190);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 190, false, 3 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 190, false, 12 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 190, false, 21 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 191, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 191, 7 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 191, false, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 191, 18 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 191, false, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 192, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 192, true, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 192, false, 26 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 193, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 193, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 193, false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 193, 16 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 193, false });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 194, true, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 194, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 194, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 194, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 195, 10 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 195, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 195, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 196, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 196, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 624,
                column: "MuscleId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 197, true, 20 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 197, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "IsPrimary", "MuscleId" },
                values: new object[] { false, 24 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 198, true, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 630,
                column: "MuscleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 199, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "ExerciseLibraryId", "IsPrimary" },
                values: new object[] { 199, true });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 199, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 200, 1 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 200, 2 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[] { 200, true, 8 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 200, 14 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 155, 28 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 160, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 169, 29 });

            migrationBuilder.UpdateData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "ExerciseLibraryId", "MuscleId" },
                values: new object[] { 170, 29 });

            migrationBuilder.InsertData(
                table: "ExerciseMuscles",
                columns: new[] { "Id", "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[,]
                {
                    { 642, 163, false, 29 },
                    { 643, 94, false, 29 },
                    { 644, 95, false, 29 },
                    { 645, 93, false, 29 },
                    { 646, 106, false, 29 },
                    { 647, 102, false, 29 },
                    { 648, 63, false, 30 },
                    { 649, 68, true, 30 },
                    { 650, 69, true, 30 },
                    { 651, 70, false, 30 },
                    { 652, 85, false, 30 },
                    { 653, 88, false, 30 }
                });
        }
    }
}
