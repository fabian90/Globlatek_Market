using Globaltek_Market.Common;
using Globaltek_Market.Infraestructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globaltek_Market.Business.Interface
{
    public interface IDetalleBusiness
    {
        BusinessResultado<DetalleDto> Guardar(DetalleDto detalle);
        BusinessResultado<IEnumerable<DetalleDto>> Consultar();
        BusinessResultado<DetalleDto> ConsultarDetallePorId(int Id);
        BusinessResultado<DetalleDto> Eliminar(int iddetalle);
        BusinessResultado<DetalleDto> Actualizar(DetalleDto detalle);
    }
}
