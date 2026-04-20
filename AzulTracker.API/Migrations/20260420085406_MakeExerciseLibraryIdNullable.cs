using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class MakeExerciseLibraryIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramExercises_ExerciseLibrary_ExerciseLibraryId",
                table: "ProgramExercises");

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseLibraryId",
                table: "ProgramExercises",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramExercises_ExerciseLibrary_ExerciseLibraryId",
                table: "ProgramExercises",
                column: "ExerciseLibraryId",
                principalTable: "ExerciseLibrary",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramExercises_ExerciseLibrary_ExerciseLibraryId",
                table: "ProgramExercises");

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseLibraryId",
                table: "ProgramExercises",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramExercises_ExerciseLibrary_ExerciseLibraryId",
                table: "ProgramExercises",
                column: "ExerciseLibraryId",
                principalTable: "ExerciseLibrary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
