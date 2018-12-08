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
    public partial class Prestamos : Form , AddItem2
    {
        public Prestamos()
        {
            InitializeComponent();
        }
        string tip = "";
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            agregarPedido gr = new agregarPedido();

            if (tip.Equals("Herramientas y Otros")||tip.Equals("Higiene y Limpieza"))
            {
                if (tip.Equals("Herramientas y Otros"))
                {
                    gr.tipo = "Her";
                }
                else if (tip.Equals("Higiene y Limpieza"))
                {
                    gr.tipo = "Hig";
                }

               
                gr.Show(this);
              
            }
            else
            {
                MessageBox.Show("Seleccione Un Tipo de Articulo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            new Clave().Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditarPedido().Show();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           tip = cbTipo.Text;
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            /*dataGLista.Columns.Add("Folio", "Folio");
            dataGLista.Columns.Add("Articulo", "Articulo");
            dataGLista.Columns.Add("Categoria", "Categoria");
            dataGLista.Columns.Add("Cantidad", "Cantidad");/*/
        }

        public void AddNewItem(DataGridViewRow row)
        {
            string item = row.Cells["item"].Value.ToString();
            string desc = row.Cells["Desc"].Value.ToString();

            this.dataGLista.Rows.Add(new [] { item, desc });
        }
       

    }

    interface AddItem2
    {
        void AddNewItem(DataGridViewRow row);
    }
}
