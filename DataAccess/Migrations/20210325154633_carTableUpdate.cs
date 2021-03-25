using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class carTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Colors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cars",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Brands",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "brand_id",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "color_id",
                table: "Cars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "brand_id",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "color_id",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colors",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cars",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Brands",
                newName: "id");
        }
    }
}
