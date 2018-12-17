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

        CheckBox che = null;
        bool seleccionaT = false;
        public void selectTodo()
        {
            che = new CheckBox();
            che.Size = new Size(15, 15);
            che.Location = new Point(10,10);
            this.dataLista.Controls.Add(che);
        }
        private void selectTodo1(CheckBox ch)
        {
            seleccionaT = true;
            foreach (DataGridViewRow dr in dataLista.Rows)
            {
                ((DataGridViewCheckBoxCell)dr.Cells["X"]).Value = ch.Checked;
                
            }
            dataLista.RefreshEdit();
            seleccionaT = false;
        }
        private void che_MouseClick(object sender,MouseEventArgs e)
        {
            selectTodo1((CheckBox)sender);
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
        String emp1 = "";
        string idAr, nomAr, descrip, cant;
        String idNuevo = "";
        int contador = 0;
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dataLista.Rows.Count > 0)
            {
                for (int i = 0; i < dataLista.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dataLista.Rows[i].Cells["X"].Value) == true)
                    {
                        emp1 = dataLista.Rows[i].Cells[4].Value.ToString();
                        MessageBox.Show(emp1);
                        ClaveDevolucionescs claveD = new ClaveDevolucionescs();
                        claveD.id = emp1;
                        if (claveD.ShowDialog() == DialogResult.OK)
                        {
                            foreach (DataGridViewRow row in dataLista.Rows)
                            {
                                if (Convert.ToBoolean(dataLista.Rows[row.Index].Cells["X"].Value) == true)
                                {
                                    String iDev = dataLista[1, row.Index].Value.ToString();
                                    String iRec = dataLista[1, row.Index].Value.ToString();
                                    String iUs = dataLista[2, row.Index].Value.ToString();
                                    String idAr = dataLista[3, row.Index].Value.ToString();
                                    String iEmp = dataLista[4, row.Index].Value.ToString();
                                    String nmAr=  dataLista[5, row.Index].Value.ToString();
                                    String cAr = dataLista[6, row.Index].Value.ToString();
                                   /* DateTime fI = Convert.ToDateTime(dataLista[7, row.Index].Value.ToString());
                                    DateTime fF = Convert.ToDateTime(dataLista[8, row.Index].Value.ToString());*/
                                    String desc = dataLista[9, row.Index].Value.ToString();

                                 
                                    String qIn = "INSERT INTO Devolucion VALUES('"+ iDev + "','"+ iRec + "','"+ iUs + "','"+ idAr + "','"+ iEmp + "','"+ nmAr + "','"+ cAr + "','12/10/2018','12/12/2018','"+ desc + "');";
                                    if (datos.insertar(qIn) == true)
                                    {
                                        qIn = "UPDATE Articulos SET CantidadAlmacen = CantidadAlmacen + '" + cAr + "' WHERE IdArticulo= '" + idAr + "'";
                                        if (datos.update(qIn) == true)
                                        {
                                            qIn = "DELETE FROM Recibos WHERE IdRecibo="+iRec;
                                            if (datos.eliminar(qIn)==true)
                                            {
                                                // contador--;
                                                if (contador == 0)
                                                {

                                                }

                                                MessageBox.Show("Delete herr" + contador);
                                            }
                                           
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("noinsert herr");
                                    }
                                }
                            }
                           
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("No seleccionaste algun articulo por devolver", "Devolver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("No tiene articulos por devolver", "Devolver",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
          
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


            selectTodo();
            che.MouseClick += new MouseEventHandler(che_MouseClick);
        }

        public string separa(string nC)
        {
            string[] codigoSolo = nC.Split('/');
            return codigoSolo[0];
        }
        public void consult(String id)
        {
            String qy = "";

            // this.miFiltro = datos.consulta(qy = "Select [Clave Usuario]as[Clave Usuario],[Clave Empleado]as[Clave Empleado],Articulo as Articulo,Cantidad as Cantidad,CONVERT(VARCHAR,[Fecha Salida],103)as [Fecha Salida],CONVERT(VARCHAR,[Fecha Entrada],103)as [Fecha Entrada] FROM PrestadosR Where [Clave Empleado] like '" + id + "%'").Tables[0].DefaultView;
            this.miFiltro = datos.consulta(qy = "Select * FROM PrestadosR Where [Clave Empleado] like '" + id + "%'").Tables[0].DefaultView;

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
/*
        public string idDev()
        {
            String id1 = "";
            String id = "";
            DataTable dt = new DataTable();

            dt = datos.spID("AGIDE");
           
            foreach (DataRow row in dt.Rows)
            {
                id1 = row[0].ToString() + row[1].ToString();

            }
            
            id = id1;
            return id;
        }
        */


    }
}
