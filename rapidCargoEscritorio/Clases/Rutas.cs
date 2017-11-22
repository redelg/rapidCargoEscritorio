using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapidCargoEscritorio.Clases
{
    public class Rutas
    {
        public int idRuta { get; set; }
        public string nombreRuta { get; set; }
        public Ciudad ciudadOrigen { get; set; }
        public Ciudad ciudadDestino { get; set; }
        public string descripcionRuta { get; set; }
        public bool rutaActiva { get; set; }
    }
}
