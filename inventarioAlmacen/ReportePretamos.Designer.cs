namespace inventarioAlmacen
{
    partial class ReportePretamos
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.dataRepEmp = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rdHi = new System.Windows.Forms.RadioButton();
            this.rdHer = new System.Windows.Forms.RadioButton();
            this.grupfiltro = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepEmp)).BeginInit();
            this.grupfiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel3.Controls.Add(this.comboBoxEmpleados);
            this.panel3.Location = new System.Drawing.Point(12, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 36);
            this.panel3.TabIndex = 12;
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxEmpleados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBoxEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpleados.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Items.AddRange(new object[] {
            "Todos los Empleados",
            "Empleado1",
            "Empleado2",
            "Empleado3",
            "Empleado4",
            "Empleado5",
            "Empleado6",
            "EmpleadoN"});
            this.comboBoxEmpleados.Location = new System.Drawing.Point(7, 4);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(281, 28);
            this.comboBoxEmpleados.TabIndex = 6;
            this.toolTip1.SetToolTip(this.comboBoxEmpleados, "Empleados");
            this.comboBoxEmpleados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleados_SelectedIndexChanged);
            this.comboBoxEmpleados.Enter += new System.EventHandler(this.comboBoxEmpleados_Enter);
            this.comboBoxEmpleados.Leave += new System.EventHandler(this.comboBoxEmpleados_Leave);
            // 
            // dataRepEmp
            // 
            this.dataRepEmp.AllowUserToAddRows = false;
            this.dataRepEmp.AllowUserToDeleteRows = false;
            this.dataRepEmp.AllowUserToOrderColumns = true;
            this.dataRepEmp.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataRepEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRepEmp.Location = new System.Drawing.Point(12, 87);
            this.dataRepEmp.Name = "dataRepEmp";
            this.dataRepEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRepEmp.Size = new System.Drawing.Size(1026, 351);
            this.dataRepEmp.TabIndex = 13;
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
            this.btnAgregar.Location = new System.Drawing.Point(768, 455);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(270, 56);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Generar Reporte";
            this.toolTip1.SetToolTip(this.btnAgregar, "Generar Reporte");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rdHi
            // 
            this.rdHi.AutoSize = true;
            this.rdHi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHi.Location = new System.Drawing.Point(190, 22);
            this.rdHi.Name = "rdHi";
            this.rdHi.Size = new System.Drawing.Size(149, 22);
            this.rdHi.TabIndex = 2;
            this.rdHi.Text = "Higiene y Limpieza";
            this.toolTip1.SetToolTip(this.rdHi, "Higiene y Limpieza");
            this.rdHi.UseVisualStyleBackColor = true;
            this.rdHi.CheckedChanged += new System.EventHandler(this.rdHi_CheckedChanged);
            // 
            // rdHer
            // 
            this.rdHer.AutoSize = true;
            this.rdHer.Checked = true;
            this.rdHer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHer.Location = new System.Drawing.Point(16, 22);
            this.rdHer.Name = "rdHer";
            this.rdHer.Size = new System.Drawing.Size(168, 22);
            this.rdHer.TabIndex = 1;
            this.rdHer.TabStop = true;
            this.rdHer.Text = "Herramientas y Otros";
            this.toolTip1.SetToolTip(this.rdHer, "Herramientas y Otros");
            this.rdHer.UseVisualStyleBackColor = true;
            this.rdHer.CheckedChanged += new System.EventHandler(this.rdHer_CheckedChanged);
            // 
            // grupfiltro
            // 
            this.grupfiltro.Controls.Add(this.rdHi);
            this.grupfiltro.Controls.Add(this.rdHer);
            this.grupfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupfiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.grupfiltro.Location = new System.Drawing.Point(335, 12);
            this.grupfiltro.Name = "grupfiltro";
            this.grupfiltro.Size = new System.Drawing.Size(354, 56);
            this.grupfiltro.TabIndex = 22;
            this.grupfiltro.TabStop = false;
            this.grupfiltro.Text = "Filtros";
            // 
            // ReportePretamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 548);
            this.Controls.Add(this.grupfiltro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataRepEmp);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportePretamos";
            this.Text = "ReportePretamos";
            this.Load += new System.EventHandler(this.ReportePretamos_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRepEmp)).EndInit();
            this.grupfiltro.ResumeLayout(false);
            this.grupfiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.DataGridView dataRepEmp;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grupfiltro;
        private System.Windows.Forms.RadioButton rdHi;
        private System.Windows.Forms.RadioButton rdHer;
    }
}