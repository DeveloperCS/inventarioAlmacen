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
    public partial class AgregarUser : Form
    {
        public AgregarUser()
        {
            InitializeComponent();
            txtNombreUser.Text = "Nombre de Usuario";
            txtNombreUser.ForeColor = Color.LightGray;
            txtPuesto.Text = "Puesto de Usuario";
            txtPuesto.ForeColor = Color.LightGray;
            comboBoxTipoUser.Text = "Tipo de Usuario";
            comboBoxTipoUser.ForeColor = Color.LightGray;
            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.LightGray;
            txtConfirmarContraseña.Text = "Confirmar Contraseña";
            txtConfirmarContraseña.ForeColor = Color.LightGray;

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

        private void txtNombreUser_Enter(object sender, EventArgs e)
        {
            foco(1);
        }

        private void txtNombreUser_Leave(object sender, EventArgs e)
        {
            foco(2);
        }

        private void txtPuesto_Enter(object sender, EventArgs e)
        {
            foco(3);
        }

        private void txtPuesto_Leave(object sender, EventArgs e)
        {
            foco(4);
        }

        private void comboBoxTipoUser_Enter(object sender, EventArgs e)
        {
            foco(5);
        }

        private void comboBoxTipoUser_Leave(object sender, EventArgs e)
        {
            foco(6);
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            foco(7);
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            foco(8);
        }

        private void txtConfirmarContraseña_Enter(object sender, EventArgs e)
        {
            foco(9);
        }

        private void txtConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            foco(0);
        }

        public void foco(int nom)
        {
            switch (nom)
            {
                case 1:
                    if (txtNombreUser.Text == "Nombre de Usuario")
                    {
                        txtNombreUser.Text = "";
                        txtNombreUser.ForeColor = Color.DimGray;
                    }
                    break;
                case 2:
                    if (txtNombreUser.Text == "")
                    {
                        txtNombreUser.Text = "Nombre de Usuario";
                        txtNombreUser.ForeColor = Color.LightGray;
                    }
                    break;
                case 3:
                    if (txtPuesto.Text == "Puesto de Usuario")
                    {
                        txtPuesto.Text = "";
                        txtPuesto.ForeColor = Color.DimGray;
                    }

                    break;
                case 4:
                    if (txtPuesto.Text == "")
                    {
                        txtPuesto.Text = "Puesto de Usuario";
                        txtPuesto.ForeColor = Color.LightGray;
                    }
                    break;
                case 5:
                    if (comboBoxTipoUser.Text == "Tipo de Usuario")
                    {
                        comboBoxTipoUser.Text = "";
                        comboBoxTipoUser.ForeColor = Color.DimGray;
                    }

                    break;
                case 6:
                    if (comboBoxTipoUser.Text == "")
                    {
                        comboBoxTipoUser.Text = "Tipo de Usuario";
                        comboBoxTipoUser.ForeColor = Color.LightGray;
                    }
                    break;
                case 7:
                    if (txtContraseña.Text == "Contraseña")
                    {
                        txtContraseña.Text = "";
                        txtContraseña.ForeColor = Color.DimGray;
                    }

                    break;
                case 8:
                    if (txtContraseña.Text == "")
                    {
                        txtContraseña.Text = "Contraseña";
                        txtContraseña.ForeColor = Color.LightGray;
                    }
                    break;
                case 9:
                    if (txtConfirmarContraseña.Text == "Confirmar Contraseña")
                    {
                        txtConfirmarContraseña.Text = "";
                        txtConfirmarContraseña.ForeColor = Color.DimGray;
                    }

                    break;
                case 0:
                    if (txtConfirmarContraseña.Text == "")
                    {
                        txtConfirmarContraseña.Text = "Confirmar Contraseña";
                        txtConfirmarContraseña.ForeColor = Color.LightGray;
                    }
                    break;


            }
        }

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
