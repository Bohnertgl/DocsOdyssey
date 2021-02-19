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
    public partial class VenusBuy : Form
    {
        public VenusBuy()
        {
            InitializeComponent();
        }

        private void btnFuel_Click(object sender, EventArgs e)
        {
            Messages("Congratulations you have refueled your Delorean.....Hopefully You got the right Octane.");
            fuelText.Visible = true;
            almanacTxt.Visible = false;
        }

        private void btnAlmanac_Click(object sender, EventArgs e)
        {
            Messages("Didn't we learn in the first movie that this is a bad idea????");
            almanacTxt.Visible = true;
            fuelText.Visible = false;
        
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Messages(string message)
        {
            message = "Congratulations you have refuled your ship.";
        }
    }
}
