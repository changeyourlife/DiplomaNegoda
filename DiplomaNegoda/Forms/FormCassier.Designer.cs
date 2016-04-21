namespace DiplomaNegoda.Forms
{
    partial class FormCassier
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
            this.LabelDataOut = new System.Windows.Forms.Label();
            this.DateTimePickerDataOut = new System.Windows.Forms.DateTimePicker();
            this.LabelCityFrom = new System.Windows.Forms.Label();
            this.ComboBoxCityFROM = new System.Windows.Forms.ComboBox();
            this.ComboBoxCityTO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVflightsCurrentSet = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVflightsCurrentSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDataOut
            // 
            this.LabelDataOut.AutoSize = true;
            this.LabelDataOut.Location = new System.Drawing.Point(12, 9);
            this.LabelDataOut.Name = "LabelDataOut";
            this.LabelDataOut.Size = new System.Drawing.Size(76, 13);
            this.LabelDataOut.TabIndex = 0;
            this.LabelDataOut.Text = "Дата вылета:";
            // 
            // DateTimePickerDataOut
            // 
            this.DateTimePickerDataOut.CustomFormat = "dd.mm.yyyy";
            this.DateTimePickerDataOut.Location = new System.Drawing.Point(94, 6);
            this.DateTimePickerDataOut.Name = "DateTimePickerDataOut";
            this.DateTimePickerDataOut.Size = new System.Drawing.Size(138, 20);
            this.DateTimePickerDataOut.TabIndex = 1;
            // 
            // LabelCityFrom
            // 
            this.LabelCityFrom.AutoSize = true;
            this.LabelCityFrom.Location = new System.Drawing.Point(274, 9);
            this.LabelCityFrom.Name = "LabelCityFrom";
            this.LabelCityFrom.Size = new System.Drawing.Size(46, 13);
            this.LabelCityFrom.TabIndex = 2;
            this.LabelCityFrom.Text = "Откуда:";
            // 
            // ComboBoxCityFROM
            // 
            this.ComboBoxCityFROM.FormattingEnabled = true;
            this.ComboBoxCityFROM.Location = new System.Drawing.Point(326, 5);
            this.ComboBoxCityFROM.Name = "ComboBoxCityFROM";
            this.ComboBoxCityFROM.Size = new System.Drawing.Size(453, 21);
            this.ComboBoxCityFROM.TabIndex = 3;
            // 
            // ComboBoxCityTO
            // 
            this.ComboBoxCityTO.FormattingEnabled = true;
            this.ComboBoxCityTO.Location = new System.Drawing.Point(326, 32);
            this.ComboBoxCityTO.Name = "ComboBoxCityTO";
            this.ComboBoxCityTO.Size = new System.Drawing.Size(453, 21);
            this.ComboBoxCityTO.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Куда:";
            // 
            // DGVflightsCurrentSet
            // 
            this.DGVflightsCurrentSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVflightsCurrentSet.Location = new System.Drawing.Point(15, 80);
            this.DGVflightsCurrentSet.Name = "DGVflightsCurrentSet";
            this.DGVflightsCurrentSet.Size = new System.Drawing.Size(903, 233);
            this.DGVflightsCurrentSet.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(903, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выбрать рейс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(785, 5);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(133, 48);
            this.ButtonSearch.TabIndex = 8;
            this.ButtonSearch.Text = "Поиск";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // FormCassier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 375);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVflightsCurrentSet);
            this.Controls.Add(this.ComboBoxCityTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxCityFROM);
            this.Controls.Add(this.LabelCityFrom);
            this.Controls.Add(this.DateTimePickerDataOut);
            this.Controls.Add(this.LabelDataOut);
            this.Name = "FormCassier";
            this.Text = "FormCassier";
            this.Shown += new System.EventHandler(this.FormCassier_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGVflightsCurrentSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDataOut;
        private System.Windows.Forms.DateTimePicker DateTimePickerDataOut;
        private System.Windows.Forms.Label LabelCityFrom;
        private System.Windows.Forms.ComboBox ComboBoxCityFROM;
        private System.Windows.Forms.ComboBox ComboBoxCityTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVflightsCurrentSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonSearch;
    }
}