namespace inventarioAlmacen
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.bar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBoxMedida = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.domainUpDownCantidad = new System.Windows.Forms.DomainUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.bar.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.bar.Controls.Add(this.btnCerrar);
            this.bar.Controls.Add(this.btnMinimizar);
            this.bar.Controls.Add(this.label1);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(367, 45);
            this.bar.TabIndex = 22;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editar Articulo";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Panel2.Controls.Add(this.txtNombre);
            this.Panel2.Location = new System.Drawing.Point(25, 64);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(295, 36);
            this.Panel2.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(9, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 19);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.Panel2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 334);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Producto";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(22, 33);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(66, 20);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "labelID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.comboBoxEstado);
            this.panel1.Location = new System.Drawing.Point(25, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 36);
            this.panel1.TabIndex = 12;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "N/A",
            "Bueno",
            "Regular",
            "Dañado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(7, 4);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(281, 28);
            this.comboBoxEstado.TabIndex = 6;
            this.comboBoxEstado.Text = "Estado";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel5.Controls.Add(this.comboBoxMedida);
            this.panel5.Location = new System.Drawing.Point(25, 220);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 36);
            this.panel5.TabIndex = 11;
            // 
            // comboBoxMedida
            // 
            this.comboBoxMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMedida.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxMedida.FormattingEnabled = true;
            this.comboBoxMedida.Items.AddRange(new object[] {
            "kg",
            "g",
            "L",
            "l",
            "unidad"});
            this.comboBoxMedida.Location = new System.Drawing.Point(7, 4);
            this.comboBoxMedida.Name = "comboBoxMedida";
            this.comboBoxMedida.Size = new System.Drawing.Size(281, 28);
            this.comboBoxMedida.TabIndex = 7;
            this.comboBoxMedida.Text = "Tipo de medida";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel4.Controls.Add(this.domainUpDownCantidad);
            this.panel4.Location = new System.Drawing.Point(25, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 36);
            this.panel4.TabIndex = 12;
            // 
            // domainUpDownCantidad
            // 
            this.domainUpDownCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.domainUpDownCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domainUpDownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownCantidad.Items.Add("1");
            this.domainUpDownCantidad.Items.Add("2");
            this.domainUpDownCantidad.Items.Add("3");
            this.domainUpDownCantidad.Items.Add("4");
            this.domainUpDownCantidad.Items.Add("5");
            this.domainUpDownCantidad.Items.Add("6");
            this.domainUpDownCantidad.Items.Add("7");
            this.domainUpDownCantidad.Items.Add("8");
            this.domainUpDownCantidad.Items.Add("9");
            this.domainUpDownCantidad.Items.Add("10");
            this.domainUpDownCantidad.Items.Add("11");
            this.domainUpDownCantidad.Items.Add("12");
            this.domainUpDownCantidad.Items.Add("13");
            this.domainUpDownCantidad.Items.Add("14");
            this.domainUpDownCantidad.Items.Add("15");
            this.domainUpDownCantidad.Items.Add("16");
            this.domainUpDownCantidad.Items.Add("17");
            this.domainUpDownCantidad.Items.Add("18");
            this.domainUpDownCantidad.Items.Add("19");
            this.domainUpDownCantidad.Items.Add("20");
            this.domainUpDownCantidad.Items.Add("21");
            this.domainUpDownCantidad.Items.Add("22");
            this.domainUpDownCantidad.Items.Add("23");
            this.domainUpDownCantidad.Items.Add("24");
            this.domainUpDownCantidad.Items.Add("25");
            this.domainUpDownCantidad.Items.Add("26");
            this.domainUpDownCantidad.Items.Add("27");
            this.domainUpDownCantidad.Items.Add("28");
            this.domainUpDownCantidad.Items.Add("29");
            this.domainUpDownCantidad.Items.Add("30");
            this.domainUpDownCantidad.Items.Add("31");
            this.domainUpDownCantidad.Items.Add("32");
            this.domainUpDownCantidad.Items.Add("34");
            this.domainUpDownCantidad.Items.Add("35");
            this.domainUpDownCantidad.Items.Add("36");
            this.domainUpDownCantidad.Items.Add("37");
            this.domainUpDownCantidad.Items.Add("38");
            this.domainUpDownCantidad.Items.Add("39");
            this.domainUpDownCantidad.Items.Add("40");
            this.domainUpDownCantidad.Items.Add("41");
            this.domainUpDownCantidad.Items.Add("42");
            this.domainUpDownCantidad.Items.Add("43");
            this.domainUpDownCantidad.Items.Add("45");
            this.domainUpDownCantidad.Items.Add("46");
            this.domainUpDownCantidad.Items.Add("47");
            this.domainUpDownCantidad.Items.Add("48");
            this.domainUpDownCantidad.Items.Add("49");
            this.domainUpDownCantidad.Items.Add("50");
            this.domainUpDownCantidad.Location = new System.Drawing.Point(8, 7);
            this.domainUpDownCantidad.Name = "domainUpDownCantidad";
            this.domainUpDownCantidad.Size = new System.Drawing.Size(280, 22);
            this.domainUpDownCantidad.TabIndex = 4;
            this.domainUpDownCantidad.Text = "Cantidad";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel3.Controls.Add(this.comboBoxCategoria);
            this.panel3.Location = new System.Drawing.Point(25, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 36);
            this.panel3.TabIndex = 11;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Higiene y Limpieza",
            "Herramientas y Otros"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(7, 4);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(281, 28);
            this.comboBoxCategoria.TabIndex = 6;
            this.comboBoxCategoria.Text = "Categoria";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(132, 422);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(223, 35);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(12, 422);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 35);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::inventarioAlmacen.Resource1.cerrarGris;
            this.btnCerrar.Location = new System.Drawing.Point(336, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::inventarioAlmacen.Resource1.minimazar;
            this.btnMinimizar.Location = new System.Drawing.Point(305, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 16;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 473);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBoxMedida;
        internal System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DomainUpDown domainUpDownCantidad;
        internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelID;
        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}