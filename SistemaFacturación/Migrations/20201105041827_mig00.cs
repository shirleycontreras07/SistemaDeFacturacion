using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturación.Migrations
{
    public partial class mig00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    IdArticulo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PrecioUnitario = table.Column<float>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.IdArticulo);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Identificación = table.Column<string>(type: "varchar(15)", nullable: false),
                    CuentaContable = table.Column<string>(type: "varchar(15)", nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "TipoMovimientos",
                columns: table => new
                {
                    IdTipoMovimiento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMovimientos", x => x.IdTipoMovimiento);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    IdVendedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PorcientoComision = table.Column<float>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.IdVendedor);
                });

            migrationBuilder.CreateTable(
                name: "DetalleFacturas",
                columns: table => new
                {
                    IdDetalleFactura = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdArticulo = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFacturas", x => x.IdDetalleFactura);
                    table.ForeignKey(
                        name: "FK_DetalleFacturas_Articulos_IdArticulo",
                        column: x => x.IdArticulo,
                        principalTable: "Articulos",
                        principalColumn: "IdArticulo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AsientoContables",
                columns: table => new
                {
                    IdAsiento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripción = table.Column<string>(type: "varchar(50)", nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    Cuenta = table.Column<string>(type: "varchar(20)", maxLength: 19, nullable: false),
                    IdTipoMovimiento = table.Column<int>(nullable: false),
                    Fecha = table.Column<string>(nullable: false),
                    MontoAsiento = table.Column<float>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsientoContables", x => x.IdAsiento);
                    table.ForeignKey(
                        name: "FK_AsientoContables_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsientoContables_TipoMovimientos_IdTipoMovimiento",
                        column: x => x.IdTipoMovimiento,
                        principalTable: "TipoMovimientos",
                        principalColumn: "IdTipoMovimiento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturaciones",
                columns: table => new
                {
                    IdFactura = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdVendedor = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    IdDetalleFactura = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Comentario = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturaciones", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_Facturaciones_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturaciones_DetalleFacturas_IdDetalleFactura",
                        column: x => x.IdDetalleFactura,
                        principalTable: "DetalleFacturas",
                        principalColumn: "IdDetalleFactura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturaciones_Vendedores_IdVendedor",
                        column: x => x.IdVendedor,
                        principalTable: "Vendedores",
                        principalColumn: "IdVendedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsientoContables_IdCliente",
                table: "AsientoContables",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_AsientoContables_IdTipoMovimiento",
                table: "AsientoContables",
                column: "IdTipoMovimiento");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_IdArticulo",
                table: "DetalleFacturas",
                column: "IdArticulo");

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_IdCliente",
                table: "Facturaciones",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_IdDetalleFactura",
                table: "Facturaciones",
                column: "IdDetalleFactura");

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_IdVendedor",
                table: "Facturaciones",
                column: "IdVendedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsientoContables");

            migrationBuilder.DropTable(
                name: "Facturaciones");

            migrationBuilder.DropTable(
                name: "TipoMovimientos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "DetalleFacturas");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Articulos");
        }
    }
}
