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

namespace DiplomaNegoda.Forms.UpdateForms
{
    public partial class FormChangeFlightCurrent : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBAviacompaniesSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBPlanesSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBCitiesToSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBCitiesFromSet = new Classes.DBLookUpComboBox();
        public string iDRow, aviacompanyID, planeID, toID, fromID, goDateTime, arriveDateTime, costOfEcoClass, costOfBusinessClass;

        private void ButtonChangeFlightCurrent_Click(object sender, EventArgs e)
        {
            //update row in DB
            FlightsCurrentSet ObjectFlightsCurrentSet = new FlightsCurrentSet();
            ObjectFlightsCurrentSet.UpdateRowInTable
                (
                iDRow, 
                ObjectDBLUCBAviacompaniesSet.iD[ComboBoxAviacompanyID.SelectedIndex], 
                ObjectDBLUCBPlanesSet.iD[ComboBoxPlaneID.SelectedIndex], 
                ObjectDBLUCBCitiesToSet.iD[ComboBoxtoID.SelectedIndex], 
                ObjectDBLUCBCitiesFromSet.iD[ComboBoxfromID.SelectedIndex], 
                DateTimePickerGoDateTime.Value.ToString(), 
                DateTimePickerArriveDateTime.Value.ToString(), 
                TextBoxCostOfEcoClass.Text, 
                TextBoxCostOfBusinessClass.Text
                );

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshFlightsCurrentSetDGV();
            }
        }

        public FormChangeFlightCurrent(string IDRow, string AviacompanyID, string PlaneID, string ToID, string FromID, string GoDateTime, string ArriveDateTime, string CostOfEcoClass, string CostOfBusinessClass)
        {
            InitializeComponent();
            iDRow = IDRow;
            aviacompanyID = AviacompanyID;
            planeID = PlaneID;
            toID = ToID;
            fromID = FromID;
            goDateTime = GoDateTime;
            arriveDateTime = ArriveDateTime;
            costOfEcoClass = CostOfEcoClass;
            costOfBusinessClass = CostOfBusinessClass;
        }

        private void FormChangeFlightCurrent_Shown(object sender, EventArgs e)
        {
            ObjectDBLUCBAviacompaniesSet.SetMasStringsValues(ObjectDBLUCBAviacompaniesSet.GetDataForComboBox("[dbo].[AviacompaniesSet]"));
            ObjectDBLUCBAviacompaniesSet.HookOnComboBox(ComboBoxAviacompanyID);
            ComboBoxAviacompanyID.SelectedIndex = ObjectDBLUCBAviacompaniesSet.ReturnIndexOfElementID(aviacompanyID);

            ObjectDBLUCBPlanesSet.SetMasStringsValues(ObjectDBLUCBPlanesSet.GetDataForComboBox("[dbo].[PlanesSet]"));
            ObjectDBLUCBPlanesSet.HookOnComboBox(ComboBoxPlaneID);
            ComboBoxPlaneID.SelectedIndex = ObjectDBLUCBPlanesSet.ReturnIndexOfElementID(planeID);

            ObjectDBLUCBCitiesToSet.SetMasStringsValues(ObjectDBLUCBCitiesToSet.GetDataForComboBox("[dbo].[CitiesSet]"));
            ObjectDBLUCBCitiesToSet.HookOnComboBox(ComboBoxtoID);
            ComboBoxtoID.SelectedIndex = ObjectDBLUCBCitiesToSet.ReturnIndexOfElementID(toID);

            ObjectDBLUCBCitiesFromSet.SetMasStringsValues(ObjectDBLUCBCitiesFromSet.GetDataForComboBox("[dbo].[CitiesSet]"));
            ObjectDBLUCBCitiesFromSet.HookOnComboBox(ComboBoxfromID);
            ComboBoxfromID.SelectedIndex = ObjectDBLUCBCitiesFromSet.ReturnIndexOfElementID(fromID);

            DateTimePickerGoDateTime.Value = DateTime.Parse(goDateTime);

            DateTimePickerArriveDateTime.Value = DateTime.Parse(arriveDateTime);

            TextBoxCostOfEcoClass.Text = costOfEcoClass;

            TextBoxCostOfBusinessClass.Text = costOfBusinessClass;
        }
    }
}
