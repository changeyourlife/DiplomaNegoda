﻿using System;
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
using DiplomaNegoda.Classes.OperationOnDB;

namespace DiplomaNegoda.Forms
{
    public partial class FormCassier: Form
    {
        DBLookUpComboBox ObjectDBLUCBCitiesSetFROM = new DBLookUpComboBox();
        DBLookUpComboBox ObjectDBLUCBCitiesSetTO = new DBLookUpComboBox();

        public FormCassier()
        {
            InitializeComponent();
        }

        private void FormCassier_Shown(object sender, EventArgs e)
        {
            DGVflightsCurrentSet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

            DGVflightsCurrentSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DGVflightsCurrentSet.Select();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ShowFlightsByParams();
            if (DGVflightsCurrentSet.Columns.GetColumnCount(DataGridViewElementStates.None) > 0)
            {
                DGVflightsCurrentSet.Columns[0].Visible = false;
                DGVflightsCurrentSet.Columns[1].Visible = false;
                DGVflightsCurrentSet.Columns[2].Visible = false;
                DGVflightsCurrentSet.Columns[3].Visible = false;
                DGVflightsCurrentSet.Columns[4].Visible = false;
                DGVflightsCurrentSet.Columns[5].Visible = false;
                DGVflightsCurrentSet.Columns[6].Visible = false;
                DGVflightsCurrentSet.Columns[7].Visible = false;
                DGVflightsCurrentSet.Columns[8].Visible = false;
                DGVflightsCurrentSet.Columns[9].Visible = false;
                DGVflightsCurrentSet.Columns[10].Visible = false;
                DGVflightsCurrentSet.Columns[11].Visible = false;
                DGVflightsCurrentSet.Columns[12].Visible = false;
                DGVflightsCurrentSet.Columns[13].Visible = false;
                DGVflightsCurrentSet.Columns[14].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameOfTableForExist = DGVflightsCurrentSet[0, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString() + DGVflightsCurrentSet[17, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString() + DGVflightsCurrentSet[18, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString();
            DBIsTableExist ObjectDBIsTableExist = new DBIsTableExist();
            if (ObjectDBIsTableExist.IsTableExist(nameOfTableForExist))
            {
                MessageBox.Show("Таблица " + nameOfTableForExist + " ЕСТЬ");
                //Переходим на форму с продажей и бронированием этих билетов
                FormSellingReservationing ObjectFormSellBooking = new FormSellingReservationing(
                    DGVflightsCurrentSet[0, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    DGVflightsCurrentSet[17, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    DGVflightsCurrentSet[18, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    DateTime.Parse(DGVflightsCurrentSet[5, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()).ToShortDateString(),
                    DateTime.Parse(DGVflightsCurrentSet[5, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()).ToShortTimeString(),
                    DateTime.Parse(DGVflightsCurrentSet[6, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()).ToShortDateString(),
                    DateTime.Parse(DGVflightsCurrentSet[6, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()).ToShortTimeString(),
                    DGVflightsCurrentSet[7, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    DGVflightsCurrentSet[8, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    nameOfTableForExist
                    )
                    ;
                ObjectFormSellBooking.Owner = this;
                ObjectFormSellBooking.ShowDialog();
            }
            else
            {
                MessageBox.Show("Таблицы " + nameOfTableForExist + " НЕТ");
                //Создаём таблицу
                DBOperationsWithTableWithTicketsOnFlight ObjectDBOperationsWithTableWithTicketsOnFlight = new DBOperationsWithTableWithTicketsOnFlight();
                ObjectDBOperationsWithTableWithTicketsOnFlight.CreateTable(nameOfTableForExist);
                //Заполняем её
                for (int i = 0; i < Int32.Parse(DGVflightsCurrentSet[13, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()); i++)
                {
                    ObjectDBOperationsWithTableWithTicketsOnFlight.FillTableWithPlacesForFlight(nameOfTableForExist, "1", "7");
                }
                for (int i = 0; i < Int32.Parse(DGVflightsCurrentSet[14, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()); i++)
                {
                    ObjectDBOperationsWithTableWithTicketsOnFlight.FillTableWithPlacesForFlight(nameOfTableForExist, "2", "7");
                }
                //Переходим на форму с продажей и бронированием этих билетов
                FormSellingReservationing ObjectFormSellBooking = new FormSellingReservationing(
                    DGVflightsCurrentSet[0, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    DGVflightsCurrentSet[17, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    DGVflightsCurrentSet[18, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    DateTime.Parse(DGVflightsCurrentSet[5, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()).ToShortDateString(),
                    DateTime.Parse(DGVflightsCurrentSet[5, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()).ToShortTimeString(),
                    DateTime.Parse(DGVflightsCurrentSet[6, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()).ToShortDateString(),
                    DateTime.Parse(DGVflightsCurrentSet[6, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString()).ToShortTimeString(),
                    DGVflightsCurrentSet[7, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    DGVflightsCurrentSet[8, DGVflightsCurrentSet.CurrentCellAddress.Y].Value.ToString(),
                    nameOfTableForExist
                    )
                    ;
                ObjectFormSellBooking.Owner = this;
                ObjectFormSellBooking.ShowDialog();
            }
        }
    }
}
