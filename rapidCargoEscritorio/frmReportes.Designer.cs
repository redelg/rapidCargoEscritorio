namespace rapidCargoEscritorio
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportes_btn_verChart = new System.Windows.Forms.Button();
            this.reportes_bt_guardarPDF = new System.Windows.Forms.Button();
            this.reportes_dgv_listarReportes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRemitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaEncomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportes_dtp_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.reportes_dtp_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.reportes_bt_generarReporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportes_dgv_listarReportes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportes_btn_verChart);
            this.groupBox2.Controls.Add(this.reportes_bt_guardarPDF);
            this.groupBox2.Controls.Add(this.reportes_dgv_listarReportes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1265, 371);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE ENCOMIENDAS";
            // 
            // reportes_btn_verChart
            // 
            this.reportes_btn_verChart.Location = new System.Drawing.Point(689, 333);
            this.reportes_btn_verChart.Name = "reportes_btn_verChart";
            this.reportes_btn_verChart.Size = new System.Drawing.Size(238, 32);
            this.reportes_btn_verChart.TabIndex = 10;
            this.reportes_btn_verChart.Text = "VER CHART";
            this.reportes_btn_verChart.UseVisualStyleBackColor = true;
            // 
            // reportes_bt_guardarPDF
            // 
            this.reportes_bt_guardarPDF.Location = new System.Drawing.Point(338, 333);
            this.reportes_bt_guardarPDF.Name = "reportes_bt_guardarPDF";
            this.reportes_bt_guardarPDF.Size = new System.Drawing.Size(238, 32);
            this.reportes_bt_guardarPDF.TabIndex = 8;
            this.reportes_bt_guardarPDF.Text = "GUARDAR COMO PDF";
            this.reportes_bt_guardarPDF.UseVisualStyleBackColor = true;
            // 
            // reportes_dgv_listarReportes
            // 
            this.reportes_dgv_listarReportes.AllowUserToAddRows = false;
            this.reportes_dgv_listarReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportes_dgv_listarReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreRemitente,
            this.RutaEncomienda,
            this.NombreDestinatario,
            this.FechaEnvio,
            this.FechaEntrega,
            this.Pago,
            this.Estado});
            this.reportes_dgv_listarReportes.Location = new System.Drawing.Point(19, 37);
            this.reportes_dgv_listarReportes.Name = "reportes_dgv_listarReportes";
            this.reportes_dgv_listarReportes.RowHeadersVisible = false;
            this.reportes_dgv_listarReportes.RowTemplate.Height = 24;
            this.reportes_dgv_listarReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportes_dgv_listarReportes.Size = new System.Drawing.Size(1223, 276);
            this.reportes_dgv_listarReportes.TabIndex = 9;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // NombreRemitente
            // 
            this.NombreRemitente.HeaderText = "NombreRemitente";
            this.NombreRemitente.Name = "NombreRemitente";
            this.NombreRemitente.Width = 200;
            // 
            // RutaEncomienda
            // 
            this.RutaEncomienda.HeaderText = "RutaEncomienda";
            this.RutaEncomienda.Name = "RutaEncomienda";
            this.RutaEncomienda.Width = 240;
            // 
            // NombreDestinatario
            // 
            this.NombreDestinatario.HeaderText = "NombreDestinatario";
            this.NombreDestinatario.Name = "NombreDestinatario";
            this.NombreDestinatario.Width = 240;
            // 
            // FechaEnvio
            // 
            this.FechaEnvio.HeaderText = "FechaEnvio";
            this.FechaEnvio.Name = "FechaEnvio";
            this.FechaEnvio.Width = 110;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "FechaEntrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Width = 120;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.Width = 70;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "REPORTE DE ENCOMIENDAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportes_dtp_fechaFin);
            this.groupBox1.Controls.Add(this.reportes_dtp_fechaInicio);
            this.groupBox1.Controls.Add(this.reportes_bt_generarReporte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1265, 128);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RANGO DE FECHAS";
            // 
            // reportes_dtp_fechaFin
            // 
            this.reportes_dtp_fechaFin.Location = new System.Drawing.Point(809, 37);
            this.reportes_dtp_fechaFin.Name = "reportes_dtp_fechaFin";
            this.reportes_dtp_fechaFin.Size = new System.Drawing.Size(318, 26);
            this.reportes_dtp_fechaFin.TabIndex = 7;
            // 
            // reportes_dtp_fechaInicio
            // 
            this.reportes_dtp_fechaInicio.Location = new System.Drawing.Point(199, 38);
            this.reportes_dtp_fechaInicio.Name = "reportes_dtp_fechaInicio";
            this.reportes_dtp_fechaInicio.Size = new System.Drawing.Size(310, 26);
            this.reportes_dtp_fechaInicio.TabIndex = 6;
            // 
            // reportes_bt_generarReporte
            // 
            this.reportes_bt_generarReporte.Location = new System.Drawing.Point(525, 79);
            this.reportes_bt_generarReporte.Name = "reportes_bt_generarReporte";
            this.reportes_bt_generarReporte.Size = new System.Drawing.Size(209, 32);
            this.reportes_bt_generarReporte.TabIndex = 2;
            this.reportes_bt_generarReporte.Text = "GENERAR REPORTE";
            this.reportes_bt_generarReporte.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de inicio:";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportes_dgv_listarReportes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button reportes_btn_verChart;
        private System.Windows.Forms.Button reportes_bt_guardarPDF;
        private System.Windows.Forms.DataGridView reportes_dgv_listarReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRemitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaEncomienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker reportes_dtp_fechaFin;
        private System.Windows.Forms.DateTimePicker reportes_dtp_fechaInicio;
        private System.Windows.Forms.Button reportes_bt_generarReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}