namespace inventarioAlmacen
{
    partial class ReporteInventario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHi = new System.Windows.Forms.RadioButton();
            this.rdHer = new System.Windows.Forms.RadioButton();
            this.rdTodo = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHi);
            this.groupBox1.Controls.Add(this.rdHer);
            this.groupBox1.Controls.Add(this.rdTodo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 62);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdHi
            // 
            this.rdHi.AutoSize = true;
            this.rdHi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHi.Location = new System.Drawing.Point(287, 26);
            this.rdHi.Name = "rdHi";
            this.rdHi.Size = new System.Drawing.Size(149, 22);
            this.rdHi.TabIndex = 2;
            this.rdHi.Text = "Higiene y Limpieza";
            this.toolTip1.SetToolTip(this.rdHi, "Higiene y Limpieza");
            this.rdHi.UseVisualStyleBackColor = true;
            // 
            // rdHer
            // 
            this.rdHer.AutoSize = true;
            this.rdHer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHer.Location = new System.Drawing.Point(104, 27);
            this.rdHer.Name = "rdHer";
            this.rdHer.Size = new System.Drawing.Size(168, 22);
            this.rdHer.TabIndex = 1;
            this.rdHer.Text = "Herramientas y Otros";
            this.toolTip1.SetToolTip(this.rdHer, "Herramientas y Otros");
            this.rdHer.UseVisualStyleBackColor = true;
            // 
            // rdTodo
            // 
            this.rdTodo.AutoSize = true;
            this.rdTodo.Checked = true;
            this.rdTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTodo.Location = new System.Drawing.Point(19, 27);
            this.rdTodo.Name = "rdTodo";
            this.rdTodo.Size = new System.Drawing.Size(61, 22);
            this.rdTodo.TabIndex = 0;
            this.rdTodo.TabStop = true;
            this.rdTodo.Text = "Todo";
            this.toolTip1.SetToolTip(this.rdTodo, "Todo");
            this.rdTodo.UseVisualStyleBackColor = true;
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
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Generar Reporte";
            this.toolTip1.SetToolTip(this.btnAgregar, "Generar Reporte");
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1026, 351);
            this.dataGridView1.TabIndex = 22;
            // 
            // ReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 568);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteInventario";
            this.Text = "ReporteInventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHi;
        private System.Windows.Forms.RadioButton rdHer;
        private System.Windows.Forms.RadioButton rdTodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}