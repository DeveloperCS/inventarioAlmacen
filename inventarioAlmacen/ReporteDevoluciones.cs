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
    public partial class ReporteDevoluciones : Form
    {
        public ReporteDevoluciones()
        {
            InitializeComponent();
            comboBoxEmpleados.Text = "Empleados";
            comboBoxEmpleados.ForeColor = Color.DimGray;
            comboBoxEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxEmpleados_Enter(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.Text != "Empleados")
            {
                comboBoxEmpleados.Text = "";
                comboBoxEmpleados.ForeColor = Color.Black;
            }
        }

        private void comboBoxEmpleados_Leave(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.Text == "")
            {
                comboBoxEmpleados.Text = "Empleados";
                comboBoxEmpleados.ForeColor = Color.DimGray;
            }
           
        }
        DataView miFiltro;
        Datos datos = new Datos();
        public void llenarCbEm()
        {
            comboBoxEmpleados.DataSource = datos.consulta("Select idEmpleado+'/'+NombreEmpleado as Em From Empleados order by idEmpleado").Tables[0];
            comboBoxEmpleados.DisplayMember = "Empleados";
            comboBoxEmpleados.ValueMember = "Em";
        }
        public string separa(string nC)
        {
            string[] codigoSolo = nC.Split('/');
            return codigoSolo[0];
        }
        private void btnGenerarReportesDevoluciones_Click(object sender, EventArgs e)
        {

        }
        String idbuscar = "";
        private void ReporteDevoluciones_Load(object sender, EventArgs e)
        {
            llenarCbEm();
            idbuscar = comboBoxEmpleados.SelectedValue.ToString();

            consult(separa(idbuscar));
        }
        public void consult(String id)
        {
            String qy = "";
           
                this.miFiltro = datos.consulta(qy = "Select * FROM MostrarDevolucion Where [CLave Empleado] like '" + id + "%'").Tables[0].DefaultView;
         

            dataDevoluciones.DataSource = miFiltro;
        }

        private void comboBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            idbuscar = comboBoxEmpleados.SelectedValue.ToString();
            consult(separa(idbuscar));
        }
    }
}
