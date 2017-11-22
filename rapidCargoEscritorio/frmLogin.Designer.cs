namespace rapidCargoEscritorio
{
    partial class frmLogin
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
            this.login_bt_limpiar = new System.Windows.Forms.Button();
            this.login_bt_ingresar = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.login_tb_password = new System.Windows.Forms.TextBox();
            this.login_tb_username = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_bt_limpiar
            // 
            this.login_bt_limpiar.Location = new System.Drawing.Point(153, 185);
            this.login_bt_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.login_bt_limpiar.Name = "login_bt_limpiar";
            this.login_bt_limpiar.Size = new System.Drawing.Size(56, 29);
            this.login_bt_limpiar.TabIndex = 5;
            this.login_bt_limpiar.Text = "Limpiar";
            this.login_bt_limpiar.UseVisualStyleBackColor = true;
            // 
            // login_bt_ingresar
            // 
            this.login_bt_ingresar.Location = new System.Drawing.Point(81, 185);
            this.login_bt_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.login_bt_ingresar.Name = "login_bt_ingresar";
            this.login_bt_ingresar.Size = new System.Drawing.Size(56, 29);
            this.login_bt_ingresar.TabIndex = 4;
            this.login_bt_ingresar.Text = "Ingresar";
            this.login_bt_ingresar.UseVisualStyleBackColor = true;
            // 
            // loginBox
            // 
            this.loginBox.Controls.Add(this.login_tb_password);
            this.loginBox.Controls.Add(this.login_tb_username);
            this.loginBox.Controls.Add(this.contrasena);
            this.loginBox.Controls.Add(this.nombreUsuario);
            this.loginBox.Location = new System.Drawing.Point(33, 49);
            this.loginBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginBox.Name = "loginBox";
            this.loginBox.Padding = new System.Windows.Forms.Padding(2);
            this.loginBox.Size = new System.Drawing.Size(219, 119);
            this.loginBox.TabIndex = 3;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Login";
            // 
            // login_tb_password
            // 
            this.login_tb_password.Location = new System.Drawing.Point(86, 72);
            this.login_tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.login_tb_password.Name = "login_tb_password";
            this.login_tb_password.PasswordChar = '•';
            this.login_tb_password.Size = new System.Drawing.Size(120, 20);
            this.login_tb_password.TabIndex = 3;
            // 
            // login_tb_username
            // 
            this.login_tb_username.Location = new System.Drawing.Point(86, 31);
            this.login_tb_username.Margin = new System.Windows.Forms.Padding(2);
            this.login_tb_username.Name = "login_tb_username";
            this.login_tb_username.Size = new System.Drawing.Size(120, 20);
            this.login_tb_username.TabIndex = 2;
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.Location = new System.Drawing.Point(26, 76);
            this.contrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(56, 13);
            this.contrasena.TabIndex = 1;
            this.contrasena.Text = "Password:";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Location = new System.Drawing.Point(23, 33);
            this.nombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(58, 13);
            this.nombreUsuario.TabIndex = 0;
            this.nombreUsuario.Text = "Username:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.login_bt_limpiar);
            this.Controls.Add(this.login_bt_ingresar);
            this.Controls.Add(this.loginBox);
            this.Name = "frmLogin";
            this.Text = "RapidCargo";
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_bt_limpiar;
        private System.Windows.Forms.Button login_bt_ingresar;
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.TextBox login_tb_password;
        private System.Windows.Forms.TextBox login_tb_username;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.Label nombreUsuario;
    }
}