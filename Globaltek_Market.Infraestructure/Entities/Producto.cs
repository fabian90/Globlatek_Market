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
    public class Producto
    {
        public Producto()
        {
            Detalles = new HashSet<Detalle>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Autoincremental
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public string Nombre { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
