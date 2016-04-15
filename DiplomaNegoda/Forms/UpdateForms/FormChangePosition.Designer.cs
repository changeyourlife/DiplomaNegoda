namespace DiplomaNegoda.Forms.UpdateForms
{
    partial class FormChangePosition
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
            this.ButtonChangePosition = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Location = new System.Drawing.Point(228, 32);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(75, 23);
            this.ButtonCloseForm.TabIndex = 11;
            this.ButtonCloseForm.Text = "Close";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            // 
            // ButtonChangePosition
            // 
            this.ButtonChangePosition.Location = new System.Drawing.Point(15, 32);
            this.ButtonChangePosition.Name = "ButtonChangePosition";
            this.ButtonChangePosition.Size = new System.Drawing.Size(75, 23);
            this.ButtonChangePosition.TabIndex = 10;
            this.ButtonChangePosition.Text = "Change";
            this.ButtonChangePosition.UseVisualStyleBackColor = true;
            this.ButtonChangePosition.Click += new System.EventHandler(this.ButtonChangePosition_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(59, 6);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(244, 20);
            this.TextBoxName.TabIndex = 9;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 8;
            this.LabelName.Text = "Name:";
            // 
            // FormChangePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 68);
            this.Controls.Add(this.ButtonCloseForm);
            this.Controls.Add(this.ButtonChangePosition);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Name = "FormChangePosition";
            this.Text = "ChangePosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseForm;
        private System.Windows.Forms.Button ButtonChangePosition;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
    }
}