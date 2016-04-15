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
    public partial class FormChangeWorker : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBPositionsSet = new Classes.DBLookUpComboBox();
        public string iDRow, fIO, bornDate, positionID, arriveDateWorker, contactData;

        private void FormChangeWorker_Shown(object sender, EventArgs e)
        {
            TextBoxFIO.Text = fIO;

            DateTimePickerBornDate.Value = DateTime.Parse(bornDate);

            ObjectDBLUCBPositionsSet.SetMasStringsValues(ObjectDBLUCBPositionsSet.GetDataForComboBox("[dbo].[PositionsSet]"));
            ObjectDBLUCBPositionsSet.HookOnComboBox(ComboBoxPositionID);
            ComboBoxPositionID.SelectedIndex = ObjectDBLUCBPositionsSet.ReturnIndexOfElementID(positionID);

            DateTimePickerArriveDate.Value = DateTime.Parse(arriveDateWorker);

            TextBoxContactData.Text = contactData;
        }

        public FormChangeWorker(string IDRow, string FIO, string BornDate, string PositionID, string ArriveDateWorker, string ContactData)
        {
            InitializeComponent();
            iDRow = IDRow;
            fIO = FIO;
            bornDate = BornDate;
            positionID = PositionID;
            arriveDateWorker = ArriveDateWorker;
            contactData = ContactData;
        }

        private void ButtonChangeWorker_Click(object sender, EventArgs e)
        {
            //update row in DB
            WorkersSet ObjectWorkersSet = new WorkersSet();
            ObjectWorkersSet.UpdateRowInTable(iDRow, TextBoxFIO.Text, DateTimePickerBornDate.Value.ToString(), ObjectDBLUCBPositionsSet.iD[ComboBoxPositionID.SelectedIndex], DateTimePickerArriveDate.Value.ToString(), TextBoxContactData.Text);

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshWorkersSetDGV();
            }
        }
    }
}
