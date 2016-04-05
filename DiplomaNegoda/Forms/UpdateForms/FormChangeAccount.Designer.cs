namespace DiplomaNegoda.Forms.UpdateForms
{
    partial class FormChangeAccount
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
            this.ButtonChangeAccount = new System.Windows.Forms.Button();
            this.ComboBoxPosition = new System.Windows.Forms.ComboBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.LabelPosition = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.ComboBoxWorker = new System.Windows.Forms.ComboBox();
            this.LabelWorker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(342, 122);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 19;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeAccount
            // 
            this.ButtonChangeAccount.Location = new System.Drawing.Point(4, 122);
            this.ButtonChangeAccount.Name = "ButtonChangeAccount";
            this.ButtonChangeAccount.Size = new System.Drawing.Size(75, 23);
            this.ButtonChangeAccount.TabIndex = 18;
            this.ButtonChangeAccount.Text = "Change";
            this.ButtonChangeAccount.UseVisualStyleBackColor = true;
            this.ButtonChangeAccount.Click += new System.EventHandler(this.ButtonChangeAccount_Click);
            // 
            // ComboBoxPosition
            // 
            this.ComboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPosition.FormattingEnabled = true;
            this.ComboBoxPosition.Location = new System.Drawing.Point(61, 85);
            this.ComboBoxPosition.Name = "ComboBoxPosition";
            this.ComboBoxPosition.Size = new System.Drawing.Size(356, 21);
            this.ComboBoxPosition.TabIndex = 17;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(61, 59);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(356, 20);
            this.TextBoxPassword.TabIndex = 16;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(61, 33);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(356, 20);
            this.TextBoxLogin.TabIndex = 15;
            // 
            // LabelPosition
            // 
            this.LabelPosition.AutoSize = true;
            this.LabelPosition.Location = new System.Drawing.Point(8, 88);
            this.LabelPosition.Name = "LabelPosition";
            this.LabelPosition.Size = new System.Drawing.Size(47, 13);
            this.LabelPosition.TabIndex = 14;
            this.LabelPosition.Text = "Position:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(1, 62);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(56, 13);
            this.LabelPassword.TabIndex = 13;
            this.LabelPassword.Text = "Password:";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(19, 36);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(36, 13);
            this.LabelLogin.TabIndex = 12;
            this.LabelLogin.Text = "Login:";
            // 
            // ComboBoxWorker
            // 
            this.ComboBoxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxWorker.FormattingEnabled = true;
            this.ComboBoxWorker.Location = new System.Drawing.Point(61, 6);
            this.ComboBoxWorker.Name = "ComboBoxWorker";
            this.ComboBoxWorker.Size = new System.Drawing.Size(356, 21);
            this.ComboBoxWorker.TabIndex = 11;
            // 
            // LabelWorker
            // 
            this.LabelWorker.AutoSize = true;
            this.LabelWorker.Location = new System.Drawing.Point(12, 9);
            this.LabelWorker.Name = "LabelWorker";
            this.LabelWorker.Size = new System.Drawing.Size(45, 13);
            this.LabelWorker.TabIndex = 10;
            this.LabelWorker.Text = "Worker:";
            // 
            // FormChangeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 154);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonChangeAccount);
            this.Controls.Add(this.ComboBoxPosition);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.LabelPosition);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.ComboBoxWorker);
            this.Controls.Add(this.LabelWorker);
            this.Name = "FormChangeAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangeAccount";
            this.Shown += new System.EventHandler(this.FormChangeAccount_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonChangeAccount;
        private System.Windows.Forms.ComboBox ComboBoxPosition;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label LabelPosition;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.ComboBox ComboBoxWorker;
        private System.Windows.Forms.Label LabelWorker;
    }
}