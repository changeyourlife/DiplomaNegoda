namespace DiplomaNegoda.Forms.InsertForms
{
    partial class FormAddAccount
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
            this.LabelWorker = new System.Windows.Forms.Label();
            this.ComboBoxWorker = new System.Windows.Forms.ComboBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelPosition = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ComboBoxPosition = new System.Windows.Forms.ComboBox();
            this.ButtonAddAccount = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelWorker
            // 
            this.LabelWorker.AutoSize = true;
            this.LabelWorker.Location = new System.Drawing.Point(-3, 9);
            this.LabelWorker.Name = "LabelWorker";
            this.LabelWorker.Size = new System.Drawing.Size(58, 13);
            this.LabelWorker.TabIndex = 0;
            this.LabelWorker.Text = "Работник:";
            // 
            // ComboBoxWorker
            // 
            this.ComboBoxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxWorker.FormattingEnabled = true;
            this.ComboBoxWorker.Location = new System.Drawing.Point(61, 6);
            this.ComboBoxWorker.Name = "ComboBoxWorker";
            this.ComboBoxWorker.Size = new System.Drawing.Size(356, 21);
            this.ComboBoxWorker.TabIndex = 1;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(14, 36);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(41, 13);
            this.LabelLogin.TabIndex = 2;
            this.LabelLogin.Text = "Логин:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(7, 62);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(48, 13);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Пароль:";
            // 
            // LabelPosition
            // 
            this.LabelPosition.AutoSize = true;
            this.LabelPosition.Location = new System.Drawing.Point(1, 88);
            this.LabelPosition.Name = "LabelPosition";
            this.LabelPosition.Size = new System.Drawing.Size(54, 13);
            this.LabelPosition.TabIndex = 4;
            this.LabelPosition.Text = "Позиция:";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(61, 33);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(356, 20);
            this.TextBoxLogin.TabIndex = 5;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(61, 59);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(356, 20);
            this.TextBoxPassword.TabIndex = 6;
            // 
            // ComboBoxPosition
            // 
            this.ComboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPosition.FormattingEnabled = true;
            this.ComboBoxPosition.Location = new System.Drawing.Point(61, 85);
            this.ComboBoxPosition.Name = "ComboBoxPosition";
            this.ComboBoxPosition.Size = new System.Drawing.Size(356, 21);
            this.ComboBoxPosition.TabIndex = 7;
            // 
            // ButtonAddAccount
            // 
            this.ButtonAddAccount.Location = new System.Drawing.Point(4, 122);
            this.ButtonAddAccount.Name = "ButtonAddAccount";
            this.ButtonAddAccount.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddAccount.TabIndex = 8;
            this.ButtonAddAccount.Text = "Добавить";
            this.ButtonAddAccount.UseVisualStyleBackColor = true;
            this.ButtonAddAccount.Click += new System.EventHandler(this.ButtonAddAccount_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(342, 122);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 9;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 154);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAddAccount);
            this.Controls.Add(this.ComboBoxPosition);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.LabelPosition);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.ComboBoxWorker);
            this.Controls.Add(this.LabelWorker);
            this.Name = "FormAddAccount";
            this.Text = "Добавить аккаунт";
            this.Shown += new System.EventHandler(this.FormAddAccount_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWorker;
        private System.Windows.Forms.ComboBox ComboBoxWorker;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelPosition;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.ComboBox ComboBoxPosition;
        private System.Windows.Forms.Button ButtonAddAccount;
        private System.Windows.Forms.Button ButtonClose;
    }
}