using DiplomaNegoda.Classes.TablesOnlyPK;

namespace DiplomaNegoda.Forms
{
    partial class FormAdmin
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
            this.TabAviacompaniesSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteAviacompany = new System.Windows.Forms.Button();
            this.ButtonChangeAviacompany = new System.Windows.Forms.Button();
            this.ButtonAddAviacompany = new System.Windows.Forms.Button();
            this.DGVaviacompanies = new System.Windows.Forms.DataGridView();
            this.TabCitiesSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteCity = new System.Windows.Forms.Button();
            this.ButtonChangeCity = new System.Windows.Forms.Button();
            this.ButtonAddCity = new System.Windows.Forms.Button();
            this.DGVcities = new System.Windows.Forms.DataGridView();
            this.TabClassPlaceSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteClassPlace = new System.Windows.Forms.Button();
            this.ButtonChangeClassPlace = new System.Windows.Forms.Button();
            this.ButtonAddClassPlace = new System.Windows.Forms.Button();
            this.DGVclassPlace = new System.Windows.Forms.DataGridView();
            this.TabPlanesSet = new System.Windows.Forms.TabPage();
            this.ButtonDeletePlane = new System.Windows.Forms.Button();
            this.ButtonChangePlane = new System.Windows.Forms.Button();
            this.ButtonAddPlane = new System.Windows.Forms.Button();
            this.DGVplanes = new System.Windows.Forms.DataGridView();
            this.TabPositionsSet = new System.Windows.Forms.TabPage();
            this.ButtonDeletePosition = new System.Windows.Forms.Button();
            this.ButtonChangePosition = new System.Windows.Forms.Button();
            this.ButtonAddPosition = new System.Windows.Forms.Button();
            this.DGVpositions = new System.Windows.Forms.DataGridView();
            this.TabTicketStatusSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteTicketStatus = new System.Windows.Forms.Button();
            this.ButtonChangeTicketStatus = new System.Windows.Forms.Button();
            this.ButtonAddTicketStatus = new System.Windows.Forms.Button();
            this.DGVticketStatus = new System.Windows.Forms.DataGridView();
            this.TabAccountsSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteAccount = new System.Windows.Forms.Button();
            this.ButtonChangeAccount = new System.Windows.Forms.Button();
            this.ButtonAddAccount = new System.Windows.Forms.Button();
            this.DGVaccounts = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TabAviacompaniesSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVaviacompanies)).BeginInit();
            this.TabCitiesSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcities)).BeginInit();
            this.TabClassPlaceSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclassPlace)).BeginInit();
            this.TabPlanesSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVplanes)).BeginInit();
            this.TabPositionsSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpositions)).BeginInit();
            this.TabTicketStatusSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVticketStatus)).BeginInit();
            this.TabAccountsSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVaccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabAviacompaniesSet);
            this.tabControl1.Controls.Add(this.TabCitiesSet);
            this.tabControl1.Controls.Add(this.TabClassPlaceSet);
            this.tabControl1.Controls.Add(this.TabPlanesSet);
            this.tabControl1.Controls.Add(this.TabPositionsSet);
            this.tabControl1.Controls.Add(this.TabTicketStatusSet);
            this.tabControl1.Controls.Add(this.TabAccountsSet);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 441);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabAviacompaniesSet
            // 
            this.TabAviacompaniesSet.Controls.Add(this.ButtonDeleteAviacompany);
            this.TabAviacompaniesSet.Controls.Add(this.ButtonChangeAviacompany);
            this.TabAviacompaniesSet.Controls.Add(this.ButtonAddAviacompany);
            this.TabAviacompaniesSet.Controls.Add(this.DGVaviacompanies);
            this.TabAviacompaniesSet.Location = new System.Drawing.Point(4, 22);
            this.TabAviacompaniesSet.Name = "TabAviacompaniesSet";
            this.TabAviacompaniesSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabAviacompaniesSet.Size = new System.Drawing.Size(1132, 415);
            this.TabAviacompaniesSet.TabIndex = 0;
            this.TabAviacompaniesSet.Text = "Aviacompanies";
            this.TabAviacompaniesSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteAviacompany
            // 
            this.ButtonDeleteAviacompany.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeleteAviacompany.Name = "ButtonDeleteAviacompany";
            this.ButtonDeleteAviacompany.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeleteAviacompany.TabIndex = 3;
            this.ButtonDeleteAviacompany.Text = "Delete Aviacompany";
            this.ButtonDeleteAviacompany.UseVisualStyleBackColor = true;
            this.ButtonDeleteAviacompany.Click += new System.EventHandler(this.ButtonDeleteAviacompany_Click);
            // 
            // ButtonChangeAviacompany
            // 
            this.ButtonChangeAviacompany.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeAviacompany.Name = "ButtonChangeAviacompany";
            this.ButtonChangeAviacompany.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeAviacompany.TabIndex = 2;
            this.ButtonChangeAviacompany.Text = "Change Aviacompany";
            this.ButtonChangeAviacompany.UseVisualStyleBackColor = true;
            this.ButtonChangeAviacompany.Click += new System.EventHandler(this.ButtonChangeAviacompany_Click);
            // 
            // ButtonAddAviacompany
            // 
            this.ButtonAddAviacompany.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddAviacompany.Name = "ButtonAddAviacompany";
            this.ButtonAddAviacompany.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddAviacompany.TabIndex = 1;
            this.ButtonAddAviacompany.Text = "Add Aviacompany";
            this.ButtonAddAviacompany.UseVisualStyleBackColor = true;
            this.ButtonAddAviacompany.Click += new System.EventHandler(this.ButtonAddAviacompany_Click);
            // 
            // DGVaviacompanies
            // 
            this.DGVaviacompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVaviacompanies.Location = new System.Drawing.Point(6, 6);
            this.DGVaviacompanies.Name = "DGVaviacompanies";
            this.DGVaviacompanies.Size = new System.Drawing.Size(1120, 336);
            this.DGVaviacompanies.TabIndex = 0;
            // 
            // TabCitiesSet
            // 
            this.TabCitiesSet.Controls.Add(this.ButtonDeleteCity);
            this.TabCitiesSet.Controls.Add(this.ButtonChangeCity);
            this.TabCitiesSet.Controls.Add(this.ButtonAddCity);
            this.TabCitiesSet.Controls.Add(this.DGVcities);
            this.TabCitiesSet.Location = new System.Drawing.Point(4, 22);
            this.TabCitiesSet.Name = "TabCitiesSet";
            this.TabCitiesSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabCitiesSet.Size = new System.Drawing.Size(1132, 415);
            this.TabCitiesSet.TabIndex = 1;
            this.TabCitiesSet.Text = "Cities";
            this.TabCitiesSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteCity
            // 
            this.ButtonDeleteCity.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeleteCity.Name = "ButtonDeleteCity";
            this.ButtonDeleteCity.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeleteCity.TabIndex = 7;
            this.ButtonDeleteCity.Text = "Delete City";
            this.ButtonDeleteCity.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeCity
            // 
            this.ButtonChangeCity.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeCity.Name = "ButtonChangeCity";
            this.ButtonChangeCity.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeCity.TabIndex = 6;
            this.ButtonChangeCity.Text = "Change City";
            this.ButtonChangeCity.UseVisualStyleBackColor = true;
            // 
            // ButtonAddCity
            // 
            this.ButtonAddCity.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddCity.Name = "ButtonAddCity";
            this.ButtonAddCity.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddCity.TabIndex = 5;
            this.ButtonAddCity.Text = "Add City";
            this.ButtonAddCity.UseVisualStyleBackColor = true;
            // 
            // DGVcities
            // 
            this.DGVcities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcities.Location = new System.Drawing.Point(6, 6);
            this.DGVcities.Name = "DGVcities";
            this.DGVcities.Size = new System.Drawing.Size(1120, 336);
            this.DGVcities.TabIndex = 4;
            // 
            // TabClassPlaceSet
            // 
            this.TabClassPlaceSet.Controls.Add(this.ButtonDeleteClassPlace);
            this.TabClassPlaceSet.Controls.Add(this.ButtonChangeClassPlace);
            this.TabClassPlaceSet.Controls.Add(this.ButtonAddClassPlace);
            this.TabClassPlaceSet.Controls.Add(this.DGVclassPlace);
            this.TabClassPlaceSet.Location = new System.Drawing.Point(4, 22);
            this.TabClassPlaceSet.Name = "TabClassPlaceSet";
            this.TabClassPlaceSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabClassPlaceSet.Size = new System.Drawing.Size(1132, 415);
            this.TabClassPlaceSet.TabIndex = 2;
            this.TabClassPlaceSet.Text = "ClassPlace";
            this.TabClassPlaceSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteClassPlace
            // 
            this.ButtonDeleteClassPlace.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeleteClassPlace.Name = "ButtonDeleteClassPlace";
            this.ButtonDeleteClassPlace.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeleteClassPlace.TabIndex = 11;
            this.ButtonDeleteClassPlace.Text = "Delete Class Place";
            this.ButtonDeleteClassPlace.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeClassPlace
            // 
            this.ButtonChangeClassPlace.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeClassPlace.Name = "ButtonChangeClassPlace";
            this.ButtonChangeClassPlace.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeClassPlace.TabIndex = 10;
            this.ButtonChangeClassPlace.Text = "Change Class Place";
            this.ButtonChangeClassPlace.UseVisualStyleBackColor = true;
            // 
            // ButtonAddClassPlace
            // 
            this.ButtonAddClassPlace.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddClassPlace.Name = "ButtonAddClassPlace";
            this.ButtonAddClassPlace.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddClassPlace.TabIndex = 9;
            this.ButtonAddClassPlace.Text = "Add Class Place";
            this.ButtonAddClassPlace.UseVisualStyleBackColor = true;
            // 
            // DGVclassPlace
            // 
            this.DGVclassPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVclassPlace.Location = new System.Drawing.Point(6, 6);
            this.DGVclassPlace.Name = "DGVclassPlace";
            this.DGVclassPlace.Size = new System.Drawing.Size(1120, 336);
            this.DGVclassPlace.TabIndex = 8;
            // 
            // TabPlanesSet
            // 
            this.TabPlanesSet.Controls.Add(this.ButtonDeletePlane);
            this.TabPlanesSet.Controls.Add(this.ButtonChangePlane);
            this.TabPlanesSet.Controls.Add(this.ButtonAddPlane);
            this.TabPlanesSet.Controls.Add(this.DGVplanes);
            this.TabPlanesSet.Location = new System.Drawing.Point(4, 22);
            this.TabPlanesSet.Name = "TabPlanesSet";
            this.TabPlanesSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabPlanesSet.Size = new System.Drawing.Size(1132, 415);
            this.TabPlanesSet.TabIndex = 3;
            this.TabPlanesSet.Text = "Planes";
            this.TabPlanesSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeletePlane
            // 
            this.ButtonDeletePlane.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeletePlane.Name = "ButtonDeletePlane";
            this.ButtonDeletePlane.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeletePlane.TabIndex = 15;
            this.ButtonDeletePlane.Text = "Delete Plane";
            this.ButtonDeletePlane.UseVisualStyleBackColor = true;
            // 
            // ButtonChangePlane
            // 
            this.ButtonChangePlane.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangePlane.Name = "ButtonChangePlane";
            this.ButtonChangePlane.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangePlane.TabIndex = 14;
            this.ButtonChangePlane.Text = "Change Plane";
            this.ButtonChangePlane.UseVisualStyleBackColor = true;
            // 
            // ButtonAddPlane
            // 
            this.ButtonAddPlane.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddPlane.Name = "ButtonAddPlane";
            this.ButtonAddPlane.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddPlane.TabIndex = 13;
            this.ButtonAddPlane.Text = "Add Plane";
            this.ButtonAddPlane.UseVisualStyleBackColor = true;
            // 
            // DGVplanes
            // 
            this.DGVplanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVplanes.Location = new System.Drawing.Point(6, 6);
            this.DGVplanes.Name = "DGVplanes";
            this.DGVplanes.Size = new System.Drawing.Size(1120, 336);
            this.DGVplanes.TabIndex = 12;
            // 
            // TabPositionsSet
            // 
            this.TabPositionsSet.Controls.Add(this.ButtonDeletePosition);
            this.TabPositionsSet.Controls.Add(this.ButtonChangePosition);
            this.TabPositionsSet.Controls.Add(this.ButtonAddPosition);
            this.TabPositionsSet.Controls.Add(this.DGVpositions);
            this.TabPositionsSet.Location = new System.Drawing.Point(4, 22);
            this.TabPositionsSet.Name = "TabPositionsSet";
            this.TabPositionsSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabPositionsSet.Size = new System.Drawing.Size(1132, 415);
            this.TabPositionsSet.TabIndex = 4;
            this.TabPositionsSet.Text = "Positions";
            this.TabPositionsSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeletePosition
            // 
            this.ButtonDeletePosition.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeletePosition.Name = "ButtonDeletePosition";
            this.ButtonDeletePosition.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeletePosition.TabIndex = 19;
            this.ButtonDeletePosition.Text = "Delete Position";
            this.ButtonDeletePosition.UseVisualStyleBackColor = true;
            // 
            // ButtonChangePosition
            // 
            this.ButtonChangePosition.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangePosition.Name = "ButtonChangePosition";
            this.ButtonChangePosition.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangePosition.TabIndex = 18;
            this.ButtonChangePosition.Text = "Change Position";
            this.ButtonChangePosition.UseVisualStyleBackColor = true;
            // 
            // ButtonAddPosition
            // 
            this.ButtonAddPosition.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddPosition.Name = "ButtonAddPosition";
            this.ButtonAddPosition.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddPosition.TabIndex = 17;
            this.ButtonAddPosition.Text = "Add Position";
            this.ButtonAddPosition.UseVisualStyleBackColor = true;
            // 
            // DGVpositions
            // 
            this.DGVpositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpositions.Location = new System.Drawing.Point(6, 6);
            this.DGVpositions.Name = "DGVpositions";
            this.DGVpositions.Size = new System.Drawing.Size(1120, 336);
            this.DGVpositions.TabIndex = 16;
            // 
            // TabTicketStatusSet
            // 
            this.TabTicketStatusSet.Controls.Add(this.ButtonDeleteTicketStatus);
            this.TabTicketStatusSet.Controls.Add(this.ButtonChangeTicketStatus);
            this.TabTicketStatusSet.Controls.Add(this.ButtonAddTicketStatus);
            this.TabTicketStatusSet.Controls.Add(this.DGVticketStatus);
            this.TabTicketStatusSet.Location = new System.Drawing.Point(4, 22);
            this.TabTicketStatusSet.Name = "TabTicketStatusSet";
            this.TabTicketStatusSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabTicketStatusSet.Size = new System.Drawing.Size(1132, 415);
            this.TabTicketStatusSet.TabIndex = 5;
            this.TabTicketStatusSet.Text = "TicketStatus";
            this.TabTicketStatusSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteTicketStatus
            // 
            this.ButtonDeleteTicketStatus.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeleteTicketStatus.Name = "ButtonDeleteTicketStatus";
            this.ButtonDeleteTicketStatus.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeleteTicketStatus.TabIndex = 23;
            this.ButtonDeleteTicketStatus.Text = "Delete Ticket Status";
            this.ButtonDeleteTicketStatus.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeTicketStatus
            // 
            this.ButtonChangeTicketStatus.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeTicketStatus.Name = "ButtonChangeTicketStatus";
            this.ButtonChangeTicketStatus.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeTicketStatus.TabIndex = 22;
            this.ButtonChangeTicketStatus.Text = "Change Ticket Status";
            this.ButtonChangeTicketStatus.UseVisualStyleBackColor = true;
            // 
            // ButtonAddTicketStatus
            // 
            this.ButtonAddTicketStatus.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddTicketStatus.Name = "ButtonAddTicketStatus";
            this.ButtonAddTicketStatus.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddTicketStatus.TabIndex = 21;
            this.ButtonAddTicketStatus.Text = "Add Ticket Status";
            this.ButtonAddTicketStatus.UseVisualStyleBackColor = true;
            // 
            // DGVticketStatus
            // 
            this.DGVticketStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVticketStatus.Location = new System.Drawing.Point(6, 6);
            this.DGVticketStatus.Name = "DGVticketStatus";
            this.DGVticketStatus.Size = new System.Drawing.Size(1120, 336);
            this.DGVticketStatus.TabIndex = 20;
            // 
            // TabAccountsSet
            // 
            this.TabAccountsSet.Controls.Add(this.ButtonDeleteAccount);
            this.TabAccountsSet.Controls.Add(this.ButtonChangeAccount);
            this.TabAccountsSet.Controls.Add(this.ButtonAddAccount);
            this.TabAccountsSet.Controls.Add(this.DGVaccounts);
            this.TabAccountsSet.Location = new System.Drawing.Point(4, 22);
            this.TabAccountsSet.Name = "TabAccountsSet";
            this.TabAccountsSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabAccountsSet.Size = new System.Drawing.Size(1132, 415);
            this.TabAccountsSet.TabIndex = 6;
            this.TabAccountsSet.Text = "Accounts";
            this.TabAccountsSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteAccount
            // 
            this.ButtonDeleteAccount.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeleteAccount.Name = "ButtonDeleteAccount";
            this.ButtonDeleteAccount.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeleteAccount.TabIndex = 27;
            this.ButtonDeleteAccount.Text = "Delete Account";
            this.ButtonDeleteAccount.UseVisualStyleBackColor = true;
            this.ButtonDeleteAccount.Click += new System.EventHandler(this.ButtonDeleteAccount_Click);
            // 
            // ButtonChangeAccount
            // 
            this.ButtonChangeAccount.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeAccount.Name = "ButtonChangeAccount";
            this.ButtonChangeAccount.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeAccount.TabIndex = 26;
            this.ButtonChangeAccount.Text = "Change Account";
            this.ButtonChangeAccount.UseVisualStyleBackColor = true;
            this.ButtonChangeAccount.Click += new System.EventHandler(this.ButtonChangeAccount_Click);
            // 
            // ButtonAddAccount
            // 
            this.ButtonAddAccount.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddAccount.Name = "ButtonAddAccount";
            this.ButtonAddAccount.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddAccount.TabIndex = 25;
            this.ButtonAddAccount.Text = "Add Account";
            this.ButtonAddAccount.UseVisualStyleBackColor = true;
            this.ButtonAddAccount.Click += new System.EventHandler(this.ButtonAddAccount_Click);
            // 
            // DGVaccounts
            // 
            this.DGVaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVaccounts.Location = new System.Drawing.Point(6, 6);
            this.DGVaccounts.Name = "DGVaccounts";
            this.DGVaccounts.Size = new System.Drawing.Size(1120, 336);
            this.DGVaccounts.TabIndex = 24;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 465);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Shown += new System.EventHandler(this.FormAdmin_Shown);
            this.tabControl1.ResumeLayout(false);
            this.TabAviacompaniesSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVaviacompanies)).EndInit();
            this.TabCitiesSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcities)).EndInit();
            this.TabClassPlaceSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVclassPlace)).EndInit();
            this.TabPlanesSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVplanes)).EndInit();
            this.TabPositionsSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVpositions)).EndInit();
            this.TabTicketStatusSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVticketStatus)).EndInit();
            this.TabAccountsSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVaccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabAviacompaniesSet;
        private System.Windows.Forms.DataGridView DGVaviacompanies;
        private System.Windows.Forms.TabPage TabCitiesSet;
        private System.Windows.Forms.TabPage TabClassPlaceSet;
        private System.Windows.Forms.TabPage TabPlanesSet;
        private System.Windows.Forms.TabPage TabPositionsSet;
        private System.Windows.Forms.TabPage TabTicketStatusSet;
        private System.Windows.Forms.Button ButtonDeleteAviacompany;
        private System.Windows.Forms.Button ButtonChangeAviacompany;
        private System.Windows.Forms.Button ButtonAddAviacompany;
        private System.Windows.Forms.Button ButtonDeleteCity;
        private System.Windows.Forms.Button ButtonChangeCity;
        private System.Windows.Forms.Button ButtonAddCity;
        private System.Windows.Forms.DataGridView DGVcities;
        private System.Windows.Forms.Button ButtonDeleteClassPlace;
        private System.Windows.Forms.Button ButtonChangeClassPlace;
        private System.Windows.Forms.Button ButtonAddClassPlace;
        private System.Windows.Forms.DataGridView DGVclassPlace;
        private System.Windows.Forms.Button ButtonDeletePlane;
        private System.Windows.Forms.Button ButtonChangePlane;
        private System.Windows.Forms.Button ButtonAddPlane;
        private System.Windows.Forms.DataGridView DGVplanes;
        private System.Windows.Forms.Button ButtonDeletePosition;
        private System.Windows.Forms.Button ButtonChangePosition;
        private System.Windows.Forms.Button ButtonAddPosition;
        private System.Windows.Forms.DataGridView DGVpositions;
        private System.Windows.Forms.Button ButtonDeleteTicketStatus;
        private System.Windows.Forms.Button ButtonChangeTicketStatus;
        private System.Windows.Forms.Button ButtonAddTicketStatus;
        private System.Windows.Forms.DataGridView DGVticketStatus;

        public bool RefreshAviacompaniesSetDGV()
        {
            AviacompaniesSet ObjectAviacompaniesSet = new AviacompaniesSet();
            DGVaviacompanies.AutoGenerateColumns = true;
            ObjectAviacompaniesSet.SetCommandTextSelect();
            DGVaviacompanies.DataSource = ObjectAviacompaniesSet.GetTableData(ObjectAviacompaniesSet.CreateDataReaderVariable());
            return true;
        }

        public bool RefreshCitiesSetDGV()
        {
            CitiesSet ObjectCitiesSet = new CitiesSet();
            DGVcities.AutoGenerateColumns = true;
            ObjectCitiesSet.SetCommandTextSelect();
            DGVcities.DataSource = ObjectCitiesSet.GetTableData(ObjectCitiesSet.CreateDataReaderVariable());
            return true;
        }

        public bool RefreshClassPlaceSetDGV()
        {
            ClassPlaceSet ObjectClassPlaceSet = new ClassPlaceSet();
            DGVclassPlace.AutoGenerateColumns = true;
            ObjectClassPlaceSet.SetCommandTextSelect();
            DGVclassPlace.DataSource = ObjectClassPlaceSet.GetTableData(ObjectClassPlaceSet.CreateDataReaderVariable());
            return true;
        }

        public bool RefreshPlanesSetDGV()
        {
            PlanesSet ObjectPlanesSet = new PlanesSet();
            DGVplanes.AutoGenerateColumns = true;
            ObjectPlanesSet.SetCommandTextSelect();
            DGVplanes.DataSource = ObjectPlanesSet.GetTableData(ObjectPlanesSet.CreateDataReaderVariable());
            return true;
        }

        public bool RefreshPositionsSetDGV()
        {
            PositionsSet ObjectPositionsSet = new PositionsSet();
            DGVpositions.AutoGenerateColumns = true;
            ObjectPositionsSet.SetCommandTextSelect();
            DGVpositions.DataSource = ObjectPositionsSet.GetTableData(ObjectPositionsSet.CreateDataReaderVariable());
            return true;
        }

        public bool RefreshTicketStatusSetDGV()
        {
            TicketStatusSet ObjectTicketStatusSet = new TicketStatusSet();
            DGVticketStatus.AutoGenerateColumns = true;
            ObjectTicketStatusSet.SetCommandTextSelect();
            DGVticketStatus.DataSource = ObjectTicketStatusSet.GetTableData(ObjectTicketStatusSet.CreateDataReaderVariable());
            return true;
        }

        public bool RefreshAccountsSetDGV()
        {
            AccountsSet ObjectAccountsSet = new AccountsSet();
            DGVaccounts.AutoGenerateColumns = true;
            ObjectAccountsSet.SetCommandTextSelect();
            DGVaccounts.DataSource = ObjectAccountsSet.GetTableData(ObjectAccountsSet.CreateDataReaderVariable());
            return true;
        }

        private System.Windows.Forms.TabPage TabAccountsSet;
        private System.Windows.Forms.Button ButtonDeleteAccount;
        private System.Windows.Forms.Button ButtonChangeAccount;
        private System.Windows.Forms.Button ButtonAddAccount;
        private System.Windows.Forms.DataGridView DGVaccounts;
    }
}