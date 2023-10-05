using Globaltek_Market.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace Globaltek_Market.Infraestructure.Dtos
{
    public class FacturaDto
    {
        //public FacturaDto()
        //{
        //    Detalles = new HashSet<DetalleDto>();
        //}
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Autoincremental
        public int IdFactura { get; set; }

        //[Required(ErrorMessage = "El número de factura es obligatorio.")]
        public string NumeroFactura { get; set; }
        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [DataType(DataType.Date)]
        [FechaNoAnterior(ErrorMessage = "La fecha no puede ser anterior al día actual.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
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

        //campo adicionales 
        [Required(ErrorMessage = "El ID de producto es obligatorio.")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria.")]
        public int Cantidad { get; set; }

        //[Required(ErrorMessage = "El precio unitario es obligatorio.")]
        //[Range(0.01, double.MaxValue, ErrorMessage = "El Precio no puede ser negativo.")]
        public decimal PrecioUnitario { get; set; }

        //// Propiedad de navegación para la relación uno a muchos con Detalle
        //[Required(ErrorMessage = "Debe agregar al menos un detalle.")]
        //public virtual ICollection<DetalleDto> Detalles { get; set; }

    }
}
