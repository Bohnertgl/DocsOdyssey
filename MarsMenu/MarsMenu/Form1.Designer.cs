
namespace MarsMenu
{
    partial class marsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marsMenu));
            this.marsWelcome = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // marsWelcome
            // 
            this.marsWelcome.AutoSize = true;
            this.marsWelcome.BackColor = System.Drawing.Color.Transparent;
            this.marsWelcome.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marsWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.marsWelcome.Location = new System.Drawing.Point(252, 130);
            this.marsWelcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.marsWelcome.Name = "marsWelcome";
            this.marsWelcome.Size = new System.Drawing.Size(226, 36);
            this.marsWelcome.TabIndex = 0;
            this.marsWelcome.Text = "Welcome to Mars!";
            this.marsWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblPrompt.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrompt.Location = new System.Drawing.Point(232, 166);
            this.lblPrompt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(284, 36);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Please make a selection";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.Yellow;
            this.btnBuy.Location = new System.Drawing.Point(247, 304);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(221, 36);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.Color.Yellow;
            this.btnLeave.Location = new System.Drawing.Point(247, 402);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(221, 36);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "Leave Planet";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.Yellow;
            this.btnSell.Location = new System.Drawing.Point(247, 352);
            this.btnSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(221, 36);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // marsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.marsWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "marsMenu";
            this.Text = "Mars";
            this.Load += new System.EventHandler(this.marsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label marsWelcome;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnSell;
    }
}

