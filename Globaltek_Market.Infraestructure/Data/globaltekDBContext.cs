using Globaltek_Market.Infraestructure.Data.Configurations;
using Globaltek_Market.Infraestructure.Dtos;
using Globaltek_Market.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globaltek_Market.Infraestructure.Data
{
   public class globaltekDBContext : DbContext
    {
        public globaltekDBContext() : base("GlobaltekContext")
        {
        }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FacturaConfiguration());
            modelBuilder.Configurations.Add(new DetalleConfiguration());
            modelBuilder.Configurations.Add(new ProductoConfiguration());

            modelBuilder.Ignore<FacturaDto>();
            modelBuilder.Ignore<DetalleDto>();
            modelBuilder.Ignore<ProductoDto>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
