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
    public partial class marsMenu : Form
    {
        public marsMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            new BuyMenu().Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            new SellMenu().Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void marsMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
