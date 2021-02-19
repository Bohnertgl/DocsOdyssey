namespace MainMenuApp
{
    partial class MenuPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            this.Level2Button = new System.Windows.Forms.Button();
            this.Level1 = new System.Windows.Forms.Button();
            this.Level3Button = new System.Windows.Forms.Button();
            this.Level4Button = new System.Windows.Forms.Button();
            this.Level5Button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.OpenExplain = new System.Windows.Forms.TextBox();
            this.HowToTxT = new System.Windows.Forms.TextBox();
            this.gameTitletxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Level2Button
            // 
            this.Level2Button.BackColor = System.Drawing.Color.Transparent;
            this.Level2Button.Enabled = false;
            this.Level2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Level2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Level2Button.ForeColor = System.Drawing.Color.Yellow;
            this.Level2Button.Location = new System.Drawing.Point(269, 225);
            this.Level2Button.Name = "Level2Button";
            this.Level2Button.Size = new System.Drawing.Size(221, 36);
            this.Level2Button.TabIndex = 0;
            this.Level2Button.Text = "Travel to Mars";
            this.Level2Button.UseVisualStyleBackColor = false;
            this.Level2Button.Click += new System.EventHandler(this.Level2Button_Click);
            // 
            // Level1
            // 
            this.Level1.BackColor = System.Drawing.Color.Transparent;
            this.Level1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Level1.ForeColor = System.Drawing.Color.Yellow;
            this.Level1.Location = new System.Drawing.Point(269, 183);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(221, 36);
            this.Level1.TabIndex = 1;
            this.Level1.Text = "Travel to Venus";
            this.Level1.UseVisualStyleBackColor = false;
            this.Level1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Level3Button
            // 
            this.Level3Button.BackColor = System.Drawing.Color.Transparent;
            this.Level3Button.Enabled = false;
            this.Level3Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Level3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level3Button.ForeColor = System.Drawing.Color.Yellow;
            this.Level3Button.Location = new System.Drawing.Point(269, 267);
            this.Level3Button.Name = "Level3Button";
            this.Level3Button.Size = new System.Drawing.Size(221, 36);
            this.Level3Button.TabIndex = 2;
            this.Level3Button.Text = "Travel to Europa";
            this.Level3Button.UseVisualStyleBackColor = false;
            this.Level3Button.Visible = false;
            this.Level3Button.Click += new System.EventHandler(this.Level3_Click);
            // 
            // Level4Button
            // 
            this.Level4Button.BackColor = System.Drawing.Color.Transparent;
            this.Level4Button.Enabled = false;
            this.Level4Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Level4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Level4Button.ForeColor = System.Drawing.Color.Yellow;
            this.Level4Button.Location = new System.Drawing.Point(269, 309);
            this.Level4Button.Name = "Level4Button";
            this.Level4Button.Size = new System.Drawing.Size(221, 36);
            this.Level4Button.TabIndex = 3;
            this.Level4Button.Text = "Travel to Pluto";
            this.Level4Button.UseVisualStyleBackColor = false;
            this.Level4Button.Visible = false;
            this.Level4Button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Level5Button
            // 
            this.Level5Button.BackColor = System.Drawing.Color.Transparent;
            this.Level5Button.Enabled = false;
            this.Level5Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Level5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Level5Button.ForeColor = System.Drawing.Color.Yellow;
            this.Level5Button.Location = new System.Drawing.Point(269, 351);
            this.Level5Button.Name = "Level5Button";
            this.Level5Button.Size = new System.Drawing.Size(221, 36);
            this.Level5Button.TabIndex = 4;
            this.Level5Button.Text = "Travel to Earth...Finally!";
            this.Level5Button.UseVisualStyleBackColor = false;
            this.Level5Button.Visible = false;
            this.Level5Button.Click += new System.EventHandler(this.Level5Button_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.exit.ForeColor = System.Drawing.Color.Yellow;
            this.exit.Location = new System.Drawing.Point(269, 393);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(221, 40);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // OpenExplain
            // 
            this.OpenExplain.BackColor = System.Drawing.SystemColors.InfoText;
            this.OpenExplain.ForeColor = System.Drawing.Color.Gold;
            this.OpenExplain.Location = new System.Drawing.Point(12, 183);
            this.OpenExplain.Multiline = true;
            this.OpenExplain.Name = "OpenExplain";
            this.OpenExplain.Size = new System.Drawing.Size(180, 266);
            this.OpenExplain.TabIndex = 6;
            this.OpenExplain.Text = resources.GetString("OpenExplain.Text");
            // 
            // HowToTxT
            // 
            this.HowToTxT.BackColor = System.Drawing.SystemColors.MenuText;
            this.HowToTxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToTxT.ForeColor = System.Drawing.Color.Gold;
            this.HowToTxT.Location = new System.Drawing.Point(599, 183);
            this.HowToTxT.Multiline = true;
            this.HowToTxT.Name = "HowToTxT";
            this.HowToTxT.Size = new System.Drawing.Size(198, 266);
            this.HowToTxT.TabIndex = 7;
            this.HowToTxT.Text = "To control your Delorean you must use your arrow keys on the keyboard.\r\n\r\nTo shoo" +
    "t the enemies, press spacebar.\r\n\r\nUse your mouse to click buttons to interact wi" +
    "th shops and choose your levels.\r\n\r\n";
            // 
            // gameTitletxt
            // 
            this.gameTitletxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.gameTitletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitletxt.ForeColor = System.Drawing.Color.Gold;
            this.gameTitletxt.Location = new System.Drawing.Point(248, 12);
            this.gameTitletxt.Name = "gameTitletxt";
            this.gameTitletxt.Size = new System.Drawing.Size(265, 45);
            this.gameTitletxt.TabIndex = 8;
            this.gameTitletxt.Text = "Doc\'s Odyssey!";
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainMenuApp.Properties.Resources.Planet_Menu_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameTitletxt);
            this.Controls.Add(this.HowToTxT);
            this.Controls.Add(this.OpenExplain);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Level5Button);
            this.Controls.Add(this.Level4Button);
            this.Controls.Add(this.Level3Button);
            this.Controls.Add(this.Level1);
            this.Controls.Add(this.Level2Button);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPage";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Level2Button;
        private System.Windows.Forms.Button Level1;
        private System.Windows.Forms.Button Level3Button;
        private System.Windows.Forms.Button Level4Button;
        private System.Windows.Forms.Button Level5Button;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox OpenExplain;
        private System.Windows.Forms.TextBox HowToTxT;
        private System.Windows.Forms.TextBox gameTitletxt;
    }
}

