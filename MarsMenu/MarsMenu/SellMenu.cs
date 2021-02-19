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
    public partial class SellMenu : Form
    {
        public SellMenu()
        {
            InitializeComponent();
        }

        private void btnPeacemaker_Click(object sender, EventArgs e)
        {
            Colttxt.Visible = true;
            Guitartxt.Visible = false;
        }

        private void btnGuitar_Click(object sender, EventArgs e)
        {
            Guitartxt.Visible = true;
            Colttxt.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
