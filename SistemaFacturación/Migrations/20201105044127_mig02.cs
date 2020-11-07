using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturación.Migrations
{
    public partial class mig02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdDetalleFactura",
                table: "Facturaciones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdDetalleFactura",
                table: "Facturaciones",
                nullable: false,
                defaultValue: 0);
        }
    }
}
