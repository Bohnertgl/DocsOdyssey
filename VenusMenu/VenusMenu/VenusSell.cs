using System;
using System.Windows.Forms;

namespace VenusMenu
{
    public partial class VenusSell : Form
    {
        public VenusSell()
        {
            InitializeComponent();
        }

        private void btnLabCoat_Click(object sender, EventArgs e)
        {
            SellCoattxt.Visible = true;
            hoverBoardTxt.Visible = false;
        }

        private void btnHoverboard_Click(object sender, EventArgs e)
        {
            hoverBoardTxt.Visible = true;
            SellCoattxt.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
