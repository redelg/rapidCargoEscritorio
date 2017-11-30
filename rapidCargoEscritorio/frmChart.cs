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
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }

        public static async Task<List<Tmp>> ListarRutasPorEncomienda()
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Tmp/ListarRutasPorEncomienda?"))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<Tmp>>(res, settings);
                        List<Tmp> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<Tmp>>(null);
                    }

                }

            }

        }

        private async void frmChart_Load(object sender, EventArgs e)
        {
            List<Tmp> tmp = new List<Tmp>();
            tmp = await ListarRutasPorEncomienda();
            frmVerChart_chart.DataSource = tmp;
            //frmVerChart_chart.ChartAreas[0].AxisY.Interval = 1;


            frmVerChart_chart.Series["Rutas"].Points.DataBindXY(tmp, "nombreRuta", tmp, "cantidad");

        }
    }
}
