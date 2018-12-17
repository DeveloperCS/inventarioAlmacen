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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
            cbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            
            comprobarExis();
            llenarCbEm();

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String cat = "";
            if (cbCategorias.Text.Equals("Herramientas y Otros") || cbCategorias.Text.Equals("Higiene y Limpieza"))
            {
                agregarPedido ped = new agregarPedido();
                String nEm = "";

                nEm = cbEmpleados.Text;
                string[] emp = nEm.Split('/');

                if (MessageBox.Show("¿Desea hacer nuevo prestamo a: " + emp[1] + "?", "Nuevo Prestamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cbCategorias.Text.Equals("Herramientas y Otros"))
                    {
                        cat = "Her";
                        ped.cat = cat;
                        ped.idEmp = emp[0];
                        cbCategorias.Enabled = false;
                        lbDev.Visible = true;
                        dtRegreso.Visible = true;
                        dtRegreso.MinDate = DateTime.Today;
                        btnCancelar.Enabled = true;
                        cbEmpleados.Enabled = false;
                        
                        if (ped.ShowDialog() == DialogResult.OK)
                        {
                            consultaLis();
                            comprobarExis();
                        }
                    }
                    else if (cbCategorias.Text.Equals("Higiene y Limpieza"))
                    {
                        cat = "Hig";
                        cbCategorias.Enabled = false;
                        ped.idEmp = emp[0];
                        ped.cat = cat;
                        btnCancelar.Enabled = true;
                        cbEmpleados.Enabled = false;
                        if (ped.ShowDialog() == DialogResult.OK)
                        {
                            
                            consultaLis();
                            comprobarExis();
                        }
                    }

                }
                else
                {

                }


            }
            else
            {
                MessageBox.Show("Selecciones primero una Categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataLista.Rows.Count>0)
            {
                if (MessageBox.Show("¿Desea Eliminar este articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string valor = "";

                    valor = Funciones.funciones.obString(dataLista, 0);

                    
                    string qy1 = "";
                    qy1 = "DELETE FROM listaArPrestamos WHERE Id='" + valor + "'";

                    if (datos.eliminar(qy1) == true)
                    {
                        MessageBox.Show("Se Elimino con Exito","Eliminado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        consultaLis();
                    }
                }
            }
            else
            {
                MessageBox.Show("No Tienes Articulos agregados","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            Clave fClave =new Clave();
            String idNuevo = "";
            if (dataLista.Rows.Count > 0)
            {
               
                fClave.id = emp1;
                string idAr,nomAr,descrip,cant;
                
                if(fClave.ShowDialog()==DialogResult.OK)
                {
                    String qIn = "";
                    int contador = 0,t=0;
                    contador = dataLista.Rows.Count;
                    if (carte.Equals("Herramientas y Otros"))
                    {
                        foreach (DataGridViewRow row in dataLista.Rows)
                        {
                            
                           t= int.Parse(dataLista[0, row.Index].Value.ToString());
                            idAr = dataLista[1, row.Index].Value.ToString();
                            nomAr = dataLista[2, row.Index].Value.ToString();
                            String nC = "";
                            nC = dataLista[4, row.Index].Value.ToString();
                            string[] cantidadSola = nC.Split(' ');

                            //descrip = "Cantida:" + nC + "Categoria:" + dataLista[3, row.Index].Value.ToString();
                            descrip = "Cantida:" + nC ;

                            idNuevo = idPrestamo();
                            //idNuevo = "Ele";
                            qIn = "INSERT INTO Recibos VALUES('"+idNuevo+ "','Us-0001','"+idAr+"','"+emp1+"','"+nomAr+"','"+cantidadSola[0]+"',GETDATE(),'"+ dtRegreso.Value.ToString("yyyy/MM/dd") + "','"+descrip+"');";
                            if (datos.insertar(qIn) == true)
                            {
                                qIn = "UPDATE Articulos SET CantidadAlmacen = CantidadAlmacen - '" + cantidadSola[0] + "' WHERE idArticulo= '" + idAr + "'";
                                if (datos.update(qIn) == true)
                                {
                                    contador--;
                                    if (contador == 0)
                                    {
                                        lbDev.Visible = false;
                                        dtRegreso.Visible = false;
                                        cbCategorias.Enabled = true;
                                        cbEmpleados.Enabled = true;
                                        this.btnCancelar.Enabled = false;
                                        
                                        eliminarLista();
                                    }

                                    MessageBox.Show("Se inserto Correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al insertar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            
                        }
                        


                    }
                    else if (carte.Equals("Higiene y Limpieza"))
                    {

                        foreach (DataGridViewRow row in dataLista.Rows)
                        {
                            t = int.Parse(dataLista[0, row.Index].Value.ToString());
                            idAr = dataLista[1, row.Index].Value.ToString();
                                nomAr = dataLista[2, row.Index].Value.ToString();
                                    String nC = "";
                                    nC = dataLista[4, row.Index].Value.ToString();
                                    string[] cantidadSola = nC.Split(' ');
                                    cant = dataLista[4, row.Index].Value.ToString();
                           
                            idNuevo = idPrestamo();
                            string qIn1 = "INSERT INTO Electronico VALUES('"+idNuevo+ "','Us-0001','" + idAr + "','" + emp1 + "','" + nomAr + "','"+float.Parse(cantidadSola[0])+"', GETDATE() );";
                     
                            if (datos.insertar(qIn1) == true)
                            {
                                    qIn1 = "UPDATE Articulos SET CantidadAlmacen = CantidadAlmacen - '" + float.Parse(cantidadSola[0]) + "' WHERE IdArticulo= '"+idAr+"'";
                                    if (datos.update(qIn1)==true)
                                    {
                                         contador--;
                                        if (contador == 0)
                                        {
                                             eliminarLista();
                                             cbCategorias.Enabled = true;
                                             cbEmpleados.Enabled = true;
                                             comprobarExis();
                                         }


                                         MessageBox.Show("Prestamo Aprobado","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    }
                                   
                                }
                                else
                                {
                                   
                                }   
                            }
                        
                    }
                }
                else
                {
                    MessageBox.Show("noinsert dialor");
                }
            }
            else
            {
                MessageBox.Show("Sin productos!!! \n \n Agrege productos a la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataLista.Rows.Count > 0)
            {
                string  id = dataLista.CurrentRow.Cells[0].Value.ToString();
                string folio = dataLista.CurrentRow.Cells[1].Value.ToString();
                string cat  = dataLista.CurrentRow.Cells[4].Value.ToString();
                string[] catSep = cat.Split(' ');
                EditarPedido edi = new EditarPedido();

                edi.id = id;
                edi.medida = catSep[1];
                edi.cantida = catSep[0];
                edi.F = folio;
                if (edi.ShowDialog() == DialogResult.OK)
                {
                    comprobarExis();
                    consultaLis();
                }
            }
            else
            {
                MessageBox.Show("No Tienes datos para poder actualizar","Actualizar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            this.dataLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            comprobarExis();
            llenarCbEm();
        }

       


        Datos datos = new Datos();
        public void llenarCbEm()
        {
            cbEmpleados.DataSource = datos.consulta("Select idEmpleado+'/'+NombreEmpleado as Em From Empleados order by idEmpleado").Tables[0];
            cbEmpleados.DisplayMember = "Empleados";
            cbEmpleados.ValueMember = "Em";
        }
        public void consultaLis()
        {
            String q = "select * from listaAr";

            dataLista.DataSource = datos.consulta(q).Tables[0];
        }
        public void eliminarLista()
        {
            String q = "Delete From listaAr";
            if (datos.eliminar(q)==true)
            {
                consultaLis();
            }
            
        }
        String carte="", emp1="";
        public void comprobarExis()
        {

            if (dataLista.Rows.Count > 0)
            {
                carte = dataLista.CurrentRow.Cells[3].Value.ToString();
                emp1 = dataLista.CurrentRow.Cells[5].Value.ToString();

                //reposisciona cb
                for (int x = 0; x <= cbEmpleados.Items.Count - 1; x++)
                {
                    cbEmpleados.SelectedIndex = x;
                    String nEm = "";
                    nEm = cbEmpleados.SelectedValue.ToString();
                    string[] emp = nEm.Split('/');

                    if (emp[0].Equals(emp1))
                    {

                        break;

                    }

                }
                int con = 0;
                foreach (object o in cbCategorias.Items)
                {
                   
                    if (o.Equals(carte))
                    {
                        cbCategorias.SelectedIndex = con;
                        break;
                    }
                    con++;
                }
                if (carte.Equals("Higiene y Limpieza"))
                {
                    lbDev.Visible = false;
                    dtRegreso.Visible = false;
                }
                else
                {
                    lbDev.Visible = true;
                    dtRegreso.Visible = true;
                }

               
                btnCancelar.Enabled = true;
                cbCategorias.Enabled = false;
                cbEmpleados.Enabled = false;
            }
            else
            {
                lbDev.Visible = false;
                dtRegreso.Visible = false;
                btnCancelar.Enabled = false;
                consultaLis();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbDev.Visible = false;
            dtRegreso.Visible = false;
            cbCategorias.Enabled = true;
            eliminarLista();
            this.btnCancelar.Enabled = false;
            cbEmpleados.Enabled = true;
        }

        private void cbCategorias_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public string idPrestamo()
        {
            String id1 = "";
            String id = "";
            String com = "";
            DataTable dt = new DataTable();
            if (cbCategorias.Text.Equals("Herramientas y Otros"))
            {
                
                dt = datos.spID("AGIDRe");
                com = "Re-";
                
            }
            else if (cbCategorias.Text.Equals("Higiene y Limpieza"))
            {
               
                dt = datos.spID("AGIDEl");
                com = "El-";
            }
            
            foreach (DataRow row in dt.Rows)
            {
               
                id1 = row["i"].ToString();
                if (id1.Equals(""))
                {
                    id = "0001";
                }
                else
                {
                    String nEm = "";
                    string[] emp = id1.Split('-');
                    nEm = emp[1];
                    int nu = int.Parse(nEm);
                    nu = nu + 1;
                    id = String.Format("{0:0000}", nu); ;
                }

            }
            return com+id;
        }
      
    }
}
