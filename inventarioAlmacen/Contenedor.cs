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
    public partial class Contenedor : Form
    {
        public Contenedor()
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

        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Boton Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //metodo para abrir en panel
        private void AbrirFormInPanel(object formhijo)
        {
            if (this.panelCentral.Controls.Count>0)
            {
                this.panelCentral.Controls.RemoveAt(0);
            }
            Form fn = formhijo as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(fn);
            this.panelCentral.Tag = fn;
            fn.Show();
        }

        

        private void Contenedor_Load(object sender, EventArgs e)
        {
            
            txtTituloBar.Text = "Inicio";
            colorEs.Location = new Point(-3, btnIni.Location.Y);
            btnIni.BackColor = Color.FromArgb(83, 164, 227);


        }

        private void btnIni_Click(object sender, EventArgs e)

        {
            retornarColor();
            txtTituloBar.Text = "Inicio";
            colorEs.Location = new Point(-3, btnIni.Location.Y);
            btnIni.BackColor = Color.FromArgb(83, 164, 227);
            //pictureBoxInicio.BackColor = Color.DodgerBlue;

        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            retornarColor();
            AbrirFormInPanel(new inventario());
            txtTituloBar.Text = "Inventario";

            /*cambiar de posucion la barra de color*/
            colorEs.Location = new Point(-3, btnInv.Location.Y);
            btnInv.BackColor = Color.FromArgb(83, 164, 227);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Prestamos());
            retornarColor();
            txtTituloBar.Text = "Prestamos";
            /*cambiar de posucion la barra de color*/
            colorEs.Location = new Point(-3, btnPrestamos.Location.Y);
            btnPrestamos.BackColor = Color.FromArgb(83, 164, 227);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            retornarColor();
            txtTituloBar.Text = "Item2";
            colorEs.Location = new Point(-3, button1.Location.Y);
            button1.BackColor = Color.FromArgb(83, 164, 227);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            retornarColor();
            txtTituloBar.Text = "Item3";
            colorEs.Location = new Point(-3, button2.Location.Y);
            button2.BackColor = Color.FromArgb(83, 164, 227);
        }

        private void retornarColor()
        {
            btnIni.BackColor = Color.FromArgb(34, 49, 65);
            btnInv.BackColor = Color.FromArgb(34, 49, 65);
            btnPrestamos.BackColor = Color.FromArgb(34, 49, 65);
            button1.BackColor = Color.FromArgb(34, 49, 65);
            button2.BackColor = Color.FromArgb(34, 49, 65);
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
