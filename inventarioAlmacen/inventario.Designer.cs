namespace inventarioAlmacen
{
    partial class inventario
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
            this.datosTabla = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.higieneYLimpiezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasYOtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdAlmacenDataSet = new inventarioAlmacen.bdAlmacenDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datosTabla)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdAlmacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datosTabla
            // 
            this.datosTabla.AllowUserToAddRows = false;
            this.datosTabla.BackgroundColor = System.Drawing.SystemColors.Info;
            this.datosTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosTabla.Location = new System.Drawing.Point(12, 116);
            this.datosTabla.Name = "datosTabla";
            this.datosTabla.Size = new System.Drawing.Size(1026, 399);
            this.datosTabla.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.Location = new System.Drawing.Point(690, 75);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(317, 35);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.Tag = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.higieneYLimpiezaToolStripMenuItem,
            this.herramientasYOtrosToolStripMenuItem});
            this.productoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoToolStripMenuItem.Image = global::inventarioAlmacen.Resource1.if_plus_1646001;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.productoToolStripMenuItem.Text = "Agregar";
            this.productoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // higieneYLimpiezaToolStripMenuItem
            // 
            this.higieneYLimpiezaToolStripMenuItem.Name = "higieneYLimpiezaToolStripMenuItem";
            this.higieneYLimpiezaToolStripMenuItem.Size = new System.Drawing.Size(273, 30);
            this.higieneYLimpiezaToolStripMenuItem.Text = "Higiene y Limpieza";
            this.higieneYLimpiezaToolStripMenuItem.Click += new System.EventHandler(this.higieneYLimpiezaToolStripMenuItem_Click);
            // 
            // herramientasYOtrosToolStripMenuItem
            // 
            this.herramientasYOtrosToolStripMenuItem.Name = "herramientasYOtrosToolStripMenuItem";
            this.herramientasYOtrosToolStripMenuItem.Size = new System.Drawing.Size(273, 30);
            this.herramientasYOtrosToolStripMenuItem.Text = "Herramientas y Otros";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.Image = global::inventarioAlmacen.Resource1.if_error_1646012;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.Image = global::inventarioAlmacen.Resource1.icons8_sincronizar_64;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bdAlmacenDataSet
            // 
            this.bdAlmacenDataSet.DataSetName = "bdAlmacenDataSet";
            this.bdAlmacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::inventarioAlmacen.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(1003, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.datosTabla);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "inventario";
            this.Text = "inventario";
            this.Load += new System.EventHandler(this.inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosTabla)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdAlmacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datosTabla;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private bdAlmacenDataSet bdAlmacenDataSet;
        private System.Windows.Forms.ToolStripMenuItem higieneYLimpiezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasYOtrosToolStripMenuItem;
    }
}