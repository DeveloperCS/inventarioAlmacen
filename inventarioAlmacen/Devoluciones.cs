using inventarioAlmacen.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventarioAlmacen
{
    public partial class Devoluciones : Form
    {
        public Devoluciones()
        {
            InitializeComponent();
            txtBuscar.Text = "Buscar";
            txtBuscar.ForeColor = Color.DimGray;
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "Seleccionar";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            dataLista.Columns.Add(checkColumn);
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

        private void btnDevolver_Click(object sender, EventArgs e)
        {
          ClaveDevolucionescs claveD = new ClaveDevolucionescs();
          claveD.Show();
        }

        
        Datos datos = new Datos();
        DataView miFiltro;
        public void llenarCbEm()
        {
            cbEmpleados.DataSource = datos.consulta("Select idEmpleado+'/'+NombreEmpleado as Em From Empleados order by idEmpleado").Tables[0];
            cbEmpleados.DisplayMember = "Empleados";
            cbEmpleados.ValueMember = "Em";
        }

        String idBuscar = "";
        private void Devoluciones_Load(object sender, EventArgs e)
        {
            this.dataLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            llenarCbEm();

            idBuscar = cbEmpleados.SelectedValue.ToString();
            consult(separa(idBuscar));
            idBuscar = "";
        }

        public string separa(string nC)
        {
            string[] codigoSolo = nC.Split('/');
            return codigoSolo[0];
        }
        public void consult(String id)
        {
            String qy = "";
            
            this.miFiltro = datos.consulta(qy = "Select [Clave Usuario]as[Clave Usuario],[Clave Empleado]as[Clave Empleado],Articulo as Articulo,Cantidad as Cantidad,CONVERT(VARCHAR,[Fecha Salida],103)as [Fecha Salida],CONVERT(VARCHAR,[Fecha Entrada],103)as [Fecha Entrada] FROM PrestadosR Where [Clave Empleado] like '" + id + "%'").Tables[0].DefaultView;

            dataLista.DataSource = miFiltro;
        }

        private void cbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            idBuscar = cbEmpleados.SelectedValue.ToString();
            consult(separa(idBuscar));
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida = "";
            string[] pBusqueda = this.txtBuscar.Text.Split(' ');
            foreach (string p in pBusqueda)
            {
                if (salida.Length == 0)
                {
                    salida = "(Articulo LIKE '% " + p + "%' OR Articulo LIKE '" + p + "%')";
                }
                else
                {
                    salida += "AND (Articulo LIKE '% " + p + "%' OR Articulo LIKE '" + p + "%')";
                }
            }
            this.miFiltro.RowFilter = salida;
        }
    }
}
