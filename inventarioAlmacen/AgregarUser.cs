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
    public partial class AgregarUser : Form
    {
        public AgregarUser()
        {
            InitializeComponent();
            txtNombreUser.Text = "Nombre de Usuario";
            txtNombreUser.ForeColor = Color.DimGray;
            txtPuesto.Text = "Puesto de Usuario";
            txtPuesto.ForeColor = Color.DimGray;
            comboBoxTipoUser.Text = "Tipo de Usuario";
            comboBoxTipoUser.ForeColor = Color.DimGray;
            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.DimGray;
            txtConfirmarContraseña.Text = "Confirmar Contraseña";
            txtConfirmarContraseña.ForeColor = Color.DimGray;

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
                    if (txtContraseña.Text == "Contraseña")
                    {
                        txtContraseña.Text = "";
                        txtContraseña.ForeColor = Color.Black;
                    }

                    break;
                case 8:
                    if (txtContraseña.Text == "")
                    {
                        txtContraseña.Text = "Contraseña";
                        txtContraseña.ForeColor = Color.DimGray;
                    }
                    break;
                case 9:
                    if (txtConfirmarContraseña.Text == "Confirmar Contraseña")
                    {
                        txtConfirmarContraseña.Text = "";
                        txtConfirmarContraseña.ForeColor = Color.Black;
                    }

                    break;
                case 0:
                    if (txtConfirmarContraseña.Text == "")
                    {
                        txtConfirmarContraseña.Text = "Confirmar Contraseña";
                        txtConfirmarContraseña.ForeColor = Color.DimGray;
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

        public bool valida(String a)
        {

            if (txtNombreUser.Text == "Nombre de Usuario" || txtPuesto.Text == "Puesto de Usuario"|| comboBoxTipoUser.Text == "Tipo de Usuario"||txtContraseña.Text == "Contraseña"|| txtConfirmarContraseña.Text == "Confirmar Contraseña")
            {
                return false;
            }
            else
            {
                return true;
            }
   
           
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
        Datos datos = new Datos();
        public string tipo = "";
        private void AgregarUser_Load(object sender, EventArgs e)
        {
            String id = "";
            DataTable dt = new DataTable();
            if (tipo.Equals("Em-"))
            {
                dt = datos.spID("AGIDE");
            }
            else if (tipo.Equals("Us-"))
            {
                dt = datos.spID("AGIDU");
            }
            
            foreach (DataRow row in dt.Rows)
            {
                id = row[1].ToString();
                if (id.Equals(""))
                {
                    id = "0001";
                }
            }
            lbID.Text = tipo + id;
        }
    }
}
