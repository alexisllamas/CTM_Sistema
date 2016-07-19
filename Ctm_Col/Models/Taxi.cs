using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ctm_Col.Models
{
    public class Taxi
    {
        public int Id { get; set; }
        public string Sitio { get; set; }
        public string NumeroEconomico { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Motor { get; set; }
        public string NumeroSerie { get; set; }
        public string Capacidad { get; set; }
        public string Placa { get; set; }

        public virtual ICollection<Chofer> Choferes { get; set; }

        [Required]
        public Concesionario Concesionario { get; set; }
    }
}