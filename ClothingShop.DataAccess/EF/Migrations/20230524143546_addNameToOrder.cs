using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingShop.DataAccess.EF.Migrations
{
    /// <inheritdoc />
    public partial class addNameToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "orders",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "name",
                table: "orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
