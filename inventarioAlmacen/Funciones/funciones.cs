using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventarioAlmacen.Funciones
{
    class funciones
    {
        Datos dts = new Datos();
        public static String obString(DataGridView dataGrid, int num)
        {
            String d = "";
            d = dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[num].Value.ToString();
            return d;
        }

       
       

    }
}
