using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctm_Col.Models
{
    public class Chofer : Usuario
    {
        public string Licencia { get; set; }
        public virtual Credencial Credencial { get; set; }
        public virtual ICollection<ReciboCredencial> RecibosCredencial { get; set; }
        public virtual ICollection<Accidente> Accidentes { get; set; }
        public virtual Taxi Taxi { get; set; }
    }
}
