using inventarioAlmacen.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace inventarioAlmacen
{
    public partial class agregarPedido : Form
    {
        public agregarPedido()
        {
            InitializeComponent();
            txtBuscar.Text = "Buscar";
            txtBuscar.ForeColor = Color.DarkGray;
            comboBoxMedida.Text = "Tipo de Medida";
            comboBoxMedida.ForeColor = Color.DarkGray;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        //Redondear esquinas
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        //Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBoxMedida_Enter(object sender, EventArgs e)
        {
            if (comboBoxMedida.Text == "Tipo de Medida")
            {
                comboBoxMedida.Text = "";
                comboBoxMedida.ForeColor = Color.DimGray;
            }
        }

        private void comboBoxMedida_Leave(object sender, EventArgs e)
        {
            if (comboBoxMedida.Text == "")
            {
                comboBoxMedida.Text = "Tipo de Medida";
                comboBoxMedida.ForeColor = Color.DarkGray;
            }
        }

        public void consult()
        {
            String qy = "";

            this.miFiltro = dts.consulta(qy = "Select * FROM InventarioArticulo").Tables[0].DefaultView;
            datosTabla.DataSource = miFiltro;
        }

        DataView miFiltro;
        Datos dts = new Datos();
        private void agregarPedido_Load(object sender, EventArgs e)
        {
            if (rdTodo.Checked == true)
            {
                consult();
            }

        }

        private void rdHer_CheckedChanged(object sender, EventArgs e)
        {
            String salida = "";
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

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.DarkGray;
            }
        }
    }
}
