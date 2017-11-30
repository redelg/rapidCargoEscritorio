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
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void vehiculos_bt_nuevaVehiculo_Click(object sender, EventArgs e)
        {
            frmCrearVehiculo crearVehiculo = new frmCrearVehiculo();
            crearVehiculo.Tag = this;
            crearVehiculo.Show(this);
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

        private async void frmVehiculos_Load(object sender, EventArgs e)
        {

            this.ActiveControl = vehiculos_tb_buscarVehiculo;

            List<TipoVehiculo> tiposVehiculo = new List<TipoVehiculo>();
            tiposVehiculo = await ListarTipoVehiculo();
            vehiculos_cb_listarTipoVehiculo.Items.Clear();
            vehiculos_cb_listarTipoVehiculo.DataSource = tiposVehiculo;

            vehiculos_cb_listarTipoVehiculo.DisplayMember = "descripcion";
            vehiculos_cb_listarTipoVehiculo.ValueMember = "idTipoVehiculo";

            vehiculos_cb_listarTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static async Task<List<Vehiculo>> ListarVehiculos(int idTipoVehiculo, String cadena)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Vehiculo/ListarVehiculo?idTipoVehiculo=" + idTipoVehiculo + "&cadena=" + cadena))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<Vehiculo>>(res, settings);
                        List<Vehiculo> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<Vehiculo>>(null);
                    }

                }

            }

        }

        private async void vehiculos_bt_buscarVehiculo_Click(object sender, EventArgs e)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            int valor = (int)vehiculos_cb_listarTipoVehiculo.SelectedValue;
            vehiculos = await ListarVehiculos(valor, vehiculos_tb_buscarVehiculo.Text);
            vehiculos_dgv_listarVehiculos.Rows.Clear();
            foreach (Vehiculo vehiculo in vehiculos)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(vehiculos_dgv_listarVehiculos);
                row.Cells[0].Value = vehiculo.idVehiculo;
                row.Cells[1].Value = vehiculo.numeroPlaca;
                row.Cells[2].Value = vehiculo.capacidadKilos;
                row.Cells[3].Value = vehiculo.tipoVehiculo.descripcion;
                vehiculos_dgv_listarVehiculos.Rows.Add(row);
            }
        }

        private void vehiculos_tb_buscarVehiculo_Enter(object sender, EventArgs e)
        {
            if (vehiculos_tb_buscarVehiculo.Text == "Placa")
            {
                vehiculos_tb_buscarVehiculo.Text = "";
                vehiculos_tb_buscarVehiculo.ForeColor = Color.Black;
            }
        }

        private void vehiculos_tb_buscarVehiculo_Leave(object sender, EventArgs e)
        {
            if (vehiculos_tb_buscarVehiculo.Text == "")
            {
                vehiculos_tb_buscarVehiculo.Text = "Placa";
                vehiculos_tb_buscarVehiculo.ForeColor = Color.Silver;
            }
        }

        private void vehiculos_dgv_listarVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idVehiculo = (int)vehiculos_dgv_listarVehiculos.Rows[e.RowIndex].Cells[0].Value;
            frmValidarEliminarVehiculo validarEliminarVehiculo = new frmValidarEliminarVehiculo(idVehiculo);
            validarEliminarVehiculo.Tag = this;
            validarEliminarVehiculo.Show(this);

        }

    }
}
