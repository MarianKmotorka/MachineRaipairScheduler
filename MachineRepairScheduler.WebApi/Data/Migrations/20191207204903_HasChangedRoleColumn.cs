using Microsoft.EntityFrameworkCore.Migrations;

namespace MachineRepairScheduler.WebApi.Migrations
{
    public partial class HasChangedRoleColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_IdentityUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_IdentityUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "HasChangedRole",
                table: "Technicians",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasChangedRole",
                table: "Employees",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "PlanningManagers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true),
                    HasChangedRole = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanningManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanningManagers_Users_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanningManagers_IdentityUserId",
                table: "PlanningManagers",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanningManagers");

            migrationBuilder.DropColumn(
                name: "HasChangedRole",
                table: "Technicians");

            migrationBuilder.DropColumn(
                name: "HasChangedRole",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdentityUserId",
                table: "Users",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_IdentityUserId",
                table: "Users",
                column: "IdentityUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
