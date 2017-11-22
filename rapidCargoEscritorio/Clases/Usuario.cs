using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapidCargoEscritorio.Clases
{
    public class Usuario
    {
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        public Personal personal { get; set; }
        public Sucursal sucursal { get; set; }
        public bool usuarioActivo { get; set; }
        public DateTime ultimaSesion { get; set; }
    }
}
