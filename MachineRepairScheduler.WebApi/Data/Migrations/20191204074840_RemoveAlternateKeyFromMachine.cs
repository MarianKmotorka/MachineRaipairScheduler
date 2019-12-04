using Microsoft.EntityFrameworkCore.Migrations;

namespace MachineRepairScheduler.WebApi.Migrations
{
    public partial class RemoveAlternateKeyFromMachine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Machines_SerialNumber",
                table: "Machines");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "Machines",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "Machines",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Machines_SerialNumber",
                table: "Machines",
                column: "SerialNumber");
        }
    }
}
