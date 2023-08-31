using CINE_1.MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINE_1.CONTROLADOR
{
    public class CTL_PRODUCTO
    {
        List<PRODUCTO> lista;
        public CTL_PRODUCTO()
        {
            lista = new List<PRODUCTO>();
        }

        public void Add_lista(PRODUCTO user)
        {
            lista.Add(user);
        }

        public string IMP()
        {
            string datos = "";

            foreach (PRODUCTO user in lista)
            {
                datos += user.ToString() + "\n";
            }
            return datos;
        }

        public void mostrartab(DataGridView tabla)
        {
            tabla.Rows.Clear();
            foreach (PRODUCTO user in lista)
            {
                tabla.Rows.Add(user.COD1, user.NOMBRE1, user.PRECIO1, user.STOCK1);
            }
        }

        public PRODUCTO BUSCARCOD(string COD)
        {
            return lista.Find(us => us.COD1.Equals(COD));
        }

        public void REMOVERT(DataGridView tabla)
        {
            tabla.Rows.Clear();
        }

        public int poscod(string CODIGO)
        {
            return lista.FindIndex(us => us.COD1.Equals(CODIGO));
        }

        public void editarus(int pos, PRODUCTO producto)
        {
            lista[pos] = producto;
        }
        public void eliminarus(int pos)
        {
            lista.RemoveAt(pos);
        }

        public int obtenercod()
        {
            int id = 0;
            if (lista.Count > 0)
            {
                id= Convert.ToInt32(lista.Last().COD1);
            }
            return id + 1;
        }
    }
}
