namespace DiplomaNegoda.Forms.InsertForms
{
    partial class FormAddWorker
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
            this.LabelBornDate = new System.Windows.Forms.Label();
            this.LabelPositionID = new System.Windows.Forms.Label();
            this.LabelArriveDate = new System.Windows.Forms.Label();
            this.LabelContactData = new System.Windows.Forms.Label();
            this.TextBoxFIO = new System.Windows.Forms.TextBox();
            this.ComboBoxPositionID = new System.Windows.Forms.ComboBox();
            this.DateTimePickerArriveDate = new System.Windows.Forms.DateTimePicker();
            this.TextBoxContactData = new System.Windows.Forms.TextBox();
            this.ButtonAddWorker = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.DateTimePickerBornDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LabelFIO
            // 
            this.LabelFIO.AutoSize = true;
            this.LabelFIO.Location = new System.Drawing.Point(52, 9);
            this.LabelFIO.Name = "LabelFIO";
            this.LabelFIO.Size = new System.Drawing.Size(27, 13);
            this.LabelFIO.TabIndex = 0;
            this.LabelFIO.Text = "FIO:";
            // 
            // LabelBornDate
            // 
            this.LabelBornDate.AutoSize = true;
            this.LabelBornDate.Location = new System.Drawing.Point(24, 35);
            this.LabelBornDate.Name = "LabelBornDate";
            this.LabelBornDate.Size = new System.Drawing.Size(55, 13);
            this.LabelBornDate.TabIndex = 1;
            this.LabelBornDate.Text = "BornDate:";
            // 
            // LabelPositionID
            // 
            this.LabelPositionID.AutoSize = true;
            this.LabelPositionID.Location = new System.Drawing.Point(21, 61);
            this.LabelPositionID.Name = "LabelPositionID";
            this.LabelPositionID.Size = new System.Drawing.Size(58, 13);
            this.LabelPositionID.TabIndex = 2;
            this.LabelPositionID.Text = "PositionID:";
            // 
            // LabelArriveDate
            // 
            this.LabelArriveDate.AutoSize = true;
            this.LabelArriveDate.Location = new System.Drawing.Point(19, 88);
            this.LabelArriveDate.Name = "LabelArriveDate";
            this.LabelArriveDate.Size = new System.Drawing.Size(60, 13);
            this.LabelArriveDate.TabIndex = 3;
            this.LabelArriveDate.Text = "ArriveDate:";
            // 
            // LabelContactData
            // 
            this.LabelContactData.AutoSize = true;
            this.LabelContactData.Location = new System.Drawing.Point(9, 114);
            this.LabelContactData.Name = "LabelContactData";
            this.LabelContactData.Size = new System.Drawing.Size(70, 13);
            this.LabelContactData.TabIndex = 4;
            this.LabelContactData.Text = "ContactData:";
            // 
            // TextBoxFIO
            // 
            this.TextBoxFIO.Location = new System.Drawing.Point(85, 6);
            this.TextBoxFIO.Name = "TextBoxFIO";
            this.TextBoxFIO.Size = new System.Drawing.Size(406, 20);
            this.TextBoxFIO.TabIndex = 5;
            // 
            // ComboBoxPositionID
            // 
            this.ComboBoxPositionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPositionID.FormattingEnabled = true;
            this.ComboBoxPositionID.Location = new System.Drawing.Point(85, 58);
            this.ComboBoxPositionID.Name = "ComboBoxPositionID";
            this.ComboBoxPositionID.Size = new System.Drawing.Size(406, 21);
            this.ComboBoxPositionID.TabIndex = 7;
            // 
            // DateTimePickerArriveDate
            // 
            this.DateTimePickerArriveDate.Location = new System.Drawing.Point(85, 85);
            this.DateTimePickerArriveDate.Name = "DateTimePickerArriveDate";
            this.DateTimePickerArriveDate.Size = new System.Drawing.Size(406, 20);
            this.DateTimePickerArriveDate.TabIndex = 8;
            // 
            // TextBoxContactData
            // 
            this.TextBoxContactData.Location = new System.Drawing.Point(85, 111);
            this.TextBoxContactData.Name = "TextBoxContactData";
            this.TextBoxContactData.Size = new System.Drawing.Size(406, 20);
            this.TextBoxContactData.TabIndex = 9;
            // 
            // ButtonAddWorker
            // 
            this.ButtonAddWorker.Location = new System.Drawing.Point(12, 137);
            this.ButtonAddWorker.Name = "ButtonAddWorker";
            this.ButtonAddWorker.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddWorker.TabIndex = 10;
            this.ButtonAddWorker.Text = "Add";
            this.ButtonAddWorker.UseVisualStyleBackColor = true;
            this.ButtonAddWorker.Click += new System.EventHandler(this.ButtonAddWorker_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(416, 137);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // DateTimePickerBornDate
            // 
            this.DateTimePickerBornDate.Location = new System.Drawing.Point(85, 32);
            this.DateTimePickerBornDate.Name = "DateTimePickerBornDate";
            this.DateTimePickerBornDate.Size = new System.Drawing.Size(406, 20);
            this.DateTimePickerBornDate.TabIndex = 12;
            // 
            // FormAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 167);
            this.Controls.Add(this.DateTimePickerBornDate);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAddWorker);
            this.Controls.Add(this.TextBoxContactData);
            this.Controls.Add(this.DateTimePickerArriveDate);
            this.Controls.Add(this.ComboBoxPositionID);
            this.Controls.Add(this.TextBoxFIO);
            this.Controls.Add(this.LabelContactData);
            this.Controls.Add(this.LabelArriveDate);
            this.Controls.Add(this.LabelPositionID);
            this.Controls.Add(this.LabelBornDate);
            this.Controls.Add(this.LabelFIO);
            this.Name = "FormAddWorker";
            this.Text = "FormAddWorker";
            this.Shown += new System.EventHandler(this.FormAddWorker_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFIO;
        private System.Windows.Forms.Label LabelBornDate;
        private System.Windows.Forms.Label LabelPositionID;
        private System.Windows.Forms.Label LabelArriveDate;
        private System.Windows.Forms.Label LabelContactData;
        private System.Windows.Forms.TextBox TextBoxFIO;
        private System.Windows.Forms.ComboBox ComboBoxPositionID;
        private System.Windows.Forms.DateTimePicker DateTimePickerArriveDate;
        private System.Windows.Forms.TextBox TextBoxContactData;
        private System.Windows.Forms.Button ButtonAddWorker;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.DateTimePicker DateTimePickerBornDate;
    }
}