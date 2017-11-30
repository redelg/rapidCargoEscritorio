namespace rapidCargoEscritorio
{
    partial class frmValidarEliminarPersonal
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
            this.validarEliminarPersonal_bt_eliminarPersonal = new System.Windows.Forms.Button();
            this.validarEliminarPersonal_tb_ingresarContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validarEliminarPersonal_bt_eliminarPersonal
            // 
            this.validarEliminarPersonal_bt_eliminarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarPersonal_bt_eliminarPersonal.Location = new System.Drawing.Point(62, 147);
            this.validarEliminarPersonal_bt_eliminarPersonal.Name = "validarEliminarPersonal_bt_eliminarPersonal";
            this.validarEliminarPersonal_bt_eliminarPersonal.Size = new System.Drawing.Size(125, 45);
            this.validarEliminarPersonal_bt_eliminarPersonal.TabIndex = 8;
            this.validarEliminarPersonal_bt_eliminarPersonal.Text = "ELIMINAR";
            this.validarEliminarPersonal_bt_eliminarPersonal.UseVisualStyleBackColor = true;
            // 
            // validarEliminarPersonal_tb_ingresarContrasena
            // 
            this.validarEliminarPersonal_tb_ingresarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarPersonal_tb_ingresarContrasena.Location = new System.Drawing.Point(50, 86);
            this.validarEliminarPersonal_tb_ingresarContrasena.Name = "validarEliminarPersonal_tb_ingresarContrasena";
            this.validarEliminarPersonal_tb_ingresarContrasena.PasswordChar = '•';
            this.validarEliminarPersonal_tb_ingresarContrasena.Size = new System.Drawing.Size(153, 27);
            this.validarEliminarPersonal_tb_ingresarContrasena.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese su Contraseña";
            // 
            // frmValidarEliminarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 233);
            this.Controls.Add(this.validarEliminarPersonal_bt_eliminarPersonal);
            this.Controls.Add(this.validarEliminarPersonal_tb_ingresarContrasena);
            this.Controls.Add(this.label1);
            this.Name = "frmValidarEliminarPersonal";
            this.Text = "Validacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validarEliminarPersonal_bt_eliminarPersonal;
        private System.Windows.Forms.TextBox validarEliminarPersonal_tb_ingresarContrasena;
        private System.Windows.Forms.Label label1;
    }
}