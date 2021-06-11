using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty2.Migrations
{
    public partial class AjoutHuntingLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "ZombieType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Point",
                table: "ZombieType");
        }
    }
}
