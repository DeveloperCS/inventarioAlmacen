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
    public partial class EditarPedido : Form
    {
        public EditarPedido()
        {
            InitializeComponent();
            comboBoxMedida.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void comboBoxMedida_Enter(object sender, EventArgs e)
        {
            if (comboBoxMedida.Text == "Tipo de Medida")
            {
                comboBoxMedida.Text = "";
                comboBoxMedida.ForeColor = Color.DimGray;
            }
        }

        private void comboBoxMedida_Leave(object sender, EventArgs e)
        {
            if (comboBoxMedida.Text == "")
            {
                comboBoxMedida.Text = "Tipo de Medida";
                comboBoxMedida.ForeColor = Color.DarkGray;
            }
        }

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public String id, cantida, medida,F;
        Datos dts = new Datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Actualizar?","Actualizar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string q1 = "select folio as f, cantidad as c from listaArPrestamos ";
                DataSet dtSet = new DataSet();
                DataTable tabla = new DataTable();
                dtSet = dts.consulta(q1);
                tabla = dtSet.Tables[0];
                string clav = "", claIngr = "";
                int con = 0;
                string[] cantidadSola = null;
                foreach (DataRow row in tabla.Rows)
                {
                    clav = row["f"].ToString();

                    if (F.Equals(clav))
                    {
                        con++;
                        claIngr = row["c"].ToString();
                        cantidadSola = claIngr.Split(' ');
                    }
                }
                if (con > 0)
                {
                    int cant = Convert.ToInt32(numCant.Value);
                    int cantidadDefinitiva = 0;
                    cantidadDefinitiva = cant; //int.Parse(cantidadSola[0])+cant;
                 
                    if (comprobarExis(F, cantidadDefinitiva) == true)
                    {
                        String q = "UPDATE listaArPrestamos SET cantidad='" + Convert.ToString(numCant.Value) + " " + comboBoxMedida.Text + "' WHERE Id='" + lbId.Text + "'";
                        if (dts.update(q) == true)
                        {
                            MessageBox.Show("Artitculo Editado");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Cuentas con suficientes articulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

               
            }
        }

        private void EditarPedido_Load(object sender, EventArgs e)
        {
            lbId.Text = id;
            numCant.Value = int.Parse(cantida);

            int con = 0;
            foreach (object o in comboBoxMedida.Items)
            {

                if (o.Equals(medida))
                {
                    comboBoxMedida.SelectedIndex = con;
                    break;
                }
                con++;
            }
        }
        public bool comprobarExis(String f, int cantDef)
        {

            string q1 = "select CantidadAlmacen as c from Articulos WHERE IdArticulo='" + f + "' ";
            DataSet dtSet = new DataSet();
            DataTable tabla = new DataTable();
            dtSet = dts.consulta(q1);
            tabla = dtSet.Tables[0];
            string claIngr = "";
            int con = 0;
            Boolean res = false;
            foreach (DataRow row in tabla.Rows)
            {
                claIngr = row["c"].ToString();
                con = int.Parse(claIngr);
                if (con >= cantDef)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }

            return res;
        }
    }
}
