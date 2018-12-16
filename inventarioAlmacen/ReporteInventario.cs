using inventarioAlmacen.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace inventarioAlmacen
{
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            this.datosTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (rdTodo.Checked == true)
            {
                consult();
            }

            if (datosTabla.Rows.Count <= 0)
            {
                MessageBox.Show("No Tienie Registros, \nAñade nuevos Registros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        DataView miFiltro;
        Datos dts = new Datos();
        public void consult()
        {
            String qy = "";

            this.miFiltro = dts.consulta(qy = "Select * FROM InventarioArticulo").Tables[0].DefaultView;
            datosTabla.DataSource = miFiltro;
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
        string h = "", f = "",TipRep="";
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (datosTabla.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (datosTabla.RowCount >= 1)
            {
                  
                //if para saber el tipo de reporte de inventario
                if (rdTodo.Checked==true)
                {
                    TipRep = "Todo";
                }
                if (rdHer.Checked==true)
                {
                    TipRep = "Herramientas y Otros";
                }
                if (rdHi.Checked==true)
                {
                    TipRep = "Higiene y Limpieza";
                }
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
                        //lef, right   top,button
                        Document doc = new Document(PageSize.A4, 30, 30, 15, 15);
                       
                        var image = iTextSharp.text.Image.GetInstance(@"../../img/Encabezado.png");
                        var scalePercent = (PageSize.A4.Width / image.Width) * 90;
                        image.ScalePercent(scalePercent);
                        Chunk head = new Chunk("Instituto Tecnológico Superior de San Pedro de las Colonias",FontFactory.GetFont("Arial", 18,1));
                        Chunk encab = new Chunk("CHECHSTORE: " + "Reporte de Inventario - " + TipRep, FontFactory.GetFont("Arial", 14));
                        
                        Chunk fechaC = new Chunk(f + "." + "\n" + h, FontFactory.GetFont("Arial", 12));
                        //  Chunk Usuario = new Chunk("Usuario: " + lbNomUS2.Text, FontFactory.GetFont("COURIER", 14));
                        //Chunk tot = new Chunk("Total: " + 4, FontFactory.GetFont("COURIER", 16));
                        try
                        {
                            MessageBox.Show(filename + "");
                            FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                            PdfWriter writer = PdfWriter.GetInstance(doc, file);
                            writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                            writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;

                           
                            doc.Open();

                            Paragraph pi = new Paragraph();
                            pi.Alignment = Element.ALIGN_CENTER;
                            pi.Add(image);
                            doc.Add(pi);
                          

                            Paragraph pr = new Paragraph();
                            pr.Alignment = Element.ALIGN_CENTER;
                            pr.Add(head);
                            doc.Add(pr);
                            doc.Add(new Paragraph("\n"));
                           
                            doc.Add(new Paragraph(encab));
                            doc.Add(new Paragraph(fechaC));
                            //  doc.Add(new Paragraph(Usuario));
                            doc.Add(new Paragraph("\n"));
                            doc.Add(new Paragraph("\n"));
                            GenerarDocumentos(doc);
                            //doc.Add(new Paragraph("\n"));
                           // doc.Add(new Paragraph(tot));
                            Process.Start(filename);
                            doc.Close();
                           

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " --" + ex.StackTrace.ToString());
                        }

                        try
                        {
                            //creamos nuestra lista de archivos a enviar
                            List<string> lstArchivos = new List<string>();
                            lstArchivos.Add(filename);

                            //creamos nuestro objeto de la clase que hicimos
                            enviaCorreo oMail = new enviaCorreo("carlosjosiel.hernandez@sistemas.tecsanpedro.edu.mx", "edgar.rosales@sistemas.tecsanpedro.edu.mx", "hola", "culito", lstArchivos);

                            //y enviamos
                            if (oMail.enviaMail())
                            {

                                MessageBox.Show("se envio el mail");

                            }
                            else
                            {
                                MessageBox.Show("no se envio el mail: " + oMail.error);

                            }
                        }
                        catch (Exception ec)
                        {
                           

                        }


                    }
                    else
                    {
                    }


                }

            }
        }


        //Función que genera el documento Pdf
        public void GenerarDocumentos(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView 
            PdfPTable datatable = new PdfPTable(datosTabla.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf 
            datatable.DefaultCell.Padding = 5;

            float[] headerwidths = GetTamañoColumnas(datosTabla);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            //DEFINIMOS EL COLOR DE LAS CELDAS EN EL PDF
            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            //DEFINIMOS EL COLOR DE LOS BORDES
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            //LA FUENTE DE NUESTRO TEXTO
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(FontFactory.GetFont("Arial", 12));

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF 
            for (int i = 0; i < datosTabla.ColumnCount; i++)
            {

                objP = new Phrase(datosTabla.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;
                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 1;

            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < datosTabla.RowCount; i++)
            {
             
             
                for (int j = 0; j < datosTabla.ColumnCount; j++)
                {
                    objP = new Phrase(datosTabla[j, i].Value.ToString(), fuente);
                    
                       
                        
                    
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
