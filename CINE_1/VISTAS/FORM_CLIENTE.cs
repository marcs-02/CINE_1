using CINE_1.CONTROLADOR;
using CINE_1.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINE_1.VISTAS
{
    public partial class FORM_CLIENTE : Form
    {
        CTL_CLIENTE CTL_CLIENTE = new CTL_CLIENTE();
        public FORM_CLIENTE()
        {
            InitializeComponent();
        }

        private void BAG_Click(object sender, EventArgs e)
        {
            int pos = CTL_CLIENTE.posced(TC.Text.Trim());
            if (pos == -1 )
            {
                CLIENTE user = new CLIENTE
                {
                    CEDULA1 = TC.Text,
                    NOMBRE1 = TN.Text,
                    APELLIDO1 = TA.Text,
                };
                CTL_CLIENTE.addlista(user);
                MessageBox.Show("CLIENTE GUARDADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CTL_CLIENTE.IMP();
            }else
            {
                MessageBox.Show("CLIENTE REPETIDO", "NOTIFICACION");
            }

            CTL_CLIENTE.mostrar(DG);
            limpiar();
            
        }
        private void limpiar()
        {
            TC.Text = "";
            TN.Text = "";
            TA.Text = "";
        }

        private void DG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                string cedula = DG.Rows[e.RowIndex].Cells[0].Value.ToString();

                CLIENTE user = CTL_CLIENTE.BUSCARCED(cedula);

                TC.Text = user.CEDULA1;
                TN.Text = user.NOMBRE1;
                TA.Text = user.APELLIDO1;

                BAG.Enabled = false;
                BED.Enabled = true;
                BEL.Enabled = true;

            }

            CTL_CLIENTE.mostrar(DG);
        }
    }
}
