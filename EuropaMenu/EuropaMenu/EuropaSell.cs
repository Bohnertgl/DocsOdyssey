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
    public partial class EuropaSell : Form
    {
        public EuropaSell()
        {
            InitializeComponent();
        }

        private void btnHat_Click(object sender, EventArgs e)
        {
            MartyHattxt.Visible = true;
            MindReadtxt.Visible = false;
        }

        private void btnHelmet_Click(object sender, EventArgs e)
        {
            MartyHattxt.Visible = false;
            MindReadtxt.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void EuropaSell_Load(object sender, EventArgs e)
        {
            
        }
    }
}
