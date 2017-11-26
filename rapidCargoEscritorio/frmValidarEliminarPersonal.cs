using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rapidCargoEscritorio
{
    public partial class frmValidarEliminarPersonal : Form
    {
        int idPersonal = 0;
        public frmValidarEliminarPersonal(int idPersonal)
        {
            this.idPersonal = idPersonal;
            InitializeComponent();
        }

        public static async Task<Boolean> eliminarPersonal(int idPersonal)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Personal/EliminarPersonal?idPersonal=" + idPersonal))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        Boolean elimino = JsonConvert.DeserializeObject<Boolean>(res);

                        return await Task.Run(() => elimino);

                    }

                }

            }

        }
    }
}
