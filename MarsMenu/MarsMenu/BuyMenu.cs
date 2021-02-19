using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsMenu
{
    public partial class BuyMenu : Form
    {
        public BuyMenu()
        {
            InitializeComponent();
        }

        private void btnPlutonium_Click(object sender, EventArgs e)
        {
            Walkmantxt.Visible = false;
            Plutoniumtxt.Visible = true;

        }

        private void btnWalkman_Click(object sender, EventArgs e)
        {
            Walkmantxt.Visible = true;
            Plutoniumtxt.Visible = false;
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
