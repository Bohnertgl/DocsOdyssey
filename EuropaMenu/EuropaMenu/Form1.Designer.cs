
namespace EuropaMenu
{
    partial class EuropaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EuropaMenu));
            this.lblEuropa = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEuropa
            // 
            this.lblEuropa.AutoSize = true;
            this.lblEuropa.BackColor = System.Drawing.Color.Transparent;
            this.lblEuropa.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuropa.ForeColor = System.Drawing.Color.Yellow;
            this.lblEuropa.Location = new System.Drawing.Point(189, 106);
            this.lblEuropa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblEuropa.Name = "lblEuropa";
            this.lblEuropa.Size = new System.Drawing.Size(213, 29);
            this.lblEuropa.TabIndex = 0;
            this.lblEuropa.Text = "Welcome to Europa!";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblPrompt.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrompt.Location = new System.Drawing.Point(174, 135);
            this.lblPrompt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(245, 29);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Please make a selection";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.Yellow;
            this.btnBuy.Location = new System.Drawing.Point(185, 247);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(166, 29);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.Yellow;
            this.btnSell.Location = new System.Drawing.Point(185, 286);
            this.btnSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(166, 29);
            this.btnSell.TabIndex = 3;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.Color.Yellow;
            this.btnLeave.Location = new System.Drawing.Point(185, 327);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(166, 29);
            this.btnLeave.TabIndex = 4;
            this.btnLeave.Text = "Leave Planet";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // EuropaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 449);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblEuropa);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "EuropaMenu";
            this.Text = "EuropaMenu";
            this.Load += new System.EventHandler(this.EuropaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuropa;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnLeave;
    }
}

