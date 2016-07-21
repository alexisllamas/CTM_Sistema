namespace Ctm_Col.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtableRecibosDeducible : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReciboDeducibles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Cantidad = c.Double(nullable: false),
                        Ajuste_Id = c.Int(),
                        Chofer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ajustes", t => t.Ajuste_Id)
                .ForeignKey("dbo.Chofers", t => t.Chofer_Id)
                .Index(t => t.Ajuste_Id)
                .Index(t => t.Chofer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReciboDeducibles", "Chofer_Id", "dbo.Chofers");
            DropForeignKey("dbo.ReciboDeducibles", "Ajuste_Id", "dbo.Ajustes");
            DropIndex("dbo.ReciboDeducibles", new[] { "Chofer_Id" });
            DropIndex("dbo.ReciboDeducibles", new[] { "Ajuste_Id" });
            DropTable("dbo.ReciboDeducibles");
        }
    }
}
