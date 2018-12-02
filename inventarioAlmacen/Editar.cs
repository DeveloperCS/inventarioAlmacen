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
                    this.Close();
                }
               
            }
            
        }
    }
}
