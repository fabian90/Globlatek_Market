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
    public class DetalleConfiguration : EntityTypeConfiguration<Detalle>
    {

        public DetalleConfiguration()
        {
            ToTable("Detalles");
            HasKey(d => d.IdDetalle);
            Property(d => d.IdDetalle)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Autoincremental
            Property(d => d.IdFactura).IsOptional();
            Property(d => d.IdProducto).IsRequired();
            Property(d => d.Cantidad).IsRequired();
            Property(d => d.PrecioUnitario).IsRequired();

            // Configuración de la relación entre Detalle y Producto
            HasRequired(d => d.Producto)
                .WithMany(f => f.Detalles)
                .HasForeignKey(d => d.IdProducto);

            // Configuración de la relación muchos a uno entre Detalle y Factura
            HasRequired(d => d.Factura)
                .WithMany(f => f.Detalles)
                .HasForeignKey(d => d.IdFactura);
        }
    }
}
