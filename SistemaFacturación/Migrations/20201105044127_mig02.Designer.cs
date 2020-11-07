﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaFacturación.Data;

namespace SistemaFacturación.Migrations
{
    [DbContext(typeof(FacturacionDbContext))]
    [Migration("20201105044127_mig02")]
    partial class mig02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.Articulo", b =>
                {
                    b.Property<int>("IdArticulo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Estado");

                    b.Property<float>("PrecioUnitario");

                    b.HasKey("IdArticulo");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.AsientoContable", b =>
                {
                    b.Property<int>("IdAsiento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cuenta")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(19);

                    b.Property<string>("Descripción")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Estado");

                    b.Property<string>("Fecha")
                        .IsRequired();

                    b.Property<int>("IdCliente");

                    b.Property<int>("IdTipoMovimiento");

                    b.Property<float>("MontoAsiento");

                    b.HasKey("IdAsiento");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdTipoMovimiento");

                    b.ToTable("AsientoContables");
                });

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CuentaContable")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<bool>("Estado");

                    b.Property<string>("Identificación")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.DetalleFactura", b =>
                {
                    b.Property<int>("IdDetalleFactura")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<bool>("Estado");

                    b.Property<int>("IdArticulo");

                    b.Property<int>("IdFactura");

                    b.Property<decimal>("Precio");

                    b.HasKey("IdDetalleFactura");

                    b.HasIndex("IdArticulo");

                    b.HasIndex("IdFactura");

                    b.ToTable("DetalleFacturas");
                });

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.Facturacion", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Estado");

                    b.Property<DateTime>("Fecha");

                    b.Property<int>("IdCliente");

                    b.Property<int>("IdVendedor");

                    b.HasKey("IdFactura");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdVendedor");

                    b.ToTable("Facturaciones");
                });

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.TipoMovimiento", b =>
                {
                    b.Property<int>("IdTipoMovimiento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.HasKey("IdTipoMovimiento");

                    b.ToTable("TipoMovimientos");
                });

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.Vendedor", b =>
                {
                    b.Property<int>("IdVendedor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<float>("PorcientoComision");

                    b.HasKey("IdVendedor");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.AsientoContable", b =>
                {
                    b.HasOne("SistemaFacturación.Models.FacturacionModels.Cliente", "Cliente")
                        .WithMany("AsientoContable")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaFacturación.Models.FacturacionModels.TipoMovimiento", "TipoMovimiento")
                        .WithMany("AsientoContable")
                        .HasForeignKey("IdTipoMovimiento")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.DetalleFactura", b =>
                {
                    b.HasOne("SistemaFacturación.Models.FacturacionModels.Articulo", "Articulo")
                        .WithMany("DetalleFactura")
                        .HasForeignKey("IdArticulo")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaFacturación.Models.FacturacionModels.Facturacion", "Facturacion")
                        .WithMany("DetalleFactura")
                        .HasForeignKey("IdFactura")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaFacturación.Models.FacturacionModels.Facturacion", b =>
                {
                    b.HasOne("SistemaFacturación.Models.FacturacionModels.Cliente", "Cliente")
                        .WithMany("Facturacion")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaFacturación.Models.FacturacionModels.Vendedor", "Vendedor")
                        .WithMany("Facturacion")
                        .HasForeignKey("IdVendedor")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
