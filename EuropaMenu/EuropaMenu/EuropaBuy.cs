using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuropaMenu
{
    public partial class lblBuy : Form
    {
        public lblBuy()
        {
            InitializeComponent();
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }

        private void btnLightning_Click(object sender, EventArgs e)
        {
            lightningTxt.Visible = true;
            OUTATIMEtxt.Visible = false;
        }

        private void btnOutatime_Click(object sender, EventArgs e)
        {
            OUTATIMEtxt.Visible = true;
            lightningTxt.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBuy_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
