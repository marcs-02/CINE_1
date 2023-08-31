using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_1.MODELOS
{
    public class PRODUCTO
    {
        private string COD;
        private string NOMBRE;
        private string PRECIO;
        private string STOCK;

        public string COD1 { get => COD; set => COD = value; }
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string PRECIO1 { get => PRECIO; set => PRECIO = value; }
        public string STOCK1 { get => STOCK; set => STOCK = value; }

        public override string ToString()
        {
            return COD + " " + NOMBRE + " " + PRECIO + " " + STOCK;
        }
    }
}
