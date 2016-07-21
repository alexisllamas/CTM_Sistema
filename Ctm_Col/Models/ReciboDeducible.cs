using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctm_Col.Models
{
    public class ReciboDeducible
    {
        public int Id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Fecha { get; set; }
        public Double Cantidad { get; set; }
        public virtual Chofer Chofer { get; set; }
        public virtual Ajuste Ajuste { get; set; }
        public virtual Taxi Taxi { get; set; }

    }
}
