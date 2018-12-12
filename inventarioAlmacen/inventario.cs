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
            txtBuscar.ForeColor = Color.DarkGray;
            
        }

        DataView miFiltro;
        Datos dts = new Datos();
        private void inventario_Load(object sender, EventArgs e)
        {
            this.datosTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (rdTodo.Checked == true)
            {
                consult();
            }

            if (datosTabla.Rows.Count <= 0)
            {
                MessageBox.Show("No Tienie Registros, \nAñade nuevos Registros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }
        public void consult()
        {
            String qy = "";

            this.miFiltro = dts.consulta(qy = "Select * FROM InventarioArticulo").Tables[0].DefaultView;
            datosTabla.DataSource = miFiltro;
            datosTabla.Columns["Stock Inicial"].DefaultCellStyle.Format = "N2";
            datosTabla.Columns["Stock Inicial"].DefaultCellStyle.NullValue = "0.00";
            datosTabla.Columns["Stock Disponible"].DefaultCellStyle.Format = "N2";
            datosTabla.Columns["Stock Disponible"].DefaultCellStyle.NullValue = "0.00";
        }


        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar ar =new Agregar();

            if (ar.ShowDialog() == DialogResult.OK)
            {
                consult();
            }
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
                txtBuscar.ForeColor = Color.DarkGray;
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
                    salida = "(Articulo LIKE '% " + p + "%' OR Articulo LIKE '" + p + "%' OR Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%' )";
                }
                else
                {
                    salida += "AND (Articulo LIKE '% " + p + "%' OR Articulo LIKE '" + p + "%' OR Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%')";
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
            Editar ed =new Editar();
            String id, nom, cat, tipo, edo;
            int c,c2,cate=0,tipoT=0,est=0;

            id = datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[0].Value.ToString();
            nom = datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[1].Value.ToString();
            cat = datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[2].Value.ToString();
            c = Convert.ToInt32(datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[4].Value.ToString());
            c2 = Convert.ToInt32(datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[3].Value.ToString());
            tipo = datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[5].Value.ToString();
            edo = datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[6].Value.ToString();
            //Higiene y Limpieza
            //Herramientas y Otros
            if (cat.Equals("Higiene y Limpieza")){
                cate = 0;
            }
            else{
                cate = 1;
            }
            /*
             * kg
                g
                L
                ml
                unidad
             */

            switch (tipo)
            {
                case "kg":
                    tipoT = 0;
                    break;
                case "g":
                    tipoT = 1;
                    break;
                case "L":
                    tipoT = 2;
                    break;
                case "ml":
                    tipoT = 3;
                    break;
                case "Unidad":
                    tipoT = 4;
                    break;
            }
            if (edo.Equals("N/A"))
            {
                est = 0;
            }
            else { est = 1; }
            if (c>0)
            {
                if (MessageBox.Show("Aun tiene la cantidiad suficiente\n \n¿Desea agregar mas ?","Atencion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ed.labelID.Text = id;
                    ed.txtNombre.Text = nom;
                    ed.comboBoxCategoria.SelectedIndex =cate;
                   // ed.numCant.Value = c;
                    ed.comboBoxMedida.SelectedIndex = tipoT;
                    ed.comboBoxEstado.SelectedIndex = est;
                    ed.cat = cat;
                    ed.med = tipo;
                    ed.cIni(c2);
                    ed.cAn(c);
                    
                    if (ed.ShowDialog() == DialogResult.OK)
                    {
                        consult();
                    }
                }
            }
            else
            {
                ed.labelID.Text = id;
                ed.txtNombre.Text = nom;
                ed.comboBoxCategoria.SelectedIndex = cate;
               // ed.numCant.Value = c;
                ed.comboBoxMedida.SelectedIndex = tipoT;
                ed.comboBoxEstado.SelectedIndex = est;
                ed.cat = cat;
                ed.med = tipo;
                ed.cIni(c2);
                ed.cAn(c);
                if (ed.ShowDialog() == DialogResult.OK)
                {
                    consult();
                }
            }

            
        }

        private void rdHer_CheckedChanged(object sender, EventArgs e)
        {

            String salida="";
            String p = "Her";
                if (salida.Length == 0)
                {
                    salida = "(Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%' )";
                }
                else
                {
                    salida += "AND (Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%')";
                }
            
            this.miFiltro.RowFilter = salida;
        }

        private void rdHi_CheckedChanged(object sender, EventArgs e)
        {
            String salida = "";
            String p = "Hig";
            if (salida.Length == 0)
            {
                salida = "(Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%' )";
            }
            else
            {
                salida += "AND (Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%')";
            }

            this.miFiltro.RowFilter = salida;
        }

        private void rdTodo_CheckedChanged(object sender, EventArgs e)
        {
            consult();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
