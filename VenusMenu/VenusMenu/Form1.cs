using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenusMenu
{
    public partial class VenusMenu : Form
    {
        public VenusMenu()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            new VenusBuy().Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            new VenusSell().Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
