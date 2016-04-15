namespace DiplomaNegoda.Forms.UpdateForms
{
    partial class FormChangeWorker
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
            this.DateTimePickerBornDate = new System.Windows.Forms.DateTimePicker();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonChangeWorker = new System.Windows.Forms.Button();
            this.TextBoxContactData = new System.Windows.Forms.TextBox();
            this.DateTimePickerArriveDate = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxPositionID = new System.Windows.Forms.ComboBox();
            this.TextBoxFIO = new System.Windows.Forms.TextBox();
            this.LabelContactData = new System.Windows.Forms.Label();
            this.LabelArriveDate = new System.Windows.Forms.Label();
            this.LabelPositionID = new System.Windows.Forms.Label();
            this.LabelBornDate = new System.Windows.Forms.Label();
            this.LabelFIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTimePickerBornDate
            // 
            this.DateTimePickerBornDate.Location = new System.Drawing.Point(89, 32);
            this.DateTimePickerBornDate.Name = "DateTimePickerBornDate";
            this.DateTimePickerBornDate.Size = new System.Drawing.Size(406, 20);
            this.DateTimePickerBornDate.TabIndex = 24;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(420, 137);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 23;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeWorker
            // 
            this.ButtonChangeWorker.Location = new System.Drawing.Point(16, 137);
            this.ButtonChangeWorker.Name = "ButtonChangeWorker";
            this.ButtonChangeWorker.Size = new System.Drawing.Size(75, 23);
            this.ButtonChangeWorker.TabIndex = 22;
            this.ButtonChangeWorker.Text = "Change";
            this.ButtonChangeWorker.UseVisualStyleBackColor = true;
            this.ButtonChangeWorker.Click += new System.EventHandler(this.ButtonChangeWorker_Click);
            // 
            // TextBoxContactData
            // 
            this.TextBoxContactData.Location = new System.Drawing.Point(89, 111);
            this.TextBoxContactData.Name = "TextBoxContactData";
            this.TextBoxContactData.Size = new System.Drawing.Size(406, 20);
            this.TextBoxContactData.TabIndex = 21;
            // 
            // DateTimePickerArriveDate
            // 
            this.DateTimePickerArriveDate.Location = new System.Drawing.Point(89, 85);
            this.DateTimePickerArriveDate.Name = "DateTimePickerArriveDate";
            this.DateTimePickerArriveDate.Size = new System.Drawing.Size(406, 20);
            this.DateTimePickerArriveDate.TabIndex = 20;
            // 
            // ComboBoxPositionID
            // 
            this.ComboBoxPositionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPositionID.FormattingEnabled = true;
            this.ComboBoxPositionID.Location = new System.Drawing.Point(89, 58);
            this.ComboBoxPositionID.Name = "ComboBoxPositionID";
            this.ComboBoxPositionID.Size = new System.Drawing.Size(406, 21);
            this.ComboBoxPositionID.TabIndex = 19;
            // 
            // TextBoxFIO
            // 
            this.TextBoxFIO.Location = new System.Drawing.Point(89, 6);
            this.TextBoxFIO.Name = "TextBoxFIO";
            this.TextBoxFIO.Size = new System.Drawing.Size(406, 20);
            this.TextBoxFIO.TabIndex = 18;
            // 
            // LabelContactData
            // 
            this.LabelContactData.AutoSize = true;
            this.LabelContactData.Location = new System.Drawing.Point(13, 114);
            this.LabelContactData.Name = "LabelContactData";
            this.LabelContactData.Size = new System.Drawing.Size(70, 13);
            this.LabelContactData.TabIndex = 17;
            this.LabelContactData.Text = "ContactData:";
            // 
            // LabelArriveDate
            // 
            this.LabelArriveDate.AutoSize = true;
            this.LabelArriveDate.Location = new System.Drawing.Point(23, 88);
            this.LabelArriveDate.Name = "LabelArriveDate";
            this.LabelArriveDate.Size = new System.Drawing.Size(60, 13);
            this.LabelArriveDate.TabIndex = 16;
            this.LabelArriveDate.Text = "ArriveDate:";
            // 
            // LabelPositionID
            // 
            this.LabelPositionID.AutoSize = true;
            this.LabelPositionID.Location = new System.Drawing.Point(25, 61);
            this.LabelPositionID.Name = "LabelPositionID";
            this.LabelPositionID.Size = new System.Drawing.Size(58, 13);
            this.LabelPositionID.TabIndex = 15;
            this.LabelPositionID.Text = "PositionID:";
            // 
            // LabelBornDate
            // 
            this.LabelBornDate.AutoSize = true;
            this.LabelBornDate.Location = new System.Drawing.Point(28, 35);
            this.LabelBornDate.Name = "LabelBornDate";
            this.LabelBornDate.Size = new System.Drawing.Size(55, 13);
            this.LabelBornDate.TabIndex = 14;
            this.LabelBornDate.Text = "BornDate:";
            // 
            // LabelFIO
            // 
            this.LabelFIO.AutoSize = true;
            this.LabelFIO.Location = new System.Drawing.Point(56, 9);
            this.LabelFIO.Name = "LabelFIO";
            this.LabelFIO.Size = new System.Drawing.Size(27, 13);
            this.LabelFIO.TabIndex = 13;
            this.LabelFIO.Text = "FIO:";
            // 
            // FormChangeWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 167);
            this.Controls.Add(this.DateTimePickerBornDate);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonChangeWorker);
            this.Controls.Add(this.TextBoxContactData);
            this.Controls.Add(this.DateTimePickerArriveDate);
            this.Controls.Add(this.ComboBoxPositionID);
            this.Controls.Add(this.TextBoxFIO);
            this.Controls.Add(this.LabelContactData);
            this.Controls.Add(this.LabelArriveDate);
            this.Controls.Add(this.LabelPositionID);
            this.Controls.Add(this.LabelBornDate);
            this.Controls.Add(this.LabelFIO);
            this.Name = "FormChangeWorker";
            this.Text = "FormChangeWorker";
            this.Shown += new System.EventHandler(this.FormChangeWorker_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerBornDate;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonChangeWorker;
        private System.Windows.Forms.TextBox TextBoxContactData;
        private System.Windows.Forms.DateTimePicker DateTimePickerArriveDate;
        private System.Windows.Forms.ComboBox ComboBoxPositionID;
        private System.Windows.Forms.TextBox TextBoxFIO;
        private System.Windows.Forms.Label LabelContactData;
        private System.Windows.Forms.Label LabelArriveDate;
        private System.Windows.Forms.Label LabelPositionID;
        private System.Windows.Forms.Label LabelBornDate;
        private System.Windows.Forms.Label LabelFIO;
    }
}