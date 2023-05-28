using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingShop.DataAccess.EF.Migrations
{
    /// <inheritdoc />
    public partial class updateUniqueName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_categories_name",
                table: "categories",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_brands_name",
                table: "brands",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_attributes_name",
                table: "attributes",
                column: "name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_categories_name",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "ix_brands_name",
                table: "brands");

            migrationBuilder.DropIndex(
                name: "ix_attributes_name",
                table: "attributes");
        }
    }
}
