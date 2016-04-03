namespace DiplomaNegoda.Forms.InsertForms
{
    partial class FormAddAviacompany
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
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ButtonAddAviacompany = new System.Windows.Forms.Button();
            this.ButtonCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(9, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(56, 6);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(244, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // ButtonAddAviacompany
            // 
            this.ButtonAddAviacompany.Location = new System.Drawing.Point(12, 32);
            this.ButtonAddAviacompany.Name = "ButtonAddAviacompany";
            this.ButtonAddAviacompany.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddAviacompany.TabIndex = 2;
            this.ButtonAddAviacompany.Text = "Add";
            this.ButtonAddAviacompany.UseVisualStyleBackColor = true;
            this.ButtonAddAviacompany.Click += new System.EventHandler(this.ButtonAddAviacompany_Click);
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Location = new System.Drawing.Point(225, 32);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(75, 23);
            this.ButtonCloseForm.TabIndex = 3;
            this.ButtonCloseForm.Text = "Close";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            // 
            // AddAviacompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 64);
            this.Controls.Add(this.ButtonCloseForm);
            this.Controls.Add(this.ButtonAddAviacompany);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Name = "AddAviacompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAviacompany";
            this.Shown += new System.EventHandler(this.AddAviacompany_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Button ButtonAddAviacompany;
        private System.Windows.Forms.Button ButtonCloseForm;
    }
}