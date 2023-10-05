using Globaltek_Market.Common;
using Globaltek_Market.Infraestructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globaltek_Market.Business.Interface
{
    public interface IProductoBusiness
    {
        BusinessResultado<ProductoDto> Guardar(ProductoDto producto);
        BusinessResultado<IEnumerable<ProductoDto>> Consultar();
        BusinessResultado<ProductoDto> ConsultarProductoPorId(int Id);
        BusinessResultado<ProductoDto> Eliminar(int idproducto);
        BusinessResultado<ProductoDto> Actualizar(ProductoDto producto);
    }
}
