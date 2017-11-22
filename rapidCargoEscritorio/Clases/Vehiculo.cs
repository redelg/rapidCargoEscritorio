using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapidCargoEscritorio.Clases
{
    public class Vehiculo
    {
        public int idVehiculo { get; set; }
        public string numeroPlaca { get; set; }
        public TipoVehiculo tipoVehiculo { get; set; }
        public string capacidadKilos { get; set; }
        public bool vehiculoActivo { get; set; }
    }
}
