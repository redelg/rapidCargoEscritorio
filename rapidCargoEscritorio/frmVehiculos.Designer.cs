namespace rapidCargoEscritorio
{
    partial class frmVehiculos
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
            this.vehiculos_dgv_listarVehiculos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vehiculos_cb_listarTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.vehiculos_bt_nuevaVehiculo = new System.Windows.Forms.Button();
            this.vehiculos_bt_buscarVehiculo = new System.Windows.Forms.Button();
            this.vehiculos_tb_buscarVehiculo = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculos_dgv_listarVehiculos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vehiculos_dgv_listarVehiculos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 330);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE VEHICULOS";
            // 
            // vehiculos_dgv_listarVehiculos
            // 
            this.vehiculos_dgv_listarVehiculos.AllowUserToAddRows = false;
            this.vehiculos_dgv_listarVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculos_dgv_listarVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Placa,
            this.Capacidad,
            this.TipoVehiculo});
            this.vehiculos_dgv_listarVehiculos.Location = new System.Drawing.Point(19, 37);
            this.vehiculos_dgv_listarVehiculos.Name = "vehiculos_dgv_listarVehiculos";
            this.vehiculos_dgv_listarVehiculos.RowHeadersVisible = false;
            this.vehiculos_dgv_listarVehiculos.RowTemplate.Height = 24;
            this.vehiculos_dgv_listarVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehiculos_dgv_listarVehiculos.Size = new System.Drawing.Size(784, 276);
            this.vehiculos_dgv_listarVehiculos.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Width = 200;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Width = 240;
            // 
            // TipoVehiculo
            // 
            this.TipoVehiculo.HeaderText = "TipoVehiculo";
            this.TipoVehiculo.Name = "TipoVehiculo";
            this.TipoVehiculo.Width = 240;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "VEHICULOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vehiculos_cb_listarTipoVehiculo);
            this.groupBox1.Controls.Add(this.vehiculos_bt_nuevaVehiculo);
            this.groupBox1.Controls.Add(this.vehiculos_bt_buscarVehiculo);
            this.groupBox1.Controls.Add(this.vehiculos_tb_buscarVehiculo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 103);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GESTIONAR VEHICULOS";
            // 
            // vehiculos_cb_listarTipoVehiculo
            // 
            this.vehiculos_cb_listarTipoVehiculo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.vehiculos_cb_listarTipoVehiculo.FormattingEnabled = true;
            this.vehiculos_cb_listarTipoVehiculo.Location = new System.Drawing.Point(34, 41);
            this.vehiculos_cb_listarTipoVehiculo.Name = "vehiculos_cb_listarTipoVehiculo";
            this.vehiculos_cb_listarTipoVehiculo.Size = new System.Drawing.Size(188, 28);
            this.vehiculos_cb_listarTipoVehiculo.TabIndex = 5;
            this.vehiculos_cb_listarTipoVehiculo.Text = "Tipo de vehiculo";
            // 
            // vehiculos_bt_nuevaVehiculo
            // 
            this.vehiculos_bt_nuevaVehiculo.Location = new System.Drawing.Point(647, 26);
            this.vehiculos_bt_nuevaVehiculo.Name = "vehiculos_bt_nuevaVehiculo";
            this.vehiculos_bt_nuevaVehiculo.Size = new System.Drawing.Size(161, 56);
            this.vehiculos_bt_nuevaVehiculo.TabIndex = 2;
            this.vehiculos_bt_nuevaVehiculo.Text = "NUEVO VEHICULO";
            this.vehiculos_bt_nuevaVehiculo.UseVisualStyleBackColor = true;
            // 
            // vehiculos_bt_buscarVehiculo
            // 
            this.vehiculos_bt_buscarVehiculo.Location = new System.Drawing.Point(475, 26);
            this.vehiculos_bt_buscarVehiculo.Name = "vehiculos_bt_buscarVehiculo";
            this.vehiculos_bt_buscarVehiculo.Size = new System.Drawing.Size(161, 56);
            this.vehiculos_bt_buscarVehiculo.TabIndex = 3;
            this.vehiculos_bt_buscarVehiculo.Text = "BUSCAR VEHICULO";
            this.vehiculos_bt_buscarVehiculo.UseVisualStyleBackColor = true;
            // 
            // vehiculos_tb_buscarVehiculo
            // 
            this.vehiculos_tb_buscarVehiculo.AccessibleDescription = "Placa";
            this.vehiculos_tb_buscarVehiculo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.vehiculos_tb_buscarVehiculo.Location = new System.Drawing.Point(249, 43);
            this.vehiculos_tb_buscarVehiculo.Name = "vehiculos_tb_buscarVehiculo";
            this.vehiculos_tb_buscarVehiculo.Size = new System.Drawing.Size(181, 26);
            this.vehiculos_tb_buscarVehiculo.TabIndex = 4;
            this.vehiculos_tb_buscarVehiculo.Text = "Placa";
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVehiculos";
            this.Text = "Vehiculos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculos_dgv_listarVehiculos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView vehiculos_dgv_listarVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox vehiculos_cb_listarTipoVehiculo;
        private System.Windows.Forms.Button vehiculos_bt_nuevaVehiculo;
        private System.Windows.Forms.Button vehiculos_bt_buscarVehiculo;
        private System.Windows.Forms.TextBox vehiculos_tb_buscarVehiculo;
    }
}