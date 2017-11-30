namespace rapidCargoEscritorio
{
    partial class frmRutas
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
            this.rutas_dgv_listarRutas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rutas_bt_nuevaRuta = new System.Windows.Forms.Button();
            this.rutas_bt_buscarRuta = new System.Windows.Forms.Button();
            this.rutas_tb_buscarRuta = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutas_dgv_listarRutas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rutas_dgv_listarRutas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 156);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(617, 268);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE RUTAS";
            // 
            // rutas_dgv_listarRutas
            // 
            this.rutas_dgv_listarRutas.AllowUserToAddRows = false;
            this.rutas_dgv_listarRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rutas_dgv_listarRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.CiudadOrigen,
            this.CiudadDestino});
            this.rutas_dgv_listarRutas.Location = new System.Drawing.Point(14, 30);
            this.rutas_dgv_listarRutas.Margin = new System.Windows.Forms.Padding(2);
            this.rutas_dgv_listarRutas.Name = "rutas_dgv_listarRutas";
            this.rutas_dgv_listarRutas.RowHeadersVisible = false;
            this.rutas_dgv_listarRutas.RowTemplate.Height = 24;
            this.rutas_dgv_listarRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rutas_dgv_listarRutas.Size = new System.Drawing.Size(588, 224);
            this.rutas_dgv_listarRutas.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // CiudadOrigen
            // 
            this.CiudadOrigen.HeaderText = "CiudadOrigen";
            this.CiudadOrigen.Name = "CiudadOrigen";
            this.CiudadOrigen.Width = 240;
            // 
            // CiudadDestino
            // 
            this.CiudadDestino.HeaderText = "CiudadDestino";
            this.CiudadDestino.Name = "CiudadDestino";
            this.CiudadDestino.Width = 240;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "RUTAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rutas_bt_nuevaRuta);
            this.groupBox1.Controls.Add(this.rutas_bt_buscarRuta);
            this.groupBox1.Controls.Add(this.rutas_tb_buscarRuta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(617, 81);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GESTIONAR RUTAS";
            // 
            // rutas_bt_nuevaRuta
            // 
            this.rutas_bt_nuevaRuta.Location = new System.Drawing.Point(490, 31);
            this.rutas_bt_nuevaRuta.Margin = new System.Windows.Forms.Padding(2);
            this.rutas_bt_nuevaRuta.Name = "rutas_bt_nuevaRuta";
            this.rutas_bt_nuevaRuta.Size = new System.Drawing.Size(112, 26);
            this.rutas_bt_nuevaRuta.TabIndex = 2;
            this.rutas_bt_nuevaRuta.Text = "NUEVA RUTA";
            this.rutas_bt_nuevaRuta.UseVisualStyleBackColor = true;
            // 
            // rutas_bt_buscarRuta
            // 
            this.rutas_bt_buscarRuta.Location = new System.Drawing.Point(358, 31);
            this.rutas_bt_buscarRuta.Margin = new System.Windows.Forms.Padding(2);
            this.rutas_bt_buscarRuta.Name = "rutas_bt_buscarRuta";
            this.rutas_bt_buscarRuta.Size = new System.Drawing.Size(121, 26);
            this.rutas_bt_buscarRuta.TabIndex = 3;
            this.rutas_bt_buscarRuta.Text = "BUSCAR RUTA";
            this.rutas_bt_buscarRuta.UseVisualStyleBackColor = true;
            // 
            // rutas_tb_buscarRuta
            // 
            this.rutas_tb_buscarRuta.Location = new System.Drawing.Point(14, 33);
            this.rutas_tb_buscarRuta.Margin = new System.Windows.Forms.Padding(2);
            this.rutas_tb_buscarRuta.Name = "rutas_tb_buscarRuta";
            this.rutas_tb_buscarRuta.Size = new System.Drawing.Size(330, 23);
            this.rutas_tb_buscarRuta.TabIndex = 4;
            // 
            // frmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRutas";
            this.Text = "Rutas";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rutas_dgv_listarRutas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView rutas_dgv_listarRutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rutas_bt_nuevaRuta;
        private System.Windows.Forms.Button rutas_bt_buscarRuta;
        private System.Windows.Forms.TextBox rutas_tb_buscarRuta;
    }
}