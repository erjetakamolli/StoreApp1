using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp1.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "ModifiedDate" },
                values: new object[] { new DateTime(2003, 2, 5, 22, 18, 34, 383, DateTimeKind.Local).AddTicks(8281), new DateTime(2023, 2, 5, 22, 18, 34, 383, DateTimeKind.Local).AddTicks(8498) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "ModifiedDate" },
                values: new object[] { new DateTime(2003, 2, 5, 22, 15, 16, 69, DateTimeKind.Local).AddTicks(3329), new DateTime(2023, 2, 5, 22, 15, 16, 69, DateTimeKind.Local).AddTicks(3377) });
        }
    }
}
