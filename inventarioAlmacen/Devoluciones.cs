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
    public partial class Devoluciones : Form
    {
        public Devoluciones()
        {
            InitializeComponent();
            txtBuscar.Text = "Buscar";
            txtBuscar.ForeColor = Color.DimGray;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
          ClaveDevolucionescs claveD = new ClaveDevolucionescs();
          claveD.Show();
        }

        
        Datos datos = new Datos();
        public void llenarCbEm()
        {
            cbEmpleados.DataSource = datos.consulta("Select idEmpleado+'/'+NombreEmpleado as Em From Empleados order by idEmpleado").Tables[0];
            cbEmpleados.DisplayMember = "Empleados";
            cbEmpleados.ValueMember = "Em";
        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {
            this.dataLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            llenarCbEm();
        }
    }
}
