namespace DiplomaNegoda.Forms.UpdateForms
{
    partial class FormChangePlaceStatus
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
            this.ButtonCloseForm = new System.Windows.Forms.Button();
            this.ButtonChangeTicketStatus = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Location = new System.Drawing.Point(228, 32);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(75, 23);
            this.ButtonCloseForm.TabIndex = 15;
            this.ButtonCloseForm.Text = "Закрыть";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeTicketStatus
            // 
            this.ButtonChangeTicketStatus.Location = new System.Drawing.Point(15, 32);
            this.ButtonChangeTicketStatus.Name = "ButtonChangeTicketStatus";
            this.ButtonChangeTicketStatus.Size = new System.Drawing.Size(75, 23);
            this.ButtonChangeTicketStatus.TabIndex = 14;
            this.ButtonChangeTicketStatus.Text = "Изменить";
            this.ButtonChangeTicketStatus.UseVisualStyleBackColor = true;
            this.ButtonChangeTicketStatus.Click += new System.EventHandler(this.ButtonChangeTicketStatus_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(78, 6);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(225, 20);
            this.TextBoxName.TabIndex = 13;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(60, 13);
            this.LabelName.TabIndex = 12;
            this.LabelName.Text = "Название:";
            // 
            // FormChangePlaceStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 63);
            this.Controls.Add(this.ButtonCloseForm);
            this.Controls.Add(this.ButtonChangeTicketStatus);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Name = "FormChangePlaceStatus";
            this.Text = "Изменить статус места";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseForm;
        private System.Windows.Forms.Button ButtonChangeTicketStatus;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
    }
}