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
    public partial class FormChangeTicket : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBFlightsCurrentSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBClassPlaceSet = new Classes.DBLookUpComboBox();

        public string numOfTicket, numOfPlace, flightID, classOfPlaceID, cost, fIO, personalDataSpecial;

        private void FormChangeTicket_Shown(object sender, EventArgs e)
        {
            TextBoxNumOfPlace.Text = numOfPlace;

            ObjectDBLUCBFlightsCurrentSet.SetMasStringsValues(ObjectDBLUCBFlightsCurrentSet.GetDataForComboBox("[dbo].[FlightsCurrentSet]"));
            ObjectDBLUCBFlightsCurrentSet.HookOnComboBox(ComboBoxFlightID);
            ComboBoxFlightID.SelectedIndex = ObjectDBLUCBFlightsCurrentSet.ReturnIndexOfElementID(flightID);

            ObjectDBLUCBClassPlaceSet.SetMasStringsValues(ObjectDBLUCBClassPlaceSet.GetDataForComboBox("[dbo].[ClassPlaceSet]"));
            ObjectDBLUCBClassPlaceSet.HookOnComboBox(ComboBoxClassOfPlaceID);
            ComboBoxClassOfPlaceID.SelectedIndex = ObjectDBLUCBClassPlaceSet.ReturnIndexOfElementID(classOfPlaceID);

            TextBoxCost.Text = cost;

            TextBoxFIO.Text = fIO;

            TextBoxPersonalDataSpecial.Text = personalDataSpecial;
        }

        private void ButtonChangeTicket_Click(object sender, EventArgs e)
        {
            //update row in DB
            TicketsSet ObjectTicketsSet = new TicketsSet();
            ObjectTicketsSet.UpdateRowInTable
                (
                numOfTicket,
                TextBoxNumOfPlace.Text,
                ObjectDBLUCBFlightsCurrentSet.iD[ComboBoxFlightID.SelectedIndex],
                ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlaceID.SelectedIndex],
                TextBoxCost.Text,
                TextBoxFIO.Text,
                TextBoxPersonalDataSpecial.Text
                );

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshTicketsSetDGV();
            }
        }

        public FormChangeTicket(string NumOfTicket, string NumOfPlace, string FlightID, string ClassOfPlaceID, string Cost, string FIO, string PersonalDataSpecial)
        {
            InitializeComponent();
            numOfTicket = NumOfTicket;
            numOfPlace = NumOfPlace;
            flightID = FlightID;
            classOfPlaceID = ClassOfPlaceID;
            cost = Cost;
            fIO = FIO;
            personalDataSpecial = PersonalDataSpecial;
        }
    }
}
