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
using DiplomaNegoda.Classes.OperationOnDB;

namespace DiplomaNegoda.Forms
{
    public partial class FormSellingReservationing : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBClassPlaceSet = new Classes.DBLookUpComboBox();
        public string numberOfFlight, fromCity, toCity, goDate, goTime, arriveDate, arriveTime, costEco, costBus, nameOfTable;

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    RefreshListOfPlacesDGVNow(nameOfTable, ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex], "7");
                    break;
                case 1:
                    RefreshListOfPlacesDGVLater(nameOfTable, ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex], "2");
                    break;
                case 2:
                    RefreshListOfPlacesDGVSold(nameOfTable, ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex], "1");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSellTicket ObjectFormSellTicket = new FormSellTicket(
            DGVlistOfPlacesSellLater[0, DGVlistOfPlacesSellLater.CurrentCellAddress.Y].Value.ToString(),
            TextBoxNumberOfFlight.Text,
            ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex],
            LabelCost.Text,
            DGVlistOfPlacesSellLater[1, DGVlistOfPlacesSellLater.CurrentCellAddress.Y].Value.ToString(),
            TextBoxFrom.Text,
            TextBoxTo.Text,
            TextBoxGoDate.Text,
            TextBoxGoTime.Text,
            TextBoxArriveDate.Text,
            TextBoxArriveTime.Text,
            nameOfTable,
            LabelCost.Text
            );
            ObjectFormSellTicket.Owner = this;
            ObjectFormSellTicket.ShowDialog();
        }

        private void ButtonReservation_Click(object sender, EventArgs e)
        {
            //меняем статус билета на забронировано
            ChangeStatusOfTicketSet ObjectChangeStatusOfTicketSet = new ChangeStatusOfTicketSet(nameOfTable, DGVlistOfPlacesSellNow[0, DGVlistOfPlacesSellNow.CurrentCellAddress.Y].Value.ToString());
            ObjectChangeStatusOfTicketSet.UpdateRowInTableReserve();
            //обновляем таблицу
            RefreshListOfPlacesDGVNow(nameOfTable, ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex], "7");
        }

        private void TabPageSellingReservationing_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            FormSellTicket ObjectFormSellTicket = new FormSellTicket(
                DGVlistOfPlacesSellNow[0, DGVlistOfPlacesSellNow.CurrentCellAddress.Y].Value.ToString(),
                TextBoxNumberOfFlight.Text,
                ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex],
                LabelCost.Text,
                DGVlistOfPlacesSellNow[1, DGVlistOfPlacesSellNow.CurrentCellAddress.Y].Value.ToString(),
                TextBoxFrom.Text,
                TextBoxTo.Text,
                TextBoxGoDate.Text,
                TextBoxGoTime.Text,
                TextBoxArriveDate.Text,
                TextBoxArriveTime.Text,
                nameOfTable,
                LabelCost.Text
                );
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
            RefreshListOfPlacesDGVNow(nameOfTable, ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex], "7");
            RefreshListOfPlacesDGVLater(nameOfTable, ObjectDBLUCBClassPlaceSet.iD[ComboBoxClassOfPlace.SelectedIndex], "2");
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
