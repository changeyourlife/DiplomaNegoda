namespace DiplomaNegoda.Forms.Cassier
{
    partial class FormSellTicket
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
            this.LabelFIO = new System.Windows.Forms.Label();
            this.TextBoxFIO = new System.Windows.Forms.TextBox();
            this.LabelPersonalDataSpecial = new System.Windows.Forms.Label();
            this.TextBoxPersonalDataSpecial = new System.Windows.Forms.TextBox();
            this.ButtonSellTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFIO
            // 
            this.LabelFIO.AutoSize = true;
            this.LabelFIO.Location = new System.Drawing.Point(94, 9);
            this.LabelFIO.Name = "LabelFIO";
            this.LabelFIO.Size = new System.Drawing.Size(53, 13);
            this.LabelFIO.TabIndex = 0;
            this.LabelFIO.Text = "LabelFIO:";
            // 
            // TextBoxFIO
            // 
            this.TextBoxFIO.Location = new System.Drawing.Point(153, 6);
            this.TextBoxFIO.Name = "TextBoxFIO";
            this.TextBoxFIO.Size = new System.Drawing.Size(323, 20);
            this.TextBoxFIO.TabIndex = 1;
            // 
            // LabelPersonalDataSpecial
            // 
            this.LabelPersonalDataSpecial.AutoSize = true;
            this.LabelPersonalDataSpecial.Location = new System.Drawing.Point(12, 35);
            this.LabelPersonalDataSpecial.Name = "LabelPersonalDataSpecial";
            this.LabelPersonalDataSpecial.Size = new System.Drawing.Size(135, 13);
            this.LabelPersonalDataSpecial.TabIndex = 2;
            this.LabelPersonalDataSpecial.Text = "LabelPersonalDataSpecial:";
            // 
            // TextBoxPersonalDataSpecial
            // 
            this.TextBoxPersonalDataSpecial.Location = new System.Drawing.Point(153, 32);
            this.TextBoxPersonalDataSpecial.Name = "TextBoxPersonalDataSpecial";
            this.TextBoxPersonalDataSpecial.Size = new System.Drawing.Size(323, 20);
            this.TextBoxPersonalDataSpecial.TabIndex = 3;
            // 
            // ButtonSellTicket
            // 
            this.ButtonSellTicket.Location = new System.Drawing.Point(15, 58);
            this.ButtonSellTicket.Name = "ButtonSellTicket";
            this.ButtonSellTicket.Size = new System.Drawing.Size(461, 39);
            this.ButtonSellTicket.TabIndex = 4;
            this.ButtonSellTicket.Text = "Sell Ticket";
            this.ButtonSellTicket.UseVisualStyleBackColor = true;
            this.ButtonSellTicket.Click += new System.EventHandler(this.ButtonSellTicket_Click);
            // 
            // FormSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 109);
            this.Controls.Add(this.ButtonSellTicket);
            this.Controls.Add(this.TextBoxPersonalDataSpecial);
            this.Controls.Add(this.LabelPersonalDataSpecial);
            this.Controls.Add(this.TextBoxFIO);
            this.Controls.Add(this.LabelFIO);
            this.Name = "FormSellTicket";
            this.Text = "FormSellTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFIO;
        private System.Windows.Forms.TextBox TextBoxFIO;
        private System.Windows.Forms.Label LabelPersonalDataSpecial;
        private System.Windows.Forms.TextBox TextBoxPersonalDataSpecial;
        private System.Windows.Forms.Button ButtonSellTicket;
    }
}