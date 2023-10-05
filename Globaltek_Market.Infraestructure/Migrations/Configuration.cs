namespace Globaltek_Market.Infraestructure.Migrations
{
    using Globaltek_Market.Infraestructure.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Globaltek_Market.Infraestructure.Data.globaltekDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Globaltek_Market.Infraestructure.Data.globaltekDBContext context)
        {
                context.Productos.AddOrUpdate(
           p => p.Nombre,
           new Producto { Nombre = "Camisa"},
           new Producto { Nombre = "Pantalon"},
           new Producto { Nombre = "Zapato" },
           new Producto { Nombre = "Tenis" },
           new Producto { Nombre = "Falda" },
           new Producto { Nombre = "Falda" }

            );
        }
    }
}
