namespace Globaltek_Market.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitCrear : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Detalle", "IdFactura", c => c.Int(nullable: true)); // Establece nullable: true
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Detalle", "IdFactura", c => c.Int(nullable: false)); // Cambia a nullable: false si es necesario
        }
    }
}
