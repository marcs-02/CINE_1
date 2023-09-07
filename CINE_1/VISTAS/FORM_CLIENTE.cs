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
        public FORM_CLIENTE()
        {
            InitializeComponent();
            Update();
            Form1.CTL_CLIENTE.mostrar(DG);
        }

        private void BAG_Click(object sender, EventArgs e)
        {
            int pos = Form1.CTL_CLIENTE.posced(TC.Text.Trim());
            if (pos == -1 )
            {
                CLIENTE user = new CLIENTE
                {
                    CEDULA1 = TC.Text,
                    NOMBRE1 = TN.Text,
                    APELLIDO1 = TA.Text,
                };
                Form1.CTL_CLIENTE.addlista(user);
                MessageBox.Show("CLIENTE GUARDADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1.CTL_CLIENTE.IMP();
            }else
            {
                MessageBox.Show("CLIENTE REPETIDO", "NOTIFICACION");
            }

            Form1.CTL_CLIENTE.mostrar(DG);
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

                CLIENTE user = Form1.CTL_CLIENTE.BUSCARCED(cedula);

                TC.Text = user.CEDULA1;
                TN.Text = user.NOMBRE1;
                TA.Text = user.APELLIDO1;

                BAG.Enabled = false;
                BED.Enabled = true;
                BEL.Enabled = true;

            }

            Form1.CTL_CLIENTE.mostrar(DG);
        }

        private void BED_Click(object sender, EventArgs e)
        {
            int pos = Form1.CTL_CLIENTE.posced(TC.Text.Trim());
            if (pos == -1)
            {
                CLIENTE user = new CLIENTE
                {
                    CEDULA1 = TC.Text,
                    NOMBRE1 = TN.Text,
                    APELLIDO1 = TA.Text,
                };
                Form1.CTL_CLIENTE.editarus(pos,user);
                MessageBox.Show("CLIENTE GUARDADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("CLIENTE REPETIDO", "NOTIFICACION");
            }
            limpiar();
            Form1.CTL_CLIENTE.mostrar(DG);
            BAG.Enabled = true;
        }

        private void BEL_Click(object sender, EventArgs e)
        {
            int pos = Form1.CTL_CLIENTE.posced(TC.Text.Trim());
            if (pos == -1)
            {
                Form1.CTL_CLIENTE = new CTL_CLIENTE();
                BAG.Enabled = true;
                BEL.Enabled = false;
            }
            else
            {
                MessageBox.Show("CLIENTE REPETIDO", "NOTIFICACION");
            }
            limpiar();
            Form1.CTL_CLIENTE.mostrar(DG);
            BAG.Enabled = true;
        }
    }
}
