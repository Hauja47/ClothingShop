using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothingShop.DataAccess.EF.Migrations
{
    /// <inheritdoc />
    public partial class updateDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "variants",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "discount",
                table: "variants",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "variants",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "promotions",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "expired_date",
                table: "promotions",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "promotions",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "products",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "products",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "orders",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "orders",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "order_items",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "order_items",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "comments",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "comments",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "categories",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "categories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "carts",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "carts",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "cart_items",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "cart_items",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "brands",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "brands",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "attributes",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "attributes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "attribute_values",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "attribute_values",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "refresh_token_expiry_time",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "variants",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "discount",
                table: "variants",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "variants",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "promotions",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "expired_date",
                table: "promotions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "promotions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "products",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "orders",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "orders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "order_items",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "order_items",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "comments",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "comments",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "categories",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "carts",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "carts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "cart_items",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "cart_items",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "brands",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "brands",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "attributes",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "attributes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "attribute_values",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "attribute_values",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "refresh_token_expiry_time",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
