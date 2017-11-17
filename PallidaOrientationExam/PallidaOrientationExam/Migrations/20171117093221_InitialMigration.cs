using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PallidaOrientationExam.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LicensePlates",
                columns: table => new
                {
                    Plate = table.Column<string>(maxLength: 50, nullable: false),
                    Brand = table.Column<string>(maxLength: 50, nullable: true),
                    Color = table.Column<string>(maxLength: 50, nullable: true),
                    Model = table.Column<string>(maxLength: 50, nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicensePlates", x => x.Plate);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LicensePlates");
        }
    }
}
