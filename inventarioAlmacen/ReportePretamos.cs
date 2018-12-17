
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
using System.Threading;

namespace inventarioAlmacen
{
    public partial class ReportePretamos : Form
    {
        public ReportePretamos()
        {
            InitializeComponent();
            comboBoxEmpleados.Text = "Empleados";
            comboBoxEmpleados.ForeColor = Color.DimGray;
            comboBoxEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxEmpleados_Enter(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.Text != "Empleados")
            {
                comboBoxEmpleados.Text = "";
                comboBoxEmpleados.ForeColor = Color.Black;
            }
        }

        private void comboBoxEmpleados_Leave(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.Text == "")
            {
                comboBoxEmpleados.Text = "Empleados";
                comboBoxEmpleados.ForeColor = Color.DimGray;
            }
        }
        String idbuscar = "";
        private void ReportePretamos_Load(object sender, EventArgs e)
        {
            this.progressMsj.Visible = false;
            this.lbProgressMsj.Visible = false;
            this.dataRepEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            llenarCbEm();
            idbuscar = comboBoxEmpleados.SelectedValue.ToString();

            consult(separa(idbuscar),"2");
            idbuscar="";
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
                this.miFiltro = datos.consulta(qy = "Select [Clave Usuario]as[Clave Usuario],[ Clave Empleado]as[ Clave Empleado],Articulo as Articulo,CONVERT(VARCHAR,[Fecha Salida],103)as [Fecha Salida] FROM ConsumoE Where [ Clave Empleado] like '" + id + "%'").Tables[0].DefaultView;
            }else if (cat.Equals("2"))
            {
                this.miFiltro = datos.consulta(qy = "Select [Clave Usuario]as[Clave Usuario],[Clave Empleado]as[Clave Empleado],Articulo as Articulo,Cantidad as Cantidad,CONVERT(VARCHAR,[Fecha Salida],103)as [Fecha Salida],CONVERT(VARCHAR,[Fecha Entrada],103)as [Fecha Entrada] FROM PrestadosR Where [Clave Empleado] like '" + id + "%'").Tables[0].DefaultView;
            }
            
            dataRepEmp.DataSource = miFiltro;
        }

        private void rdHi_CheckedChanged(object sender, EventArgs e)
        {

            idbuscar = comboBoxEmpleados.SelectedValue.ToString();
            consult(separa(idbuscar), "1");
        }

        private void rdHer_CheckedChanged(object sender, EventArgs e)
        {
            idbuscar = comboBoxEmpleados.SelectedValue.ToString();
            consult(separa(idbuscar), "2");
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
        string h = "", f = "",TipRep="";
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dataRepEmp.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataRepEmp.RowCount >= 1)
            {
                
                if (rdHer.Checked == true)
                {
                    TipRep = "Herramientas y Otros";
                }
                if (rdHi.Checked == true)
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
                        Chunk head = new Chunk("Instituto Tecnológico Superior de San Pedro de las Colonias", FontFactory.GetFont("Arial", 18, 1));
                        Chunk encab = new Chunk("CHECHSTORE: " + "Reporte de Inventario - " + TipRep, FontFactory.GetFont("Arial", 14));

                        Chunk fechaC = new Chunk(f + "." + "\n" + h, FontFactory.GetFont("Arial", 12));
                        Chunk empleado = new Chunk("Empleado: " + comboBoxEmpleados.Text, FontFactory.GetFont("Arial", 12));
                        //Chunk tot = new Chunk("Total: " + 4, FontFactory.GetFont("COURIER", 16));
                        try
                        {
                            MessageBox.Show(filename+"");
                            FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                            PdfWriter writer = PdfWriter.GetInstance(doc, file);
                            writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                            writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;


                            doc.Open();

                            Paragraph pi = new Paragraph();
                            pi.Alignment = Element.ALIGN_RIGHT;
                            pi.Add(image);
                            doc.Add(pi);


                            Paragraph pr = new Paragraph();
                            pr.Alignment = Element.ALIGN_CENTER;
                            pr.Add(head);
                            doc.Add(pr);
                            doc.Add(new Paragraph("\n"));

                            doc.Add(new Paragraph(encab));
                            doc.Add(new Paragraph(fechaC));
                            doc.Add(new Paragraph(empleado));
                            doc.Add(new Paragraph("\n"));
                            doc.Add(new Paragraph("\n"));
                            GenerarDocumentos(doc);
                            //doc.Add(new Paragraph("\n"));
                            // doc.Add(new Paragraph(tot));
                            Process.Start(filename);
                            doc.Close();

                            if (MessageBox.Show("¿Desea enviar Reporte por Correo?", "Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                CorreoElectronico cor = new CorreoElectronico();
                                cor.parametrosCorreo(filename);
                                if (cor.ShowDialog() == DialogResult.OK)
                                {

                                    try
                                    {

                                        if (!backgroundWorker1.IsBusy)
                                        {
                                            this.progressMsj.Visible = true;
                                            this.lbProgressMsj.Visible = true;
                                            backgroundWorker1.RunWorkerAsync();
                                        }

                                    }
                                    catch (Exception ec)
                                    {

                                        if (backgroundWorker1.IsBusy)
                                        {
                                            backgroundWorker1.CancelAsync();
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Cancelo el Envio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " --" + ex.StackTrace.ToString());
                        }
                    }
                    else
                    {
                    }


                }

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int pro = 100;
            int delay = 100;
            int index = 1;
            try
            {
                for (int i = 0; i < pro; i++)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        backgroundWorker1.ReportProgress(index++ * 100 / pro, string.Format("Enviando Mensaje.....{0}% ", i));
                        Thread.Sleep(delay);
                    }
                }
            }
            catch (Exception es)
            {
                backgroundWorker1.CancelAsync();
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            this.progressMsj.Visible = false;
            this.lbProgressMsj.Visible = false;
            MessageBox.Show("Se Envio el Reporte por Correo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressMsj.Value = e.ProgressPercentage;
            this.lbProgressMsj.Text = String.Format("Enviando Mensaje.....{0}%", e.ProgressPercentage);
            progressMsj.Update();
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
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(FontFactory.GetFont("Arial", 12));

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
