namespace inventarioAlmacen
{
    partial class ReporteDevoluciones
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
            this.btnGenerarReportesDevoluciones = new System.Windows.Forms.Button();
            this.dataDevoluciones = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbProgressMsj = new System.Windows.Forms.Label();
            this.progressMsj = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataDevoluciones)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarReportesDevoluciones
            // 
            this.btnGenerarReportesDevoluciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.btnGenerarReportesDevoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReportesDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnGenerarReportesDevoluciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGenerarReportesDevoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerarReportesDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReportesDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReportesDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReportesDevoluciones.Location = new System.Drawing.Point(768, 462);
            this.btnGenerarReportesDevoluciones.Name = "btnGenerarReportesDevoluciones";
            this.btnGenerarReportesDevoluciones.Size = new System.Drawing.Size(270, 56);
            this.btnGenerarReportesDevoluciones.TabIndex = 24;
            this.btnGenerarReportesDevoluciones.Text = "Generar Reporte";
            this.toolTip1.SetToolTip(this.btnGenerarReportesDevoluciones, "Generar Reporte");
            this.btnGenerarReportesDevoluciones.UseVisualStyleBackColor = false;
            this.btnGenerarReportesDevoluciones.Click += new System.EventHandler(this.btnGenerarReportesDevoluciones_Click);
            // 
            // dataDevoluciones
            // 
            this.dataDevoluciones.AllowUserToAddRows = false;
            this.dataDevoluciones.AllowUserToDeleteRows = false;
            this.dataDevoluciones.AllowUserToOrderColumns = true;
            this.dataDevoluciones.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDevoluciones.Location = new System.Drawing.Point(12, 94);
            this.dataDevoluciones.Name = "dataDevoluciones";
            this.dataDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDevoluciones.Size = new System.Drawing.Size(1026, 351);
            this.dataDevoluciones.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel3.Controls.Add(this.comboBoxEmpleados);
            this.panel3.Location = new System.Drawing.Point(12, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 36);
            this.panel3.TabIndex = 22;
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpleados.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(7, 4);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(281, 28);
            this.comboBoxEmpleados.TabIndex = 6;
            this.toolTip1.SetToolTip(this.comboBoxEmpleados, "Empleados");
            this.comboBoxEmpleados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleados_SelectedIndexChanged);
            this.comboBoxEmpleados.Enter += new System.EventHandler(this.comboBoxEmpleados_Enter);
            this.comboBoxEmpleados.Leave += new System.EventHandler(this.comboBoxEmpleados_Leave);
            // 
            // lbProgressMsj
            // 
            this.lbProgressMsj.AutoSize = true;
            this.lbProgressMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgressMsj.Location = new System.Drawing.Point(156, 477);
            this.lbProgressMsj.Name = "lbProgressMsj";
            this.lbProgressMsj.Size = new System.Drawing.Size(240, 24);
            this.lbProgressMsj.TabIndex = 27;
            this.lbProgressMsj.Text = "Enviando Mensaje.....0%";
            // 
            // progressMsj
            // 
            this.progressMsj.ForeColor = System.Drawing.Color.GreenYellow;
            this.progressMsj.Location = new System.Drawing.Point(17, 510);
            this.progressMsj.Name = "progressMsj";
            this.progressMsj.Size = new System.Drawing.Size(552, 23);
            this.progressMsj.TabIndex = 26;
            // 
            // ReporteDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 548);
            this.Controls.Add(this.lbProgressMsj);
            this.Controls.Add(this.progressMsj);
            this.Controls.Add(this.btnGenerarReportesDevoluciones);
            this.Controls.Add(this.dataDevoluciones);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteDevoluciones";
            this.Text = "ReporteDevoluciones";
            this.Load += new System.EventHandler(this.ReporteDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDevoluciones)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReportesDevoluciones;
        private System.Windows.Forms.DataGridView dataDevoluciones;
        internal System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbProgressMsj;
        private System.Windows.Forms.ProgressBar progressMsj;
    }
}