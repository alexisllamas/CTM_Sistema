using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ctm_Col.Models
{
    public class Credencial
    {
        [ForeignKey("Chofer")]
        public int Id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime FechaInicioVigencia { get; set; }

        [Column(TypeName = "Date")]
        public DateTime FechaFinalVigencia { get; set; }
        
        public virtual Chofer Chofer { get; set; }
    }
}