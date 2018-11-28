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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void btnInv_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new inventario());
            txtTituloBar.Text = "Inventario";
            colorEs.BackColor = Color.Aqua;
            /*cambiar de posucion la barra de color*/
            colorEs.Location = new Point(-3, btnInv.Location.Y);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            /*cambiar de posucion la barra de color*/
            colorEs.Location = new Point(-3,btnPrestamos.Location.Y);
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {
            txtTituloBar.Text = "Inicio";
            colorEs.Location = new Point(-3, btnIni.Location.Y);
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            txtTituloBar.Text = "Inicio";
            colorEs.Location = new Point(-3, btnIni.Location.Y);
        }
    }
}
