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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.DimGray;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnMinimizar.Visible = false;
            
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

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DimGray;
            }
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
        Datos datos = new Datos();
        String qy = "";
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Agregar Producto?","Agrega",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (comboBoxCategoria.Text.Equals("Higiene y Limpieza"))
                {
                    qy = "INSERT INTO Articulos values('Ar-0004','"+txtNombre.Text+"','"+comboBoxCategoria.Text+"',10,10,'"+comboBoxMedida.Text+"','N/A')";
                    if (datos.insertar(qy)==true)
                    {
                        MessageBox.Show("Articulo Agregado!!");
                        limpiar();
                        //new inventario().consult();
                        this.Close();
                       
                    }
                }
                else if(comboBoxCategoria.Text.Equals("Herramientas y Otros"))
                {
                    qy = "INSERT INTO Articulos values('Ar-0004','" + txtNombre.Text + "','" + comboBoxCategoria.Text + "',10,10,'" + comboBoxMedida.Text + "','Bueno')";
                    if (datos.insertar(qy) == true)
                    {
                        MessageBox.Show("Articulo Agregado!!");
                        limpiar();
                       // new inventario().consult();
                        this.Close();
                       
                    }
                }

            }
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            comboBoxCategoria.Text = "";
            domainUpDownCantidad.Text = "0";
            comboBoxMedida.Text = "";
        }

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
