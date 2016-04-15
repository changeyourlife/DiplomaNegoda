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
    public partial class FormAddTicket : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBFlightsCurrentSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBClassPlaceSet = new Classes.DBLookUpComboBox();

        public FormAddTicket()
        {
            InitializeComponent();
        }

        private void ButtonAddTicket_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(TextBoxFIO.Text+" "+ DateTimePickerBornDate.Value.ToString()+ " " + DateTimePickerArriveDate.Value.ToString() + " " + TextBoxContactData.Text);

            //insert in DB
            TicketsSet ObjectTicketsSet = new TicketsSet();
            ObjectTicketsSet.InsertIntoTable
                (
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

        private void FormAddTicket_Shown(object sender, EventArgs e)
        {
            ObjectDBLUCBFlightsCurrentSet.SetMasStringsValues(ObjectDBLUCBFlightsCurrentSet.GetDataForComboBox("[dbo].[FlightsCurrentSet]"));
            ObjectDBLUCBFlightsCurrentSet.HookOnComboBox(ComboBoxFlightID);
            ComboBoxFlightID.SelectedIndex = 0;

            ObjectDBLUCBClassPlaceSet.SetMasStringsValues(ObjectDBLUCBClassPlaceSet.GetDataForComboBox("[dbo].[ClassPlaceSet]"));
            ObjectDBLUCBClassPlaceSet.HookOnComboBox(ComboBoxClassOfPlaceID);
            ComboBoxClassOfPlaceID.SelectedIndex = 0;
        }
    }
}
