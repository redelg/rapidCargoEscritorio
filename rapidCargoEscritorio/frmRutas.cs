using Newtonsoft.Json;
using rapidCargoEscritorio.Clases;
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
    public partial class frmRutas : Form
    {
        public frmRutas()
        {
            InitializeComponent();
        }

        public static async Task<List<Rutas>> ListarRutasGerente(String cadena)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Ruta/ListarRutasGerente?cadena=" + cadena))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<Rutas>>(res, settings);
                        List<Rutas> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<Rutas>>(null);
                    }

                }

            }

        }

        private void frmRutas_Load(object sender, EventArgs e)
        {
            rutas_dgv_listarRutas.AllowUserToAddRows = false;
        }

        private async void rutas_bt_buscarRuta_Click(object sender, EventArgs e)
        {
            List<Rutas> rutas = new List<Rutas>();
            rutas = await ListarRutasGerente(rutas_tb_buscarRuta.Text);
            rutas_dgv_listarRutas.Rows.Clear();
            foreach (Rutas ruta in rutas)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(rutas_dgv_listarRutas);
                row.Cells[0].Value = ruta.idRuta;
                row.Cells[1].Value = ruta.nombreRuta;
                row.Cells[2].Value = ruta.ciudadOrigen.nombreCiudad;
                row.Cells[3].Value = ruta.ciudadDestino.nombreCiudad;
                rutas_dgv_listarRutas.Rows.Add(row);
            }

        }

        private void rutas_bt_nuevaRuta_Click(object sender, EventArgs e)
        {
            frmCrearRuta crearRuta = new frmCrearRuta();
            crearRuta.Tag = this;
            crearRuta.ShowDialog(this);
        }



        private void rutas_dgv_listarRutas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRuta = (int)rutas_dgv_listarRutas.Rows[e.RowIndex].Cells[0].Value;
            frmValidarEliminarRuta validarEliminarRuta = new frmValidarEliminarRuta(idRuta);
            validarEliminarRuta.Tag = this;
            validarEliminarRuta.Show(this);

        }
    }
}
