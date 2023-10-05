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
    public class ProductoData : IRepositoryBase<Producto>
    {
        public Producto Add(Producto obj)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {
                    context.Productos.Add(obj);
                    context.SaveChanges();
                    return obj;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }

        public Producto Delete(int Id)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {
                    var detalle = context.Productos.Find(Id);
                    context.Productos.Remove(detalle);
                    context.SaveChanges();
                    return detalle;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Producto> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string nombre)
        {
            throw new NotImplementedException();
        }

        public Producto Get(int id)
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {

                    return context.Productos.Find(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Producto> GetAll()
        {
            using (globaltekDBContext context = new globaltekDBContext())
            {
                try
                {
                    var producto= context.Productos.ToList();

                    return producto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Producto Update(Producto obj)
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
