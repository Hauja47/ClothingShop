using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingShop.DataAccess.EF.Migrations
{
    /// <inheritdoc />
    public partial class setDefaultValueForUpdateDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "variants",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "promotions",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "products",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "orders",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "order_items",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "comments",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "categories",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "carts",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "cart_items",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "brands",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "attributes",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "attribute_values",
                type: "timestamp without time zone",
                nullable: true,
                defaultValueSql: "now() at time zone 'utc'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "variants",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "promotions",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "products",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "orders",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "order_items",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "comments",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "categories",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "carts",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "cart_items",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "brands",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "attributes",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_date",
                table: "attribute_values",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValueSql: "now() at time zone 'utc'");
        }
    }
}
