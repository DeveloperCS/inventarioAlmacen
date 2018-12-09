namespace inventarioAlmacen
{
    partial class AgregarUser
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboBoxTipoUser = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bar = new System.Windows.Forms.Panel();
            this.Usuarios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.bar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(132, 376);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(223, 35);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // comboBoxTipoUser
            // 
            this.comboBoxTipoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxTipoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoUser.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxTipoUser.FormattingEnabled = true;
            this.comboBoxTipoUser.Items.AddRange(new object[] {
            "Higiene y Limpieza",
            "Herramientas y Otros"});
            this.comboBoxTipoUser.Location = new System.Drawing.Point(7, 4);
            this.comboBoxTipoUser.Name = "comboBoxTipoUser";
            this.comboBoxTipoUser.Size = new System.Drawing.Size(281, 28);
            this.comboBoxTipoUser.TabIndex = 6;
            this.comboBoxTipoUser.Enter += new System.EventHandler(this.comboBoxTipoUser_Enter);
            this.comboBoxTipoUser.Leave += new System.EventHandler(this.comboBoxTipoUser_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel3.Controls.Add(this.comboBoxTipoUser);
            this.panel3.Location = new System.Drawing.Point(24, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 36);
            this.panel3.TabIndex = 11;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Panel2.Controls.Add(this.txtNombreUser);
            this.Panel2.Location = new System.Drawing.Point(24, 35);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(295, 36);
            this.Panel2.TabIndex = 10;
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtNombreUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUser.Location = new System.Drawing.Point(9, 8);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(279, 19);
            this.txtNombreUser.TabIndex = 0;
            this.txtNombreUser.Enter += new System.EventHandler(this.txtNombreUser_Enter);
            this.txtNombreUser.Leave += new System.EventHandler(this.txtNombreUser_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.Panel2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 290);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::inventarioAlmacen.Resource1.cerr;
            this.btnCerrar.Location = new System.Drawing.Point(332, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::inventarioAlmacen.Resource1.minimazar;
            this.btnMinimizar.Location = new System.Drawing.Point(303, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 16;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(12, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 35);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.bar.Controls.Add(this.btnCerrar);
            this.bar.Controls.Add(this.btnMinimizar);
            this.bar.Controls.Add(this.Usuarios);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(367, 45);
            this.bar.TabIndex = 17;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            // 
            // Usuarios
            // 
            this.Usuarios.AutoSize = true;
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            this.Usuarios.Location = new System.Drawing.Point(123, 9);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(116, 29);
            this.Usuarios.TabIndex = 2;
            this.Usuarios.Text = "Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.bar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 430);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel4.Controls.Add(this.txtPuesto);
            this.panel4.Location = new System.Drawing.Point(24, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 36);
            this.panel4.TabIndex = 11;
            // 
            // txtPuesto
            // 
            this.txtPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(9, 8);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(279, 19);
            this.txtPuesto.TabIndex = 0;
            this.txtPuesto.Enter += new System.EventHandler(this.txtPuesto_Enter);
            this.txtPuesto.Leave += new System.EventHandler(this.txtPuesto_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel5.Controls.Add(this.txtContraseña);
            this.panel5.Location = new System.Drawing.Point(24, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 36);
            this.panel5.TabIndex = 11;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(9, 8);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(279, 19);
            this.txtContraseña.TabIndex = 0;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel6.Controls.Add(this.txtConfirmarContraseña);
            this.panel6.Location = new System.Drawing.Point(24, 226);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 36);
            this.panel6.TabIndex = 11;
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(9, 8);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(279, 19);
            this.txtConfirmarContraseña.TabIndex = 0;
            this.txtConfirmarContraseña.Enter += new System.EventHandler(this.txtConfirmarContraseña_Enter);
            this.txtConfirmarContraseña.Leave += new System.EventHandler(this.txtConfirmarContraseña_Leave);
            // 
            // AgregarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 430);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUser";
            this.panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox comboBoxTipoUser;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPuesto;
        internal System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtContraseña;
        internal System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Label Usuarios;
        private System.Windows.Forms.Panel panel1;
    }
}