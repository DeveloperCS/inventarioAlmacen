using inventarioAlmacen.Funciones;
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
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
            txtBuscar.Text = "Buscar";
            txtBuscar.ForeColor = Color.LightGray;
        }

        DataView miFiltro;
        private void inventario_Load(object sender, EventArgs e)
        {
           
            Datos dts = new Datos();
            String qy = "";

            this.miFiltro = dts.consulta(qy = "Select * FROM Articulos").Tables[0].DefaultView;

            datosTabla.DataSource = miFiltro;

        }


        private void higieneYLimpiezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Agregar().ShowDialog();
            
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }
        //buscador
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.LightGray;
            }

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida = "";
            string[] pBusqueda = this.txtBuscar.Text.Split(' ');
            foreach (string p in pBusqueda)
            {
                if (salida.Length == 0)
                {
                    salida = "(NombreArticulo LIKE '% " + p + "%' OR NombreArticulo LIKE '" + p + "%' OR Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%' )";
                }
                else
                {
                    salida += "AND (NombreArticulo LIKE '% " + p + "%' OR NombreArticulo LIKE '" + p + "%' OR Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%')";
                }
            }
            this.miFiltro.RowFilter = salida;
        }
    }
}
