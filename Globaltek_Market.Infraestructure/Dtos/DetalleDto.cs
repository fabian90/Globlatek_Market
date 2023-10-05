using Globaltek_Market.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globaltek_Market.Infraestructure.Dtos
{
    public class DetalleDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Autoincremental
        public int IdDetalle { get; set; }

        //[Required(ErrorMessage = "El ID de factura es obligatorio.")]
        public int? IdFactura { get; set; }

        [Required(ErrorMessage = "El ID de producto es obligatorio.")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad de productos debe ser mayor a 0.")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El precio unitario es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El Precio no puede ser negativo.")]
        public decimal PrecioUnitario { get; set; }

        // Propiedad de navegación para la relación muchos a uno con Factura
        // Propiedad de navegación para la relación muchos a uno con Factura
        public virtual FacturaDto Factura { get; set; }

        // Propiedad de navegación para la relación muchos a uno con Producto
        public virtual ProductoDto Producto { get; set; }
    }
}

