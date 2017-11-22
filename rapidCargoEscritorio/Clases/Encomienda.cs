using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapidCargoEscritorio.Clases
{
    public class Encomienda
    {
        public int idEncomienda { get; set; }
        public string codigoEncomienda { get; set; }
        public Cliente cliente { get; set; }
        public Rutas ruta { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaLlegada { get; set; }
        public EntregaUnica entregaUnica { get; set; }
        public string nombreDestinatario { get; set; }
        public string direccionDestinatario { get; set; }
        public Sucursal sucursalOrigen { get; set; }
        public Sucursal sucursalDestino { get; set; }
        public EstadoEncomienda estadoEncomienda { get; set; }
        public float peso { get; set; }
        public float montoPago { get; set; }
        public string descripcionEncomienda { get; set; }
        public bool aDomicilio { get; set; }
        public Usuario usuarioCajero { get; set; }
    }
}
