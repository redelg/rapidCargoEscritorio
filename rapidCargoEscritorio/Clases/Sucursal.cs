using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapidCargoEscritorio.Clases
{
    public class Sucursal
    {
        public int idSucursal { get; set; }
        public string nombreAgencia { get; set; }
        public string direccionSucursal { get; set; }
        public Ciudad ciudad { get; set; }
        public bool sucursalActiva { get; set; }
    }
}
