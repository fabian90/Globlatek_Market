using Globaltek_Market.Infraestructure.Data.Interface;
using Globaltek_Market.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globaltek_Market.Infraestructure.Data.Implementation
{
    public class DetalleData : IRepositoryBase<Detalle>
    {
        public Detalle Add(Detalle obj)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {
                    context.Detalles.Add(obj);
                    context.SaveChanges();
                    return obj;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }

        public Detalle Delete(int Id)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {
                    var detalle = context.Detalles.Find(Id);
                    context.Detalles.Remove(detalle);
                    context.SaveChanges();
                    return detalle;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Detalle> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string nombre)
        {
            throw new NotImplementedException();
        }

        public Detalle Get(int id)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {

                    return context.Detalles.Find(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Detalle> GetAll()
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {

                    return context.Detalles.Include(x=>x.Producto).Include(x=>x.Factura).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Detalle Update(Detalle obj)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {

                    context.Entry(obj).State = EntityState.Modified;
                    context.SaveChanges();
                    return obj;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
