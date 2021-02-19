using System.Windows.Forms;

namespace Level2
{
    partial class Level2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.Player = new System.Windows.Forms.PictureBox();
            this.Gametime = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.NextLvL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = global::Level2.Properties.Resources.Delorean;
            this.Player.Location = new System.Drawing.Point(313, 442);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(52, 99);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Gametime
            // 
            this.Gametime.Interval = 30;
            this.Gametime.Tick += new System.EventHandler(this.MaingameTimer);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtScore.ForeColor = System.Drawing.SystemColors.Control;
            this.txtScore.Location = new System.Drawing.Point(32, 482);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(72, 20);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            // 
            // NextLvL
            // 
            this.NextLvL.BackColor = System.Drawing.Color.Transparent;
            this.NextLvL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextLvL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLvL.ForeColor = System.Drawing.Color.DarkRed;
            this.NextLvL.Location = new System.Drawing.Point(273, 209);
            this.NextLvL.Name = "NextLvL";
            this.NextLvL.Size = new System.Drawing.Size(139, 118);
            this.NextLvL.TabIndex = 4;
            this.NextLvL.Text = "Continue to Mars";
            this.NextLvL.UseVisualStyleBackColor = false;
            this.NextLvL.Visible = false;
            this.NextLvL.Click += new System.EventHandler(this.NextLvL_Click);
            // 
            // Level2
            // 
            this.BackgroundImage = global::Level2.Properties.Resources.backgroundGame;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.NextLvL);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "Level2";
            this.Load += new System.EventHandler(this.Level2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer Gametime;
        private System.Windows.Forms.Label txtScore;
        private Button NextLvL;
    }
}