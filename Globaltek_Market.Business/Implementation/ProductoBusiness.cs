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
    public class ProductoBusiness : IProductoBusiness
    {
        public BusinessResultado<ProductoDto> Actualizar(ProductoDto detalle)
        {
            try
            {
                var productoBusiness = new ProductoData();
                productoBusiness.Update(ConfiguracionMapper<ProductoDto, Producto>.Convert(detalle));
                return BusinessResultado<ProductoDto>.Success(detalle, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<ProductoDto>.Error(detalle, ex.Message, ex);
            }
        }

        public BusinessResultado<IEnumerable<ProductoDto>> Consultar()
        {
            IEnumerable<ProductoDto> obj = new List<ProductoDto>();
            try
            {
                var productoBusiness = new ProductoData();
                var mapp = ConfiguracionMapper<Producto, ProductoDto>.ConvertList(productoBusiness.GetAll().ToList());
                return BusinessResultado<IEnumerable<ProductoDto>>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<IEnumerable<ProductoDto>>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<ProductoDto> ConsultarProductoPorId(int Id)
        {
            var obj = new ProductoDto();
            try
            {
                var productoBusiness = new ProductoData();
                var all = productoBusiness.Get(Id);
                var mapp = (ConfiguracionMapper<Producto, ProductoDto>.Convert(all));
                return BusinessResultado<ProductoDto>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<ProductoDto>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<ProductoDto> Eliminar(int iddetalle)
        {
            var obj = new ProductoDto();
            try
            {
                var productoBusiness = new ProductoData();
                var all = productoBusiness.Delete(iddetalle);
                var mapp = (ConfiguracionMapper<Producto, ProductoDto>.Convert(all));
                return BusinessResultado<ProductoDto>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<ProductoDto>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<ProductoDto> Guardar(ProductoDto detalle)
        {
            try
            {
                var productoBusiness = new ProductoData();
                var all = productoBusiness.Add(ConfiguracionMapper<ProductoDto, Producto>.Convert(detalle));
                return BusinessResultado<ProductoDto>.Success(detalle, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<ProductoDto>.Error(detalle, ex.Message, ex);
            }
        }
    }
}
