
namespace MarsMenu
{
    partial class BuyMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyMenu));
            this.buyPrompt = new System.Windows.Forms.Label();
            this.btnWalkman = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPlutonium = new System.Windows.Forms.Button();
            this.Plutoniumtxt = new System.Windows.Forms.TextBox();
            this.Walkmantxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buyPrompt
            // 
            this.buyPrompt.AutoSize = true;
            this.buyPrompt.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPrompt.ForeColor = System.Drawing.Color.Yellow;
            this.buyPrompt.Location = new System.Drawing.Point(145, 110);
            this.buyPrompt.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.buyPrompt.Name = "buyPrompt";
            this.buyPrompt.Size = new System.Drawing.Size(428, 36);
            this.buyPrompt.TabIndex = 0;
            this.buyPrompt.Text = "What items would you like to buy?";
            // 
            // btnWalkman
            // 
            this.btnWalkman.BackColor = System.Drawing.Color.Transparent;
            this.btnWalkman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWalkman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalkman.ForeColor = System.Drawing.Color.Yellow;
            this.btnWalkman.Location = new System.Drawing.Point(247, 351);
            this.btnWalkman.Name = "btnWalkman";
            this.btnWalkman.Size = new System.Drawing.Size(221, 36);
            this.btnWalkman.TabIndex = 7;
            this.btnWalkman.Text = "Walkman";
            this.btnWalkman.UseVisualStyleBackColor = false;
            this.btnWalkman.Click += new System.EventHandler(this.btnWalkman_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Yellow;
            this.btnReturn.Location = new System.Drawing.Point(247, 402);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(221, 36);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPlutonium
            // 
            this.btnPlutonium.BackColor = System.Drawing.Color.Transparent;
            this.btnPlutonium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlutonium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlutonium.ForeColor = System.Drawing.Color.Yellow;
            this.btnPlutonium.Location = new System.Drawing.Point(247, 303);
            this.btnPlutonium.Name = "btnPlutonium";
            this.btnPlutonium.Size = new System.Drawing.Size(221, 36);
            this.btnPlutonium.TabIndex = 5;
            this.btnPlutonium.Text = "Plutonium";
            this.btnPlutonium.UseVisualStyleBackColor = false;
            this.btnPlutonium.Click += new System.EventHandler(this.btnPlutonium_Click);
            // 
            // Plutoniumtxt
            // 
            this.Plutoniumtxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.Plutoniumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plutoniumtxt.ForeColor = System.Drawing.Color.Maroon;
            this.Plutoniumtxt.Location = new System.Drawing.Point(247, 171);
            this.Plutoniumtxt.Multiline = true;
            this.Plutoniumtxt.Name = "Plutoniumtxt";
            this.Plutoniumtxt.Size = new System.Drawing.Size(193, 109);
            this.Plutoniumtxt.TabIndex = 8;
            this.Plutoniumtxt.Text = "I see you remembered the Delorean runs on nuclear power now.  Still happy about t" +
    "hat other \"fuel\"?\r\n";
            this.Plutoniumtxt.Visible = false;
            this.Plutoniumtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Walkmantxt
            // 
            this.Walkmantxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.Walkmantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walkmantxt.ForeColor = System.Drawing.Color.Maroon;
            this.Walkmantxt.Location = new System.Drawing.Point(247, 171);
            this.Walkmantxt.Multiline = true;
            this.Walkmantxt.Name = "Walkmantxt";
            this.Walkmantxt.Size = new System.Drawing.Size(193, 109);
            this.Walkmantxt.TabIndex = 9;
            this.Walkmantxt.Text = "You really want to buy a 1980s walkman in 2021??";
            this.Walkmantxt.Visible = false;
            // 
            // BuyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.Walkmantxt);
            this.Controls.Add(this.Plutoniumtxt);
            this.Controls.Add(this.btnWalkman);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPlutonium);
            this.Controls.Add(this.buyPrompt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuyMenu";
            this.Text = "BuyMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buyPrompt;
        private System.Windows.Forms.Button btnWalkman;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPlutonium;
        private System.Windows.Forms.TextBox Plutoniumtxt;
        private System.Windows.Forms.TextBox Walkmantxt;
    }
}