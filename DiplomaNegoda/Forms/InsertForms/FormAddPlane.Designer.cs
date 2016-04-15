namespace DiplomaNegoda.Forms.InsertForms
{
    partial class FormAddPlane
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
            this.ButtonAddPlane = new System.Windows.Forms.Button();
            this.TextBoxCountOfPlacesBusiness = new System.Windows.Forms.TextBox();
            this.TextBoxCountOfPlacesEco = new System.Windows.Forms.TextBox();
            this.TextBoxModel = new System.Windows.Forms.TextBox();
            this.LabelCountOfPlacesBusiness = new System.Windows.Forms.Label();
            this.LabelCountOfPlacesEco = new System.Windows.Forms.Label();
            this.LabelModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(442, 92);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 15;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonAddPlane
            // 
            this.ButtonAddPlane.Location = new System.Drawing.Point(15, 92);
            this.ButtonAddPlane.Name = "ButtonAddPlane";
            this.ButtonAddPlane.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddPlane.TabIndex = 14;
            this.ButtonAddPlane.Text = "Add";
            this.ButtonAddPlane.UseVisualStyleBackColor = true;
            this.ButtonAddPlane.Click += new System.EventHandler(this.ButtonAddPlane_Click);
            // 
            // TextBoxCountOfPlacesBusiness
            // 
            this.TextBoxCountOfPlacesBusiness.Location = new System.Drawing.Point(141, 58);
            this.TextBoxCountOfPlacesBusiness.Name = "TextBoxCountOfPlacesBusiness";
            this.TextBoxCountOfPlacesBusiness.Size = new System.Drawing.Size(72, 20);
            this.TextBoxCountOfPlacesBusiness.TabIndex = 13;
            // 
            // TextBoxCountOfPlacesEco
            // 
            this.TextBoxCountOfPlacesEco.Location = new System.Drawing.Point(141, 32);
            this.TextBoxCountOfPlacesEco.Name = "TextBoxCountOfPlacesEco";
            this.TextBoxCountOfPlacesEco.Size = new System.Drawing.Size(72, 20);
            this.TextBoxCountOfPlacesEco.TabIndex = 12;
            // 
            // TextBoxModel
            // 
            this.TextBoxModel.Location = new System.Drawing.Point(141, 6);
            this.TextBoxModel.Name = "TextBoxModel";
            this.TextBoxModel.Size = new System.Drawing.Size(376, 20);
            this.TextBoxModel.TabIndex = 11;
            // 
            // LabelCountOfPlacesBusiness
            // 
            this.LabelCountOfPlacesBusiness.AutoSize = true;
            this.LabelCountOfPlacesBusiness.Location = new System.Drawing.Point(12, 61);
            this.LabelCountOfPlacesBusiness.Name = "LabelCountOfPlacesBusiness";
            this.LabelCountOfPlacesBusiness.Size = new System.Drawing.Size(123, 13);
            this.LabelCountOfPlacesBusiness.TabIndex = 10;
            this.LabelCountOfPlacesBusiness.Text = "CountOfPlacesBusiness:";
            // 
            // LabelCountOfPlacesEco
            // 
            this.LabelCountOfPlacesEco.AutoSize = true;
            this.LabelCountOfPlacesEco.Location = new System.Drawing.Point(35, 35);
            this.LabelCountOfPlacesEco.Name = "LabelCountOfPlacesEco";
            this.LabelCountOfPlacesEco.Size = new System.Drawing.Size(100, 13);
            this.LabelCountOfPlacesEco.TabIndex = 9;
            this.LabelCountOfPlacesEco.Text = "CountOfPlacesEco:";
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(96, 9);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(39, 13);
            this.LabelModel.TabIndex = 8;
            this.LabelModel.Text = "Model:";
            // 
            // FormAddPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 126);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAddPlane);
            this.Controls.Add(this.TextBoxCountOfPlacesBusiness);
            this.Controls.Add(this.TextBoxCountOfPlacesEco);
            this.Controls.Add(this.TextBoxModel);
            this.Controls.Add(this.LabelCountOfPlacesBusiness);
            this.Controls.Add(this.LabelCountOfPlacesEco);
            this.Controls.Add(this.LabelModel);
            this.Name = "FormAddPlane";
            this.Text = "AddPlane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonAddPlane;
        private System.Windows.Forms.TextBox TextBoxCountOfPlacesBusiness;
        private System.Windows.Forms.TextBox TextBoxCountOfPlacesEco;
        private System.Windows.Forms.TextBox TextBoxModel;
        private System.Windows.Forms.Label LabelCountOfPlacesBusiness;
        private System.Windows.Forms.Label LabelCountOfPlacesEco;
        private System.Windows.Forms.Label LabelModel;
    }
}