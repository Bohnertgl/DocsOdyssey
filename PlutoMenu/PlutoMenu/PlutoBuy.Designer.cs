
namespace PlutoMenu
{
    partial class PlutoBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlutoBuy));
            this.lblBuy = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClocktower = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.Controltxt = new System.Windows.Forms.TextBox();
            this.Clocktxt = new System.Windows.Forms.TextBox();
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
            this.lblBuy.TabIndex = 1;
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
            this.btnReturn.Size = new System.Drawing.Size(221, 36);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClocktower
            // 
            this.btnClocktower.BackColor = System.Drawing.Color.Transparent;
            this.btnClocktower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClocktower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClocktower.ForeColor = System.Drawing.Color.Yellow;
            this.btnClocktower.Location = new System.Drawing.Point(247, 351);
            this.btnClocktower.Name = "btnClocktower";
            this.btnClocktower.Size = new System.Drawing.Size(221, 36);
            this.btnClocktower.TabIndex = 6;
            this.btnClocktower.Text = "Clocktower Replica";
            this.btnClocktower.UseVisualStyleBackColor = false;
            this.btnClocktower.Click += new System.EventHandler(this.btnClocktower_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanel.ForeColor = System.Drawing.Color.Yellow;
            this.btnPanel.Location = new System.Drawing.Point(247, 303);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(221, 36);
            this.btnPanel.TabIndex = 5;
            this.btnPanel.Text = "Control Panel";
            this.btnPanel.UseVisualStyleBackColor = false;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // Controltxt
            // 
            this.Controltxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.Controltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controltxt.ForeColor = System.Drawing.Color.Maroon;
            this.Controltxt.Location = new System.Drawing.Point(214, 142);
            this.Controltxt.Multiline = true;
            this.Controltxt.Name = "Controltxt";
            this.Controltxt.Size = new System.Drawing.Size(317, 149);
            this.Controltxt.TabIndex = 8;
            this.Controltxt.Text = "Probably should have read what kind of control panel before buying this.  Do you " +
    "even own or know what a Furby is?";
            this.Controltxt.Visible = false;
            this.Controltxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Clocktxt
            // 
            this.Clocktxt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Clocktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clocktxt.ForeColor = System.Drawing.Color.Maroon;
            this.Clocktxt.Location = new System.Drawing.Point(249, 149);
            this.Clocktxt.Multiline = true;
            this.Clocktxt.Name = "Clocktxt";
            this.Clocktxt.Size = new System.Drawing.Size(219, 57);
            this.Clocktxt.TabIndex = 9;
            this.Clocktxt.Text = "The key word here is \"replica\"";
            this.Clocktxt.Visible = false;
            // 
            // PlutoBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.Clocktxt);
            this.Controls.Add(this.Controltxt);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnClocktower);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.lblBuy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "PlutoBuy";
            this.Text = "PlutoBuy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClocktower;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.TextBox Controltxt;
        private System.Windows.Forms.TextBox Clocktxt;
    }
}