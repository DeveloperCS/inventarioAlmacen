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
    }
}
