namespace rapidCargoEscritorio
{
    partial class frmCrearRuta
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
            this.rutas_cb_ciudadDestino = new System.Windows.Forms.ComboBox();
            this.rutas_cb_ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.rutas_tb_descripcionRuta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rutas_bt_crearNuevaRuta = new System.Windows.Forms.Button();
            this.rutas_tb_nombreNuevaRuta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rutas_cb_ciudadDestino
            // 
            this.rutas_cb_ciudadDestino.FormattingEnabled = true;
            this.rutas_cb_ciudadDestino.Location = new System.Drawing.Point(145, 162);
            this.rutas_cb_ciudadDestino.Margin = new System.Windows.Forms.Padding(2);
            this.rutas_cb_ciudadDestino.Name = "rutas_cb_ciudadDestino";
            this.rutas_cb_ciudadDestino.Size = new System.Drawing.Size(197, 21);
            this.rutas_cb_ciudadDestino.TabIndex = 21;
            // 
            // rutas_cb_ciudadOrigen
            // 
            this.rutas_cb_ciudadOrigen.FormattingEnabled = true;
            this.rutas_cb_ciudadOrigen.Location = new System.Drawing.Point(145, 114);
            this.rutas_cb_ciudadOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.rutas_cb_ciudadOrigen.Name = "rutas_cb_ciudadOrigen";
            this.rutas_cb_ciudadOrigen.Size = new System.Drawing.Size(197, 21);
            this.rutas_cb_ciudadOrigen.TabIndex = 20;
            // 
            // rutas_tb_descripcionRuta
            // 
            this.rutas_tb_descripcionRuta.Location = new System.Drawing.Point(145, 214);
            this.rutas_tb_descripcionRuta.Margin = new System.Windows.Forms.Padding(2);
            this.rutas_tb_descripcionRuta.Name = "rutas_tb_descripcionRuta";
            this.rutas_tb_descripcionRuta.Size = new System.Drawing.Size(197, 20);
            this.rutas_tb_descripcionRuta.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Descripción:";
            // 
            // rutas_bt_crearNuevaRuta
            // 
            this.rutas_bt_crearNuevaRuta.Location = new System.Drawing.Point(132, 264);
            this.rutas_bt_crearNuevaRuta.Margin = new System.Windows.Forms.Padding(2);
            this.rutas_bt_crearNuevaRuta.Name = "rutas_bt_crearNuevaRuta";
            this.rutas_bt_crearNuevaRuta.Size = new System.Drawing.Size(104, 29);
            this.rutas_bt_crearNuevaRuta.TabIndex = 17;
            this.rutas_bt_crearNuevaRuta.Text = "Agregar ruta";
            this.rutas_bt_crearNuevaRuta.UseVisualStyleBackColor = true;
            // 
            // rutas_tb_nombreNuevaRuta
            // 
            this.rutas_tb_nombreNuevaRuta.Location = new System.Drawing.Point(145, 63);
            this.rutas_tb_nombreNuevaRuta.Margin = new System.Windows.Forms.Padding(2);
            this.rutas_tb_nombreNuevaRuta.Name = "rutas_tb_nombreNuevaRuta";
            this.rutas_tb_nombreNuevaRuta.Size = new System.Drawing.Size(197, 20);
            this.rutas_tb_nombreNuevaRuta.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ciudad de destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ciudad de origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "NUEVA RUTA";
            // 
            // frmCrearRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 319);
            this.Controls.Add(this.rutas_cb_ciudadDestino);
            this.Controls.Add(this.rutas_cb_ciudadOrigen);
            this.Controls.Add(this.rutas_tb_descripcionRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rutas_bt_crearNuevaRuta);
            this.Controls.Add(this.rutas_tb_nombreNuevaRuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearRuta";
            this.Text = "Crear Ruta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rutas_cb_ciudadDestino;
        private System.Windows.Forms.ComboBox rutas_cb_ciudadOrigen;
        private System.Windows.Forms.TextBox rutas_tb_descripcionRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rutas_bt_crearNuevaRuta;
        private System.Windows.Forms.TextBox rutas_tb_nombreNuevaRuta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}