namespace Ctm_Col.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Taxis", "Id", "dbo.Usuarios");
            DropForeignKey("dbo.Polizas", "Taxi_Id", "dbo.Taxis");
            DropForeignKey("dbo.Polizas", "Id", "dbo.Usuarios");
            DropForeignKey("dbo.ReciboAjustes", "Ajuste_Id", "dbo.Ajustes");
            DropForeignKey("dbo.ReciboAjustes", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.ReciboAutoridads", "Ajuste_Id", "dbo.Ajustes");
            DropForeignKey("dbo.ReciboAutoridads", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.ReciboCredencials", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.ReciboDeducibles", "Ajuste_Id", "dbo.Ajustes");
            DropForeignKey("dbo.ReciboDeducibles", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Credencials", "Id", "dbo.Usuarios");
            DropIndex("dbo.Polizas", new[] { "Taxi_Id" });
            DropIndex("dbo.ReciboAjustes", new[] { "Ajuste_Id" });
            DropIndex("dbo.ReciboAjustes", new[] { "Usuario_Id" });
            DropIndex("dbo.ReciboAutoridads", new[] { "Ajuste_Id" });
            DropIndex("dbo.ReciboAutoridads", new[] { "Usuario_Id" });
            DropIndex("dbo.ReciboCredencials", new[] { "Usuario_Id" });
            DropIndex("dbo.ReciboDeducibles", new[] { "Ajuste_Id" });
            DropIndex("dbo.ReciboDeducibles", new[] { "Usuario_Id" });
            CreateTable(
                "dbo.Accidentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        CantidadDeducible = c.Double(nullable: false),
                        Ajuste_Id = c.Int(),
                        Chofer_Id = c.Int(),
                        Taxi_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ajustes", t => t.Ajuste_Id)
                .ForeignKey("dbo.Chofers", t => t.Chofer_Id)
                .ForeignKey("dbo.Taxis", t => t.Taxi_Id)
                .Index(t => t.Ajuste_Id)
                .Index(t => t.Chofer_Id)
                .Index(t => t.Taxi_Id);
            
            CreateTable(
                "dbo.Chofers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Licencia = c.String(),
                        Nombres = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Cargo = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Municipio = c.String(),
                        Colonia = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false, storeType: "date"),
                        Taxi_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Taxis", t => t.Taxi_Id)
                .Index(t => t.Taxi_Id);
            
            CreateTable(
                "dbo.Concesionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rfc = c.String(),
                        Nombres = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Cargo = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Municipio = c.String(),
                        Colonia = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReciboPolizas",
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
            
            AddColumn("dbo.Ajustes", "FechaInicioVigencia", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ajustes", "FechaFinalVigencia", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.ReciboCredencials", "Ajuste_Id", c => c.Int());
            AddColumn("dbo.ReciboCredencials", "Chofer_Id", c => c.Int());
            CreateIndex("dbo.ReciboCredencials", "Ajuste_Id");
            CreateIndex("dbo.ReciboCredencials", "Chofer_Id");
            AddForeignKey("dbo.ReciboCredencials", "Ajuste_Id", "dbo.Ajustes", "Id");
            AddForeignKey("dbo.Credencials", "Id", "dbo.Chofers", "Id");
            AddForeignKey("dbo.ReciboCredencials", "Chofer_Id", "dbo.Chofers", "Id");
            AddForeignKey("dbo.Polizas", "Id", "dbo.Concesionarios", "Id");
            AddForeignKey("dbo.Taxis", "Id", "dbo.Concesionarios", "Id");
            DropColumn("dbo.Polizas", "Taxi_Id");
            DropColumn("dbo.ReciboCredencials", "Usuario_Id");
            DropTable("dbo.Usuarios");
            DropTable("dbo.ReciboAjustes");
            DropTable("dbo.ReciboAutoridads");
            DropTable("dbo.ReciboDeducibles");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
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
            
            AddColumn("dbo.ReciboCredencials", "Usuario_Id", c => c.Int());
            AddColumn("dbo.Polizas", "Taxi_Id", c => c.Int());
            DropForeignKey("dbo.Accidentes", "Taxi_Id", "dbo.Taxis");
            DropForeignKey("dbo.Taxis", "Id", "dbo.Concesionarios");
            DropForeignKey("dbo.ReciboPolizas", "Concesionario_Id", "dbo.Concesionarios");
            DropForeignKey("dbo.ReciboPolizas", "Ajuste_Id", "dbo.Ajustes");
            DropForeignKey("dbo.Polizas", "Id", "dbo.Concesionarios");
            DropForeignKey("dbo.Chofers", "Taxi_Id", "dbo.Taxis");
            DropForeignKey("dbo.ReciboCredencials", "Chofer_Id", "dbo.Chofers");
            DropForeignKey("dbo.Credencials", "Id", "dbo.Chofers");
            DropForeignKey("dbo.Accidentes", "Chofer_Id", "dbo.Chofers");
            DropForeignKey("dbo.ReciboCredencials", "Ajuste_Id", "dbo.Ajustes");
            DropForeignKey("dbo.Accidentes", "Ajuste_Id", "dbo.Ajustes");
            DropIndex("dbo.ReciboPolizas", new[] { "Concesionario_Id" });
            DropIndex("dbo.ReciboPolizas", new[] { "Ajuste_Id" });
            DropIndex("dbo.Chofers", new[] { "Taxi_Id" });
            DropIndex("dbo.ReciboCredencials", new[] { "Chofer_Id" });
            DropIndex("dbo.ReciboCredencials", new[] { "Ajuste_Id" });
            DropIndex("dbo.Accidentes", new[] { "Taxi_Id" });
            DropIndex("dbo.Accidentes", new[] { "Chofer_Id" });
            DropIndex("dbo.Accidentes", new[] { "Ajuste_Id" });
            DropColumn("dbo.ReciboCredencials", "Chofer_Id");
            DropColumn("dbo.ReciboCredencials", "Ajuste_Id");
            DropColumn("dbo.Ajustes", "FechaFinalVigencia");
            DropColumn("dbo.Ajustes", "FechaInicioVigencia");
            DropTable("dbo.ReciboPolizas");
            DropTable("dbo.Concesionarios");
            DropTable("dbo.Chofers");
            DropTable("dbo.Accidentes");
            CreateIndex("dbo.ReciboDeducibles", "Usuario_Id");
            CreateIndex("dbo.ReciboDeducibles", "Ajuste_Id");
            CreateIndex("dbo.ReciboCredencials", "Usuario_Id");
            CreateIndex("dbo.ReciboAutoridads", "Usuario_Id");
            CreateIndex("dbo.ReciboAutoridads", "Ajuste_Id");
            CreateIndex("dbo.ReciboAjustes", "Usuario_Id");
            CreateIndex("dbo.ReciboAjustes", "Ajuste_Id");
            CreateIndex("dbo.Polizas", "Taxi_Id");
            AddForeignKey("dbo.Credencials", "Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.ReciboDeducibles", "Usuario_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.ReciboDeducibles", "Ajuste_Id", "dbo.Ajustes", "Id");
            AddForeignKey("dbo.ReciboCredencials", "Usuario_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.ReciboAutoridads", "Usuario_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.ReciboAutoridads", "Ajuste_Id", "dbo.Ajustes", "Id");
            AddForeignKey("dbo.ReciboAjustes", "Usuario_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.ReciboAjustes", "Ajuste_Id", "dbo.Ajustes", "Id");
            AddForeignKey("dbo.Polizas", "Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Polizas", "Taxi_Id", "dbo.Taxis", "Id");
            AddForeignKey("dbo.Taxis", "Id", "dbo.Usuarios", "Id");
        }
    }
}
