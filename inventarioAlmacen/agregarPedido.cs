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
    public partial class agregarPedido : Form
    {
        public agregarPedido()
        {
            InitializeComponent();
            txtBuscar.Text = "Buscar";
            txtBuscar.ForeColor = Color.DimGray;
            comboBoxMedida.Text = "Tipo de Medida";
            comboBoxMedida.ForeColor = Color.DimGray;
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

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new Prestamos().cbCategorias.Enabled = true;
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

        private void comboBoxMedida_Enter(object sender, EventArgs e)
        {
            if (comboBoxMedida.Text == "Tipo de Medida")
            {
                comboBoxMedida.Text = "";
                comboBoxMedida.ForeColor = Color.Black;
            }
        }

        private void comboBoxMedida_Leave(object sender, EventArgs e)
        {
            if (comboBoxMedida.Text == "")
            {
                comboBoxMedida.Text = "Tipo de Medida";
                comboBoxMedida.ForeColor = Color.DimGray;
            }
        }

        public String cat;
        public void consult()
        {
            String qy = "";

            this.miFiltro = dts.consulta(qy = "Select Folio,Articulo,Categoria,Medida FROM InventarioArticulo Where Categoria like '" + cat + "%'").Tables[0].DefaultView;
            datosTabla.DataSource = miFiltro;


            if (cat.Equals("Her"))
            {
                //comboBoxMedida.Enabled = false;
                // comboBoxMedida.SelectedIndex = 4;
                String val = "";
                if (datosTabla.Rows.Count > 0)
                {
                    val = datosTabla.CurrentRow.Cells[3].Value.ToString();
                    compruebaMedida(val, this.comboBoxMedida);
                }
            }

        }

        DataView miFiltro;
        Datos dts = new Datos();
        private void agregarPedido_Load(object sender, EventArgs e)
        {

            this.datosTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            consult();
            String val = "";
            if (datosTabla.Rows.Count > 0)
            {
                val = datosTabla.CurrentRow.Cells[3].Value.ToString();
                compruebaMedida(val,this.comboBoxMedida);
            }

        }

        private void rdHer_CheckedChanged(object sender, EventArgs e)
        {
            String salida = "";
            String p = "Her";
            if (salida.Length == 0)
            {
                salida = "(Articulo LIKE '%" + p + "%' OR Articulo LIKE '" + p + "%' )";
            }
            else
            {
                salida += "AND (Articulo LIKE '%" + p + "%' OR Articulo LIKE '" + p + "%')";
            }

            this.miFiltro.RowFilter = salida;
        }

        private void rdHi_CheckedChanged(object sender, EventArgs e)
        {
            String salida = "";
            String p = "Hig";
            if (salida.Length == 0)
            {
                salida = "(Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%' )";
            }
            else
            {
                salida += "AND (Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%')";
            }

            this.miFiltro.RowFilter = salida;
        }

        private void rdTodo_CheckedChanged(object sender, EventArgs e)
        {
            consult();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            String salida = "";

            if (salida.Length == 0)
            {
                salida = "(Articulo LIKE '%" + txtBuscar.Text + "%' OR Articulo LIKE '" + txtBuscar.Text + "%' )";
            }
            else
            {
                salida += "AND (Articulo LIKE '%" + txtBuscar.Text
                    + "%' OR Articulo LIKE '" + txtBuscar.Text + "%')";
            }

            this.miFiltro.RowFilter = salida;
        }

        private String F, Ar, Cate, CantT;
        private int cant = 0;
        public String idEmp = "";

        private void datosTabla_SelectionChanged(object sender, EventArgs e)
        {
            String val = "";
            if (datosTabla.Rows.Count > 0)
            {
                val = datosTabla.CurrentRow.Cells[3].Value.ToString();
                compruebaMedida(val, this.comboBoxMedida);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

          
            float cantF = (float)(nmCantidad.Value);
            F = datosTabla.CurrentRow.Cells[0].Value.ToString();
            Ar = datosTabla.CurrentRow.Cells[1].Value.ToString();
            Cate = datosTabla.CurrentRow.Cells[2].Value.ToString();
            CantT = Convert.ToString(cantF) + " " + comboBoxMedida.Text;
            if (cantF > 0.00)
            {
                if (comboBoxMedida.Text == "Tipo de Medida")
                {
                    MessageBox.Show("Seleccione en un tipo de Medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Detalles del producto a Agregar: \n -Nombre:" + Ar + " \n -Cantidad:" + CantT, "Agregar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
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
                                float cantidadDefinitiva = 0;
                                cantidadDefinitiva = float.Parse(cantidadSola[0]) + cantF;

                                if (comprobarExis(F, cantidadDefinitiva) == true)
                                {
                                    String q = "UPDATE listaArPrestamos SET cantidad='" + Convert.ToString(CantT) + " " + comboBoxMedida.Text + "' WHERE folio='" + F + "'";
                                    if (dts.update(q) == true)
                                    {
                                        MessageBox.Show("Artitculo agregado");
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No Cuentas con suficientes articulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else if (con <= 0)
                            {
                                if (comprobarExis(F, cantF) == true)
                                {
                                    String q = "INSERT INTO listaArPrestamos Values('" + F + "','" + Ar + "','" + Cate + "','" + CantT + "','" + idEmp + "' ); ";
                                    if (dts.insertar(q) == true)
                                    {
                                        MessageBox.Show("Artitculo agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "Error");
                        }
                    }
                    else
                    {

                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccion Uno o Más Articulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool comprobarExis(String f, float cantDef)
        {

            string q1 = "select CantidadAlmacen as c from Articulos WHERE idArticulo='" + f + "' ";
            DataSet dtSet = new DataSet();
            DataTable tabla = new DataTable();
            dtSet = dts.consulta(q1);
            tabla = dtSet.Tables[0];
            string claIngr = "";
            float con = 0;
            Boolean res = false;
            foreach (DataRow row in tabla.Rows)
            {
                claIngr = row["c"].ToString();
                con = float.Parse(claIngr);
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

        /// <summary>
        /// Metodo para comprobar que tipo de medida es originalmente el articulo 
        /// y asi poder prestar solo los tipos de medida.
        /// </summary>
        /// <param name="val">La Celda donde se encuentra el tipo de medida</param>
        /// <param name="combo">nombre del comboBox</param>
        public void compruebaMedida(String val,ComboBox combo)
        {
            /*
             * kg g  L ml Unidad
             */
            if (val.Equals("Unidad"))
            {
                combo.Items.Clear();
                combo.Items.Add("Unidad");
            }
            if (val.Equals("kg") || val.Equals("g"))
            {
                combo.Items.Clear();
                combo.Items.Add("kg");
                combo.Items.Add("g");
            }
            if (val.Equals("L") || val.Equals("ml"))
            {
                combo.Items.Clear();
                combo.Items.Add("L");
                combo.Items.Add("ml");
            }


        }




    }
}
