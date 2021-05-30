using Microsoft.EntityFrameworkCore.Migrations;

namespace MP5.Migrations
{
    public partial class AddedWarehouseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Soldiers",
                table: "Soldiers");

            migrationBuilder.RenameTable(
                name: "Soldiers",
                newName: "Soilder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Soilder",
                table: "Soilder",
                column: "IdSoldier");

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    IdWarehouse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CapacityInBoxes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.IdWarehouse);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Soilder",
                table: "Soilder");

            migrationBuilder.RenameTable(
                name: "Soilder",
                newName: "Soldiers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Soldiers",
                table: "Soldiers",
                column: "IdSoldier");
        }
    }
}
