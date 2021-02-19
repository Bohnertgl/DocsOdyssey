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
    public partial class PlutoSell : Form
    {
        public PlutoSell()
        {
            InitializeComponent();
        }

        private void btnVest_Click(object sender, EventArgs e)
        {
            Vesttxt.Visible = true;
            Jackettxt.Visible = false;
        }

        private void btnJacket_Click(object sender, EventArgs e)
        {
            Vesttxt.Visible = false;
            Jackettxt.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
