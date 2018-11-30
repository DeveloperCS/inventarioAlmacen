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

            txtNombre.Text = "Nombre del Articulo";
            txtNombre.ForeColor = Color.FromArgb(210, 210, 210);
            //domainUpDownCantidad.Text = "Cantidad";
            //domainUpDownCantidad.ForeColor = Color.FromArgb(210, 210, 210);
            comboBoxCategoria.Text = "Categoria";
            comboBoxCategoria.ForeColor = Color.FromArgb(210, 210, 210);
            comboBoxMedida.Text = "Tipo de Medida";
            comboBoxMedida.ForeColor = Color.FromArgb(210, 210, 210);

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

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

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
            if (rec().Equals(false))
            {
                MessageBox.Show("Falto Completar algún Campo \n Verificalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                if (MessageBox.Show("¿Desea Agregar Producto?", "Agrega", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (comboBoxCategoria.Text.Equals("Higiene y Limpieza"))
                    {
                        qy = "INSERT INTO Articulos values('Ar-0004','" + txtNombre.Text + "','" + comboBoxCategoria.Text + "','" + nmCantidad.Value + "','" + nmCantidad.Value + "','" + comboBoxMedida.Text + "','N/A')";
                        if (datos.insertar(qy) == true)
                        {
                            MessageBox.Show("Articulo Agregado!!");
                            limpiar();
                            //new inventario().consult();
                            this.Close();

                        }
                    }
                    else if (comboBoxCategoria.Text.Equals("Herramientas y Otros"))
                    {
                        qy = "INSERT INTO Articulos values('Ar-0004','" + txtNombre.Text + "','" + comboBoxCategoria.Text + "','" + nmCantidad.Value + "','" + nmCantidad.Value + "','" + comboBoxMedida.Text + "','Bueno')";
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
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            comboBoxCategoria.Text = "";
          //  domainUpDownCantidad.Text = "0";
            comboBoxMedida.Text = "";
        }

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            foco(8);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            foco(7);
        }

        private void comboBoxCategoria_Enter(object sender, EventArgs e)
        {
            foco(6);
        }

        private void comboBoxCategoria_Leave(object sender, EventArgs e)
        {
            foco(5);
        }

        private void domainUpDownCantidad_Enter(object sender, EventArgs e)
        {
            foco(4);
        }

        private void domainUpDownCantidad_Leave(object sender, EventArgs e)
        {
            foco(3);
        }

        private void comboBoxMedida_Enter(object sender, EventArgs e)
        {
            foco(1);
        }

        private void comboBoxMedida_Leave(object sender, EventArgs e)
        {
            foco(2);
        }

        public void foco(int nom)
        {
            switch (nom)
            {
                case 1:
                    if (comboBoxMedida.Text == "Tipo de Medida")
                    {
                        comboBoxMedida.Text = "";
                        comboBoxMedida.ForeColor = Color.DimGray;
                    }
                    break;
                case 2:
                    if (comboBoxMedida.Text == "")
                    {
                        comboBoxMedida.Text = "Tipo de Medida";
                        comboBoxMedida.ForeColor = Color.FromArgb(210, 210, 210);
                    }
                    break;
                case 3:
                   /*if (domainUpDownCantidad.Text == "")
                    {
                        domainUpDownCantidad.Text = "Cantidad";
                        domainUpDownCantidad.ForeColor = Color.FromArgb(210, 210, 210);
                    }*/
                    break;
                case 4:
                   /* if (domainUpDownCantidad.Text == "Cantidad")
                    {
                        domainUpDownCantidad.Text = "";
                        domainUpDownCantidad.ForeColor = Color.DimGray;
                    }*/
                    break;
                case 5:
                    if (comboBoxCategoria.Text == "")
                    {
                        comboBoxCategoria.Text = "Categoria";
                        comboBoxCategoria.ForeColor = Color.FromArgb(210, 210, 210);
                    }
                    break;
                case 6:
                    if (comboBoxCategoria.Text == "Categoria")
                    {
                        comboBoxCategoria.Text = "";
                        comboBoxCategoria.ForeColor = Color.DimGray;
                    }
                    break;
                case 7:
                    if (txtNombre.Text == "")
                    {
                        txtNombre.Text = "Nombre del Articulo";
                        txtNombre.ForeColor = Color.FromArgb(210, 210, 210);
                    }
                    break;
                case 8:
                    if (txtNombre.Text == "Nombre del Articulo")
                    {
                        txtNombre.Text = "";
                        txtNombre.ForeColor = Color.Red;
                    }
                    break;
            }
                
        }
        // agraga letra mayuscula
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }
        //comprobaciones 
        public bool rec()
        {
            bool resT =false;
            if (comboBoxCategoria.Text !="Categoria"&& txtNombre.Text!="Nombre del Articulo"&& comboBoxMedida.Text!="Tipo de Medida"&&nmCantidad.Value!=0)
            {
                
                resT = true;
            }
            else
            {
               
                resT = false;
            }
           
            return resT;
        }
    }
}
