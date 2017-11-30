namespace rapidCargoEscritorio
{
    partial class frmValidarEliminarRuta
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
            this.validarEliminarRuta_bt_eliminarRuta = new System.Windows.Forms.Button();
            this.validarEliminarRuta_tb_ingresarContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validarEliminarRuta_bt_eliminarRuta
            // 
            this.validarEliminarRuta_bt_eliminarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarRuta_bt_eliminarRuta.Location = new System.Drawing.Point(65, 141);
            this.validarEliminarRuta_bt_eliminarRuta.Margin = new System.Windows.Forms.Padding(2);
            this.validarEliminarRuta_bt_eliminarRuta.Name = "validarEliminarRuta_bt_eliminarRuta";
            this.validarEliminarRuta_bt_eliminarRuta.Size = new System.Drawing.Size(94, 37);
            this.validarEliminarRuta_bt_eliminarRuta.TabIndex = 5;
            this.validarEliminarRuta_bt_eliminarRuta.Text = "ELIMINAR";
            this.validarEliminarRuta_bt_eliminarRuta.UseVisualStyleBackColor = true;
            // 
            // validarEliminarRuta_tb_ingresarContrasena
            // 
            this.validarEliminarRuta_tb_ingresarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarRuta_tb_ingresarContrasena.Location = new System.Drawing.Point(56, 91);
            this.validarEliminarRuta_tb_ingresarContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.validarEliminarRuta_tb_ingresarContrasena.Name = "validarEliminarRuta_tb_ingresarContrasena";
            this.validarEliminarRuta_tb_ingresarContrasena.Size = new System.Drawing.Size(116, 23);
            this.validarEliminarRuta_tb_ingresarContrasena.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese su Contraseña";
            // 
            // frmValidarEliminarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 225);
            this.Controls.Add(this.validarEliminarRuta_bt_eliminarRuta);
            this.Controls.Add(this.validarEliminarRuta_tb_ingresarContrasena);
            this.Controls.Add(this.label1);
            this.Name = "frmValidarEliminarRuta";
            this.Text = "Validacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validarEliminarRuta_bt_eliminarRuta;
        private System.Windows.Forms.TextBox validarEliminarRuta_tb_ingresarContrasena;
        private System.Windows.Forms.Label label1;
    }
}