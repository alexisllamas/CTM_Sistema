namespace Ctm_Col.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRecibosPrimeringreso : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReciboPrimerIngresoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Cantidad = c.Double(nullable: false),
                        Ajuste_Id = c.Int(),
                        Concesionario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ajustes", t => t.Ajuste_Id)
                .ForeignKey("dbo.Concesionarios", t => t.Concesionario_Id)
                .Index(t => t.Ajuste_Id)
                .Index(t => t.Concesionario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReciboPrimerIngresoes", "Concesionario_Id", "dbo.Concesionarios");
            DropForeignKey("dbo.ReciboPrimerIngresoes", "Ajuste_Id", "dbo.Ajustes");
            DropIndex("dbo.ReciboPrimerIngresoes", new[] { "Concesionario_Id" });
            DropIndex("dbo.ReciboPrimerIngresoes", new[] { "Ajuste_Id" });
            DropTable("dbo.ReciboPrimerIngresoes");
        }
    }
}
