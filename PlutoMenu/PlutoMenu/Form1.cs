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
    public partial class PlutoMenu : Form
    {
        public PlutoMenu()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            new PlutoBuy().Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            new PlutoSell().Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlutoMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
