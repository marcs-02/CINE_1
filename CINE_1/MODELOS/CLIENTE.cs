using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_1.MODELOS
{
    public class CLIENTE
    {

        private string CEDULA;
        private string NOMBRE;
        private string APELLIDO;
        public CLIENTE() { 

        }

        public string CEDULA1 { get => CEDULA; set => CEDULA = value; }
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string APELLIDO1 { get => APELLIDO; set => APELLIDO = value; }

        public override string ToString()
        {
            return CEDULA + " "+NOMBRE + " " + APELLIDO;
        }

    }
}
