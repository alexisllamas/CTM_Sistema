using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ctm_Col.Models
{
    public class Poliza
    {
        [ForeignKey("Concesionario")]
        public int Id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime FechaInicioVigencia { get; set; }

        [Column(TypeName = "Date")]
        public DateTime FechaFinalVigencia { get; set; }

        public virtual Concesionario Concesionario { get; set; }

    }
}