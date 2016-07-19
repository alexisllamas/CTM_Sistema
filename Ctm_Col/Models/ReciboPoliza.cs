using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctm_Col.Models
{
    public class ReciboPoliza
    {
        public int Id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Fecha { get; set; }

        public Double Cantidad { get; set; }

        public virtual Concesionario Concesionario { get; set; }

        public virtual Ajuste Ajuste { get; set; }
    }
}
