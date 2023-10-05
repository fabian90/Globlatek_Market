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
    public class FacturaConfiguration : EntityTypeConfiguration<Factura>
    {
        public FacturaConfiguration()
        {
            HasKey(f => f.IdFactura);
            Property(f => f.IdFactura)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(f => f.NumeroFactura)
                .IsRequired()
                .HasMaxLength(255);

            Property(f => f.Fecha)
                .IsRequired();

            Property(f => f.TipoDePago)
                .IsRequired()
                .HasMaxLength(50);

            Property(f => f.DocumentoCliente)
                .IsRequired()
                .HasMaxLength(50);

            Property(f => f.NombreCliente)
                .IsRequired()
                .HasMaxLength(255);

            Property(f => f.Subtotal)
                .IsRequired();

            Property(f => f.Descuento)
                .IsRequired();

            Property(f => f.IVA)
                .IsRequired();

            Property(f => f.TotalDescuento)
                .IsRequired();

            Property(f => f.TotalImpuesto)
                .IsRequired();

            Property(f => f.Total)
                .IsRequired();

            //HasMany(f => f.Detalles)
            //    .WithRequired(d => d.Factura)
            //    .HasForeignKey(d => d.IdFactura)
            //    .WillCascadeOnDelete(true);
        }
    }
}
