namespace Ctm_Col.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ctm_Col.Models.Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ctm_Col.Models.Db context)
        {

            //context.Usuarios.AddOrUpdate(
            //    u => u.Id,
            //    new Usuario
            //    {
            //        Nombres = "Alexis bb",
            //        ApellidoPaterno = "Navarro",
            //        ApellidoMaterno = "Llamas",
            //        Domicilio = "Dr Miguel Galindo 800",
            //        Colonia = "Providencia",
            //        Cargo = "Chidori",
            //        Licencia = "321",
            //        Rfc = "123",
            //        Observaciones = "Es muy chido",
            //        FechaNacimiento = new DateTime(1995, 08, 23),
            //        Municipio = "Colima",
            //        Telefono = "3121234567",
            //        Taxi = new Taxi
            //            {
            //                Marca = "Tsuro",
            //                Modelo = "2018",
            //                Capacidad = "6",
            //                Motor = "Grande",
            //                NumeroEconomico = "57",
            //                NumeroSerie = "123",
            //                Placa = "Chidori",
            //                Sitio = "Libertad"   
            //            }
            //    },
            //    new Usuario
            //    {
            //        Nombres = "Don F",
            //        ApellidoPaterno = "Navarro",
            //        ApellidoMaterno = "Mendoza",
            //        Domicilio = "Su casa",
            //        Colonia = "Chida",
            //        Cargo = "Presi",
            //        Licencia = "De dios",
            //        Rfc = "1234",
            //        Observaciones = "Es don F",
            //        FechaNacimiento = new DateTime(1968, 06, 24),
            //        Municipio = "Comala",
            //        Telefono = "7654321312",
            //        Taxi = new Taxi
            //        {
            //            Marca = "Tsuru",
            //            Modelo = "2005",
            //            Capacidad = "5",
            //            Motor = "Grande",
            //            NumeroEconomico = "58",
            //            NumeroSerie = "123",
            //            Placa = "Chidori",
            //            Sitio = "Libertad"
            //        }
            //    },
            //    new Usuario
            //    {
            //        Nombres = "Don chuy",
            //        ApellidoPaterno = "Don",
            //        ApellidoMaterno = "Chuy",
            //        Domicilio = "La casa de don chuy",
            //        Colonia = "La colonia de don chuy",
            //        Cargo = "Don chuy",
            //        Licencia = "La de su mamá",
            //        Rfc = "12345",
            //        Observaciones = "Se llama don chuy",
            //        FechaNacimiento = new DateTime(2005, 1, 1),
            //        Municipio = "Colima",
            //        Telefono = "1234567123",
            //        Taxi = new Taxi
            //        {
            //            Marca = "Tsuro",
            //            Modelo = "1988",
            //            Capacidad = "2",
            //            Motor = "Grande",
            //            NumeroEconomico = "28",
            //            NumeroSerie = "123",
            //            Placa = "Chidori",
            //            Sitio = "Dinosaurio"
            //        }
            //    }
            //);
        }
    }
}
