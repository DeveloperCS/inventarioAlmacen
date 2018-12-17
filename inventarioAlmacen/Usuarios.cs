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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarUser().Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditarUser().Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        DataView miFiltro;
        Datos dts = new Datos();
        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.datosTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (rdUs.Checked == true)
            {
                consult();
            }
        }
        public void consult()
        {
            String qy = "";

            this.miFiltro = dts.consulta(qy = "Select * FROM Usuario").Tables[0].DefaultView;
            datosTabla.DataSource = miFiltro;
           
        }
        public void consult1()
        {
            String qy = "";

            this.miFiltro = dts.consulta(qy = "Select * FROM Empleados").Tables[0].DefaultView;
            datosTabla.DataSource = miFiltro;

        }


        private void rdUs_CheckedChanged(object sender, EventArgs e)
        {
            consult();
        }

        private void rdEm_CheckedChanged(object sender, EventArgs e)
        {
            consult1();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida = "";
            string[] pBusqueda = this.txtBuscar.Text.Split(' ');
            foreach (string p in pBusqueda)
            {
                if (salida.Length == 0)
                {
                    if (rdUs.Checked==true)
                    {
                        salida = "(NombreUsuario LIKE '% " + p + "%' OR NombreUsuario LIKE '" + p + "%' )";
                    }
                    else if(rdEm.Checked==true)
                    {
                        salida = "(NombreEmpleado LIKE '% " + p + "%' OR NombreEmpleado LIKE '" + p + "%' )";
                    }
                    
                }
                else
                {
                  
                    if (rdUs.Checked == true)
                    {
                        salida += "AND (NombreUsuario LIKE '% " + p + "%' OR NombreUsuario LIKE '" + p + "%')";
                    }
                    else if (rdEm.Checked == true)
                    {
                        salida += "AND (NombreEmpleado LIKE '% " + p + "%' OR NombreEmpleado LIKE '" + p + "%')";
                    }

                }
            }
            this.miFiltro.RowFilter = salida;
        }
    }
}
