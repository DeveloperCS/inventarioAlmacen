
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using inventarioAlmacen.Funciones;

namespace inventarioAlmacen
{
    public partial class ReportePretamos : Form
    {
        public ReportePretamos()
        {
            InitializeComponent();
            comboBoxEmpleados.Text = "Empleados";
            comboBoxEmpleados.ForeColor = Color.DarkGray;
        }

        private void comboBoxEmpleados_Enter(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.Text == "Empleados")
            {
                comboBoxEmpleados.Text = "";
                comboBoxEmpleados.ForeColor = Color.DimGray;
            }
        }

        private void comboBoxEmpleados_Leave(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.Text == "")
            {
                comboBoxEmpleados.Text = "Empleados";
                comboBoxEmpleados.ForeColor = Color.DarkGray;
            }
        }
        String idbuscar = "";
        private void ReportePretamos_Load(object sender, EventArgs e)
        {
            llenarCbEm();
            idbuscar = comboBoxEmpleados.SelectedValue.ToString();

            consult(separa(idbuscar),"2");
            
        }
        DataView miFiltro;
        Datos datos = new Datos();
        public void llenarCbEm()
        {
            comboBoxEmpleados.DataSource = datos.consulta("Select idEmpleado+'/'+NombreEmpleado as Em From Empleados order by idEmpleado").Tables[0];
            comboBoxEmpleados.DisplayMember = "Empleados";
            comboBoxEmpleados.ValueMember = "Em";
        }

        public string separa(string nC)
        {
            string[] codigoSolo = nC.Split('/');
            return codigoSolo[0];
        }

        public void consult(String id,string cat)
        {
            String qy = "";
            if (cat.Equals("1"))
            {
                this.miFiltro = datos.consulta(qy = "Select * FROM ConsumoE Where [ Clave Empleado] like '" + id + "%'").Tables[0].DefaultView;
            }else if (cat.Equals("2"))
            {
                this.miFiltro = datos.consulta(qy = "Select * FROM PrestadosR Where [Clave Empleado] like '" + id + "%'").Tables[0].DefaultView;
            }
            
            dataRepEmp.DataSource = miFiltro;
        }

        private void rdHi_CheckedChanged(object sender, EventArgs e)
        {
            

            consult(comboBoxEmpleados.SelectedText.ToString(),"2");
          
        }

        private void rdHer_CheckedChanged(object sender, EventArgs e)
        {
            consult(comboBoxEmpleados.SelectedText.ToString(), "1");
        }

        private void comboBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

            idbuscar = comboBoxEmpleados.SelectedValue.ToString();
            if (rdHer.Checked)
            {
                consult(separa(idbuscar), "2");
            }
            else if (rdHi.Checked)
            {
                consult(separa(idbuscar), "1");
            }
           
        }
        string h = "", f = "";
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dataRepEmp.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataRepEmp.RowCount >= 1)
            {
                //hora y fecha
                h = DateTime.Now.ToLongTimeString();
                f = DateTime.Now.ToLongDateString();
                //ESCOJE A RUTA DONDE GUARDAREMOS EL PDF
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    int con = 1;
                    if (con == 1)
                    {
                        string filename = save.FileName;
                        Document doc = new Document(PageSize.A3, 9, 9, 9, 9);
                        Chunk encab = new Chunk("GYM CONTROL REPORT: " + "aa", FontFactory.GetFont("COURIER", 18));
                        Chunk fechaC = new Chunk(f + "." + "\n" + h, FontFactory.GetFont("COURIER", 12));
                        //  Chunk Usuario = new Chunk("Usuario: " + lbNomUS2.Text, FontFactory.GetFont("COURIER", 14));
                        Chunk tot = new Chunk("Total: " + 4, FontFactory.GetFont("COURIER", 16));
                        try
                        {
                            FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                            PdfWriter writer = PdfWriter.GetInstance(doc, file);
                            writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                            writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                            doc.Open();
                            doc.Add(new Paragraph(encab));
                            doc.Add(new Paragraph(fechaC));
                            //  doc.Add(new Paragraph(Usuario));
                            doc.Add(new Paragraph("\n"));
                            GenerarDocumentos(doc);
                            doc.Add(new Paragraph("\n"));
                            doc.Add(new Paragraph(tot));
                            Process.Start(filename);
                            doc.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " --" + ex.StackTrace.ToString());
                        }
                    }
                    else
                    {
                        string filename = save.FileName;
                        Document doc = new Document(PageSize.A3, 9, 9, 9, 9);
                        Chunk encab = new Chunk("GYM CONTROL REPORT: " + "aa", FontFactory.GetFont("COURIER", 18));
                        Chunk fechaC = new Chunk(f + "." + "\n" + h, FontFactory.GetFont("COURIER", 12));
                        // Chunk Usuario = new Chunk("Usuario: " + lbNomUS2.Text, FontFactory.GetFont("COURIER", 14));


                        try
                        {
                            FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                            PdfWriter writer = PdfWriter.GetInstance(doc, file);
                            writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                            writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                            doc.Open();
                            doc.Add(new Paragraph(encab));
                            doc.Add(new Paragraph(fechaC));
                            // doc.Add(new Paragraph(Usuario));
                            doc.Add(new Paragraph("\n"));
                            GenerarDocumentos(doc);
                            Process.Start(filename);
                            doc.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " --" + ex.StackTrace.ToString());
                        }

                    }


                }

            }
        }


        //Función que genera el documento Pdf
        public void GenerarDocumentos(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView 
            PdfPTable datatable = new PdfPTable(dataRepEmp.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf 
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dataRepEmp);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            //DEFINIMOS EL COLOR DE LAS CELDAS EN EL PDF
            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            //DEFINIMOS EL COLOR DE LOS BORDES
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            //LA FUENTE DE NUESTRO TEXTO
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF 
            for (int i = 0; i < dataRepEmp.ColumnCount; i++)
            {

                objP = new Phrase(dataRepEmp.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 1;

            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dataRepEmp.RowCount; i++)
            {
                for (int j = 0; j < dataRepEmp.ColumnCount; j++)
                {
                    objP = new Phrase(dataRepEmp[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        //Función que obtiene los tamaños de las columnas del datagridview
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            //Tomamos el numero de columnas
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                //Tomamos el ancho de cada columna
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
      
    }
}
