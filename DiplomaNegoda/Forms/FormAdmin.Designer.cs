using DiplomaNegoda.Classes.TablesOnlyPK;
using System.Windows.Forms;

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
            this.TabPlaceStatusSet = new System.Windows.Forms.TabPage();
            this.ButtonDeletePlaceStatus = new System.Windows.Forms.Button();
            this.ButtonChangePlaceStatus = new System.Windows.Forms.Button();
            this.ButtonAddPlaceStatus = new System.Windows.Forms.Button();
            this.DGVplaceStatus = new System.Windows.Forms.DataGridView();
            this.TabAccountsSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteAccount = new System.Windows.Forms.Button();
            this.ButtonChangeAccount = new System.Windows.Forms.Button();
            this.ButtonAddAccount = new System.Windows.Forms.Button();
            this.DGVaccounts = new System.Windows.Forms.DataGridView();
            this.TabFlightsArchiveSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteFlightArchive = new System.Windows.Forms.Button();
            this.DGVflightsArchive = new System.Windows.Forms.DataGridView();
            this.TabFlightsCurrentSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteFlightAccount = new System.Windows.Forms.Button();
            this.ButtonChangeFlightCurrent = new System.Windows.Forms.Button();
            this.ButtonAddFlightCurrent = new System.Windows.Forms.Button();
            this.DGVflightsCurrent = new System.Windows.Forms.DataGridView();
            this.TabTicketsSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteTicket = new System.Windows.Forms.Button();
            this.ButtonChangeTicket = new System.Windows.Forms.Button();
            this.ButtonAddTicket = new System.Windows.Forms.Button();
            this.DGVtickets = new System.Windows.Forms.DataGridView();
            this.TabWorkersSet = new System.Windows.Forms.TabPage();
            this.ButtonDeleteWorker = new System.Windows.Forms.Button();
            this.ButtonChangeWorker = new System.Windows.Forms.Button();
            this.ButtonAddWorker = new System.Windows.Forms.Button();
            this.DGVworkers = new System.Windows.Forms.DataGridView();
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
            this.TabPlaceStatusSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVplaceStatus)).BeginInit();
            this.TabAccountsSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVaccounts)).BeginInit();
            this.TabFlightsArchiveSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVflightsArchive)).BeginInit();
            this.TabFlightsCurrentSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVflightsCurrent)).BeginInit();
            this.TabTicketsSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtickets)).BeginInit();
            this.TabWorkersSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVworkers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabAviacompaniesSet);
            this.tabControl1.Controls.Add(this.TabCitiesSet);
            this.tabControl1.Controls.Add(this.TabClassPlaceSet);
            this.tabControl1.Controls.Add(this.TabPlanesSet);
            this.tabControl1.Controls.Add(this.TabPositionsSet);
            this.tabControl1.Controls.Add(this.TabPlaceStatusSet);
            this.tabControl1.Controls.Add(this.TabAccountsSet);
            this.tabControl1.Controls.Add(this.TabFlightsArchiveSet);
            this.tabControl1.Controls.Add(this.TabFlightsCurrentSet);
            this.tabControl1.Controls.Add(this.TabTicketsSet);
            this.tabControl1.Controls.Add(this.TabWorkersSet);
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
            this.ButtonDeleteCity.Click += new System.EventHandler(this.ButtonDeleteCity_Click);
            // 
            // ButtonChangeCity
            // 
            this.ButtonChangeCity.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeCity.Name = "ButtonChangeCity";
            this.ButtonChangeCity.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeCity.TabIndex = 6;
            this.ButtonChangeCity.Text = "Change City";
            this.ButtonChangeCity.UseVisualStyleBackColor = true;
            this.ButtonChangeCity.Click += new System.EventHandler(this.ButtonChangeCity_Click);
            // 
            // ButtonAddCity
            // 
            this.ButtonAddCity.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddCity.Name = "ButtonAddCity";
            this.ButtonAddCity.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddCity.TabIndex = 5;
            this.ButtonAddCity.Text = "Add City";
            this.ButtonAddCity.UseVisualStyleBackColor = true;
            this.ButtonAddCity.Click += new System.EventHandler(this.ButtonAddCity_Click);
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
            this.ButtonDeleteClassPlace.Click += new System.EventHandler(this.ButtonDeleteClassPlace_Click);
            // 
            // ButtonChangeClassPlace
            // 
            this.ButtonChangeClassPlace.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeClassPlace.Name = "ButtonChangeClassPlace";
            this.ButtonChangeClassPlace.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeClassPlace.TabIndex = 10;
            this.ButtonChangeClassPlace.Text = "Change Class Place";
            this.ButtonChangeClassPlace.UseVisualStyleBackColor = true;
            this.ButtonChangeClassPlace.Click += new System.EventHandler(this.ButtonChangeClassPlace_Click);
            // 
            // ButtonAddClassPlace
            // 
            this.ButtonAddClassPlace.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddClassPlace.Name = "ButtonAddClassPlace";
            this.ButtonAddClassPlace.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddClassPlace.TabIndex = 9;
            this.ButtonAddClassPlace.Text = "Add Class Place";
            this.ButtonAddClassPlace.UseVisualStyleBackColor = true;
            this.ButtonAddClassPlace.Click += new System.EventHandler(this.ButtonAddClassPlace_Click);
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
            this.ButtonDeletePlane.Click += new System.EventHandler(this.ButtonDeletePlane_Click);
            // 
            // ButtonChangePlane
            // 
            this.ButtonChangePlane.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangePlane.Name = "ButtonChangePlane";
            this.ButtonChangePlane.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangePlane.TabIndex = 14;
            this.ButtonChangePlane.Text = "Change Plane";
            this.ButtonChangePlane.UseVisualStyleBackColor = true;
            this.ButtonChangePlane.Click += new System.EventHandler(this.ButtonChangePlane_Click);
            // 
            // ButtonAddPlane
            // 
            this.ButtonAddPlane.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddPlane.Name = "ButtonAddPlane";
            this.ButtonAddPlane.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddPlane.TabIndex = 13;
            this.ButtonAddPlane.Text = "Add Plane";
            this.ButtonAddPlane.UseVisualStyleBackColor = true;
            this.ButtonAddPlane.Click += new System.EventHandler(this.ButtonAddPlane_Click);
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
            this.ButtonDeletePosition.Click += new System.EventHandler(this.ButtonDeletePosition_Click);
            // 
            // ButtonChangePosition
            // 
            this.ButtonChangePosition.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangePosition.Name = "ButtonChangePosition";
            this.ButtonChangePosition.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangePosition.TabIndex = 18;
            this.ButtonChangePosition.Text = "Change Position";
            this.ButtonChangePosition.UseVisualStyleBackColor = true;
            this.ButtonChangePosition.Click += new System.EventHandler(this.ButtonChangePosition_Click);
            // 
            // ButtonAddPosition
            // 
            this.ButtonAddPosition.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddPosition.Name = "ButtonAddPosition";
            this.ButtonAddPosition.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddPosition.TabIndex = 17;
            this.ButtonAddPosition.Text = "Add Position";
            this.ButtonAddPosition.UseVisualStyleBackColor = true;
            this.ButtonAddPosition.Click += new System.EventHandler(this.ButtonAddPosition_Click);
            // 
            // DGVpositions
            // 
            this.DGVpositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpositions.Location = new System.Drawing.Point(6, 6);
            this.DGVpositions.Name = "DGVpositions";
            this.DGVpositions.Size = new System.Drawing.Size(1120, 336);
            this.DGVpositions.TabIndex = 16;
            // 
            // TabPlaceStatusSet
            // 
            this.TabPlaceStatusSet.Controls.Add(this.ButtonDeletePlaceStatus);
            this.TabPlaceStatusSet.Controls.Add(this.ButtonChangePlaceStatus);
            this.TabPlaceStatusSet.Controls.Add(this.ButtonAddPlaceStatus);
            this.TabPlaceStatusSet.Controls.Add(this.DGVplaceStatus);
            this.TabPlaceStatusSet.Location = new System.Drawing.Point(4, 22);
            this.TabPlaceStatusSet.Name = "TabPlaceStatusSet";
            this.TabPlaceStatusSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabPlaceStatusSet.Size = new System.Drawing.Size(1132, 415);
            this.TabPlaceStatusSet.TabIndex = 5;
            this.TabPlaceStatusSet.Text = "PlaceStatus";
            this.TabPlaceStatusSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeletePlaceStatus
            // 
            this.ButtonDeletePlaceStatus.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeletePlaceStatus.Name = "ButtonDeletePlaceStatus";
            this.ButtonDeletePlaceStatus.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeletePlaceStatus.TabIndex = 23;
            this.ButtonDeletePlaceStatus.Text = "Delete Ticket Status";
            this.ButtonDeletePlaceStatus.UseVisualStyleBackColor = true;
            this.ButtonDeletePlaceStatus.Click += new System.EventHandler(this.ButtonDeleteTicketStatus_Click);
            // 
            // ButtonChangePlaceStatus
            // 
            this.ButtonChangePlaceStatus.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangePlaceStatus.Name = "ButtonChangePlaceStatus";
            this.ButtonChangePlaceStatus.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangePlaceStatus.TabIndex = 22;
            this.ButtonChangePlaceStatus.Text = "Change Ticket Status";
            this.ButtonChangePlaceStatus.UseVisualStyleBackColor = true;
            this.ButtonChangePlaceStatus.Click += new System.EventHandler(this.ButtonChangeTicketStatus_Click);
            // 
            // ButtonAddPlaceStatus
            // 
            this.ButtonAddPlaceStatus.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddPlaceStatus.Name = "ButtonAddPlaceStatus";
            this.ButtonAddPlaceStatus.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddPlaceStatus.TabIndex = 21;
            this.ButtonAddPlaceStatus.Text = "Add Ticket Status";
            this.ButtonAddPlaceStatus.UseVisualStyleBackColor = true;
            this.ButtonAddPlaceStatus.Click += new System.EventHandler(this.ButtonAddTicketStatus_Click);
            // 
            // DGVplaceStatus
            // 
            this.DGVplaceStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVplaceStatus.Location = new System.Drawing.Point(6, 6);
            this.DGVplaceStatus.Name = "DGVplaceStatus";
            this.DGVplaceStatus.Size = new System.Drawing.Size(1120, 336);
            this.DGVplaceStatus.TabIndex = 20;
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
            // TabFlightsArchiveSet
            // 
            this.TabFlightsArchiveSet.Controls.Add(this.ButtonDeleteFlightArchive);
            this.TabFlightsArchiveSet.Controls.Add(this.DGVflightsArchive);
            this.TabFlightsArchiveSet.Location = new System.Drawing.Point(4, 22);
            this.TabFlightsArchiveSet.Name = "TabFlightsArchiveSet";
            this.TabFlightsArchiveSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabFlightsArchiveSet.Size = new System.Drawing.Size(1132, 415);
            this.TabFlightsArchiveSet.TabIndex = 7;
            this.TabFlightsArchiveSet.Text = "FlightsArchive";
            this.TabFlightsArchiveSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteFlightArchive
            // 
            this.ButtonDeleteFlightArchive.Location = new System.Drawing.Point(6, 348);
            this.ButtonDeleteFlightArchive.Name = "ButtonDeleteFlightArchive";
            this.ButtonDeleteFlightArchive.Size = new System.Drawing.Size(1120, 61);
            this.ButtonDeleteFlightArchive.TabIndex = 31;
            this.ButtonDeleteFlightArchive.Text = "Delete FlightArchive row";
            this.ButtonDeleteFlightArchive.UseVisualStyleBackColor = true;
            this.ButtonDeleteFlightArchive.Click += new System.EventHandler(this.ButtonDeleteFlightArchive_Click);
            // 
            // DGVflightsArchive
            // 
            this.DGVflightsArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVflightsArchive.Location = new System.Drawing.Point(6, 6);
            this.DGVflightsArchive.Name = "DGVflightsArchive";
            this.DGVflightsArchive.Size = new System.Drawing.Size(1120, 336);
            this.DGVflightsArchive.TabIndex = 28;
            // 
            // TabFlightsCurrentSet
            // 
            this.TabFlightsCurrentSet.Controls.Add(this.ButtonDeleteFlightAccount);
            this.TabFlightsCurrentSet.Controls.Add(this.ButtonChangeFlightCurrent);
            this.TabFlightsCurrentSet.Controls.Add(this.ButtonAddFlightCurrent);
            this.TabFlightsCurrentSet.Controls.Add(this.DGVflightsCurrent);
            this.TabFlightsCurrentSet.Location = new System.Drawing.Point(4, 22);
            this.TabFlightsCurrentSet.Name = "TabFlightsCurrentSet";
            this.TabFlightsCurrentSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabFlightsCurrentSet.Size = new System.Drawing.Size(1132, 415);
            this.TabFlightsCurrentSet.TabIndex = 8;
            this.TabFlightsCurrentSet.Text = "FlightsCurrent";
            this.TabFlightsCurrentSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteFlightAccount
            // 
            this.ButtonDeleteFlightAccount.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeleteFlightAccount.Name = "ButtonDeleteFlightAccount";
            this.ButtonDeleteFlightAccount.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeleteFlightAccount.TabIndex = 31;
            this.ButtonDeleteFlightAccount.Text = "Delete FlightCurrent";
            this.ButtonDeleteFlightAccount.UseVisualStyleBackColor = true;
            this.ButtonDeleteFlightAccount.Click += new System.EventHandler(this.ButtonDeleteFlightAccount_Click);
            // 
            // ButtonChangeFlightCurrent
            // 
            this.ButtonChangeFlightCurrent.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeFlightCurrent.Name = "ButtonChangeFlightCurrent";
            this.ButtonChangeFlightCurrent.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeFlightCurrent.TabIndex = 30;
            this.ButtonChangeFlightCurrent.Text = "Change FlightCurrent";
            this.ButtonChangeFlightCurrent.UseVisualStyleBackColor = true;
            this.ButtonChangeFlightCurrent.Click += new System.EventHandler(this.ButtonChangeFlightCurrent_Click);
            // 
            // ButtonAddFlightCurrent
            // 
            this.ButtonAddFlightCurrent.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddFlightCurrent.Name = "ButtonAddFlightCurrent";
            this.ButtonAddFlightCurrent.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddFlightCurrent.TabIndex = 29;
            this.ButtonAddFlightCurrent.Text = "Add FlightCurrent";
            this.ButtonAddFlightCurrent.UseVisualStyleBackColor = true;
            this.ButtonAddFlightCurrent.Click += new System.EventHandler(this.ButtonAddFlightCurrent_Click);
            // 
            // DGVflightsCurrent
            // 
            this.DGVflightsCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVflightsCurrent.Location = new System.Drawing.Point(6, 6);
            this.DGVflightsCurrent.Name = "DGVflightsCurrent";
            this.DGVflightsCurrent.Size = new System.Drawing.Size(1120, 336);
            this.DGVflightsCurrent.TabIndex = 28;
            // 
            // TabTicketsSet
            // 
            this.TabTicketsSet.Controls.Add(this.ButtonDeleteTicket);
            this.TabTicketsSet.Controls.Add(this.ButtonChangeTicket);
            this.TabTicketsSet.Controls.Add(this.ButtonAddTicket);
            this.TabTicketsSet.Controls.Add(this.DGVtickets);
            this.TabTicketsSet.Location = new System.Drawing.Point(4, 22);
            this.TabTicketsSet.Name = "TabTicketsSet";
            this.TabTicketsSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabTicketsSet.Size = new System.Drawing.Size(1132, 415);
            this.TabTicketsSet.TabIndex = 9;
            this.TabTicketsSet.Text = "Tickets";
            this.TabTicketsSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteTicket
            // 
            this.ButtonDeleteTicket.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeleteTicket.Name = "ButtonDeleteTicket";
            this.ButtonDeleteTicket.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeleteTicket.TabIndex = 35;
            this.ButtonDeleteTicket.Text = "Delete Ticket";
            this.ButtonDeleteTicket.UseVisualStyleBackColor = true;
            this.ButtonDeleteTicket.Click += new System.EventHandler(this.ButtonDeleteTicket_Click);
            // 
            // ButtonChangeTicket
            // 
            this.ButtonChangeTicket.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeTicket.Name = "ButtonChangeTicket";
            this.ButtonChangeTicket.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeTicket.TabIndex = 34;
            this.ButtonChangeTicket.Text = "Change Ticket";
            this.ButtonChangeTicket.UseVisualStyleBackColor = true;
            this.ButtonChangeTicket.Click += new System.EventHandler(this.ButtonChangeTicket_Click);
            // 
            // ButtonAddTicket
            // 
            this.ButtonAddTicket.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddTicket.Name = "ButtonAddTicket";
            this.ButtonAddTicket.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddTicket.TabIndex = 33;
            this.ButtonAddTicket.Text = "Add Ticket";
            this.ButtonAddTicket.UseVisualStyleBackColor = true;
            this.ButtonAddTicket.Click += new System.EventHandler(this.ButtonAddTicket_Click);
            // 
            // DGVtickets
            // 
            this.DGVtickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtickets.Location = new System.Drawing.Point(6, 6);
            this.DGVtickets.Name = "DGVtickets";
            this.DGVtickets.Size = new System.Drawing.Size(1120, 336);
            this.DGVtickets.TabIndex = 32;
            // 
            // TabWorkersSet
            // 
            this.TabWorkersSet.Controls.Add(this.ButtonDeleteWorker);
            this.TabWorkersSet.Controls.Add(this.ButtonChangeWorker);
            this.TabWorkersSet.Controls.Add(this.ButtonAddWorker);
            this.TabWorkersSet.Controls.Add(this.DGVworkers);
            this.TabWorkersSet.Location = new System.Drawing.Point(4, 22);
            this.TabWorkersSet.Name = "TabWorkersSet";
            this.TabWorkersSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabWorkersSet.Size = new System.Drawing.Size(1132, 415);
            this.TabWorkersSet.TabIndex = 10;
            this.TabWorkersSet.Text = "Workers";
            this.TabWorkersSet.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteWorker
            // 
            this.ButtonDeleteWorker.Location = new System.Drawing.Point(841, 348);
            this.ButtonDeleteWorker.Name = "ButtonDeleteWorker";
            this.ButtonDeleteWorker.Size = new System.Drawing.Size(285, 61);
            this.ButtonDeleteWorker.TabIndex = 39;
            this.ButtonDeleteWorker.Text = "Delete Worker";
            this.ButtonDeleteWorker.UseVisualStyleBackColor = true;
            this.ButtonDeleteWorker.Click += new System.EventHandler(this.ButtonDeleteWorker_Click);
            // 
            // ButtonChangeWorker
            // 
            this.ButtonChangeWorker.Location = new System.Drawing.Point(436, 348);
            this.ButtonChangeWorker.Name = "ButtonChangeWorker";
            this.ButtonChangeWorker.Size = new System.Drawing.Size(285, 61);
            this.ButtonChangeWorker.TabIndex = 38;
            this.ButtonChangeWorker.Text = "Change Worker";
            this.ButtonChangeWorker.UseVisualStyleBackColor = true;
            this.ButtonChangeWorker.Click += new System.EventHandler(this.ButtonChangeWorker_Click);
            // 
            // ButtonAddWorker
            // 
            this.ButtonAddWorker.Location = new System.Drawing.Point(6, 348);
            this.ButtonAddWorker.Name = "ButtonAddWorker";
            this.ButtonAddWorker.Size = new System.Drawing.Size(285, 61);
            this.ButtonAddWorker.TabIndex = 37;
            this.ButtonAddWorker.Text = "Add Worker";
            this.ButtonAddWorker.UseVisualStyleBackColor = true;
            this.ButtonAddWorker.Click += new System.EventHandler(this.ButtonAddWorker_Click);
            // 
            // DGVworkers
            // 
            this.DGVworkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVworkers.Location = new System.Drawing.Point(6, 6);
            this.DGVworkers.Name = "DGVworkers";
            this.DGVworkers.Size = new System.Drawing.Size(1120, 336);
            this.DGVworkers.TabIndex = 36;
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
            this.TabPlaceStatusSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVplaceStatus)).EndInit();
            this.TabAccountsSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVaccounts)).EndInit();
            this.TabFlightsArchiveSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVflightsArchive)).EndInit();
            this.TabFlightsCurrentSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVflightsCurrent)).EndInit();
            this.TabTicketsSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVtickets)).EndInit();
            this.TabWorkersSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVworkers)).EndInit();
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
        private System.Windows.Forms.TabPage TabPlaceStatusSet;
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
        private System.Windows.Forms.Button ButtonDeletePlaceStatus;
        private System.Windows.Forms.Button ButtonChangePlaceStatus;
        private System.Windows.Forms.Button ButtonAddPlaceStatus;
        private System.Windows.Forms.DataGridView DGVplaceStatus;

        public bool RefreshAviacompaniesSetDGV()
        {
            AviacompaniesSet ObjectAviacompaniesSet = new AviacompaniesSet();
            DGVaviacompanies.AutoGenerateColumns = true;
            ObjectAviacompaniesSet.SetCommandTextSelect();
            DGVaviacompanies.DataSource = ObjectAviacompaniesSet.GetTableData(ObjectAviacompaniesSet.CreateDataReaderVariable());
            DGVaviacompanies.Columns[0].Visible = false;
            DGVaviacompanies.Columns[1].Visible = false;
            DGVaviacompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            return true;
        }

        public bool RefreshCitiesSetDGV()
        {
            CitiesSet ObjectCitiesSet = new CitiesSet();
            DGVcities.AutoGenerateColumns = true;
            ObjectCitiesSet.SetCommandTextSelect();
            DGVcities.DataSource = ObjectCitiesSet.GetTableData(ObjectCitiesSet.CreateDataReaderVariable());
            DGVcities.Columns[0].Visible = false;
            DGVcities.Columns[1].Visible = false;
            DGVcities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            return true;
        }

        public bool RefreshClassPlaceSetDGV()
        {
            ClassPlaceSet ObjectClassPlaceSet = new ClassPlaceSet();
            DGVclassPlace.AutoGenerateColumns = true;
            ObjectClassPlaceSet.SetCommandTextSelect();
            DGVclassPlace.DataSource = ObjectClassPlaceSet.GetTableData(ObjectClassPlaceSet.CreateDataReaderVariable());
            DGVclassPlace.Columns[0].Visible = false;
            DGVclassPlace.Columns[1].Visible = false;
            DGVclassPlace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            return true;
        }

        public bool RefreshPlanesSetDGV()
        {
            PlanesSet ObjectPlanesSet = new PlanesSet();
            DGVplanes.AutoGenerateColumns = true;
            ObjectPlanesSet.SetCommandTextSelect();
            DGVplanes.DataSource = ObjectPlanesSet.GetTableData(ObjectPlanesSet.CreateDataReaderVariable());
            DGVplanes.Columns[0].Visible = false;
            DGVplanes.Columns[1].Visible = false;
            DGVplanes.Columns[2].Visible = false;
            DGVplanes.Columns[3].Visible = false;
            DGVplanes.Columns[4].Visible = false;
            DGVplanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            return true;
        }

        public bool RefreshPositionsSetDGV()
        {
            PositionsSet ObjectPositionsSet = new PositionsSet();
            DGVpositions.AutoGenerateColumns = true;
            ObjectPositionsSet.SetCommandTextSelect();
            DGVpositions.DataSource = ObjectPositionsSet.GetTableData(ObjectPositionsSet.CreateDataReaderVariable());
            DGVpositions.Columns[0].Visible = false;
            DGVpositions.Columns[1].Visible = false;
            DGVpositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            return true;
        }

        public bool RefreshPlaceStatusSetDGV()
        {
            PlaceStatusSet ObjectTicketStatusSet = new PlaceStatusSet();
            DGVplaceStatus.AutoGenerateColumns = true;
            ObjectTicketStatusSet.SetCommandTextSelect();
            DGVplaceStatus.DataSource = ObjectTicketStatusSet.GetTableData(ObjectTicketStatusSet.CreateDataReaderVariable());
            DGVplaceStatus.Columns[0].Visible = false;
            DGVplaceStatus.Columns[1].Visible = false;
            DGVplaceStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            return true;
        }

        public bool RefreshAccountsSetDGV()
        {
            AccountsSet ObjectAccountsSet = new AccountsSet();
            DGVaccounts.AutoGenerateColumns = true;
            ObjectAccountsSet.SetCommandTextSelect();
            DGVaccounts.DataSource = ObjectAccountsSet.GetTableData(ObjectAccountsSet.CreateDataReaderVariable());
            DGVaccounts.Columns[0].Visible = false;
            DGVaccounts.Columns[1].Visible = false;
            DGVaccounts.Columns[2].Visible = false;
            DGVaccounts.Columns[3].Visible = false;
            DGVaccounts.Columns[4].Visible = false;
            DGVaccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            return true;
        }

        public bool RefreshFlightsArchiveSetDGV()
        {
            FlightsArchiveSet ObjectFlightsArchiveSet = new FlightsArchiveSet();
            DGVflightsArchive.AutoGenerateColumns = true;
            ObjectFlightsArchiveSet.SetCommandTextSelect();
            DGVflightsArchive.DataSource = ObjectFlightsArchiveSet.GetTableData(ObjectFlightsArchiveSet.CreateDataReaderVariable());
            /*DGVflightsArchive.Columns[0].Visible = false;
            DGVflightsArchive.Columns[1].Visible = false;
            DGVflightsArchive.Columns[2].Visible = false;
            DGVflightsArchive.Columns[3].Visible = false;
            DGVflightsArchive.Columns[4].Visible = false;
            DGVflightsArchive.Columns[5].Visible = false;
            DGVflightsArchive.Columns[6].Visible = false;
            DGVflightsArchive.Columns[7].Visible = false;
            DGVflightsArchive.Columns[8].Visible = false;
            DGVflightsArchive.Columns[9].Visible = false;
            DGVflightsArchive.Columns[10].Visible = false;
            DGVflightsArchive.Columns[11].Visible = false;
            DGVflightsArchive.Columns[12].Visible = false;
            DGVflightsArchive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;*/
            return true;
        }

        public bool RefreshFlightsCurrentSetDGV()
        {
            FlightsCurrentSet ObjectFlightsCurrentSet = new FlightsCurrentSet();
            DGVflightsCurrent.AutoGenerateColumns = true;
            ObjectFlightsCurrentSet.SetCommandTextSelect();
            DGVflightsCurrent.DataSource = ObjectFlightsCurrentSet.GetTableData(ObjectFlightsCurrentSet.CreateDataReaderVariable());
            DGVflightsCurrent.Columns[0].Visible = false;
            DGVflightsCurrent.Columns[1].Visible = false;
            DGVflightsCurrent.Columns[2].Visible = false;
            DGVflightsCurrent.Columns[3].Visible = false;
            DGVflightsCurrent.Columns[4].Visible = false;
            DGVflightsCurrent.Columns[5].Visible = false;
            DGVflightsCurrent.Columns[6].Visible = false;
            DGVflightsCurrent.Columns[7].Visible = false;
            DGVflightsCurrent.Columns[8].Visible = false;
            DGVflightsCurrent.Columns[9].Visible = false;
            DGVflightsCurrent.Columns[10].Visible = false;
            DGVflightsCurrent.Columns[11].Visible = false;
            DGVflightsCurrent.Columns[12].Visible = false;
            DGVflightsCurrent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            return true;
        }

        public bool RefreshTicketsSetDGV()
        {
            TicketsSet ObjectTicketsSet = new TicketsSet();
            DGVtickets.AutoGenerateColumns = true;
            ObjectTicketsSet.SetCommandTextSelect();
            DGVtickets.DataSource = ObjectTicketsSet.GetTableData(ObjectTicketsSet.CreateDataReaderVariable());
            return true;
        }

        public bool RefreshWorkersSetDGV()
        {
            WorkersSet ObjectWorkersSet = new WorkersSet();
            DGVworkers.AutoGenerateColumns = true;
            ObjectWorkersSet.SetCommandTextSelect();
            DGVworkers.DataSource = ObjectWorkersSet.GetTableData(ObjectWorkersSet.CreateDataReaderVariable());
            return true;
        }

        private System.Windows.Forms.TabPage TabAccountsSet;
        private System.Windows.Forms.Button ButtonDeleteAccount;
        private System.Windows.Forms.Button ButtonChangeAccount;
        private System.Windows.Forms.Button ButtonAddAccount;
        private System.Windows.Forms.DataGridView DGVaccounts;
        private System.Windows.Forms.TabPage TabFlightsArchiveSet;
        private System.Windows.Forms.Button ButtonDeleteFlightArchive;
        private System.Windows.Forms.DataGridView DGVflightsArchive;
        private System.Windows.Forms.TabPage TabFlightsCurrentSet;
        private System.Windows.Forms.Button ButtonDeleteFlightAccount;
        private System.Windows.Forms.Button ButtonChangeFlightCurrent;
        private System.Windows.Forms.Button ButtonAddFlightCurrent;
        private System.Windows.Forms.DataGridView DGVflightsCurrent;
        private System.Windows.Forms.TabPage TabTicketsSet;
        private System.Windows.Forms.Button ButtonDeleteTicket;
        private System.Windows.Forms.Button ButtonChangeTicket;
        private System.Windows.Forms.Button ButtonAddTicket;
        private System.Windows.Forms.DataGridView DGVtickets;
        private System.Windows.Forms.TabPage TabWorkersSet;
        private System.Windows.Forms.Button ButtonDeleteWorker;
        private System.Windows.Forms.Button ButtonChangeWorker;
        private System.Windows.Forms.Button ButtonAddWorker;
        private System.Windows.Forms.DataGridView DGVworkers;
    }
}