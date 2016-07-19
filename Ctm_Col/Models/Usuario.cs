using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctm_Col.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Cargo { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }

        [Column(TypeName = "Date")]
        public DateTime FechaNacimiento { get; set; }
    }
}
