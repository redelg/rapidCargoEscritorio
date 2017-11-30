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
    public partial class frmCrearVehiculo : Form
    {
        public frmCrearVehiculo()
        {
            InitializeComponent();
        }

        public static async Task<Boolean> CrearVehiculo(String numeroPlaca, String capacidadKilos, int idTipoVehiculo)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Vehiculo/CrearVehiculo?numeroPlaca=" + numeroPlaca + "&capacidadKilos=" + capacidadKilos + "&idTipoVehiculo=" + idTipoVehiculo))
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

        public static async Task<List<TipoVehiculo>> ListarTipoVehiculo()
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/TipoVehiculo/ListarTipoVehiculo?"))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<TipoVehiculo>>(res, settings);
                        List<TipoVehiculo> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<TipoVehiculo>>(null);
                    }

                }

            }

        }


        private async void frmCrearVehiculo_Load(object sender, EventArgs e)
        {
            List<TipoVehiculo> tiposVehiculo = new List<TipoVehiculo>();

            tiposVehiculo = await ListarTipoVehiculo();
            vehiculos_cb_tipoVehiculo.Items.Clear();
            vehiculos_cb_tipoVehiculo.DataSource = tiposVehiculo;
            vehiculos_cb_tipoVehiculo.DisplayMember = "descripcion";
            vehiculos_cb_tipoVehiculo.ValueMember = "idTipoVehiculo";
            vehiculos_cb_tipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void vehiculos_bt_crearNuevoVehiculo_Click(object sender, EventArgs e)
        {
            if ((int)vehiculos_cb_tipoVehiculo.SelectedValue == 1 && int.Parse(vehiculos_tb_capacidad.Text) < 40)
            {
                MessageBox.Show("La capacidad del bus debe ser mayor o igual a 40");
            }
            else
            {
                if ((int)vehiculos_cb_tipoVehiculo.SelectedValue == 2 && int.Parse(vehiculos_tb_capacidad.Text) < 20)
                {
                    MessageBox.Show("La capacidad de la minivan debe ser mayor o igual a 20");
                }
                else
                {
                    Boolean inserto = await CrearVehiculo(vehiculos_tb_numeroPlaca.Text, vehiculos_tb_capacidad.Text, (int)vehiculos_cb_tipoVehiculo.SelectedValue);
                    if (inserto)
                    {
                        MessageBox.Show("Se agregó el vehículo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar vehículo");
                    }
                }

            }

        }

        private void vehiculos_tb_capacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
