using System;
using System.Windows.Forms;
using DocsOdyssey;

namespace MainMenuApp
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Level1().Show();

            Level2Button.Enabled = true;
            Level3Button.Visible = true;
        }
        
        private void Level2Button_Click(object sender, EventArgs e)
        {
            new Level2.Level2().Show();
            Level3Button.Enabled = true;
            Level4Button.Visible = true;

        }

        private void Level3_Click(object sender, EventArgs e)
        {
            new Level3.Level3().Show();
            Level4Button.Enabled = true;
            Level5Button.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Level4.Level4().Show();
            Level5Button.Enabled = true;
        }

        private void Level5Button_Click(object sender, EventArgs e)
        {
            new Level5.Level5().Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
