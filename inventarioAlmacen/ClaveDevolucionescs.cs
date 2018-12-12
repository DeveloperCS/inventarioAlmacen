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
    public partial class ClaveDevolucionescs : Form
    {
        public ClaveDevolucionescs()
        {
            InitializeComponent();
            txtClave.Text = "clav";
            txtClave.ForeColor = Color.DarkGray;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "clav")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.DimGray;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "clav";
                txtClave.ForeColor = Color.DarkGray;
            }
        }
    }
}
