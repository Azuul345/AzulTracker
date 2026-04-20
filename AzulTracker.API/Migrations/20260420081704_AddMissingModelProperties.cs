using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingModelProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkoutLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PreferredWorkoutView",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "RestTimerEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CustomExerciseName",
                table: "ProgramExercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderIndex",
                table: "ProgramExercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "ProgramExercises",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "WorkoutLogs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreferredWorkoutView",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RestTimerEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CustomExerciseName",
                table: "ProgramExercises");

            migrationBuilder.DropColumn(
                name: "OrderIndex",
                table: "ProgramExercises");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "ProgramExercises");
        }
    }
}
