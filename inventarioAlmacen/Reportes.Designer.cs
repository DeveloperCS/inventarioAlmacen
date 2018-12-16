namespace inventarioAlmacen
{
    partial class Reportes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.PrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrestamosToolStripMenuItem,
            this.InventarioToolStripMenuItem,
            this.devolucionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 32);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelCentral
            // 
            this.panelCentral.Location = new System.Drawing.Point(0, 32);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1050, 548);
            this.panelCentral.TabIndex = 11;
            // 
            // PrestamosToolStripMenuItem
            // 
            this.PrestamosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrestamosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.PrestamosToolStripMenuItem.Image = global::inventarioAlmacen.Resource1.icons8_tomar_prestado_un_libro_48;
            this.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem";
            this.PrestamosToolStripMenuItem.Size = new System.Drawing.Size(126, 28);
            this.PrestamosToolStripMenuItem.Text = "Prestamos";
            this.PrestamosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrestamosToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // InventarioToolStripMenuItem
            // 
            this.InventarioToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.InventarioToolStripMenuItem.Image = global::inventarioAlmacen.Resource1.icons48;
            this.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem";
            this.InventarioToolStripMenuItem.Size = new System.Drawing.Size(119, 28);
            this.InventarioToolStripMenuItem.Text = "Inventario";
            this.InventarioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InventarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.devolucionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.devolucionesToolStripMenuItem.Image = global::inventarioAlmacen.Resource1.DevolverPro;
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(153, 28);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            this.devolucionesToolStripMenuItem.Click += new System.EventHandler(this.devolucionesToolStripMenuItem_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 580);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InventarioToolStripMenuItem;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
    }
}