using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlutoMenu
{
    public partial class PlutoBuy : Form
    {
        public PlutoBuy()
        {
            InitializeComponent();
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            Controltxt.Visible = true;
            Clocktxt.Visible = false;
        }

        private void btnClocktower_Click(object sender, EventArgs e)
        {
            Clocktxt.Visible = true;
            Controltxt.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
