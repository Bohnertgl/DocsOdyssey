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
    public partial class EuropaMenu : Form
    {
        public EuropaMenu()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            new lblBuy().Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            new EuropaSell().Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EuropaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
