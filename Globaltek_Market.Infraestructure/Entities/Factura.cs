using Globaltek_Market.Infraestructure.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globaltek_Market.Infraestructure.Entities
{
    public class Factura
    {
        public Factura()
        {
            Detalles = new HashSet<Detalle>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Autoincremental
        public int IdFactura { get; set; }

        [Required(ErrorMessage = "El número de factura es obligatorio.")]
        public string NumeroFactura { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El tipo de pago es obligatorio.")]
        public string TipoDePago { get; set; }

        [Required(ErrorMessage = "El documento del cliente es obligatorio.")]
        public string DocumentoCliente { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "El subtotal es obligatorio.")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "El descuento es obligatorio.")]
        public decimal Descuento { get; set; }

        [Required(ErrorMessage = "El IVA es obligatorio.")]
        public decimal IVA { get; set; }

        [Required(ErrorMessage = "El total de descuento es obligatorio.")]
        public decimal TotalDescuento { get; set; }

        [Required(ErrorMessage = "El total de impuesto es obligatorio.")]
        public decimal TotalImpuesto { get; set; }

        [Required(ErrorMessage = "El total es obligatorio.")]
        public decimal Total { get; set; }

        // Propiedad de navegación para la relación uno a muchos con Detalle
        [Required(ErrorMessage = "Debe agregar al menos un detalle.")]
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
