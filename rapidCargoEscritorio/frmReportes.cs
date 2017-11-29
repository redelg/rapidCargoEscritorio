using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Newtonsoft.Json;
using rapidCargoEscritorio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rapidCargoEscritorio
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        public static async Task<List<Encomienda>> ListarEncomiendasGerente(DateTime fechaInicio, DateTime fechaFin)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Encomienda/ListarEncomiendaGerente?fechaInicio=" +
                    fechaInicio + "&fechaFin=" + fechaFin))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<Encomienda>>(res, settings);
                        List<Encomienda> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<Encomienda>>(null);
                    }

                }

            }

        }

        private async void reportes_bt_generarReporte_Click(object sender, EventArgs e)
        {
            List<Encomienda> encomiendas = new List<Encomienda>();
            encomiendas = await ListarEncomiendasGerente(DateTime.Parse(reportes_dtp_fechaInicio.Text), DateTime.Parse(reportes_dtp_fechaFin.Text));
            reportes_dgv_listarReportes.Rows.Clear();
            foreach (Encomienda encomienda in encomiendas)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(reportes_dgv_listarReportes);
                row.Cells[0].Value = encomienda.codigoEncomienda;
                row.Cells[1].Value = encomienda.cliente.persona.nombres;
                row.Cells[2].Value = encomienda.ruta.nombreRuta;
                row.Cells[3].Value = encomienda.nombreDestinatario;
                row.Cells[4].Value = encomienda.fechaRegistro;
                row.Cells[5].Value = encomienda.entregaUnica.fechaEntrega;
                row.Cells[6].Value = encomienda.montoPago;
                row.Cells[7].Value = encomienda.estadoEncomienda.descripcionEstadoEncomienda;
                reportes_dgv_listarReportes.Rows.Add(row);
            }
        }

        private void reportes_bt_guardarPDF_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Now;
            //Creating iTextSharp Table from the DataTable data

            PdfPTable pdfTable = new PdfPTable(reportes_dgv_listarReportes.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 90;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;


            pdfTable.DefaultCell.BorderWidth = 3;

            //Adding Header row
            for (int j = 0; j < reportes_dgv_listarReportes.Columns.Count; j++)
            {

                PdfPCell cell = new PdfPCell(new Phrase(reportes_dgv_listarReportes.Columns[j].HeaderText));



                cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 140, 0);
                cell.BorderWidth = 3;

                cell.Padding = 6;
                cell.VerticalAlignment = Element.ALIGN_CENTER;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.AddCell(cell);




            }

            for (int i = 0; i < reportes_dgv_listarReportes.Rows.Count; i++)
            {
                for (int k = 0; k < reportes_dgv_listarReportes.Columns.Count; k++)
                {
                    if (reportes_dgv_listarReportes[k, i].Value != null)
                    {
                        pdfTable.AddCell(new Phrase(reportes_dgv_listarReportes[k, i].Value.ToString()));
                    }
                    else
                    {
                        pdfTable.AddCell(new Phrase(" "));
                    }
                }

            }

            //Exporting to PDF

            string folderPath = "C:\\ReportesEncomienda\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Reporte" + thisDay.ToString().Replace("/", "-").Replace(":", "-") + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                iTextSharp.text.Font contentFont = FontFactory.GetFont("Segoe UI", 30.0f, BaseColor.BLACK);

                Paragraph p = new Paragraph("REPORTE DE ENCOMIENDAS", contentFont);
                p.PaddingTop = 20;
                p.Alignment = 1;

                //Paragraph p2 = new Paragraph();

                Chunk linebreak = new Chunk(new LineSeparator(4f, 100f, BaseColor.ORANGE, Element.ALIGN_CENTER, 0));

                iTextSharp.text.Font contentFont2 = FontFactory.GetFont("Segoe UI", 14.0f, BaseColor.BLACK);

                Paragraph fecha = new Paragraph("FECHA DEL REPORTE: " + thisDay, contentFont2);
                fecha.PaddingTop = 20;
                fecha.Alignment = 1;

                pdfDoc.Add(p);
                pdfDoc.Add(fecha);
                pdfDoc.Add(linebreak);

                //pdfDoc.Add(p2);



                pdfDoc.Add(pdfTable);


                pdfDoc.Close();
                stream.Close();
                System.Diagnostics.Process.Start(folderPath + "Reporte" + thisDay.ToString().Replace("/", "-").Replace(":", "-") + ".pdf");

            }
            MessageBox.Show("El PDF se exporto correctamente");

        }


        private void reportes_btn_verChart_Click(object sender, EventArgs e)
        {
            frmChart crearChart = new frmChart();
            crearChart.Tag = this;
            crearChart.ShowDialog(this);
        }
    }
}
