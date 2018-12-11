using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace inventarioAlmacen.Funciones
{
    class creaPDF
    {
        //Función que genera el documento Pdf
        /// <summary>
        /// Funcion para Generar un .PDf con base un DataGridView
        /// </summary>
        /// <param name="document">Documento</param>
        /// <param name="dataGridView1">DataGridView</param>
        public void GenerarDocumentos(Document document,DataGridView dataGridView1)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView 
            PdfPTable datatable = new PdfPTable(dataGridView1.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf 
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dataGridView1);

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
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {

                objP = new Phrase(dataGridView1.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 1;

            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    objP = new Phrase(dataGridView1[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        //Función que obtiene los tamaños de las columnas del datagridview
        /// <summary>
        /// Determina el tamaño de las Columnas del DataGridView
        /// </summary>
        /// <param name="dg"></param>
        /// <returns></returns>
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
