namespace Ctm_Col
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Db : DbContext
    {
        // Your context has been configured to use a 'Db' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Ctm_Col.Models.Db' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Db' 
        // connection string in the application configuration file.
        public Db()
            : base("name=Db")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Ajuste> Ajustes { get; set; }
        public DbSet<Credencial> Credenciales { get; set; }
        public DbSet<Poliza> Polizas { get; set; }
        public DbSet<ReciboPoliza> RecibosPoliza { get; set; }
        public DbSet<ReciboCredencial> RecibosCredencial { get; set; }
        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<Chofer> Choferes { get; set; }
        public DbSet<Concesionario> Concesionarios { get; set; }
        public DbSet<Accidente> Accidentes { get; set; }
    }
}