using Microsoft.EntityFrameworkCore.Migrations;

namespace MP5.Migrations
{
    public partial class AddedFirearmInheritanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firearm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MagazineSize = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    BulletSpeed = table.Column<double>(type: "float", nullable: false),
                    FireDistance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firearm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssaultRifle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FireMode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssaultRifle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssaultRifle_Firearm_Id",
                        column: x => x.Id,
                        principalTable: "Firearm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SniperRifle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MinimalScopeMagnification = table.Column<double>(type: "float", nullable: false),
                    MaximalScopeMagnification = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SniperRifle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SniperRifle_Firearm_Id",
                        column: x => x.Id,
                        principalTable: "Firearm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssaultRifle");

            migrationBuilder.DropTable(
                name: "SniperRifle");

            migrationBuilder.DropTable(
                name: "Firearm");
        }
    }
}
