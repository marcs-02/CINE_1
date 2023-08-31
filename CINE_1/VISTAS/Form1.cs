using CINE_1.VISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINE_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {
            FORM_CLIENTE FC = new FORM_CLIENTE();
            FC.Show();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            FORM_PRODUCTO FP = new FORM_PRODUCTO();
            FP.Show();
        }

        private void B3_Click(object sender, EventArgs e)
        {

        }
    }
}
