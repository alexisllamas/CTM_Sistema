using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctm_Col.Models
{
    public class Accidente
    {
        public int Id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Fecha { get; set; }

        public Double CantidadDeducible { get; set; }

        public virtual Chofer Chofer { get; set; }

        public virtual Taxi Taxi { get; set; }

        public virtual Ajuste Ajuste { get; set; }
    }
}
