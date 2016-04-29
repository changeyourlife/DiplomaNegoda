namespace DiplomaNegoda.Forms.UpdateForms
{
    partial class FormChangeFlightCurrent
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
            this.ButtonChangeFlightCurrent = new System.Windows.Forms.Button();
            this.TextBoxCostOfBusinessClass = new System.Windows.Forms.TextBox();
            this.TextBoxCostOfEcoClass = new System.Windows.Forms.TextBox();
            this.DateTimePickerArriveDateTime = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerGoDateTime = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxfromID = new System.Windows.Forms.ComboBox();
            this.ComboBoxtoID = new System.Windows.Forms.ComboBox();
            this.ComboBoxPlaneID = new System.Windows.Forms.ComboBox();
            this.ComboBoxAviacompanyID = new System.Windows.Forms.ComboBox();
            this.CostOfBusinessClass = new System.Windows.Forms.Label();
            this.LabelCostOfEcoClass = new System.Windows.Forms.Label();
            this.LabelArriveDateTime = new System.Windows.Forms.Label();
            this.LabelGoDateTime = new System.Windows.Forms.Label();
            this.LabelfromID = new System.Windows.Forms.Label();
            this.LabeltoID = new System.Windows.Forms.Label();
            this.LabelPlaneID = new System.Windows.Forms.Label();
            this.LabelAviacompanyID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(254, 242);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 35;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeFlightCurrent
            // 
            this.ButtonChangeFlightCurrent.Location = new System.Drawing.Point(14, 242);
            this.ButtonChangeFlightCurrent.Name = "ButtonChangeFlightCurrent";
            this.ButtonChangeFlightCurrent.Size = new System.Drawing.Size(75, 23);
            this.ButtonChangeFlightCurrent.TabIndex = 34;
            this.ButtonChangeFlightCurrent.Text = "Изменить";
            this.ButtonChangeFlightCurrent.UseVisualStyleBackColor = true;
            this.ButtonChangeFlightCurrent.Click += new System.EventHandler(this.ButtonChangeFlightCurrent_Click);
            // 
            // TextBoxCostOfBusinessClass
            // 
            this.TextBoxCostOfBusinessClass.Location = new System.Drawing.Point(169, 216);
            this.TextBoxCostOfBusinessClass.Name = "TextBoxCostOfBusinessClass";
            this.TextBoxCostOfBusinessClass.Size = new System.Drawing.Size(160, 20);
            this.TextBoxCostOfBusinessClass.TabIndex = 33;
            // 
            // TextBoxCostOfEcoClass
            // 
            this.TextBoxCostOfEcoClass.Location = new System.Drawing.Point(169, 186);
            this.TextBoxCostOfEcoClass.Name = "TextBoxCostOfEcoClass";
            this.TextBoxCostOfEcoClass.Size = new System.Drawing.Size(160, 20);
            this.TextBoxCostOfEcoClass.TabIndex = 32;
            // 
            // DateTimePickerArriveDateTime
            // 
            this.DateTimePickerArriveDateTime.Location = new System.Drawing.Point(169, 156);
            this.DateTimePickerArriveDateTime.Name = "DateTimePickerArriveDateTime";
            this.DateTimePickerArriveDateTime.Size = new System.Drawing.Size(160, 20);
            this.DateTimePickerArriveDateTime.TabIndex = 31;
            // 
            // DateTimePickerGoDateTime
            // 
            this.DateTimePickerGoDateTime.Location = new System.Drawing.Point(168, 123);
            this.DateTimePickerGoDateTime.Name = "DateTimePickerGoDateTime";
            this.DateTimePickerGoDateTime.Size = new System.Drawing.Size(160, 20);
            this.DateTimePickerGoDateTime.TabIndex = 30;
            this.DateTimePickerGoDateTime.ValueChanged += new System.EventHandler(this.DateTimePickerGoDateTime_ValueChanged);
            // 
            // ComboBoxfromID
            // 
            this.ComboBoxfromID.FormattingEnabled = true;
            this.ComboBoxfromID.Location = new System.Drawing.Point(168, 94);
            this.ComboBoxfromID.Name = "ComboBoxfromID";
            this.ComboBoxfromID.Size = new System.Drawing.Size(160, 21);
            this.ComboBoxfromID.TabIndex = 29;
            this.ComboBoxfromID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxfromID_SelectedIndexChanged);
            // 
            // ComboBoxtoID
            // 
            this.ComboBoxtoID.FormattingEnabled = true;
            this.ComboBoxtoID.Location = new System.Drawing.Point(168, 64);
            this.ComboBoxtoID.Name = "ComboBoxtoID";
            this.ComboBoxtoID.Size = new System.Drawing.Size(160, 21);
            this.ComboBoxtoID.TabIndex = 28;
            this.ComboBoxtoID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxtoID_SelectedIndexChanged);
            // 
            // ComboBoxPlaneID
            // 
            this.ComboBoxPlaneID.FormattingEnabled = true;
            this.ComboBoxPlaneID.Location = new System.Drawing.Point(168, 34);
            this.ComboBoxPlaneID.Name = "ComboBoxPlaneID";
            this.ComboBoxPlaneID.Size = new System.Drawing.Size(160, 21);
            this.ComboBoxPlaneID.TabIndex = 27;
            this.ComboBoxPlaneID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlaneID_SelectedIndexChanged);
            // 
            // ComboBoxAviacompanyID
            // 
            this.ComboBoxAviacompanyID.FormattingEnabled = true;
            this.ComboBoxAviacompanyID.Location = new System.Drawing.Point(168, 4);
            this.ComboBoxAviacompanyID.Name = "ComboBoxAviacompanyID";
            this.ComboBoxAviacompanyID.Size = new System.Drawing.Size(160, 21);
            this.ComboBoxAviacompanyID.TabIndex = 26;
            this.ComboBoxAviacompanyID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAviacompanyID_SelectedIndexChanged);
            // 
            // CostOfBusinessClass
            // 
            this.CostOfBusinessClass.AutoSize = true;
            this.CostOfBusinessClass.Location = new System.Drawing.Point(14, 219);
            this.CostOfBusinessClass.Name = "CostOfBusinessClass";
            this.CostOfBusinessClass.Size = new System.Drawing.Size(149, 13);
            this.CostOfBusinessClass.TabIndex = 25;
            this.CostOfBusinessClass.Text = "Стоимость бизнесс-класса:";
            // 
            // LabelCostOfEcoClass
            // 
            this.LabelCostOfEcoClass.AutoSize = true;
            this.LabelCostOfEcoClass.Location = new System.Drawing.Point(18, 189);
            this.LabelCostOfEcoClass.Name = "LabelCostOfEcoClass";
            this.LabelCostOfEcoClass.Size = new System.Drawing.Size(145, 13);
            this.LabelCostOfEcoClass.TabIndex = 24;
            this.LabelCostOfEcoClass.Text = "Стоимость эконом-класса:";
            // 
            // LabelArriveDateTime
            // 
            this.LabelArriveDateTime.AutoSize = true;
            this.LabelArriveDateTime.Location = new System.Drawing.Point(75, 159);
            this.LabelArriveDateTime.Name = "LabelArriveDateTime";
            this.LabelArriveDateTime.Size = new System.Drawing.Size(88, 13);
            this.LabelArriveDateTime.TabIndex = 23;
            this.LabelArriveDateTime.Text = "Дата прибытия:";
            // 
            // LabelGoDateTime
            // 
            this.LabelGoDateTime.AutoSize = true;
            this.LabelGoDateTime.Location = new System.Drawing.Point(59, 129);
            this.LabelGoDateTime.Name = "LabelGoDateTime";
            this.LabelGoDateTime.Size = new System.Drawing.Size(104, 13);
            this.LabelGoDateTime.TabIndex = 22;
            this.LabelGoDateTime.Text = "Дата отправления:";
            // 
            // LabelfromID
            // 
            this.LabelfromID.AutoSize = true;
            this.LabelfromID.Location = new System.Drawing.Point(117, 99);
            this.LabelfromID.Name = "LabelfromID";
            this.LabelfromID.Size = new System.Drawing.Size(46, 13);
            this.LabelfromID.TabIndex = 21;
            this.LabelfromID.Text = "Откуда:";
            // 
            // LabeltoID
            // 
            this.LabeltoID.AutoSize = true;
            this.LabeltoID.Location = new System.Drawing.Point(129, 69);
            this.LabeltoID.Name = "LabeltoID";
            this.LabeltoID.Size = new System.Drawing.Size(34, 13);
            this.LabeltoID.TabIndex = 20;
            this.LabeltoID.Text = "Куда:";
            // 
            // LabelPlaneID
            // 
            this.LabelPlaneID.AutoSize = true;
            this.LabelPlaneID.Location = new System.Drawing.Point(109, 39);
            this.LabelPlaneID.Name = "LabelPlaneID";
            this.LabelPlaneID.Size = new System.Drawing.Size(54, 13);
            this.LabelPlaneID.TabIndex = 19;
            this.LabelPlaneID.Text = "Самолёт:";
            // 
            // LabelAviacompanyID
            // 
            this.LabelAviacompanyID.AutoSize = true;
            this.LabelAviacompanyID.Location = new System.Drawing.Point(78, 9);
            this.LabelAviacompanyID.Name = "LabelAviacompanyID";
            this.LabelAviacompanyID.Size = new System.Drawing.Size(85, 13);
            this.LabelAviacompanyID.TabIndex = 18;
            this.LabelAviacompanyID.Text = "Авиакомпания:";
            // 
            // FormChangeFlightCurrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 273);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonChangeFlightCurrent);
            this.Controls.Add(this.TextBoxCostOfBusinessClass);
            this.Controls.Add(this.TextBoxCostOfEcoClass);
            this.Controls.Add(this.DateTimePickerArriveDateTime);
            this.Controls.Add(this.DateTimePickerGoDateTime);
            this.Controls.Add(this.ComboBoxfromID);
            this.Controls.Add(this.ComboBoxtoID);
            this.Controls.Add(this.ComboBoxPlaneID);
            this.Controls.Add(this.ComboBoxAviacompanyID);
            this.Controls.Add(this.CostOfBusinessClass);
            this.Controls.Add(this.LabelCostOfEcoClass);
            this.Controls.Add(this.LabelArriveDateTime);
            this.Controls.Add(this.LabelGoDateTime);
            this.Controls.Add(this.LabelfromID);
            this.Controls.Add(this.LabeltoID);
            this.Controls.Add(this.LabelPlaneID);
            this.Controls.Add(this.LabelAviacompanyID);
            this.Name = "FormChangeFlightCurrent";
            this.Text = "Изменить рейс";
            this.Shown += new System.EventHandler(this.FormChangeFlightCurrent_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonChangeFlightCurrent;
        private System.Windows.Forms.TextBox TextBoxCostOfBusinessClass;
        private System.Windows.Forms.TextBox TextBoxCostOfEcoClass;
        private System.Windows.Forms.DateTimePicker DateTimePickerArriveDateTime;
        private System.Windows.Forms.DateTimePicker DateTimePickerGoDateTime;
        private System.Windows.Forms.ComboBox ComboBoxfromID;
        private System.Windows.Forms.ComboBox ComboBoxtoID;
        private System.Windows.Forms.ComboBox ComboBoxPlaneID;
        private System.Windows.Forms.ComboBox ComboBoxAviacompanyID;
        private System.Windows.Forms.Label CostOfBusinessClass;
        private System.Windows.Forms.Label LabelCostOfEcoClass;
        private System.Windows.Forms.Label LabelArriveDateTime;
        private System.Windows.Forms.Label LabelGoDateTime;
        private System.Windows.Forms.Label LabelfromID;
        private System.Windows.Forms.Label LabeltoID;
        private System.Windows.Forms.Label LabelPlaneID;
        private System.Windows.Forms.Label LabelAviacompanyID;
    }
}