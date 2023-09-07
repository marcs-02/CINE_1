using CINE_1.MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINE_1.CONTROLADOR
{
    public class CTL_FACTURA
    {
        List<FACTURA> lista;

        public CTL_FACTURA()
        {
            lista = new List<FACTURA>();    

        }
        public void ADDL(FACTURA USER)
        {
            lista.Add(USER);

        }

            public string imp()
        {

            string datos = "";

            foreach (FACTURA user in lista)
            {
                datos += user.ToString() + "\n";
            }
            return datos;
        }

        public void mostrartab(DataGridView tabla)
        {
            tabla.Rows.Clear();
            foreach(FACTURA user in lista)
            {
                tabla.Rows.Add(user.NUM_FACTURA1, user.CED_CLIENTE1, user.FECHA1, user.TOTAL1);
            }
        }
        public int num_f()
        {
            int num = 0;
            if(lista.Count > 0)
            {
                num = lista.Last().NUM_FACTURA1;
            }
            return num + 1;
        }
    }
}
