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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        int ci = 0;
        public  void cIni(int c1)
        {
            ci = c1;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void foco(int nom)
        {
            switch (nom)
            {
                case 1:

                    if (txtNombre.Text == "Nombre del Articulo")
                    {
                        txtNombre.Text = "";
                        txtNombre.ForeColor = Color.DimGray;
                    }

                    break;
                case 2:
                    if (txtNombre.Text == "")
                    {
                        txtNombre.Text = "Nombre del Articulo";
                        txtNombre.ForeColor = Color.DarkGray;
                    }


                    break;
                case 3:
                    if (comboBoxCategoria.Text == "Categoria")
                    {
                        comboBoxCategoria.Text = "";
                        comboBoxCategoria.ForeColor = Color.DimGray;
                    }

                    break;
                case 4:
                    if (comboBoxCategoria.Text == "")
                    {
                        comboBoxCategoria.Text = "Categoria";
                        comboBoxCategoria.ForeColor = Color.DarkGray;
                    }
                    break;
                case 5:
                    if (comboBoxMedida.Text == "Tipo de Medida")
                    {
                        comboBoxMedida.Text = "";
                        comboBoxMedida.ForeColor = Color.DimGray;
                    }
                    break;
                case 6:
                    if (comboBoxMedida.Text == "")
                    {
                        comboBoxMedida.Text = "Tipo de Medida";
                        comboBoxMedida.ForeColor = Color.DarkGray;
                    }
                    break;
                case 7:
                    if (comboBoxEstado.Text == "Estado")
                    {
                        comboBoxEstado.Text = "";
                        comboBoxEstado.ForeColor = Color.DimGray;
                    }
                    break;
                case 8:
                    if (comboBoxEstado.Text == "")
                    {
                        comboBoxEstado.Text = "Estado";
                        comboBoxEstado.ForeColor = Color.DarkGray;
                    }
                    break;

            }

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            foco(1);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            foco(2);
        }

        private void comboBoxCategoria_Enter(object sender, EventArgs e)
        {
            foco(3);
        }

        private void comboBoxCategoria_Leave(object sender, EventArgs e)
        {
            foco(4);
        }

        private void comboBoxMedida_Enter(object sender, EventArgs e)
        {
            foco(5);
        }

        private void comboBoxMedida_Leave(object sender, EventArgs e)
        {
            foco(6);
        }

        private void comboBoxEstado_Enter(object sender, EventArgs e)
        {
            foco(7);
        }

        private void comboBoxEstado_Leave(object sender, EventArgs e)
        {
            foco(8);
        }

        Datos d = new Datos();
        String q;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Editar los Registros?","Editar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                /*
	                [IdArticulo] 
                    [NombreArticulo
                    [Categoria]
                    [CantidadInicial
                    [CantidadAlmacen] 
	                [TipoMedida] 
	                [Estado
                 * 
                 */
                
                if (ci>0)
                {
                    ci = ci +Convert.ToInt32( numCant.Value);
                    q = "UPDATE Articulos Set NombreArticulo='" + txtNombre.Text + "',Categoria='" + comboBoxCategoria.Text + "',CantidadInicial='"+ci+ "',CantidadAlmacen='" + ci + "',TipoMedida='"+comboBoxMedida.Text+"',Estado='"+comboBoxEstado.Text+"'  WHERE IdArticulo='" + labelID.Text + "' ";
                    //MessageBox.Show(""+ci);
                }
                else if(ci==0)
                {
                    q = "UPDATE Articulos Set NombreArticulo='" + txtNombre.Text + "',Categoria='" + comboBoxCategoria.Text + "',CantidadInicial='"+numCant.Value+"',CantidadAlmacen='"+numCant.Value+ "',TipoMedida='" + comboBoxMedida.Text + "',Estado='" + comboBoxEstado.Text + "'  WHERE IdArticulo='" + labelID.Text + "' ";
                }


                if (d.update(q)==true)
                {
                    MessageBox.Show("Datos Actualizados!!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    ci = 0;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
               
            }
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
