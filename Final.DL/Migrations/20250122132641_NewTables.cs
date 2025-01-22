using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.DL.Migrations
{
    /// <inheritdoc />
    public partial class NewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Treatments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "qawfsfqw3f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6200ae7-cbec-4217-be23-8b1b7f8c84a1", "05af249b-cd07-4d3b-b218-ada9578190fb" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Description", "ImageURL", "Title" },
                values: new object[] { 1, "Gelin disinizi alin,razi qalin", "images/t1.png", "Dis hekimi" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageURL", "Name", "TreatmentId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 1, 22, 17, 26, 40, 958, DateTimeKind.Local).AddTicks(4458), null, "images/team1.jpg", "Mesum", 1, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Treatments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "qawfsfqw3f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85c754f2-b7c4-4bcb-814a-47657c369bee", "de686616-c917-44e5-b57e-7d91d2487f86" });
        }
    }
}
