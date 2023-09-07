using CINE_1.MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_1.CONTROLADOR
{
    internal class CTL_FACTURA
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


    }
}
