using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventarioAlmacen
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            AbrirFormInPanel(new ReportePretamos());
            PrestamosToolStripMenuItem.BackColor = Color.FromArgb(83, 164, 227);
        }

        //metodo para abrir en panel
        private void AbrirFormInPanel(object formhijo)
        {
            if (this.panelCentral.Controls.Count > 0)
            {
                this.panelCentral.Controls.RemoveAt(0);
            }
            Form fn = formhijo as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(fn);
            this.panelCentral.Tag = fn;
            fn.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ReportePretamos());
            PrestamosToolStripMenuItem.BackColor = Color.FromArgb(83, 164, 227);
            InventarioToolStripMenuItem.BackColor = Color.FromArgb(31, 49, 65);
            devolucionesToolStripMenuItem.BackColor = Color.FromArgb(31, 49, 65);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ReporteInventario());
            InventarioToolStripMenuItem.BackColor = Color.FromArgb(83, 164, 227);
            PrestamosToolStripMenuItem.BackColor = Color.FromArgb(31, 49, 65);
            devolucionesToolStripMenuItem.BackColor = Color.FromArgb(31, 49, 65);
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ReporteDevoluciones());
            devolucionesToolStripMenuItem.BackColor = Color.FromArgb(83, 164, 227);
            InventarioToolStripMenuItem.BackColor = Color.FromArgb(31, 49, 65);
            PrestamosToolStripMenuItem.BackColor = Color.FromArgb(31, 49, 65);
        }
    }
}
