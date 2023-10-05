using Globaltek_Market.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globaltek_Market.Infraestructure.Data.Configurations
{
    public class ProductoConfiguration : EntityTypeConfiguration<Producto>
    {
        public ProductoConfiguration()
        {
            ToTable("Productos");
            HasKey(p => p.IdProducto);
            Property(p => p.IdProducto)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Autoincremental
            Property(p => p.Nombre).IsRequired().HasMaxLength(100);

        }
    }
}
