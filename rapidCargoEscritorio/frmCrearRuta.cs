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
    public partial class frmCrearRuta : Form
    {
        public frmCrearRuta()
        {
            InitializeComponent();
        }

        public static async Task<Boolean> CrearRuta(String nombreRuta, int idCiudadOrigen, int idCiudadDestino, String descripcion)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Ruta/CrearRuta?nombreRuta=" + nombreRuta + "&idCiudadOrigen=" + idCiudadOrigen + "&idCiudadDestino=" + idCiudadDestino + "&descripcionRuta=" + descripcion))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var objeto = JsonConvert.DeserializeObject<Boolean>(res);
                        Boolean bandera = (Boolean)objeto;

                        return await Task.Run(() => bandera);

                    }

                }

            }
        }

        public static async Task<List<Ciudad>> ListarCiudad()
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Ciudad/ListarCiudad?"))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<Ciudad>>(res, settings);
                        List<Ciudad> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<Ciudad>>(null);
                    }

                }

            }

        }

        private async void frmCrearRuta_Load(object sender, EventArgs e)
        {
            List<Ciudad> ciudadesOrigen = new List<Ciudad>();

            ciudadesOrigen = await ListarCiudad();
            rutas_cb_ciudadOrigen.Items.Clear();
            rutas_cb_ciudadOrigen.DataSource = ciudadesOrigen;
            rutas_cb_ciudadOrigen.DisplayMember = "nombreCiudad";
            rutas_cb_ciudadOrigen.ValueMember = "idCiudad";
            rutas_cb_ciudadOrigen.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Ciudad> ciudadesDestino = new List<Ciudad>();
            ciudadesDestino = await ListarCiudad();
            rutas_cb_ciudadDestino.Items.Clear();
            rutas_cb_ciudadDestino.DataSource = ciudadesDestino;
            rutas_cb_ciudadDestino.DisplayMember = "nombreCiudad";
            rutas_cb_ciudadDestino.ValueMember = "idCiudad";
            rutas_cb_ciudadDestino.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void rutas_bt_crearNuevaRuta_Click(object sender, EventArgs e)
        {
            if ((int)rutas_cb_ciudadOrigen.SelectedValue == (int)rutas_cb_ciudadDestino.SelectedValue)
            {
                MessageBox.Show("La ciudad de origen y destino son iguales. Cámbialas.");
            }
            else
            {
                Boolean inserto = await CrearRuta(rutas_tb_nombreNuevaRuta.Text, (int)rutas_cb_ciudadOrigen.SelectedValue, (int)rutas_cb_ciudadDestino.SelectedValue, rutas_tb_descripcionRuta.Text);
                if (inserto)
                {
                    MessageBox.Show("Se agregó la ruta");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar ruta");
                }
            }

        }
    }
}
