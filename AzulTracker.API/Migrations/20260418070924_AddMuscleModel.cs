using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class AddMuscleModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ExerciseLibrary");

            migrationBuilder.RenameColumn(
                name: "MuscleGroupImage",
                table: "ExerciseLibrary",
                newName: "VideoUrl");

            migrationBuilder.RenameColumn(
                name: "MuscleGroup",
                table: "ExerciseLibrary",
                newName: "Category");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ExerciseLibrary",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "ExerciseLibrary",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCustom",
                table: "ExerciseLibrary",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SubmittedById",
                table: "ExerciseLibrary",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubmittedByUserId",
                table: "ExerciseLibrary",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Muscles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MuscleGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muscles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseMuscles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    ExerciseLibraryId = table.Column<int>(type: "int", nullable: false),
                    MuscleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseMuscles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseMuscles_ExerciseLibrary_ExerciseLibraryId",
                        column: x => x.ExerciseLibraryId,
                        principalTable: "ExerciseLibrary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseMuscles_Muscles_MuscleId",
                        column: x => x.MuscleId,
                        principalTable: "Muscles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseLibrary_SubmittedById",
                table: "ExerciseLibrary",
                column: "SubmittedById");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscles_ExerciseLibraryId",
                table: "ExerciseMuscles",
                column: "ExerciseLibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscles_MuscleId",
                table: "ExerciseMuscles",
                column: "MuscleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseLibrary_Users_SubmittedById",
                table: "ExerciseLibrary",
                column: "SubmittedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseLibrary_Users_SubmittedById",
                table: "ExerciseLibrary");

            migrationBuilder.DropTable(
                name: "ExerciseMuscles");

            migrationBuilder.DropTable(
                name: "Muscles");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseLibrary_SubmittedById",
                table: "ExerciseLibrary");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ExerciseLibrary");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "ExerciseLibrary");

            migrationBuilder.DropColumn(
                name: "IsCustom",
                table: "ExerciseLibrary");

            migrationBuilder.DropColumn(
                name: "SubmittedById",
                table: "ExerciseLibrary");

            migrationBuilder.DropColumn(
                name: "SubmittedByUserId",
                table: "ExerciseLibrary");

            migrationBuilder.RenameColumn(
                name: "VideoUrl",
                table: "ExerciseLibrary",
                newName: "MuscleGroupImage");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "ExerciseLibrary",
                newName: "MuscleGroup");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ExerciseLibrary",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
