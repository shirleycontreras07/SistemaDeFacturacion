using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturación.Migrations
{
    public partial class mig01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturaciones_DetalleFacturas_IdDetalleFactura",
                table: "Facturaciones");

            migrationBuilder.DropIndex(
                name: "IX_Facturaciones_IdDetalleFactura",
                table: "Facturaciones");

            migrationBuilder.AddColumn<int>(
                name: "IdFactura",
                table: "DetalleFacturas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_IdFactura",
                table: "DetalleFacturas",
                column: "IdFactura");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturas_Facturaciones_IdFactura",
                table: "DetalleFacturas",
                column: "IdFactura",
                principalTable: "Facturaciones",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturas_Facturaciones_IdFactura",
                table: "DetalleFacturas");

            migrationBuilder.DropIndex(
                name: "IX_DetalleFacturas_IdFactura",
                table: "DetalleFacturas");

            migrationBuilder.DropColumn(
                name: "IdFactura",
                table: "DetalleFacturas");

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_IdDetalleFactura",
                table: "Facturaciones",
                column: "IdDetalleFactura");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturaciones_DetalleFacturas_IdDetalleFactura",
                table: "Facturaciones",
                column: "IdDetalleFactura",
                principalTable: "DetalleFacturas",
                principalColumn: "IdDetalleFactura",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
