using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social.Migrations
{
    /// <inheritdoc />
    public partial class Chat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 36, 59, 543, DateTimeKind.Local).AddTicks(156), new DateTime(2025, 2, 12, 23, 36, 59, 543, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 36, 59, 543, DateTimeKind.Local).AddTicks(159), new DateTime(2025, 2, 12, 23, 36, 59, 543, DateTimeKind.Local).AddTicks(159) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 19, 37, 40, 938, DateTimeKind.Local).AddTicks(5807), new DateTime(2025, 2, 12, 19, 37, 40, 938, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 19, 37, 40, 938, DateTimeKind.Local).AddTicks(5814), new DateTime(2025, 2, 12, 19, 37, 40, 938, DateTimeKind.Local).AddTicks(5812) });
        }
    }
}
