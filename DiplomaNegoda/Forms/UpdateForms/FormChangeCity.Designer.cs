namespace DiplomaNegoda.Forms.UpdateForms
{
    partial class FormChangeCity
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
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonChangeCity = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(353, 32);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 23;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeCity
            // 
            this.ButtonChangeCity.Location = new System.Drawing.Point(15, 32);
            this.ButtonChangeCity.Name = "ButtonChangeCity";
            this.ButtonChangeCity.Size = new System.Drawing.Size(75, 23);
            this.ButtonChangeCity.TabIndex = 22;
            this.ButtonChangeCity.Text = "Изменить";
            this.ButtonChangeCity.UseVisualStyleBackColor = true;
            this.ButtonChangeCity.Click += new System.EventHandler(this.ButtonChangeCity_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(78, 6);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(350, 20);
            this.TextBoxName.TabIndex = 21;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(60, 13);
            this.LabelName.TabIndex = 20;
            this.LabelName.Text = "Название:";
            // 
            // FormChangeCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 67);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonChangeCity);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Name = "FormChangeCity";
            this.Text = "Изменить город";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonChangeCity;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
    }
}