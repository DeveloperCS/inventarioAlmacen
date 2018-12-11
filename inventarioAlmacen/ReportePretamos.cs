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
    public partial class ReportePretamos : Form
    {
        public ReportePretamos()
        {
            InitializeComponent();
            comboBoxEmpleados.Text = "Empleados";
            comboBoxEmpleados.ForeColor = Color.DarkGray;
        }

        private void comboBoxEmpleados_Enter(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.Text == "Empleados")
            {
                comboBoxEmpleados.Text = "";
                comboBoxEmpleados.ForeColor = Color.DimGray;
            }
        }

        private void comboBoxEmpleados_Leave(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.Text == "")
            {
                comboBoxEmpleados.Text = "Empleados";
                comboBoxEmpleados.ForeColor = Color.DarkGray;
            }
        }
        String idbuscar = "";
        private void ReportePretamos_Load(object sender, EventArgs e)
        {
            llenarCbEm();
            idbuscar = comboBoxEmpleados.SelectedValue.ToString();

            consult(separa(idbuscar),"2");
            
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

        public void consult(String id,string cat)
        {
            String qy = "";
            if (cat.Equals("1"))
            {
                this.miFiltro = datos.consulta(qy = "Select * FROM ConsumoE Where [ Clave Empleado] like '" + id + "%'").Tables[0].DefaultView;
            }else if (cat.Equals("2"))
            {
                this.miFiltro = datos.consulta(qy = "Select * FROM PrestadosR Where [Clave Empleado] like '" + id + "%'").Tables[0].DefaultView;
            }
            
            dataRepEmp.DataSource = miFiltro;
        }

        private void rdHi_CheckedChanged(object sender, EventArgs e)
        {
            

            consult(comboBoxEmpleados.SelectedText.ToString(),"2");
          
        }

        private void rdHer_CheckedChanged(object sender, EventArgs e)
        {
            consult(comboBoxEmpleados.SelectedText.ToString(), "1");
        }

        private void comboBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

            idbuscar = comboBoxEmpleados.SelectedValue.ToString();
            if (rdHer.Checked)
            {
                consult(separa(idbuscar), "2");
            }
            else if (rdHi.Checked)
            {
                consult(separa(idbuscar), "1");
            }
           
        }
    }
}
