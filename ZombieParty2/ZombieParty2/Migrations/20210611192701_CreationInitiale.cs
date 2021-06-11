using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty2.Migrations
{
    public partial class CreationInitiale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZombieType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZombieType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zombie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    IdZombieType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zombie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zombie_ZombieType_IdZombieType",
                        column: x => x.IdZombieType,
                        principalTable: "ZombieType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zombie_IdZombieType",
                table: "Zombie",
                column: "IdZombieType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zombie");

            migrationBuilder.DropTable(
                name: "ZombieType");
        }
    }
}
