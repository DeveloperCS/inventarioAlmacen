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
        List<string> lstArchivos = new List<string>();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCorreoDe.Equals("")|| txtCorreoDe.Equals(null)&&txtCorreoPara.Equals("")|| txtCorreoPara.Equals(null))
            {
                MessageBox.Show("Campos requeridos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desa Mandar el correo con estos datos?","Enviar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {

                    enviaCorreo oMail = new enviaCorreo(txtCorreoDe.Text.Trim(), txtCorreoPara.Text.Trim(), "Reporte Nuevo", "Nuevo Reporte CHECKSTORE", lstArchivos);
                    //y enviamos
                    if (oMail.enviaMail())
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("no se envio el mail: " + oMail.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.Close();
                    }

                    
                }
            }
        }
        public void parametrosCorreo(String list)
        {
            lstArchivos.Add(list);
        }
    }
}
