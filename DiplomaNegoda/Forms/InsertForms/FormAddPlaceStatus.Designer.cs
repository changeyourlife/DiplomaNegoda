namespace DiplomaNegoda.Forms.InsertForms
{
    partial class FormAddPlaceStatus
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
            this.ButtonAddTicketStatus = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Location = new System.Drawing.Point(228, 32);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(75, 23);
            this.ButtonCloseForm.TabIndex = 19;
            this.ButtonCloseForm.Text = "Закрыть";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            // 
            // ButtonAddTicketStatus
            // 
            this.ButtonAddTicketStatus.Location = new System.Drawing.Point(15, 32);
            this.ButtonAddTicketStatus.Name = "ButtonAddTicketStatus";
            this.ButtonAddTicketStatus.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddTicketStatus.TabIndex = 18;
            this.ButtonAddTicketStatus.Text = "Добавить";
            this.ButtonAddTicketStatus.UseVisualStyleBackColor = true;
            this.ButtonAddTicketStatus.Click += new System.EventHandler(this.ButtonAddTicketStatus_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(78, 6);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(225, 20);
            this.TextBoxName.TabIndex = 17;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(60, 13);
            this.LabelName.TabIndex = 16;
            this.LabelName.Text = "Название:";
            // 
            // FormAddPlaceStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 65);
            this.Controls.Add(this.ButtonCloseForm);
            this.Controls.Add(this.ButtonAddTicketStatus);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Name = "FormAddPlaceStatus";
            this.Text = "Добавить статус места";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseForm;
        private System.Windows.Forms.Button ButtonAddTicketStatus;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
    }
}