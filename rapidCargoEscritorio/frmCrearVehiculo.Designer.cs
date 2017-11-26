namespace rapidCargoEscritorio
{
    partial class frmCrearVehiculo
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
            this.vehiculos_tb_capacidad = new System.Windows.Forms.TextBox();
            this.vehiculos_cb_tipoVehiculo = new System.Windows.Forms.ComboBox();
            this.vehiculos_bt_crearNuevoVehiculo = new System.Windows.Forms.Button();
            this.vehiculos_tb_numeroPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vehiculos_tb_capacidad
            // 
            this.vehiculos_tb_capacidad.Location = new System.Drawing.Point(191, 149);
            this.vehiculos_tb_capacidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehiculos_tb_capacidad.Name = "vehiculos_tb_capacidad";
            this.vehiculos_tb_capacidad.Size = new System.Drawing.Size(261, 22);
            this.vehiculos_tb_capacidad.TabIndex = 30;
            // 
            // vehiculos_cb_tipoVehiculo
            // 
            this.vehiculos_cb_tipoVehiculo.FormattingEnabled = true;
            this.vehiculos_cb_tipoVehiculo.Location = new System.Drawing.Point(191, 210);
            this.vehiculos_cb_tipoVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehiculos_cb_tipoVehiculo.Name = "vehiculos_cb_tipoVehiculo";
            this.vehiculos_cb_tipoVehiculo.Size = new System.Drawing.Size(261, 24);
            this.vehiculos_cb_tipoVehiculo.TabIndex = 29;
            // 
            // vehiculos_bt_crearNuevoVehiculo
            // 
            this.vehiculos_bt_crearNuevoVehiculo.Location = new System.Drawing.Point(176, 282);
            this.vehiculos_bt_crearNuevoVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehiculos_bt_crearNuevoVehiculo.Name = "vehiculos_bt_crearNuevoVehiculo";
            this.vehiculos_bt_crearNuevoVehiculo.Size = new System.Drawing.Size(139, 36);
            this.vehiculos_bt_crearNuevoVehiculo.TabIndex = 28;
            this.vehiculos_bt_crearNuevoVehiculo.Text = "Agregar vehiculo";
            this.vehiculos_bt_crearNuevoVehiculo.UseVisualStyleBackColor = true;
            // 
            // vehiculos_tb_numeroPlaca
            // 
            this.vehiculos_tb_numeroPlaca.Location = new System.Drawing.Point(191, 88);
            this.vehiculos_tb_numeroPlaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehiculos_tb_numeroPlaca.Name = "vehiculos_tb_numeroPlaca";
            this.vehiculos_tb_numeroPlaca.Size = new System.Drawing.Size(261, 22);
            this.vehiculos_tb_numeroPlaca.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tipo de vehiculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Capacidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Numero de placa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "NUEVO VEHICULO";
            // 
            // frmCrearVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 370);
            this.Controls.Add(this.vehiculos_tb_capacidad);
            this.Controls.Add(this.vehiculos_cb_tipoVehiculo);
            this.Controls.Add(this.vehiculos_bt_crearNuevoVehiculo);
            this.Controls.Add(this.vehiculos_tb_numeroPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearVehiculo";
            this.Text = "Crear vehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vehiculos_tb_capacidad;
        private System.Windows.Forms.ComboBox vehiculos_cb_tipoVehiculo;
        private System.Windows.Forms.Button vehiculos_bt_crearNuevoVehiculo;
        private System.Windows.Forms.TextBox vehiculos_tb_numeroPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}