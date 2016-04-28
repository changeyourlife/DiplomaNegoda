namespace DiplomaNegoda.Forms.InsertForms
{
    partial class FormAddClassPlace
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
            this.ButtonAddClassPlace = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(353, 32);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 27;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonAddClassPlace
            // 
            this.ButtonAddClassPlace.Location = new System.Drawing.Point(15, 32);
            this.ButtonAddClassPlace.Name = "ButtonAddClassPlace";
            this.ButtonAddClassPlace.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddClassPlace.TabIndex = 26;
            this.ButtonAddClassPlace.Text = "Добавить";
            this.ButtonAddClassPlace.UseVisualStyleBackColor = true;
            this.ButtonAddClassPlace.Click += new System.EventHandler(this.ButtonAddClassPlace_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(78, 6);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(350, 20);
            this.TextBoxName.TabIndex = 25;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(60, 13);
            this.LabelName.TabIndex = 24;
            this.LabelName.Text = "Название:";
            // 
            // FormAddClassPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 65);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAddClassPlace);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Name = "FormAddClassPlace";
            this.Text = "Добавить класс места";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonAddClassPlace;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
    }
}