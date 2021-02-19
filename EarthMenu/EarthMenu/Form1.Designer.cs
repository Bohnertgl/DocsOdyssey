
namespace EarthMenu
{
    partial class EarthMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarthMenu));
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblBeat = new System.Windows.Forms.Label();
            this.lblThanks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.BackColor = System.Drawing.Color.Transparent;
            this.lblCongrats.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.ForeColor = System.Drawing.Color.Lime;
            this.lblCongrats.Location = new System.Drawing.Point(215, 207);
            this.lblCongrats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(314, 36);
            this.lblCongrats.TabIndex = 0;
            this.lblCongrats.Text = "CONGRATULATIONS!!!";
            this.lblCongrats.Click += new System.EventHandler(this.lblCongrats_Click);
            // 
            // lblBeat
            // 
            this.lblBeat.AutoSize = true;
            this.lblBeat.BackColor = System.Drawing.Color.Transparent;
            this.lblBeat.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeat.ForeColor = System.Drawing.Color.Lime;
            this.lblBeat.Location = new System.Drawing.Point(260, 282);
            this.lblBeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBeat.Name = "lblBeat";
            this.lblBeat.Size = new System.Drawing.Size(239, 36);
            this.lblBeat.TabIndex = 1;
            this.lblBeat.Text = "You beat the game!";
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.BackColor = System.Drawing.Color.Transparent;
            this.lblThanks.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.ForeColor = System.Drawing.Color.Lime;
            this.lblThanks.Location = new System.Drawing.Point(164, 356);
            this.lblThanks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(410, 36);
            this.lblThanks.TabIndex = 2;
            this.lblThanks.Text = "Thanks for playing Doc\'s Odyssey";
            // 
            // EarthMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.lblBeat);
            this.Controls.Add(this.lblCongrats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "EarthMenu";
            this.Text = "Earth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label lblBeat;
        private System.Windows.Forms.Label lblThanks;
    }
}

