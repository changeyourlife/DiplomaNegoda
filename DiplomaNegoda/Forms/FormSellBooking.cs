using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiplomaNegoda.Forms.Cassier;

namespace DiplomaNegoda.Forms
{
    public partial class FormSellingReservationing : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBClassPlaceSet = new Classes.DBLookUpComboBox();
        public string numberOfFlight, fromCity, toCity, goDate, goTime, arriveDate, arriveTime, costEco, costBus, nameOfTable;

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            FormSellTicket ObjectFormSellTicket = new FormSellTicket();
            ObjectFormSellTicket.Owner = this;
            ObjectFormSellTicket.ShowDialog();
        }

        private void ComboBoxClassOfPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex]) == 1)
            {
                LabelCost.Text = costEco;
            }
            else
            {
                LabelCost.Text = costBus;
            }
            RefreshListOfPlacesDGV(nameOfTable, ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex], "7");
            
        }

        public FormSellingReservationing(string NumberOfFlight, string FromCity, string ToCity, string GoDate, string GoTime, string ArriveDate, string ArriveTime, string CostEco, string CostBus, string NameOfTable)
        {
            InitializeComponent();
            numberOfFlight = NumberOfFlight;
            fromCity = FromCity;
            toCity = ToCity;
            goDate = GoDate;
            goTime = GoTime;
            arriveDate = ArriveDate;
            arriveTime = ArriveTime;
            costEco = CostEco;
            costBus = CostBus;
            nameOfTable = NameOfTable;
        }

        private void FormSellBooking_Shown(object sender, EventArgs e)
        {
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount - 2, 0);
            TextBoxNumberOfFlight.Text = numberOfFlight;
            TextBoxFrom.Text = fromCity;
            TextBoxTo.Text = toCity;
            TextBoxGoDate.Text = goDate;
            TextBoxGoTime.Text = goTime;
            TextBoxArriveDate.Text = arriveDate;
            TextBoxArriveTime.Text = arriveTime;

            ObjectDBLUCBClassPlaceSet.SetMasStringsValues(ObjectDBLUCBClassPlaceSet.GetDataForComboBox("[dbo].[ClassPlaceSet]"));
            ObjectDBLUCBClassPlaceSet.HookOnComboBox(ComboBoxClassOfPlace);
            ComboBoxClassOfPlace.SelectedIndex = 0;
        }
    }
}
