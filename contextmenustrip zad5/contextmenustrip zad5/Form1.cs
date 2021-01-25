using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contextmenustrip_zad5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void lijevoNaDesnoCtrldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtboxDesno.Text = txtboxLijevo.Text;
        }

        private void desnoNaLijevoCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtboxLijevo.Text = txtboxDesno.Text;
        }
    }
}
