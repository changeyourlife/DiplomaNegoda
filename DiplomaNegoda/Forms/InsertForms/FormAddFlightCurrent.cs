using DiplomaNegoda.Classes.TablesOnlyPK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaNegoda.Forms.InsertForms
{
    public partial class FormAddFlightCurrent : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBAviacompaniesSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBPlanesSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBCitiesToSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBCitiesFromSet = new Classes.DBLookUpComboBox();

        public FormAddFlightCurrent()
        {
            InitializeComponent();
        }

        private void ButtonAddFlightCurrent_Click(object sender, EventArgs e)
        {
            //insert in DB
            FlightsCurrentSet ObjectFlightsCurrentSet = new FlightsCurrentSet();
            ObjectFlightsCurrentSet.InsertIntoTable(ObjectDBLUCBAviacompaniesSet.iD[ComboBoxAviacompanyID.SelectedIndex], ObjectDBLUCBPlanesSet.iD[ComboBoxPlaneID.SelectedIndex], ObjectDBLUCBCitiesToSet.iD[ComboBoxtoID.SelectedIndex], ObjectDBLUCBCitiesFromSet.iD[ComboBoxfromID.SelectedIndex], DateTimePickerGoDateTime.Value.ToString(), DateTimePickerArriveDateTime.Value.ToString(), TextBoxCostOfEcoClass.Text, TextBoxCostOfBusinessClass.Text);

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshFlightsCurrentSetDGV();
            }
        }

        private void FormAddFlightCurrent_Shown(object sender, EventArgs e)
        {
            ObjectDBLUCBAviacompaniesSet.SetMasStringsValues(ObjectDBLUCBAviacompaniesSet.GetDataForComboBox("[dbo].[AviacompaniesSet]"));
            ObjectDBLUCBAviacompaniesSet.HookOnComboBox(ComboBoxAviacompanyID);
            ComboBoxAviacompanyID.SelectedIndex = 0;

            ObjectDBLUCBPlanesSet.SetMasStringsValues(ObjectDBLUCBPlanesSet.GetDataForComboBox("[dbo].[PlanesSet]"));
            ObjectDBLUCBPlanesSet.HookOnComboBox(ComboBoxPlaneID);
            ComboBoxPlaneID.SelectedIndex = 0;

            ObjectDBLUCBCitiesToSet.SetMasStringsValues(ObjectDBLUCBCitiesToSet.GetDataForComboBox("[dbo].[CitiesSet]"));
            ObjectDBLUCBCitiesToSet.HookOnComboBox(ComboBoxtoID);
            ComboBoxtoID.SelectedIndex = 0;

            ObjectDBLUCBCitiesFromSet.SetMasStringsValues(ObjectDBLUCBCitiesFromSet.GetDataForComboBox("[dbo].[CitiesSet]"));
            ObjectDBLUCBCitiesFromSet.HookOnComboBox(ComboBoxfromID);
            ComboBoxfromID.SelectedIndex = 0;
        }
    }
}
