using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Feedoora.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Password", "PhoneNum", "Updatedby", "Username" },
                values: new object[] { 1, "System", new DateTime(2024, 12, 8, 14, 37, 55, 407, DateTimeKind.Local).AddTicks(4199), new DateTime(2024, 12, 8, 14, 37, 55, 407, DateTimeKind.Local).AddTicks(4227), null, null, "System", "WayneToh" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
