using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSubmittedByAndCreatedAtToMuscle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Muscles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SubmittedById",
                table: "Muscles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubmittedByUserId",
                table: "Muscles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(2436), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3767), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3769), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3770), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3802), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3804), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3805), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3806), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3807), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3808), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3809), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3810), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3811), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3813), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3814), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3816), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3817), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3818), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3819), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3820), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3821), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3822), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3823), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3825), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3838), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3839), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3840), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3841), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3824), null, null });

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "SubmittedById", "SubmittedByUserId" },
                values: new object[] { new DateTime(2026, 6, 15, 19, 46, 16, 481, DateTimeKind.Utc).AddTicks(3815), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Muscles_SubmittedById",
                table: "Muscles",
                column: "SubmittedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Muscles_Users_SubmittedById",
                table: "Muscles",
                column: "SubmittedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muscles_Users_SubmittedById",
                table: "Muscles");

            migrationBuilder.DropIndex(
                name: "IX_Muscles_SubmittedById",
                table: "Muscles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Muscles");

            migrationBuilder.DropColumn(
                name: "SubmittedById",
                table: "Muscles");

            migrationBuilder.DropColumn(
                name: "SubmittedByUserId",
                table: "Muscles");
        }
    }
}
