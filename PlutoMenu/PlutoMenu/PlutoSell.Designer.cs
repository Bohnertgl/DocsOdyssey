
namespace PlutoMenu
{
    partial class PlutoSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlutoSell));
            this.lblSell = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnJacket = new System.Windows.Forms.Button();
            this.btnVest = new System.Windows.Forms.Button();
            this.Vesttxt = new System.Windows.Forms.TextBox();
            this.Jackettxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.BackColor = System.Drawing.Color.Transparent;
            this.lblSell.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.ForeColor = System.Drawing.Color.Yellow;
            this.lblSell.Location = new System.Drawing.Point(145, 110);
            this.lblSell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(422, 36);
            this.lblSell.TabIndex = 2;
            this.lblSell.Text = "What items would you like to sell?";
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
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnJacket
            // 
            this.btnJacket.BackColor = System.Drawing.Color.Transparent;
            this.btnJacket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJacket.ForeColor = System.Drawing.Color.Yellow;
            this.btnJacket.Location = new System.Drawing.Point(247, 351);
            this.btnJacket.Name = "btnJacket";
            this.btnJacket.Size = new System.Drawing.Size(221, 36);
            this.btnJacket.TabIndex = 9;
            this.btnJacket.Text = "Marty\'s Jacket";
            this.btnJacket.UseVisualStyleBackColor = false;
            this.btnJacket.Click += new System.EventHandler(this.btnJacket_Click);
            // 
            // btnVest
            // 
            this.btnVest.BackColor = System.Drawing.Color.Transparent;
            this.btnVest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVest.ForeColor = System.Drawing.Color.Yellow;
            this.btnVest.Location = new System.Drawing.Point(247, 303);
            this.btnVest.Name = "btnVest";
            this.btnVest.Size = new System.Drawing.Size(221, 36);
            this.btnVest.TabIndex = 8;
            this.btnVest.Text = "Marty\'s Vest";
            this.btnVest.UseVisualStyleBackColor = false;
            this.btnVest.Click += new System.EventHandler(this.btnVest_Click);
            // 
            // Vesttxt
            // 
            this.Vesttxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.Vesttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vesttxt.ForeColor = System.Drawing.Color.Yellow;
            this.Vesttxt.Location = new System.Drawing.Point(188, 149);
            this.Vesttxt.Multiline = true;
            this.Vesttxt.Name = "Vesttxt";
            this.Vesttxt.Size = new System.Drawing.Size(316, 57);
            this.Vesttxt.TabIndex = 11;
            this.Vesttxt.Text = "Doesn\'t really work with the space suit, does it?";
            this.Vesttxt.Visible = false;
            // 
            // Jackettxt
            // 
            this.Jackettxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.Jackettxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jackettxt.ForeColor = System.Drawing.Color.Yellow;
            this.Jackettxt.Location = new System.Drawing.Point(179, 149);
            this.Jackettxt.Multiline = true;
            this.Jackettxt.Name = "Jackettxt";
            this.Jackettxt.Size = new System.Drawing.Size(335, 152);
            this.Jackettxt.TabIndex = 12;
            this.Jackettxt.Text = " Selling this might actually be the cause of Marty-mageddon.  Wait, how does time" +
    " travel work again?  Sell now, have later, but not if I sold later because I hav" +
    "e now?";
            this.Jackettxt.Visible = false;
            // 
            // PlutoSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.Jackettxt);
            this.Controls.Add(this.Vesttxt);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnJacket);
            this.Controls.Add(this.btnVest);
            this.Controls.Add(this.lblSell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "PlutoSell";
            this.Text = "PlutoSell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnJacket;
        private System.Windows.Forms.Button btnVest;
        private System.Windows.Forms.TextBox Vesttxt;
        private System.Windows.Forms.TextBox Jackettxt;
    }
}