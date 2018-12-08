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
            comboBoxMedida.Text = "Tipo de Medida";
            comboBoxMedida.ForeColor = Color.LightGray;

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
                comboBoxMedida.ForeColor = Color.DimGray;
            }
        }

        private void comboBoxMedida_Leave(object sender, EventArgs e)
        {
            if (comboBoxMedida.Text == "")
            {
                comboBoxMedida.Text = "Tipo de Medida";
                comboBoxMedida.ForeColor = Color.LightGray;
            }
        }

        public void consult()
        {
            String qy = "";

            this.miFiltro = dts.consulta(qy = "Select Folio,Articulo,Categoria FROM InventarioArticulo WHERE Categoria LIKE '%" + tipo + "%' OR Categoria LIKE '" + tipo + "%'  ").Tables[0].DefaultView;

            //datosTabla.DataSource = miFiltro; LoadGrid
           this.datosTabla.DataSource = LoadGrid();
        }

        DataView miFiltro;
        Datos dts = new Datos();
        public String tipo;
        
        private void agregarPedido_Load(object sender, EventArgs e)
        {
            /* if (rdTodo.Checked == true)
             {
                 consult();
             }*/
            consult();
            /*
            String salida = "";

            if (salida.Length == 0)
            {
                salida = "(Categoria LIKE '%" + tipo + "%' OR Categoria LIKE '" + tipo + "%' )";
            }
            else
            {
                salida += "AND (Categoria LIKE '%" + tipo + "%' OR Categoria LIKE '" + tipo + "%')";
            }

            this.miFiltro.RowFilter = salida;*/

        }
     
        private void rdHer_CheckedChanged(object sender, EventArgs e)
        {
            String salida = "";
            String p = "Her";
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

        private void txtBusc_KeyUp(object sender, KeyEventArgs e)
        {
            string salida = "";
            string[] pBusqueda = this.txtBusc.Text.Split(' ');
            foreach (string p in pBusqueda)
            {
                if (salida.Length == 0)
                {
                    salida = "(Articulo LIKE '% " + p + "%' OR Articulo LIKE '" + p + "%' OR Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%' )";
                }
                else
                {
                    salida += "AND (Articulo LIKE '% " + p + "%' OR Articulo LIKE '" + p + "%' OR Categoria LIKE '%" + p + "%' OR Categoria LIKE '" + p + "%')";
                }
            }
            this.miFiltro.RowFilter = salida;
        }

        public bool consultaStock(String id)
        {
            DataSet dataC1 = new DataSet();
            string qqAc = "select [Stock Disponible] as C from InventarioArticulo WHERE Folio ='"+id+"'";
            dataC1 = dts.consulta(qqAc);
            DataTable dt2 = dataC1.Tables[0];
            string exten = "";
            foreach (DataRow row in dt2.Rows)
            {
                exten = row["C"].ToString();
            }
            int cant = 0;
            cant = Convert.ToInt32(exten);
          
            if (cant>=nmCantidad.Value)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //ps.Caller = this;

            string folio, articulo, categoria;

            /*folio = datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[0].Value.ToString();
            articulo = datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[1].Value.ToString();*/
            //categoria = datosTabla.Rows[datosTabla.CurrentRow.Index].Cells[2].Value.ToString();

            /*if(consultaStock(folio)==true)
            {*/
                DataGridViewRow rowT = this.datosTabla.SelectedRows[0] as DataGridViewRow;


            //AddItem2 pa = this.Owner as AddItem2;
            AddItem2 pa = this.MdiParent.MdiChildren.LastOrDefault(f=>f.GetType() == typeof(Prestamos)) as AddItem2;
            //AddItem2 MiInterface = this.Parent as AddItem2;
            //pa.AddNewItem(rowT);
            pa.AddNewItem(rowT);
                //this.Close();
      /*      }
            else
            {
                ///no hay articulos en stock
                MessageBox.Show("No cuenta con la cantidad suficiente en Alamacen","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
    */
            //this.Close();

        }
        public DataTable LoadGrid()
        {
            DataTable table = new DataTable();

            table.Columns.Add("item");
            table.Columns.Add("Desc");

            DataRow row1 = table.NewRow();
            row1["item"] = "item1";
            row1["Desc"] = "Desc1";
            table.Rows.Add(row1);

            DataRow row2 = table.NewRow();
            row2["item"] = "item2";
            row2["Desc"] = "Desc2";
            table.Rows.Add(row2);

            DataRow row3 = table.NewRow();
            row3["item"] = "item3";
            row3["Desc"] = "Desc3";
            table.Rows.Add(row3);

            return table;
        }


    }
}
