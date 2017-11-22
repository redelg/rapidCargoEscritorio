using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapidCargoEscritorio.Clases
{
    public class CargaUnica
    {
        public int idCargaUnica { get; set; }
        public Encomienda encomienda { get; set; }
        public Vehiculo vehiculo { get; set; }
        public Usuario nombreConductor { get; set; }
        public Usuario nombreAlmacenero { get; set; }
    }
}
