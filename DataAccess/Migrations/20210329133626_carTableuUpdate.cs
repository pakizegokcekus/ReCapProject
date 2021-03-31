using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class carTableuUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "daily_price",
                table: "Cars",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "model_year",
                table: "Cars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "daily_price",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "model_year",
                table: "Cars");
        }
    }
}
