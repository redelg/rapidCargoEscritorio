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
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        public static async Task<List<Personal>> ListarPersonal(String cadena)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Personal/ListarPersonal?cadena=" + cadena))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<Personal>>(res, settings);
                        List<Personal> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<Personal>>(null);
                    }

                }

            }

        }


        private void personal_bt_nuevoPersonal_Click(object sender, EventArgs e)
        {
            frmCrearPersonal crearPersonal = new frmCrearPersonal();
            crearPersonal.Tag = this;
            crearPersonal.Show(this);
        }

        private async void personal_bt_buscarPersonal_Click(object sender, EventArgs e)
        {
            List<Personal> personales = new List<Personal>();
            personales = await ListarPersonal(personal_tb_buscarPersonal.Text);
            personal_dgv_listarPersonal.Rows.Clear();
            foreach (Personal personal in personales)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(personal_dgv_listarPersonal);
                row.Cells[0].Value = personal.idPersonal;
                row.Cells[1].Value = personal.persona.nombres;
                row.Cells[2].Value = personal.persona.apellidos;
                row.Cells[3].Value = personal.persona.telefono;
                row.Cells[4].Value = personal.usuario.nombreUsuario;
                row.Cells[5].Value = personal.usuario.contrasena;
                row.Cells[6].Value = personal.usuario.tipoUsuario.descripcion;
                personal_dgv_listarPersonal.Rows.Add(row);
            }
        }

        private void personal_dgv_listarPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPersonal = (int)personal_dgv_listarPersonal.Rows[e.RowIndex].Cells[0].Value;
            frmValidarEliminarPersonal validarEliminarPersonal = new frmValidarEliminarPersonal(idPersonal);
            validarEliminarPersonal.Tag = this;
            validarEliminarPersonal.Show(this);

        }


    }
}
