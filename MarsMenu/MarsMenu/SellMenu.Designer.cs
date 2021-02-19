
namespace MarsMenu
{
    partial class SellMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellMenu));
            this.lblSell = new System.Windows.Forms.Label();
            this.btnGuitar = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPeacemaker = new System.Windows.Forms.Button();
            this.Colttxt = new System.Windows.Forms.TextBox();
            this.Guitartxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.BackColor = System.Drawing.Color.Black;
            this.lblSell.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.ForeColor = System.Drawing.Color.Yellow;
            this.lblSell.Location = new System.Drawing.Point(145, 110);
            this.lblSell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(422, 36);
            this.lblSell.TabIndex = 0;
            this.lblSell.Text = "What items would you like to sell?";
            // 
            // btnGuitar
            // 
            this.btnGuitar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuitar.ForeColor = System.Drawing.Color.Yellow;
            this.btnGuitar.Location = new System.Drawing.Point(247, 351);
            this.btnGuitar.Name = "btnGuitar";
            this.btnGuitar.Size = new System.Drawing.Size(221, 36);
            this.btnGuitar.TabIndex = 10;
            this.btnGuitar.Text = "Marty\'s Guitar";
            this.btnGuitar.UseVisualStyleBackColor = false;
            this.btnGuitar.Click += new System.EventHandler(this.btnGuitar_Click);
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
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPeacemaker
            // 
            this.btnPeacemaker.BackColor = System.Drawing.Color.Transparent;
            this.btnPeacemaker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPeacemaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeacemaker.ForeColor = System.Drawing.Color.Yellow;
            this.btnPeacemaker.Location = new System.Drawing.Point(247, 303);
            this.btnPeacemaker.Name = "btnPeacemaker";
            this.btnPeacemaker.Size = new System.Drawing.Size(221, 36);
            this.btnPeacemaker.TabIndex = 8;
            this.btnPeacemaker.Text = "Colt Peacemaker";
            this.btnPeacemaker.UseVisualStyleBackColor = false;
            this.btnPeacemaker.Click += new System.EventHandler(this.btnPeacemaker_Click);
            // 
            // Colttxt
            // 
            this.Colttxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.Colttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colttxt.ForeColor = System.Drawing.Color.Yellow;
            this.Colttxt.Location = new System.Drawing.Point(276, 149);
            this.Colttxt.Multiline = true;
            this.Colttxt.Name = "Colttxt";
            this.Colttxt.Size = new System.Drawing.Size(134, 85);
            this.Colttxt.TabIndex = 11;
            this.Colttxt.Text = "What\'s wrong, you YELLOW??";
            this.Colttxt.Visible = false;
            // 
            // Guitartxt
            // 
            this.Guitartxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.Guitartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guitartxt.ForeColor = System.Drawing.Color.Maroon;
            this.Guitartxt.Location = new System.Drawing.Point(256, 149);
            this.Guitartxt.Multiline = true;
            this.Guitartxt.Name = "Guitartxt";
            this.Guitartxt.Size = new System.Drawing.Size(196, 109);
            this.Guitartxt.TabIndex = 12;
            this.Guitartxt.Text = "Guess you\'re not ready for it yet but your kids are gonna love it!";
            this.Guitartxt.Visible = false;
            // 
            // SellMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.Guitartxt);
            this.Controls.Add(this.Colttxt);
            this.Controls.Add(this.btnGuitar);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPeacemaker);
            this.Controls.Add(this.lblSell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SellMenu";
            this.Text = "SellMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Button btnGuitar;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPeacemaker;
        private System.Windows.Forms.TextBox Colttxt;
        private System.Windows.Forms.TextBox Guitartxt;
    }
}