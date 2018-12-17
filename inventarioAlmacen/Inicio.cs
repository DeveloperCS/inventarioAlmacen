using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using inventarioAlmacen.Funciones;

namespace inventarioAlmacen
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        Form nuevaFrom = new Form();
        private void button1_Click(object sender, EventArgs e)
        {

            // new Prestamos().ShowDialog();
            AbrirFormInPanel(new Prestamos());
            creafroma();

        }
        private void btnGenerarRepor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reportes());
            creafroma();
        }
        private void btnDevolverArt_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Devoluciones());
            creafroma();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Usuarios());
            creafroma();

        }
        public void creafroma()
        {
            nuevaFrom.Text = "Prestamos";
            nuevaFrom.Size = new Size(1050, 650);

            nuevaFrom.StartPosition = FormStartPosition.CenterScreen;
            nuevaFrom.FormBorderStyle = FormBorderStyle.None;
            nuevaFrom.MinimizeBox = false;
            nuevaFrom.MaximizeBox = false;
            nuevaFrom.Load += new EventHandler(nuevaFrom_load);
            nuevaFrom.ShowDialog();
        }
        Panel panelCentral = new Panel();
        Panel barra = new Panel();
        PictureBox pic = new PictureBox();
        private void nuevaFrom_load(object sender, EventArgs e)
        {
            //panel contenedor
            panelCentral.Size = new Size(1050, 560);
            panelCentral.Location = new Point(0, 40);
            panelCentral.Margin = new Padding(3, 3, 3, 3);
            panelCentral.BackColor = Color.FromArgb(239, 239, 239);
            //AbrirFormInPanel(new Prestamos());
            /*
             * locacion 250,0
             * 1050, 70
             * 83, 164, 227
             */
            //barra del form
            barra.Size = new Size(1050, 40);
            barra.Location = new Point(0, 0);
            barra.Margin = new Padding(3, 3, 3, 3);
            barra.BackColor = Color.FromArgb(3, 164, 227);
            barra.MouseDown += new MouseEventHandler(barra1_MouseDown);

            pic.BackColor = Color.Transparent;
            pic.Cursor = Cursors.Hand;
            pic.Size = new Size(25, 25);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Location = new Point(1013, 12);
            pic.Image = Image.FromFile(@"../../img/cerr.png");
            pic.Click += new EventHandler(btnCerrar_Click);

            if (this.nuevaFrom.Controls.Count > 0)
            {
                this.nuevaFrom.Controls.RemoveAt(0);
            }

            nuevaFrom.Controls.Add(barra);
            barra.Controls.Add(pic);
            nuevaFrom.Controls.Add(panelCentral);



        }
        //Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.nuevaFrom.Close();
        }


        //Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void barra1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.nuevaFrom.Handle, 0x112, 0xf012, 0);
        }

        //metodo para abrir en panel
        public void AbrirFormInPanel(object formhijo)
        {
            if (this.panelCentral.Controls.Count > 0)
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
        Datos datos = new Datos();
        string qVis = "", qMem = "";

        private void Inicio_Load(object sender, EventArgs e)
        {
        
            timerCheck.Start();
            timerCheck.Enabled = true;
            timerCheck.Interval = 25;
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            String id = "";
            DataTable dt = new DataTable();
            dt = datos.spID("ContadorEl");
            int contador = 0, tot=0;
            foreach (DataRow row in dt.Rows)
            {
                id = row["c"].ToString();
                if (!id.Equals(""))
                {
                    contador = int.Parse(id);
                    tot +=contador;
                }
                lbHig.Text = contador+"";
            }
            contador = 0;
            dt = datos.spID("ContadorRe");
            foreach (DataRow row in dt.Rows)
            {
                id = row["c"].ToString();
                
                if (!id.Equals(""))
                {
                    contador=int.Parse(id);
                    tot += contador;
                }
                lbHer.Text = contador + "";
            }

            lbT.Text = tot + "";
        }
    }
}
