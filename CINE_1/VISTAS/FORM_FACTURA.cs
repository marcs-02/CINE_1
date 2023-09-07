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
    public partial class FORM_FACTURA : Form
    {
        public FORM_FACTURA()
        {
            InitializeComponent();

            LFAC.Text = "FACT Nro " + Form1.CTL_FAC.num_f();
            LFEC.Text = DateTime.Now.ToString();
        }


        private void FORM_FACTURA_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
            if(T1.Text.Length == 10)
            {
                CLIENTE CLI = Form1.CTL_CLIENTE.BUSCARCED(T1.Text);
                if (CLI != null)
                {
                    LN.Text = CLI.NOMBRE1 + " " + CLI.APELLIDO1;
                }
                else
                {
                    LN.Text = "-";
                }
            }
            else
            {
                LN.Text = "-";
            }
        }
    }
}
