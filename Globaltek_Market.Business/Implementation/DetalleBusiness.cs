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
    public class DetalleBusiness:IDetalleBusiness
    {
        public BusinessResultado<DetalleDto> Actualizar(DetalleDto detalle)
        {
            try
            {
                var detalleBusiness = new DetalleData();
                detalleBusiness.Update(ConfiguracionMapper<DetalleDto, Detalle>.Convert(detalle));
                return BusinessResultado<DetalleDto>.Success(detalle, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<DetalleDto>.Error(detalle, ex.Message, ex);
            }
        }

        public BusinessResultado<IEnumerable<DetalleDto>> Consultar()
        {
            IEnumerable<DetalleDto> obj = new List<DetalleDto>();
            try
            {
                var detalleBusiness = new DetalleData();
                var mapp = ConfiguracionMapper<Detalle, DetalleDto>.ConvertList(detalleBusiness.GetAll().ToList());
                return BusinessResultado<IEnumerable<DetalleDto>>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<IEnumerable<DetalleDto>>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<DetalleDto> ConsultarDetallePorId(int Id)
        {
            var obj = new DetalleDto();
            try
            {
                var detalleBusiness = new DetalleData();
                var all = detalleBusiness.Get(Id);
                var mapp = (ConfiguracionMapper<Detalle, DetalleDto>.Convert(all));
                return BusinessResultado<DetalleDto>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<DetalleDto>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<DetalleDto> Eliminar(int idDetalle)
        {
            var obj = new DetalleDto();
            try
            {
                var detalleBusiness = new DetalleData();
                var all = detalleBusiness.Delete(idDetalle);
                var mapp = (ConfiguracionMapper<Detalle, DetalleDto>.Convert(all));
                return BusinessResultado<DetalleDto>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<DetalleDto>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<DetalleDto> Guardar(DetalleDto detalle)
        {
            try
            {
                var detalleBusiness = new DetalleData();
                 Detalle all = detalleBusiness.Add(ConfiguracionMapper<DetalleDto, Detalle>.Convert(detalle));
                DetalleDto detalleDto = ConfiguracionMapper<Detalle, DetalleDto>.Convert(all);
                return BusinessResultado<DetalleDto>.Success(detalleDto, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<DetalleDto>.Error(detalle, ex.Message, ex);
            }
        }
    }
}
