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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
            comprobarExis();

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String cat="";
            if (cbCategorias.Text.Equals("Herramientas y  Otros")||cbCategorias.Text.Equals("Higiene y  Limpieza"))
            {
                agregarPedido ped = new agregarPedido();
                String nEm = "";

                nEm = cbEmpleados.Text;
                string[] emp = nEm.Split('/');

                if (MessageBox.Show("¿Desea hacer nuevo prestamo a: "+ emp [1]+ "?","Nuevo Prestamo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (cbCategorias.Text.Equals("Herramientas y  Otros"))
                    {
                        cat = "Her";
                        ped.cat = cat;
                        ped.idEmp = emp[0];
                        cbCategorias.Enabled = false;
                        lbDev.Visible = true;
                        dtRegreso.Visible = true;
                        btnCancelar.Enabled = true;
                        cbEmpleados.Enabled = false;
                        ped.Show();
                    }
                    else if (cbCategorias.Text.Equals("Higiene y  Limpieza"))
                    {
                        cat = "Hig";
                        cbCategorias.Enabled = false;
                        ped.idEmp = emp[0];
                        ped.cat = cat;
                        btnCancelar.Enabled = true;
                        cbEmpleados.Enabled = false;
                        ped.Show();
                    }

                }
                else
                {

                }
              

            }
            else
            {
                MessageBox.Show("Selecciones primero una Categoria","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



           
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (dataLista.Rows.Count>0)
            {
                new Clave().Show();
            }
            else
            {
                MessageBox.Show("Si productos!!! \n \n Agrege productos a la lista","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditarPedido().Show();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
           
            comprobarExis();
       
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lbDev.Visible = false;
            dtRegreso.Visible = false;
            cbCategorias.Enabled = true;
            this.btnCancelar.Enabled = false;
            cbEmpleados.Enabled = true;
        }


        Datos datos = new Datos();
        public void llenarCbEm()
        {
            cbEmpleados.DataSource = datos.consulta("Select idEmpleado+'/'+NombreEmpleado as Em From Empleados order by idEmpleado").Tables[0];
            cbEmpleados.DisplayMember = "Empleados";
            cbEmpleados.ValueMember = "Em";
        }
        public void consultaLis()
        {
            String q = "select * from listaAr";

            dataLista.DataSource = datos.consulta(q).Tables[0];
        }
        public void comprobarExis()
        {
            String carte, us;



            if (dataLista.Rows.Count > 0)
            {
                carte = dataLista.CurrentRow.Cells[3].Value.ToString();
                us = dataLista.CurrentRow.Cells[5].Value.ToString();
                MessageBox.Show(carte + " \n" + us);


               

                lbDev.Visible = false;
                dtRegreso.Visible = false;
                btnCancelar.Enabled = false;
                llenarCbEm();
                cbCategorias.Enabled = false;
                cbEmpleados.Enabled = false;
            }
            else
            {
                lbDev.Visible = false;
                dtRegreso.Visible = false;
                btnCancelar.Enabled = false;
                llenarCbEm();
                consultaLis();
            }
        }
      
    }
}
