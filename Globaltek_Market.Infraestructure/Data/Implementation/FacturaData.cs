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
    public class FacturaData : IRepositoryBase<Factura>
    {
        public Factura Add(Factura obj)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {
                    context.Facturas.Add(obj);
                    context.SaveChanges();
                    return obj;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }

        public Factura Delete(int Id)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {
                    var detalle = context.Facturas.Find(Id);
                    context.Facturas.Remove(detalle);
                    context.SaveChanges();
                    return detalle;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Factura> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string nombre)
        {
            throw new NotImplementedException();
        }

        public Factura Get(int id)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {

                    return context.Facturas.Find(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Factura> GetAll()
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {

                    return context.Facturas.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Factura Update(Factura obj)
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
