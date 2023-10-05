using Globaltek_Market.Common;
using Globaltek_Market.Infraestructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globaltek_Market.Business.Interface
{
    public interface IFacturaBusiness
    {
        BusinessResultado<FacturaDto> Guardar(FacturaDto detalle);
        BusinessResultado<IEnumerable<FacturaDto>> Consultar();
        BusinessResultado<FacturaDto> ConsultarFacturaPorId(int Id);
        BusinessResultado<FacturaDto> Eliminar(int iddetalle);
        BusinessResultado<FacturaDto> Actualizar(FacturaDto detalle);
    }
}
