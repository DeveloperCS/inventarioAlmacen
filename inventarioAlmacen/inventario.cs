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
            txtBuscar.ForeColor = Color.FromArgb(210, 210, 210);
        }

        DataView miFiltro;
        Datos dts = new Datos();
        private void inventario_Load(object sender, EventArgs e)
        {


            consult();

            if (datosTabla.Rows.Count<=0)
            {
                MessageBox.Show("No Tienie Registros, \nAñade nuevos Registros","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                
            }

        }
        public void consult()
        {
            String qy = "";

            this.miFiltro = dts.consulta(qy = "Select * FROM Articulos").Tables[0].DefaultView;
            datosTabla.DataSource = miFiltro;
        }


        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Agregar().Show();
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
                txtBuscar.ForeColor = Color.FromArgb(210, 210, 210);
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
        string qy = "";
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?","Eliminar", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string valor = "";

                valor = Funciones.funciones.obString(datosTabla,0);

                //MessageBox.Show(valor);
                string qy1 = "";
                qy1 = "DELETE FROM Articulos WHERE IdArticulo='"+valor+"'";

                if(dts.eliminar(qy1) == true)
                {
                    MessageBox.Show("Exito");
                    consult();
                }
                                

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Editar().Show();
        }
    }
}
