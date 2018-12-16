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
    public partial class CorreoElectronico : Form
    {
        public CorreoElectronico()
        {
            InitializeComponent();
            txtCorreoDe.Text = "Correo electronico";
            txtCorreoDe.ForeColor = Color.DimGray;
            txtCorreoPara.Text = "Correo electronico";
            txtCorreoPara.ForeColor = Color.DimGray;
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

        private void txtCorreoDe_Enter(object sender, EventArgs e)
        {
            if (txtCorreoDe.Text == "Correo electronico")
            {
                txtCorreoDe.Text = "";
                txtCorreoDe.ForeColor = Color.Black;
            }
        }

        private void txtCorreoDe_Leave(object sender, EventArgs e)
        {
            if (txtCorreoDe.Text == "")
            {
                txtCorreoDe.Text = "Correo electronico";
                txtCorreoDe.ForeColor = Color.DimGray;
            }
        }

        private void txtCorreoPara_Enter(object sender, EventArgs e)
        {
            if (txtCorreoPara.Text == "Correo electronico")
            {
                txtCorreoPara.Text = "";
                txtCorreoPara.ForeColor = Color.Black;
            }
        }

        private void txtCorreoPara_Leave(object sender, EventArgs e)
        {
            if (txtCorreoPara.Text == "")
            {
                txtCorreoPara.Text = "Correo electronico";
                txtCorreoPara.ForeColor = Color.DimGray;
            }
        }
    }
}
