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
    public partial class FORM_PRODUCTO : Form
    {
        CTL_PRODUCTO CTL_PRO = new CTL_PRODUCTO();
        public FORM_PRODUCTO()
        {
            InitializeComponent();
            BED.Enabled = false;
            BEL.Enabled = false;
            UPDATE();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UPDATE()
        {
            TC.Text = CTL_PRO.obtenercod().ToString();
        }

        private void BAG_Click(object sender, EventArgs e)
        {
            PRODUCTO producto = new PRODUCTO
            {
                COD1 = TC.Text,
                    NOMBRE1 = TN.Text,
                    PRECIO1 = TP.Text,
                    STOCK1 = TS.Text,
            };

            CTL_PRO.Add_lista(producto);

            MessageBox.Show("USUARIO GUARDADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            CTL_PRO.IMP();

            UPDATE();

            CTL_PRO.mostrartab(DG);

            LIMPIAR();


        }

        public void LIMPIAR()
        {
            UPDATE();
            TC.Text = "";
            TN.Text = "";
            TP.Text = "";
            TS.Text = "";
        }

        private void BED_Click(object sender, EventArgs e)
        {
            int POS = CTL_PRO.poscod(TC.Text);

            PRODUCTO USER = new PRODUCTO
            {
                COD1 = TC.Text,
                NOMBRE1 = TN.Text,
                PRECIO1 = TP.Text,
                STOCK1 = TS.Text,
            };

            CTL_PRO.editarus(POS, USER);
            BAG.Enabled = true;
            BED.Enabled = false;
            BEL.Enabled = false;
            LIMPIAR();

            CTL_PRO.mostrartab(DG);
        }

        private void BEL_Click(object sender, EventArgs e)
        {
            int POS = CTL_PRO.poscod(TC.Text);
            if (POS != -1)
            {
                CTL_PRO.eliminarus(POS);
                LIMPIAR();

                CTL_PRO.mostrartab(DG);
                BAG.Enabled = true;
                BED.Enabled = false;
                BEL.Enabled = false;
            }else
            {
                MessageBox.Show("ERROR AL ELIMINAR", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            CTL_PRO.mostrartab(DG);
        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                string cedula = DG.Rows[e.RowIndex].Cells[0].Value.ToString();

                PRODUCTO user = CTL_PRO.BUSCARCOD(cedula);

                TC.Text = user.COD1;
                TN.Text = user.NOMBRE1;
                TP.Text = user.PRECIO1;
                TS.Text = user.STOCK1;

                BAG.Enabled = true;
                BED.Enabled = false;
                BEL.Enabled = true;

            }

            CTL_PRO.mostrartab(DG);
        }
    }
}
