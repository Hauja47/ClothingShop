using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothingShop.DataAccess.EF.Migrations
{
    /// <inheritdoc />
    public partial class addRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { new Guid("03d8fa70-1f01-437d-8574-603c5486afe4"), "847311e8-fef8-4eea-b8a9-03b2367ef86b", "Customer", "CUSTOMER" },
                    { new Guid("ab0923fb-f25b-47aa-a414-957aa4a28009"), "78c902b3-634a-454b-8890-12bb9ccf3897", "Administrator", "ADMINISTRATOR" },
                    { new Guid("b151a6a8-d00e-457b-a3ec-57d4f022b539"), "1c4ad8e7-fc6a-40e4-8640-07505306a912", "Employee", "EMPLOYEE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: new Guid("03d8fa70-1f01-437d-8574-603c5486afe4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: new Guid("ab0923fb-f25b-47aa-a414-957aa4a28009"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: new Guid("b151a6a8-d00e-457b-a3ec-57d4f022b539"));
        }
    }
}
