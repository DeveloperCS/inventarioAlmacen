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
            this.btnGenerarReportePrestamos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rdHi = new System.Windows.Forms.RadioButton();
            this.rdHer = new System.Windows.Forms.RadioButton();
            this.grupfiltro = new System.Windows.Forms.GroupBox();
            this.lbProgressMsj = new System.Windows.Forms.Label();
            this.progressMsj = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.comboBoxEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpleados.ForeColor = System.Drawing.Color.Black;
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
            // btnGenerarReportePrestamos
            // 
            this.btnGenerarReportePrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.btnGenerarReportePrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReportePrestamos.FlatAppearance.BorderSize = 0;
            this.btnGenerarReportePrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGenerarReportePrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerarReportePrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReportePrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReportePrestamos.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReportePrestamos.Location = new System.Drawing.Point(768, 455);
            this.btnGenerarReportePrestamos.Name = "btnGenerarReportePrestamos";
            this.btnGenerarReportePrestamos.Size = new System.Drawing.Size(270, 56);
            this.btnGenerarReportePrestamos.TabIndex = 21;
            this.btnGenerarReportePrestamos.Text = "Generar Reporte";
            this.toolTip1.SetToolTip(this.btnGenerarReportePrestamos, "Generar Reporte");
            this.btnGenerarReportePrestamos.UseVisualStyleBackColor = false;
            this.btnGenerarReportePrestamos.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // lbProgressMsj
            // 
            this.lbProgressMsj.AutoSize = true;
            this.lbProgressMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgressMsj.Location = new System.Drawing.Point(174, 455);
            this.lbProgressMsj.Name = "lbProgressMsj";
            this.lbProgressMsj.Size = new System.Drawing.Size(240, 24);
            this.lbProgressMsj.TabIndex = 27;
            this.lbProgressMsj.Text = "Enviando Mensaje.....0%";
            // 
            // progressMsj
            // 
            this.progressMsj.ForeColor = System.Drawing.Color.GreenYellow;
            this.progressMsj.Location = new System.Drawing.Point(35, 488);
            this.progressMsj.Name = "progressMsj";
            this.progressMsj.Size = new System.Drawing.Size(552, 23);
            this.progressMsj.TabIndex = 26;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ReportePretamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 548);
            this.Controls.Add(this.lbProgressMsj);
            this.Controls.Add(this.progressMsj);
            this.Controls.Add(this.grupfiltro);
            this.Controls.Add(this.btnGenerarReportePrestamos);
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
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.DataGridView dataRepEmp;
        private System.Windows.Forms.Button btnGenerarReportePrestamos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grupfiltro;
        private System.Windows.Forms.RadioButton rdHi;
        private System.Windows.Forms.RadioButton rdHer;
        private System.Windows.Forms.Label lbProgressMsj;
        private System.Windows.Forms.ProgressBar progressMsj;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}