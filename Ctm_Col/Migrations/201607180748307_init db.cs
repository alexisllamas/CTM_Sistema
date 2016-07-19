namespace Ctm_Col.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ajustes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Credencials",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FechaInicioVigencia = c.DateTime(nullable: false, storeType: "date"),
                        FechaFinalVigencia = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Cargo = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Municipio = c.String(),
                        Colonia = c.String(),
                        Observaciones = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false, storeType: "date"),
                        Licencia = c.String(),
                        Rfc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Polizas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FechaInicioVigencia = c.DateTime(nullable: false, storeType: "date"),
                        FechaFinalVigencia = c.DateTime(nullable: false, storeType: "date"),
                        Taxi_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Taxis", t => t.Taxi_Id)
                .ForeignKey("dbo.Usuarios", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Taxi_Id);
            
            CreateTable(
                "dbo.Taxis",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Sitio = c.String(),
                        NumeroEconomico = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Motor = c.String(),
                        NumeroSerie = c.String(),
                        Capacidad = c.String(),
                        Placa = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ReciboAjustes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Cantidad = c.Double(nullable: false),
                        Ajuste_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ajustes", t => t.Ajuste_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Ajuste_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.ReciboAutoridads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Cantidad = c.Double(nullable: false),
                        Ajuste_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ajustes", t => t.Ajuste_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Ajuste_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.ReciboCredencials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Cantidad = c.Double(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.ReciboDeducibles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Cantidad = c.Double(nullable: false),
                        Ajuste_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ajustes", t => t.Ajuste_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Ajuste_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Credencials", "Id", "dbo.Usuarios");
            DropForeignKey("dbo.ReciboDeducibles", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.ReciboDeducibles", "Ajuste_Id", "dbo.Ajustes");
            DropForeignKey("dbo.ReciboCredencials", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.ReciboAutoridads", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.ReciboAutoridads", "Ajuste_Id", "dbo.Ajustes");
            DropForeignKey("dbo.ReciboAjustes", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.ReciboAjustes", "Ajuste_Id", "dbo.Ajustes");
            DropForeignKey("dbo.Polizas", "Id", "dbo.Usuarios");
            DropForeignKey("dbo.Polizas", "Taxi_Id", "dbo.Taxis");
            DropForeignKey("dbo.Taxis", "Id", "dbo.Usuarios");
            DropIndex("dbo.ReciboDeducibles", new[] { "Usuario_Id" });
            DropIndex("dbo.ReciboDeducibles", new[] { "Ajuste_Id" });
            DropIndex("dbo.ReciboCredencials", new[] { "Usuario_Id" });
            DropIndex("dbo.ReciboAutoridads", new[] { "Usuario_Id" });
            DropIndex("dbo.ReciboAutoridads", new[] { "Ajuste_Id" });
            DropIndex("dbo.ReciboAjustes", new[] { "Usuario_Id" });
            DropIndex("dbo.ReciboAjustes", new[] { "Ajuste_Id" });
            DropIndex("dbo.Taxis", new[] { "Id" });
            DropIndex("dbo.Polizas", new[] { "Taxi_Id" });
            DropIndex("dbo.Polizas", new[] { "Id" });
            DropIndex("dbo.Credencials", new[] { "Id" });
            DropTable("dbo.ReciboDeducibles");
            DropTable("dbo.ReciboCredencials");
            DropTable("dbo.ReciboAutoridads");
            DropTable("dbo.ReciboAjustes");
            DropTable("dbo.Taxis");
            DropTable("dbo.Polizas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Credencials");
            DropTable("dbo.Ajustes");
        }
    }
}
