using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Social.Migrations
{
    /// <inheritdoc />
    public partial class builder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 12, 19, 37, 40, 938, DateTimeKind.Local).AddTicks(5807), new DateTime(2025, 2, 12, 19, 37, 40, 938, DateTimeKind.Local).AddTicks(5803), "General", null },
                    { 2, "System", new DateTime(2025, 2, 12, 19, 37, 40, 938, DateTimeKind.Local).AddTicks(5814), new DateTime(2025, 2, 12, 19, 37, 40, 938, DateTimeKind.Local).AddTicks(5812), "Tech Talk", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
