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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static async Task<Usuario> VerificarAcceso(String nombreUsuario, String contrasena)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Usuario/VerificarAcceso?nombreUsuario=" + nombreUsuario + "&contrasena=" + contrasena))
                {
                    using (HttpContent content = response.Content)
                    {
                        String a = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<Usuario>(a, settings);
                        Usuario usuario = (Usuario)objeto;

                        if (usuario != null)
                        {
                            return await Task.Run(() => usuario);
                        }
                        else
                            return await Task.FromResult<Usuario>(null);
                    }

                }

            }
        }

        private async void login_bt_ingresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = await VerificarAcceso(login_tb_username.Text, login_tb_password.Text);
            if (usuario != null)
            {
                if (usuario.tipoUsuario.idTipoUsuario == 1)
                {
                    Global.nombreUsuario = usuario.nombreUsuario;
                    Global.contrasena = usuario.contrasena;
                    frmMenuGerente menuGerente = new frmMenuGerente();
                    menuGerente.Tag = this;
                    menuGerente.Show(this);
                    Hide();

                }
                else
                {
                    MessageBox.Show("Tipo de usuario no válido");
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalidos");
            }
        }

        private void login_bt_limpiar_Click(object sender, EventArgs e)
        {
            login_tb_username.Text = "";
            login_tb_password.Text = "";

        }
    }
}

