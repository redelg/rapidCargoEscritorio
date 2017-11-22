using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapidCargoEscritorio.Clases
{
    public class Personal
    {
        public int idPersonal { get; set; }
        public Persona persona { get; set; }
        public Usuario usuario { get; set; }
        public string correoCorporativo { get; set; }
        public bool personalActivo { get; set; }
    }
}
