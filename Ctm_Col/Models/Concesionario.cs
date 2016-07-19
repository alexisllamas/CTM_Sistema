using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctm_Col.Models
{
    public class Concesionario : Usuario
    {
        public string Rfc { get; set; }
        public virtual Poliza Poliza { get; set; }
        public virtual ICollection<ReciboPoliza> ReciboPoliza { get; set; }
        public Taxi Taxi { get; set; }
    }
}
