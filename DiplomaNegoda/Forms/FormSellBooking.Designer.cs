namespace DiplomaNegoda.Forms
{
    partial class FormSellingReservationing
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageSellingReservationing = new System.Windows.Forms.TabPage();
            this.TabPageSellReservation = new System.Windows.Forms.TabPage();
            this.LabelNumberOfFlight = new System.Windows.Forms.Label();
            this.LabelDirection = new System.Windows.Forms.Label();
            this.TextBoxNumberOfFlight = new System.Windows.Forms.TextBox();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.TextBoxFrom = new System.Windows.Forms.TextBox();
            this.LabelTo = new System.Windows.Forms.Label();
            this.TextBoxTo = new System.Windows.Forms.TextBox();
            this.LabelGoDate = new System.Windows.Forms.Label();
            this.TextBoxGoDate = new System.Windows.Forms.TextBox();
            this.LabelGoTime = new System.Windows.Forms.Label();
            this.TextBoxGoTime = new System.Windows.Forms.TextBox();
            this.TextBoxArriveTime = new System.Windows.Forms.TextBox();
            this.LabelArriveTime = new System.Windows.Forms.Label();
            this.TextBoxArriveDate = new System.Windows.Forms.TextBox();
            this.LabelArriveDate = new System.Windows.Forms.Label();
            this.LabelClassOfPlace = new System.Windows.Forms.Label();
            this.ComboBoxClassOfPlace = new System.Windows.Forms.ComboBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelListOfPlaces = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonSell = new System.Windows.Forms.Button();
            this.ButtonBooking = new System.Windows.Forms.Button();
            this.TabPageSoldPlaces = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.TabPageSellingReservationing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageSellingReservationing);
            this.tabControl1.Controls.Add(this.TabPageSellReservation);
            this.tabControl1.Controls.Add(this.TabPageSoldPlaces);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(42, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPageSellingReservationing
            // 
            this.TabPageSellingReservationing.Controls.Add(this.ButtonBooking);
            this.TabPageSellingReservationing.Controls.Add(this.ButtonSell);
            this.TabPageSellingReservationing.Controls.Add(this.dataGridView1);
            this.TabPageSellingReservationing.Controls.Add(this.LabelListOfPlaces);
            this.TabPageSellingReservationing.Controls.Add(this.LabelCost);
            this.TabPageSellingReservationing.Controls.Add(this.LabelPrice);
            this.TabPageSellingReservationing.Controls.Add(this.ComboBoxClassOfPlace);
            this.TabPageSellingReservationing.Controls.Add(this.LabelClassOfPlace);
            this.TabPageSellingReservationing.Controls.Add(this.TextBoxArriveTime);
            this.TabPageSellingReservationing.Controls.Add(this.LabelArriveTime);
            this.TabPageSellingReservationing.Controls.Add(this.TextBoxArriveDate);
            this.TabPageSellingReservationing.Controls.Add(this.LabelArriveDate);
            this.TabPageSellingReservationing.Controls.Add(this.TextBoxGoTime);
            this.TabPageSellingReservationing.Controls.Add(this.LabelGoTime);
            this.TabPageSellingReservationing.Controls.Add(this.TextBoxGoDate);
            this.TabPageSellingReservationing.Controls.Add(this.LabelGoDate);
            this.TabPageSellingReservationing.Controls.Add(this.TextBoxTo);
            this.TabPageSellingReservationing.Controls.Add(this.LabelTo);
            this.TabPageSellingReservationing.Controls.Add(this.TextBoxFrom);
            this.TabPageSellingReservationing.Controls.Add(this.LabelFrom);
            this.TabPageSellingReservationing.Controls.Add(this.TextBoxNumberOfFlight);
            this.TabPageSellingReservationing.Controls.Add(this.LabelDirection);
            this.TabPageSellingReservationing.Controls.Add(this.LabelNumberOfFlight);
            this.TabPageSellingReservationing.Location = new System.Drawing.Point(4, 22);
            this.TabPageSellingReservationing.Name = "TabPageSellingReservationing";
            this.TabPageSellingReservationing.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSellingReservationing.Size = new System.Drawing.Size(471, 505);
            this.TabPageSellingReservationing.TabIndex = 0;
            this.TabPageSellingReservationing.Text = "Selling/Reservationing";
            this.TabPageSellingReservationing.UseVisualStyleBackColor = true;
            // 
            // TabPageSellReservation
            // 
            this.TabPageSellReservation.Location = new System.Drawing.Point(4, 22);
            this.TabPageSellReservation.Name = "TabPageSellReservation";
            this.TabPageSellReservation.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSellReservation.Size = new System.Drawing.Size(471, 505);
            this.TabPageSellReservation.TabIndex = 1;
            this.TabPageSellReservation.Text = "Sell reservation";
            this.TabPageSellReservation.UseVisualStyleBackColor = true;
            // 
            // LabelNumberOfFlight
            // 
            this.LabelNumberOfFlight.AutoSize = true;
            this.LabelNumberOfFlight.Location = new System.Drawing.Point(8, 23);
            this.LabelNumberOfFlight.Name = "LabelNumberOfFlight";
            this.LabelNumberOfFlight.Size = new System.Drawing.Size(109, 13);
            this.LabelNumberOfFlight.TabIndex = 0;
            this.LabelNumberOfFlight.Text = "LabelNumberOfFlight:";
            // 
            // LabelDirection
            // 
            this.LabelDirection.AutoSize = true;
            this.LabelDirection.Location = new System.Drawing.Point(39, 49);
            this.LabelDirection.Name = "LabelDirection";
            this.LabelDirection.Size = new System.Drawing.Size(78, 13);
            this.LabelDirection.TabIndex = 1;
            this.LabelDirection.Text = "LabelDirection:";
            // 
            // TextBoxNumberOfFlight
            // 
            this.TextBoxNumberOfFlight.Location = new System.Drawing.Point(123, 20);
            this.TextBoxNumberOfFlight.Name = "TextBoxNumberOfFlight";
            this.TextBoxNumberOfFlight.Size = new System.Drawing.Size(330, 20);
            this.TextBoxNumberOfFlight.TabIndex = 2;
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Location = new System.Drawing.Point(120, 49);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(27, 13);
            this.LabelFrom.TabIndex = 3;
            this.LabelFrom.Text = "from";
            // 
            // TextBoxFrom
            // 
            this.TextBoxFrom.Location = new System.Drawing.Point(153, 46);
            this.TextBoxFrom.Name = "TextBoxFrom";
            this.TextBoxFrom.Size = new System.Drawing.Size(136, 20);
            this.TextBoxFrom.TabIndex = 4;
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Location = new System.Drawing.Point(295, 49);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(16, 13);
            this.LabelTo.TabIndex = 5;
            this.LabelTo.Text = "to";
            // 
            // TextBoxTo
            // 
            this.TextBoxTo.Location = new System.Drawing.Point(317, 46);
            this.TextBoxTo.Name = "TextBoxTo";
            this.TextBoxTo.Size = new System.Drawing.Size(136, 20);
            this.TextBoxTo.TabIndex = 6;
            // 
            // LabelGoDate
            // 
            this.LabelGoDate.AutoSize = true;
            this.LabelGoDate.Location = new System.Drawing.Point(44, 87);
            this.LabelGoDate.Name = "LabelGoDate";
            this.LabelGoDate.Size = new System.Drawing.Size(73, 13);
            this.LabelGoDate.TabIndex = 7;
            this.LabelGoDate.Text = "LabelGoDate:";
            // 
            // TextBoxGoDate
            // 
            this.TextBoxGoDate.Location = new System.Drawing.Point(123, 84);
            this.TextBoxGoDate.Name = "TextBoxGoDate";
            this.TextBoxGoDate.Size = new System.Drawing.Size(88, 20);
            this.TextBoxGoDate.TabIndex = 8;
            // 
            // LabelGoTime
            // 
            this.LabelGoTime.AutoSize = true;
            this.LabelGoTime.Location = new System.Drawing.Point(286, 87);
            this.LabelGoTime.Name = "LabelGoTime";
            this.LabelGoTime.Size = new System.Drawing.Size(73, 13);
            this.LabelGoTime.TabIndex = 9;
            this.LabelGoTime.Text = "LabelGoTime:";
            // 
            // TextBoxGoTime
            // 
            this.TextBoxGoTime.Location = new System.Drawing.Point(365, 84);
            this.TextBoxGoTime.Name = "TextBoxGoTime";
            this.TextBoxGoTime.Size = new System.Drawing.Size(88, 20);
            this.TextBoxGoTime.TabIndex = 10;
            // 
            // TextBoxArriveTime
            // 
            this.TextBoxArriveTime.Location = new System.Drawing.Point(365, 123);
            this.TextBoxArriveTime.Name = "TextBoxArriveTime";
            this.TextBoxArriveTime.Size = new System.Drawing.Size(88, 20);
            this.TextBoxArriveTime.TabIndex = 14;
            // 
            // LabelArriveTime
            // 
            this.LabelArriveTime.AutoSize = true;
            this.LabelArriveTime.Location = new System.Drawing.Point(273, 126);
            this.LabelArriveTime.Name = "LabelArriveTime";
            this.LabelArriveTime.Size = new System.Drawing.Size(86, 13);
            this.LabelArriveTime.TabIndex = 13;
            this.LabelArriveTime.Text = "LabelArriveTime:";
            // 
            // TextBoxArriveDate
            // 
            this.TextBoxArriveDate.Location = new System.Drawing.Point(123, 123);
            this.TextBoxArriveDate.Name = "TextBoxArriveDate";
            this.TextBoxArriveDate.Size = new System.Drawing.Size(88, 20);
            this.TextBoxArriveDate.TabIndex = 12;
            // 
            // LabelArriveDate
            // 
            this.LabelArriveDate.AutoSize = true;
            this.LabelArriveDate.Location = new System.Drawing.Point(31, 126);
            this.LabelArriveDate.Name = "LabelArriveDate";
            this.LabelArriveDate.Size = new System.Drawing.Size(86, 13);
            this.LabelArriveDate.TabIndex = 11;
            this.LabelArriveDate.Text = "LabelArriveDate:";
            // 
            // LabelClassOfPlace
            // 
            this.LabelClassOfPlace.AutoSize = true;
            this.LabelClassOfPlace.Location = new System.Drawing.Point(18, 163);
            this.LabelClassOfPlace.Name = "LabelClassOfPlace";
            this.LabelClassOfPlace.Size = new System.Drawing.Size(99, 13);
            this.LabelClassOfPlace.TabIndex = 15;
            this.LabelClassOfPlace.Text = "LabelClassOfPlace:";
            // 
            // ComboBoxClassOfPlace
            // 
            this.ComboBoxClassOfPlace.FormattingEnabled = true;
            this.ComboBoxClassOfPlace.Location = new System.Drawing.Point(123, 160);
            this.ComboBoxClassOfPlace.Name = "ComboBoxClassOfPlace";
            this.ComboBoxClassOfPlace.Size = new System.Drawing.Size(88, 21);
            this.ComboBoxClassOfPlace.TabIndex = 16;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(302, 168);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(60, 13);
            this.LabelPrice.TabIndex = 17;
            this.LabelPrice.Text = "LabelPrice:";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCost.Location = new System.Drawing.Point(365, 168);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(35, 13);
            this.LabelCost.TabIndex = 18;
            this.LabelCost.Text = "5000";
            // 
            // LabelListOfPlaces
            // 
            this.LabelListOfPlaces.AutoSize = true;
            this.LabelListOfPlaces.Location = new System.Drawing.Point(22, 232);
            this.LabelListOfPlaces.Name = "LabelListOfPlaces";
            this.LabelListOfPlaces.Size = new System.Drawing.Size(95, 13);
            this.LabelListOfPlaces.TabIndex = 19;
            this.LabelListOfPlaces.Text = "LabelListOfPlaces:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 249);
            this.dataGridView1.TabIndex = 20;
            // 
            // ButtonSell
            // 
            this.ButtonSell.Location = new System.Drawing.Point(365, 248);
            this.ButtonSell.Name = "ButtonSell";
            this.ButtonSell.Size = new System.Drawing.Size(88, 105);
            this.ButtonSell.TabIndex = 21;
            this.ButtonSell.Text = "Sell";
            this.ButtonSell.UseVisualStyleBackColor = true;
            // 
            // ButtonBooking
            // 
            this.ButtonBooking.Location = new System.Drawing.Point(365, 392);
            this.ButtonBooking.Name = "ButtonBooking";
            this.ButtonBooking.Size = new System.Drawing.Size(88, 105);
            this.ButtonBooking.TabIndex = 22;
            this.ButtonBooking.Text = "Booking";
            this.ButtonBooking.UseVisualStyleBackColor = true;
            // 
            // TabPageSoldPlaces
            // 
            this.TabPageSoldPlaces.Location = new System.Drawing.Point(4, 22);
            this.TabPageSoldPlaces.Name = "TabPageSoldPlaces";
            this.TabPageSoldPlaces.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSoldPlaces.Size = new System.Drawing.Size(471, 505);
            this.TabPageSoldPlaces.TabIndex = 2;
            this.TabPageSoldPlaces.Text = "Sold places";
            this.TabPageSoldPlaces.UseVisualStyleBackColor = true;
            // 
            // FormSellingReservationing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSellingReservationing";
            this.Text = "FormSellingReservationing";
            this.Shown += new System.EventHandler(this.FormSellBooking_Shown);
            this.tabControl1.ResumeLayout(false);
            this.TabPageSellingReservationing.ResumeLayout(false);
            this.TabPageSellingReservationing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageSellingReservationing;
        private System.Windows.Forms.TabPage TabPageSellReservation;
        private System.Windows.Forms.Button ButtonBooking;
        private System.Windows.Forms.Button ButtonSell;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelListOfPlaces;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.ComboBox ComboBoxClassOfPlace;
        private System.Windows.Forms.Label LabelClassOfPlace;
        private System.Windows.Forms.TextBox TextBoxArriveTime;
        private System.Windows.Forms.Label LabelArriveTime;
        private System.Windows.Forms.TextBox TextBoxArriveDate;
        private System.Windows.Forms.Label LabelArriveDate;
        private System.Windows.Forms.TextBox TextBoxGoTime;
        private System.Windows.Forms.Label LabelGoTime;
        private System.Windows.Forms.TextBox TextBoxGoDate;
        private System.Windows.Forms.Label LabelGoDate;
        private System.Windows.Forms.TextBox TextBoxTo;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.TextBox TextBoxFrom;
        private System.Windows.Forms.Label LabelFrom;
        private System.Windows.Forms.TextBox TextBoxNumberOfFlight;
        private System.Windows.Forms.Label LabelDirection;
        private System.Windows.Forms.Label LabelNumberOfFlight;
        private System.Windows.Forms.TabPage TabPageSoldPlaces;
    }
}