using Microsoft.EntityFrameworkCore.Migrations;

namespace MachineRepairScheduler.WebApi.Migrations
{
    public partial class AddMachine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: false),
                    MachineName = table.Column<string>(nullable: true),
                    ManufacturerName = table.Column<string>(nullable: true),
                    YearOfManufacture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                    table.UniqueConstraint("AK_Machines_SerialNumber", x => x.SerialNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Machines");
        }
    }
}
