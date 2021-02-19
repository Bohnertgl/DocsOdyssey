
namespace EuropaMenu
{
    partial class EuropaSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EuropaSell));
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnHelmet = new System.Windows.Forms.Button();
            this.btnHat = new System.Windows.Forms.Button();
            this.MindReadtxt = new System.Windows.Forms.TextBox();
            this.MartyHattxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblPrompt.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrompt.Location = new System.Drawing.Point(145, 111);
            this.lblPrompt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(422, 36);
            this.lblPrompt.TabIndex = 3;
            this.lblPrompt.Text = "What items would you like to sell?";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Yellow;
            this.btnReturn.Location = new System.Drawing.Point(247, 402);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(221, 36);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnHelmet
            // 
            this.btnHelmet.BackColor = System.Drawing.Color.Transparent;
            this.btnHelmet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelmet.ForeColor = System.Drawing.Color.Yellow;
            this.btnHelmet.Location = new System.Drawing.Point(247, 352);
            this.btnHelmet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelmet.Name = "btnHelmet";
            this.btnHelmet.Size = new System.Drawing.Size(221, 36);
            this.btnHelmet.TabIndex = 9;
            this.btnHelmet.Text = "Mind Reading Helmet";
            this.btnHelmet.UseVisualStyleBackColor = false;
            this.btnHelmet.Click += new System.EventHandler(this.btnHelmet_Click);
            // 
            // btnHat
            // 
            this.btnHat.BackColor = System.Drawing.Color.Transparent;
            this.btnHat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHat.ForeColor = System.Drawing.Color.Yellow;
            this.btnHat.Location = new System.Drawing.Point(247, 304);
            this.btnHat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHat.Name = "btnHat";
            this.btnHat.Size = new System.Drawing.Size(221, 36);
            this.btnHat.TabIndex = 8;
            this.btnHat.Text = "Marty\'s Hat";
            this.btnHat.UseVisualStyleBackColor = false;
            this.btnHat.Click += new System.EventHandler(this.btnHat_Click);
            // 
            // MindReadtxt
            // 
            this.MindReadtxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.MindReadtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MindReadtxt.ForeColor = System.Drawing.Color.Yellow;
            this.MindReadtxt.Location = new System.Drawing.Point(237, 150);
            this.MindReadtxt.Multiline = true;
            this.MindReadtxt.Name = "MindReadtxt";
            this.MindReadtxt.Size = new System.Drawing.Size(231, 149);
            this.MindReadtxt.TabIndex = 11;
            this.MindReadtxt.Text = "You actually want to sell a helmet that reads minds?  Didn\'t see that one coming!" +
    "";
            this.MindReadtxt.Visible = false;
            // 
            // MartyHattxt
            // 
            this.MartyHattxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.MartyHattxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MartyHattxt.ForeColor = System.Drawing.Color.Yellow;
            this.MartyHattxt.Location = new System.Drawing.Point(241, 150);
            this.MartyHattxt.Multiline = true;
            this.MartyHattxt.Name = "MartyHattxt";
            this.MartyHattxt.Size = new System.Drawing.Size(227, 101);
            this.MartyHattxt.TabIndex = 12;
            this.MartyHattxt.Text = "Good call.  I hear head lice were pretty rampant in 1985.";
            this.MartyHattxt.Visible = false;
            // 
            // EuropaSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.MartyHattxt);
            this.Controls.Add(this.MindReadtxt);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnHelmet);
            this.Controls.Add(this.btnHat);
            this.Controls.Add(this.lblPrompt);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "EuropaSell";
            this.Text = "EuropaSell";
            this.Load += new System.EventHandler(this.EuropaSell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnHelmet;
        private System.Windows.Forms.Button btnHat;
        private System.Windows.Forms.TextBox MindReadtxt;
        private System.Windows.Forms.TextBox MartyHattxt;
    }
}