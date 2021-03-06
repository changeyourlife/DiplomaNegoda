﻿namespace DiplomaNegoda.Forms.InsertForms
{
    partial class FormAddFlightCurrent
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
            this.LabelAviacompanyID = new System.Windows.Forms.Label();
            this.LabelPlaneID = new System.Windows.Forms.Label();
            this.LabeltoID = new System.Windows.Forms.Label();
            this.LabelfromID = new System.Windows.Forms.Label();
            this.LabelGoDateTime = new System.Windows.Forms.Label();
            this.LabelArriveDateTime = new System.Windows.Forms.Label();
            this.LabelCostOfEcoClass = new System.Windows.Forms.Label();
            this.CostOfBusinessClass = new System.Windows.Forms.Label();
            this.ComboBoxAviacompanyID = new System.Windows.Forms.ComboBox();
            this.ComboBoxPlaneID = new System.Windows.Forms.ComboBox();
            this.ComboBoxtoID = new System.Windows.Forms.ComboBox();
            this.ComboBoxfromID = new System.Windows.Forms.ComboBox();
            this.DateTimePickerGoDateTime = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerArriveDateTime = new System.Windows.Forms.DateTimePicker();
            this.TextBoxCostOfEcoClass = new System.Windows.Forms.TextBox();
            this.TextBoxCostOfBusinessClass = new System.Windows.Forms.TextBox();
            this.ButtonAddFlightCurrent = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelAviacompanyID
            // 
            this.LabelAviacompanyID.AutoSize = true;
            this.LabelAviacompanyID.Location = new System.Drawing.Point(71, 9);
            this.LabelAviacompanyID.Name = "LabelAviacompanyID";
            this.LabelAviacompanyID.Size = new System.Drawing.Size(85, 13);
            this.LabelAviacompanyID.TabIndex = 0;
            this.LabelAviacompanyID.Text = "Авиакомпания:";
            // 
            // LabelPlaneID
            // 
            this.LabelPlaneID.AutoSize = true;
            this.LabelPlaneID.Location = new System.Drawing.Point(102, 39);
            this.LabelPlaneID.Name = "LabelPlaneID";
            this.LabelPlaneID.Size = new System.Drawing.Size(54, 13);
            this.LabelPlaneID.TabIndex = 1;
            this.LabelPlaneID.Text = "Самолёт:";
            // 
            // LabeltoID
            // 
            this.LabeltoID.AutoSize = true;
            this.LabeltoID.Location = new System.Drawing.Point(122, 69);
            this.LabeltoID.Name = "LabeltoID";
            this.LabeltoID.Size = new System.Drawing.Size(34, 13);
            this.LabeltoID.TabIndex = 2;
            this.LabeltoID.Text = "Куда:";
            // 
            // LabelfromID
            // 
            this.LabelfromID.AutoSize = true;
            this.LabelfromID.Location = new System.Drawing.Point(110, 99);
            this.LabelfromID.Name = "LabelfromID";
            this.LabelfromID.Size = new System.Drawing.Size(46, 13);
            this.LabelfromID.TabIndex = 3;
            this.LabelfromID.Text = "Откуда:";
            // 
            // LabelGoDateTime
            // 
            this.LabelGoDateTime.AutoSize = true;
            this.LabelGoDateTime.Location = new System.Drawing.Point(52, 131);
            this.LabelGoDateTime.Name = "LabelGoDateTime";
            this.LabelGoDateTime.Size = new System.Drawing.Size(104, 13);
            this.LabelGoDateTime.TabIndex = 4;
            this.LabelGoDateTime.Text = "Дата отправления:";
            // 
            // LabelArriveDateTime
            // 
            this.LabelArriveDateTime.AutoSize = true;
            this.LabelArriveDateTime.Location = new System.Drawing.Point(68, 162);
            this.LabelArriveDateTime.Name = "LabelArriveDateTime";
            this.LabelArriveDateTime.Size = new System.Drawing.Size(88, 13);
            this.LabelArriveDateTime.TabIndex = 5;
            this.LabelArriveDateTime.Text = "Дата прибытия:";
            // 
            // LabelCostOfEcoClass
            // 
            this.LabelCostOfEcoClass.AutoSize = true;
            this.LabelCostOfEcoClass.Location = new System.Drawing.Point(11, 189);
            this.LabelCostOfEcoClass.Name = "LabelCostOfEcoClass";
            this.LabelCostOfEcoClass.Size = new System.Drawing.Size(145, 13);
            this.LabelCostOfEcoClass.TabIndex = 6;
            this.LabelCostOfEcoClass.Text = "Стоимость эконом-класса:";
            // 
            // CostOfBusinessClass
            // 
            this.CostOfBusinessClass.AutoSize = true;
            this.CostOfBusinessClass.Location = new System.Drawing.Point(7, 219);
            this.CostOfBusinessClass.Name = "CostOfBusinessClass";
            this.CostOfBusinessClass.Size = new System.Drawing.Size(149, 13);
            this.CostOfBusinessClass.TabIndex = 7;
            this.CostOfBusinessClass.Text = "Стоимость бизнесс-класса:";
            // 
            // ComboBoxAviacompanyID
            // 
            this.ComboBoxAviacompanyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAviacompanyID.FormattingEnabled = true;
            this.ComboBoxAviacompanyID.Location = new System.Drawing.Point(162, 6);
            this.ComboBoxAviacompanyID.Name = "ComboBoxAviacompanyID";
            this.ComboBoxAviacompanyID.Size = new System.Drawing.Size(167, 21);
            this.ComboBoxAviacompanyID.TabIndex = 8;
            // 
            // ComboBoxPlaneID
            // 
            this.ComboBoxPlaneID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPlaneID.FormattingEnabled = true;
            this.ComboBoxPlaneID.Location = new System.Drawing.Point(162, 36);
            this.ComboBoxPlaneID.Name = "ComboBoxPlaneID";
            this.ComboBoxPlaneID.Size = new System.Drawing.Size(167, 21);
            this.ComboBoxPlaneID.TabIndex = 9;
            // 
            // ComboBoxtoID
            // 
            this.ComboBoxtoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxtoID.FormattingEnabled = true;
            this.ComboBoxtoID.Location = new System.Drawing.Point(162, 66);
            this.ComboBoxtoID.Name = "ComboBoxtoID";
            this.ComboBoxtoID.Size = new System.Drawing.Size(167, 21);
            this.ComboBoxtoID.TabIndex = 10;
            // 
            // ComboBoxfromID
            // 
            this.ComboBoxfromID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxfromID.FormattingEnabled = true;
            this.ComboBoxfromID.Location = new System.Drawing.Point(162, 96);
            this.ComboBoxfromID.Name = "ComboBoxfromID";
            this.ComboBoxfromID.Size = new System.Drawing.Size(167, 21);
            this.ComboBoxfromID.TabIndex = 11;
            // 
            // DateTimePickerGoDateTime
            // 
            this.DateTimePickerGoDateTime.Location = new System.Drawing.Point(162, 125);
            this.DateTimePickerGoDateTime.Name = "DateTimePickerGoDateTime";
            this.DateTimePickerGoDateTime.Size = new System.Drawing.Size(167, 20);
            this.DateTimePickerGoDateTime.TabIndex = 12;
            // 
            // DateTimePickerArriveDateTime
            // 
            this.DateTimePickerArriveDateTime.Location = new System.Drawing.Point(162, 156);
            this.DateTimePickerArriveDateTime.Name = "DateTimePickerArriveDateTime";
            this.DateTimePickerArriveDateTime.Size = new System.Drawing.Size(167, 20);
            this.DateTimePickerArriveDateTime.TabIndex = 13;
            // 
            // TextBoxCostOfEcoClass
            // 
            this.TextBoxCostOfEcoClass.Location = new System.Drawing.Point(162, 186);
            this.TextBoxCostOfEcoClass.Name = "TextBoxCostOfEcoClass";
            this.TextBoxCostOfEcoClass.Size = new System.Drawing.Size(167, 20);
            this.TextBoxCostOfEcoClass.TabIndex = 14;
            // 
            // TextBoxCostOfBusinessClass
            // 
            this.TextBoxCostOfBusinessClass.Location = new System.Drawing.Point(162, 216);
            this.TextBoxCostOfBusinessClass.Name = "TextBoxCostOfBusinessClass";
            this.TextBoxCostOfBusinessClass.Size = new System.Drawing.Size(167, 20);
            this.TextBoxCostOfBusinessClass.TabIndex = 15;
            // 
            // ButtonAddFlightCurrent
            // 
            this.ButtonAddFlightCurrent.Location = new System.Drawing.Point(14, 270);
            this.ButtonAddFlightCurrent.Name = "ButtonAddFlightCurrent";
            this.ButtonAddFlightCurrent.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddFlightCurrent.TabIndex = 16;
            this.ButtonAddFlightCurrent.Text = "Добавить";
            this.ButtonAddFlightCurrent.UseVisualStyleBackColor = true;
            this.ButtonAddFlightCurrent.Click += new System.EventHandler(this.ButtonAddFlightCurrent_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(254, 270);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 17;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // FormAddFlightCurrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 300);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAddFlightCurrent);
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
            this.Name = "FormAddFlightCurrent";
            this.Text = "Добавить рейс";
            this.Shown += new System.EventHandler(this.FormAddFlightCurrent_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAviacompanyID;
        private System.Windows.Forms.Label LabelPlaneID;
        private System.Windows.Forms.Label LabeltoID;
        private System.Windows.Forms.Label LabelfromID;
        private System.Windows.Forms.Label LabelGoDateTime;
        private System.Windows.Forms.Label LabelArriveDateTime;
        private System.Windows.Forms.Label LabelCostOfEcoClass;
        private System.Windows.Forms.Label CostOfBusinessClass;
        private System.Windows.Forms.ComboBox ComboBoxAviacompanyID;
        private System.Windows.Forms.ComboBox ComboBoxPlaneID;
        private System.Windows.Forms.ComboBox ComboBoxtoID;
        private System.Windows.Forms.ComboBox ComboBoxfromID;
        private System.Windows.Forms.DateTimePicker DateTimePickerGoDateTime;
        private System.Windows.Forms.DateTimePicker DateTimePickerArriveDateTime;
        private System.Windows.Forms.TextBox TextBoxCostOfEcoClass;
        private System.Windows.Forms.TextBox TextBoxCostOfBusinessClass;
        private System.Windows.Forms.Button ButtonAddFlightCurrent;
        private System.Windows.Forms.Button ButtonClose;
    }
}