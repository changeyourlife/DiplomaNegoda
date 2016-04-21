using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiplomaNegoda.Classes;
using DiplomaNegoda.Classes.TablesOnlyPK;

namespace DiplomaNegoda.Forms
{
    public partial class FormCassier: Form
    {
        DBLookUpComboBox ObjectDBLUCBCitiesSetFROM = new Classes.DBLookUpComboBox();
        DBLookUpComboBox ObjectDBLUCBCitiesSetTO = new Classes.DBLookUpComboBox();
        public FormCassier()
        {
            InitializeComponent();
        }

        private void FormCassier_Shown(object sender, EventArgs e)
        {
            ObjectDBLUCBCitiesSetFROM.SetMasStringsValues(ObjectDBLUCBCitiesSetFROM.GetDataForComboBox("[dbo].[CitiesSet]"));
            ObjectDBLUCBCitiesSetFROM.HookOnComboBox(ComboBoxCityFROM);
            ComboBoxCityFROM.SelectedIndex = 0;

            ObjectDBLUCBCitiesSetTO.SetMasStringsValues(ObjectDBLUCBCitiesSetTO.GetDataForComboBox("[dbo].[CitiesSet]"));
            ObjectDBLUCBCitiesSetTO.HookOnComboBox(ComboBoxCityTO);
            ComboBoxCityTO.SelectedIndex = 0;

            DGVflightsCurrentSet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ShowFlightsByParams()
        {
            FlightsCurrentSet ObjectFlightsCurrentSet = new FlightsCurrentSet();
            DGVflightsCurrentSet.AutoGenerateColumns = true;
            ObjectFlightsCurrentSet.SetCommandTextSelectAllForViewFlights(DateTimePickerDataOut.Value.ToShortDateString(), DateTimePickerDataOut.Value.AddDays(1).ToShortDateString(), ObjectDBLUCBCitiesSetFROM.iD[ComboBoxCityFROM.SelectedIndex], ObjectDBLUCBCitiesSetTO.iD[ComboBoxCityTO.SelectedIndex]);
            DGVflightsCurrentSet.DataSource = ObjectFlightsCurrentSet.GetTableData(ObjectFlightsCurrentSet.CreateDataReaderVariable());
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ShowFlightsByParams();
        }
    }
}
