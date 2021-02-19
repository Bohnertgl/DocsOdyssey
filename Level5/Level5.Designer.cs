namespace Level5
{
    partial class Level5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level5));
            this.Player = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.FinalLevel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = global::Level5.Properties.Resources.Delorean;
            this.Player.Location = new System.Drawing.Point(313, 442);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(52, 99);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.ForeColor = System.Drawing.SystemColors.Control;
            this.txtScore.Location = new System.Drawing.Point(49, 499);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(72, 20);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // FinalLevel
            // 
            this.FinalLevel.BackColor = System.Drawing.Color.Transparent;
            this.FinalLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinalLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalLevel.ForeColor = System.Drawing.Color.Yellow;
            this.FinalLevel.Location = new System.Drawing.Point(220, 132);
            this.FinalLevel.Name = "FinalLevel";
            this.FinalLevel.Size = new System.Drawing.Size(259, 158);
            this.FinalLevel.TabIndex = 2;
            this.FinalLevel.Text = "Continue To Earth!";
            this.FinalLevel.UseVisualStyleBackColor = false;
            this.FinalLevel.Visible = false;
            this.FinalLevel.Click += new System.EventHandler(this.FinalLevel_Click);
            // 
            // Level5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Level5.Properties.Resources.Planet_Menu_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.FinalLevel);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.Player);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "Level5";
            this.Text = "Level5";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button FinalLevel;
    }
}

