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
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            Datos dts = new Datos();
            String qy = "";
            datosTabla.DataSource = dts.consulta(qy="Select * FROM Articulos").Tables[0];

        }
    }
}
