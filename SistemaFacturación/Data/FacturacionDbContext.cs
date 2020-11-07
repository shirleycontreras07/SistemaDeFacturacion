using Microsoft.EntityFrameworkCore;
using SistemaFacturación.Models.FacturacionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturación.Data
{
    public class FacturacionDbContext : DbContext
    {
        public FacturacionDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Facturacion> Facturaciones { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<AsientoContable> AsientoContables { get; set; }
        public DbSet<TipoMovimiento> TipoMovimientos { get; set; }
    }
}
