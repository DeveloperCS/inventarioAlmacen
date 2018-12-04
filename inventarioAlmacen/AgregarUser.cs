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
    public partial class AgregarUser : Form
    {
        public AgregarUser()
        {
            InitializeComponent();
        }

        private void AgregarUser_Load(object sender, EventArgs e)
        {

        }

        private void txtName_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {

        }

        private void txtPuesto_Enter(object sender, EventArgs e)
        {

        }

        private void txtPuesto_Leave(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoUser_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoUser_Leave(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {

        }

        private void txtConfirmarContraseña_Enter(object sender, EventArgs e)
        {

        }

        private void txtConfirmarContraseña_Leave(object sender, EventArgs e)
        {

        }

        public void foco(int nom)
        {
            switch (nom)
            {
                case 1:
                    if (txtName.Text == "Nombre de Usuario")
                    {
                        txtName.Text = "";
                        txtName.ForeColor = Color.DimGray;
                    }
                    break;
                case 2:
                    if (txtName.Text == "")
                    {
                        txtName.Text = "Nombre de Usuario";
                        txtName.ForeColor = Color.LightGray;
                    }
                    break;
                case 3:
                    if (txtPuesto.Text == "")
                    {
                        comboBoxCategoria.Text = "Categoria";
                        comboBoxCategoria.ForeColor = Color.LightGray;
                    }
                    break;
                case 4:
                    if (comboBoxCategoria.Text == "Categoria")
                    {
                        comboBoxCategoria.Text = "";
                        comboBoxCategoria.ForeColor = Color.DimGray;
                    }
                    break;
                case 5:
                    if (txtNombre.Text == "")
                    {
                        txtNombre.Text = "Nombre del Articulo";
                        txtNombre.ForeColor = Color.LightGray;
                    }
                    break;
                case 6:
                    if (txtNombre.Text == "Nombre del Articulo")
                    {
                        txtNombre.Text = "";
                        txtNombre.ForeColor = Color.DimGray;
                    }
                    break;

            }
        }
    }
}
