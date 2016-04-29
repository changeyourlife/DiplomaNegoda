namespace DiplomaNegoda.Forms.UpdateForms
{
    partial class FormChangePlane
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
            this.LabelModel = new System.Windows.Forms.Label();
            this.LabelCountOfPlacesEco = new System.Windows.Forms.Label();
            this.LabelCountOfPlacesBusiness = new System.Windows.Forms.Label();
            this.TextBoxModel = new System.Windows.Forms.TextBox();
            this.TextBoxCountOfPlacesEco = new System.Windows.Forms.TextBox();
            this.TextBoxCountOfPlacesBusiness = new System.Windows.Forms.TextBox();
            this.ButtonChangePlane = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(113, 10);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(49, 13);
            this.LabelModel.TabIndex = 0;
            this.LabelModel.Text = "Модель:";
            // 
            // LabelCountOfPlacesEco
            // 
            this.LabelCountOfPlacesEco.AutoSize = true;
            this.LabelCountOfPlacesEco.Location = new System.Drawing.Point(12, 36);
            this.LabelCountOfPlacesEco.Name = "LabelCountOfPlacesEco";
            this.LabelCountOfPlacesEco.Size = new System.Drawing.Size(152, 13);
            this.LabelCountOfPlacesEco.TabIndex = 1;
            this.LabelCountOfPlacesEco.Text = "Кол-во мест эконом-класса:";
            // 
            // LabelCountOfPlacesBusiness
            // 
            this.LabelCountOfPlacesBusiness.AutoSize = true;
            this.LabelCountOfPlacesBusiness.Location = new System.Drawing.Point(12, 62);
            this.LabelCountOfPlacesBusiness.Name = "LabelCountOfPlacesBusiness";
            this.LabelCountOfPlacesBusiness.Size = new System.Drawing.Size(150, 13);
            this.LabelCountOfPlacesBusiness.TabIndex = 2;
            this.LabelCountOfPlacesBusiness.Text = "Кол-во мест бизнес-класса:";
            // 
            // TextBoxModel
            // 
            this.TextBoxModel.Location = new System.Drawing.Point(170, 7);
            this.TextBoxModel.Name = "TextBoxModel";
            this.TextBoxModel.Size = new System.Drawing.Size(324, 20);
            this.TextBoxModel.TabIndex = 3;
            // 
            // TextBoxCountOfPlacesEco
            // 
            this.TextBoxCountOfPlacesEco.Location = new System.Drawing.Point(170, 33);
            this.TextBoxCountOfPlacesEco.Name = "TextBoxCountOfPlacesEco";
            this.TextBoxCountOfPlacesEco.Size = new System.Drawing.Size(72, 20);
            this.TextBoxCountOfPlacesEco.TabIndex = 4;
            // 
            // TextBoxCountOfPlacesBusiness
            // 
            this.TextBoxCountOfPlacesBusiness.Location = new System.Drawing.Point(170, 59);
            this.TextBoxCountOfPlacesBusiness.Name = "TextBoxCountOfPlacesBusiness";
            this.TextBoxCountOfPlacesBusiness.Size = new System.Drawing.Size(72, 20);
            this.TextBoxCountOfPlacesBusiness.TabIndex = 5;
            // 
            // ButtonChangePlane
            // 
            this.ButtonChangePlane.Location = new System.Drawing.Point(15, 92);
            this.ButtonChangePlane.Name = "ButtonChangePlane";
            this.ButtonChangePlane.Size = new System.Drawing.Size(75, 23);
            this.ButtonChangePlane.TabIndex = 6;
            this.ButtonChangePlane.Text = "Изменить";
            this.ButtonChangePlane.UseVisualStyleBackColor = true;
            this.ButtonChangePlane.Click += new System.EventHandler(this.ButtonChangePlane_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(419, 92);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 7;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // FormChangePlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 126);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonChangePlane);
            this.Controls.Add(this.TextBoxCountOfPlacesBusiness);
            this.Controls.Add(this.TextBoxCountOfPlacesEco);
            this.Controls.Add(this.TextBoxModel);
            this.Controls.Add(this.LabelCountOfPlacesBusiness);
            this.Controls.Add(this.LabelCountOfPlacesEco);
            this.Controls.Add(this.LabelModel);
            this.Name = "FormChangePlane";
            this.Text = "Изменить самолёт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.Label LabelCountOfPlacesEco;
        private System.Windows.Forms.Label LabelCountOfPlacesBusiness;
        private System.Windows.Forms.TextBox TextBoxModel;
        private System.Windows.Forms.TextBox TextBoxCountOfPlacesEco;
        private System.Windows.Forms.TextBox TextBoxCountOfPlacesBusiness;
        private System.Windows.Forms.Button ButtonChangePlane;
        private System.Windows.Forms.Button ButtonClose;
    }
}