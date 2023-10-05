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
    public class ProductoDto
    {
     
        [Key]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public string Nombre { get; set; }
        //[NotMapped]
        //public virtual ICollection<DetalleDto> Detalles { get; set; }
    }
}
