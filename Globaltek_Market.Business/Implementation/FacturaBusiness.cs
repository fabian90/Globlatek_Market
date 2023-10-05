using Globaltek_Market.Business.Interface;
using Globaltek_Market.Common;
using Globaltek_Market.Common.Helper;
using Globaltek_Market.Infraestructure.Data.Implementation;
using Globaltek_Market.Infraestructure.Dtos;
using Globaltek_Market.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globaltek_Market.Business.Implementation
{
    public class FacturaBusiness: IFacturaBusiness
    {
        public BusinessResultado<FacturaDto> Actualizar(FacturaDto factura)
        {
            try
            {
                var facturaBusiness = new FacturaData();
                facturaBusiness.Update(ConfiguracionMapper<FacturaDto, Factura>.Convert(factura));
                return BusinessResultado<FacturaDto>.Success(factura, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<FacturaDto>.Error(factura, ex.Message, ex);
            }
        }

        public BusinessResultado<IEnumerable<FacturaDto>> Consultar()
        {
            IEnumerable<FacturaDto> obj = new List<FacturaDto>();
            try
            {
                var facturaBusiness = new FacturaData();
                var mapp = ConfiguracionMapper<Factura, FacturaDto>.ConvertList(facturaBusiness.GetAll().ToList());
                return BusinessResultado<IEnumerable<FacturaDto>>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<IEnumerable<FacturaDto>>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<FacturaDto> ConsultarFacturaPorId(int Id)
        {
            var obj = new FacturaDto();
            try
            {
                var facturaBusiness = new FacturaData();
                var all = facturaBusiness.Get(Id);
                var mapp = (ConfiguracionMapper<Factura, FacturaDto>.Convert(all));
                return BusinessResultado<FacturaDto>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<FacturaDto>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<FacturaDto> Eliminar(int idfactura)
        {
            var obj = new FacturaDto();
            try
            {
                var facturaBusiness = new FacturaData();
                var all = facturaBusiness.Delete(idfactura);
                var mapp = (ConfiguracionMapper<Factura, FacturaDto>.Convert(all));
                return BusinessResultado<FacturaDto>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<FacturaDto>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<FacturaDto> Guardar(FacturaDto factura)
        {
            try
            {
                var facturaBusiness = new FacturaData();
                var all = facturaBusiness.Add(ConfiguracionMapper<FacturaDto, Factura>.Convert(factura));
                factura = ConfiguracionMapper<Factura, FacturaDto>.Convert(all);
                return BusinessResultado<FacturaDto>.Success(factura, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<FacturaDto>.Error(factura, ex.Message, ex);
            }
        }
    }
}
