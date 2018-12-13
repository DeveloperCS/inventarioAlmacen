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
    public partial class EditarUser : Form
    {
        public EditarUser()
        {
            InitializeComponent();
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

        public void foco(int nom)
        {
            switch (nom)
            {
                case 1:
                    if (txtNombreUser.Text == "Nombre de Usuario")
                    {
                        txtNombreUser.Text = "";
                        txtNombreUser.ForeColor = Color.Black;
                    }
                    break;
                case 2:
                    if (txtNombreUser.Text == "")
                    {
                        txtNombreUser.Text = "Nombre de Usuario";
                        txtNombreUser.ForeColor = Color.DimGray;
                    }
                    break;
                case 3:
                    if (txtPuesto.Text == "Puesto de Usuario")
                    {
                        txtPuesto.Text = "";
                        txtPuesto.ForeColor = Color.Black;
                    }

                    break;
                case 4:
                    if (txtPuesto.Text == "")
                    {
                        txtPuesto.Text = "Puesto de Usuario";
                        txtPuesto.ForeColor = Color.DimGray;
                    }
                    break;
                case 5:
                    if (comboBoxTipoUser.Text == "Tipo de Usuario")
                    {
                        comboBoxTipoUser.Text = "";
                        comboBoxTipoUser.ForeColor = Color.Black;
                    }

                    break;
                case 6:
                    if (comboBoxTipoUser.Text == "")
                    {
                        comboBoxTipoUser.Text = "Tipo de Usuario";
                        comboBoxTipoUser.ForeColor = Color.DimGray;
                    }
                    break;
                case 7:
                    if (txtContraseñaActual.Text == "Contraseña Actual")
                    {
                        txtContraseñaActual.Text = "";
                        txtContraseñaActual.ForeColor = Color.Black;
                    }

                    break;
                case 8:
                    if (txtContraseñaActual.Text == "")
                    {
                        txtContraseñaActual.Text = "Contraseña Actual";
                        txtContraseñaActual.ForeColor = Color.DimGray;
                    }
                    break;
                case 9:
                    if (txtContraseñaNueva.Text == "Contraseña Nueva")
                    {
                        txtContraseñaNueva.Text = "";
                        txtContraseñaNueva.ForeColor = Color.Black;
                    }

                    break;
                case 10:
                    if (txtContraseñaNueva.Text == "")
                    {
                        txtContraseñaNueva.Text = "Contraseña Nueva";
                        txtContraseñaNueva.ForeColor = Color.DimGray;
                    }
                    break;

                case 11:
                    if (txtConfirmarContraseñaNueva.Text == "Confirmar Contraseña")
                    {
                        txtConfirmarContraseñaNueva.Text = "";
                        txtConfirmarContraseñaNueva.ForeColor = Color.Black;
                    }

                    break;
                case 12:
                    if (txtConfirmarContraseñaNueva.Text == "")
                    {
                        txtConfirmarContraseñaNueva.Text = "Confirmar Contraseña";
                        txtConfirmarContraseñaNueva.ForeColor = Color.DimGray;
                    }
                    break;
            }
        }

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

        private void txtContraseñaActual_Enter(object sender, EventArgs e)
        {
            foco(7);
        }

        private void txtContraseñaActual_Leave(object sender, EventArgs e)
        {
            foco(8);
        }

        private void txtContraseñaNueva_Enter(object sender, EventArgs e)
        {
            foco(9);
        }

        private void txtContraseñaNueva_Leave(object sender, EventArgs e)
        {
            foco(10);
        }

        private void txtConfirmarContraseñaNueva_Enter(object sender, EventArgs e)
        {
            foco(11);
        }

        private void txtConfirmarContraseñaNueva_Leave(object sender, EventArgs e)
        {
            foco(12);
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

        private void Usuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
