
namespace VenusMenu
{
    partial class VenusBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenusBuy));
            this.lblBuy = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAlmanac = new System.Windows.Forms.Button();
            this.btnFuel = new System.Windows.Forms.Button();
            this.fuelText = new System.Windows.Forms.TextBox();
            this.almanacTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.BackColor = System.Drawing.Color.Transparent;
            this.lblBuy.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.ForeColor = System.Drawing.Color.Yellow;
            this.lblBuy.Location = new System.Drawing.Point(145, 110);
            this.lblBuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(428, 36);
            this.lblBuy.TabIndex = 0;
            this.lblBuy.Text = "What items would you like to buy?";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Yellow;
            this.btnReturn.Location = new System.Drawing.Point(247, 402);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(202, 50);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAlmanac
            // 
            this.btnAlmanac.BackColor = System.Drawing.Color.Transparent;
            this.btnAlmanac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlmanac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmanac.ForeColor = System.Drawing.Color.Yellow;
            this.btnAlmanac.Location = new System.Drawing.Point(247, 351);
            this.btnAlmanac.Name = "btnAlmanac";
            this.btnAlmanac.Size = new System.Drawing.Size(202, 50);
            this.btnAlmanac.TabIndex = 6;
            this.btnAlmanac.Text = "Almanac";
            this.btnAlmanac.UseVisualStyleBackColor = false;
            this.btnAlmanac.Click += new System.EventHandler(this.btnAlmanac_Click);
            // 
            // btnFuel
            // 
            this.btnFuel.BackColor = System.Drawing.Color.Transparent;
            this.btnFuel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuel.ForeColor = System.Drawing.Color.Yellow;
            this.btnFuel.Location = new System.Drawing.Point(247, 303);
            this.btnFuel.Name = "btnFuel";
            this.btnFuel.Size = new System.Drawing.Size(202, 50);
            this.btnFuel.TabIndex = 5;
            this.btnFuel.Text = "Fuel";
            this.btnFuel.UseVisualStyleBackColor = false;
            this.btnFuel.Click += new System.EventHandler(this.btnFuel_Click);
            // 
            // fuelText
            // 
            this.fuelText.BackColor = System.Drawing.Color.Black;
            this.fuelText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fuelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelText.ForeColor = System.Drawing.Color.Maroon;
            this.fuelText.Location = new System.Drawing.Point(99, 164);
            this.fuelText.Multiline = true;
            this.fuelText.Name = "fuelText";
            this.fuelText.Size = new System.Drawing.Size(521, 101);
            this.fuelText.TabIndex = 8;
            this.fuelText.Text = "Congratulations you have refueled your Delorean Hopefully You got the right Octan" +
    "e.";
            this.fuelText.Visible = false;
            // 
            // almanacTxt
            // 
            this.almanacTxt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.almanacTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.almanacTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.almanacTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almanacTxt.ForeColor = System.Drawing.Color.Maroon;
            this.almanacTxt.Location = new System.Drawing.Point(99, 164);
            this.almanacTxt.Multiline = true;
            this.almanacTxt.Name = "almanacTxt";
            this.almanacTxt.Size = new System.Drawing.Size(521, 101);
            this.almanacTxt.TabIndex = 9;
            this.almanacTxt.Text = "Didn\'t we learn in the Second movie that this is a bad idea????";
            this.almanacTxt.Visible = false;
            // 
            // VenusBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.almanacTxt);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAlmanac);
            this.Controls.Add(this.btnFuel);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.fuelText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "VenusBuy";
            this.Text = "VenusBuy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAlmanac;
        private System.Windows.Forms.Button btnFuel;
        private System.Windows.Forms.TextBox fuelText;
        private System.Windows.Forms.TextBox almanacTxt;
    }
}