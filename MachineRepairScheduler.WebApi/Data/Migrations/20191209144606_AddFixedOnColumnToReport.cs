using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MachineRepairScheduler.WebApi.Migrations
{
    public partial class AddFixedOnColumnToReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FixDate",
                table: "MalfunctionReports",
                newName: "PlannedFixDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "FixedDate",
                table: "MalfunctionReports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FixedDate",
                table: "MalfunctionReports");

            migrationBuilder.RenameColumn(
                name: "PlannedFixDate",
                table: "MalfunctionReports",
                newName: "FixDate");
        }
    }
}
