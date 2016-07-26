using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctm_Col.Models
{
    public class Ajuste
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaFinalVigencia { get; set; }
        public double PrimaNeta { get; set; }
        public double IVA { get; set; }
        public double PrimaTotal { get; set; }
        public virtual ICollection<Accidente> Accidentes { get; set; }
        public virtual ICollection<ReciboCredencial> RecibosCredencial { get; set; }
        public virtual ICollection<ReciboPoliza> RecibosPoliza { get; set; }
        public virtual ICollection<ReciboPrimerIngreso> RecibosPrimerIngreso { get; set; }
    }
}
