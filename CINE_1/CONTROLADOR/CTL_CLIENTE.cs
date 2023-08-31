using CINE_1.MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINE_1.CONTROLADOR
{
    public class CTL_CLIENTE
    {
        List<CLIENTE> lista;

        public CTL_CLIENTE()
        {
            lista = new List<CLIENTE>();
        }

        public void addlista(CLIENTE user)
        {
            lista.Add(user);
        }

        public string IMP()
        {
            string DATOS = "";

            foreach (CLIENTE user in lista)
            {
                DATOS += user.ToString() + "\n";
            }
            return DATOS;
        }

        public void mostrar(DataGridView tabla)
        {
            tabla.Rows.Clear();
            foreach (CLIENTE user in lista)
            {
                tabla.Rows.Add(user.CEDULA1,user.NOMBRE1,user.APELLIDO1);
            }
        }

        public CLIENTE BUSCARCED(string CEDULA) {
            return lista.Find(us => us.CEDULA1.Equals(CEDULA));
        }

        public void REMOVERT(DataGridView tabla)
        {
            tabla.Rows.Clear();
        }

        public int posced(string CEDULA)
        {
            return lista.FindIndex(us => us.CEDULA1.Equals(CEDULA));
        }

        public void editarus(int pos, CLIENTE cliente)
        {
            lista[pos] = cliente;
        }
        public void eliminarus(int pos)
        {
            lista.RemoveAt(pos);
        }
    }
}
