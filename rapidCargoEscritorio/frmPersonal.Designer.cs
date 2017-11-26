namespace rapidCargoEscritorio
{
    partial class frmPersonal
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
            this.personal_dgv_listarPersonal = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personal_bt_nuevoPersonal = new System.Windows.Forms.Button();
            this.personal_bt_buscarPersonal = new System.Windows.Forms.Button();
            this.personal_tb_buscarPersonal = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personal_dgv_listarPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.personal_dgv_listarPersonal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 330);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE PERSONAL";
            // 
            // personal_dgv_listarPersonal
            // 
            this.personal_dgv_listarPersonal.AllowUserToAddRows = false;
            this.personal_dgv_listarPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personal_dgv_listarPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombres,
            this.Apellidos,
            this.Telefono,
            this.NombreUsuario,
            this.Contrasena,
            this.TipoPersonal});
            this.personal_dgv_listarPersonal.Location = new System.Drawing.Point(19, 37);
            this.personal_dgv_listarPersonal.Name = "personal_dgv_listarPersonal";
            this.personal_dgv_listarPersonal.RowHeadersVisible = false;
            this.personal_dgv_listarPersonal.RowTemplate.Height = 24;
            this.personal_dgv_listarPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personal_dgv_listarPersonal.Size = new System.Drawing.Size(784, 276);
            this.personal_dgv_listarPersonal.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 140;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 140;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 80;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "NombreUsuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Width = 200;
            // 
            // Contrasena
            // 
            this.Contrasena.HeaderText = "Contrasena";
            this.Contrasena.Name = "Contrasena";
            // 
            // TipoPersonal
            // 
            this.TipoPersonal.HeaderText = "TipoPersonal";
            this.TipoPersonal.Name = "TipoPersonal";
            this.TipoPersonal.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "PERSONAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personal_bt_nuevoPersonal);
            this.groupBox1.Controls.Add(this.personal_bt_buscarPersonal);
            this.groupBox1.Controls.Add(this.personal_tb_buscarPersonal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GESTIONAR PERSONAL";
            // 
            // personal_bt_nuevoPersonal
            // 
            this.personal_bt_nuevoPersonal.Location = new System.Drawing.Point(653, 26);
            this.personal_bt_nuevoPersonal.Name = "personal_bt_nuevoPersonal";
            this.personal_bt_nuevoPersonal.Size = new System.Drawing.Size(150, 56);
            this.personal_bt_nuevoPersonal.TabIndex = 2;
            this.personal_bt_nuevoPersonal.Text = "NUEVO PERSONAL";
            this.personal_bt_nuevoPersonal.UseVisualStyleBackColor = true;
            // 
            // personal_bt_buscarPersonal
            // 
            this.personal_bt_buscarPersonal.Location = new System.Drawing.Point(479, 26);
            this.personal_bt_buscarPersonal.Name = "personal_bt_buscarPersonal";
            this.personal_bt_buscarPersonal.Size = new System.Drawing.Size(161, 56);
            this.personal_bt_buscarPersonal.TabIndex = 3;
            this.personal_bt_buscarPersonal.Text = "BUSCAR PERSONAL";
            this.personal_bt_buscarPersonal.UseVisualStyleBackColor = true;
            // 
            // personal_tb_buscarPersonal
            // 
            this.personal_tb_buscarPersonal.Location = new System.Drawing.Point(19, 41);
            this.personal_tb_buscarPersonal.Name = "personal_tb_buscarPersonal";
            this.personal_tb_buscarPersonal.Size = new System.Drawing.Size(438, 26);
            this.personal_tb_buscarPersonal.TabIndex = 4;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPersonal";
            this.Text = "Personal";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personal_dgv_listarPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView personal_dgv_listarPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button personal_bt_nuevoPersonal;
        private System.Windows.Forms.Button personal_bt_buscarPersonal;
        private System.Windows.Forms.TextBox personal_tb_buscarPersonal;
    }
}