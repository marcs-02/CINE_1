using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_1.MODELOS
{
    public class FACTURA
    {

        private int NUM_FACTURA;
        private string CED_CLIENTE;
        private string FECHA;
        private int TOTAL;

        public FACTURA() { 
        }

        public int NUM_FACTURA1 { get => NUM_FACTURA; set => NUM_FACTURA = value; }
        public string CED_CLIENTE1 { get => CED_CLIENTE; set => CED_CLIENTE = value; }
        public string FECHA1 { get => FECHA; set => FECHA = value; }
        public int TOTAL1 { get => TOTAL; set => TOTAL = value; }


    }
}
