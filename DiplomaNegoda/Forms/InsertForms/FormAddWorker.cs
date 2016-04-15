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
    public partial class FormAddWorker : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBPositionsSet = new Classes.DBLookUpComboBox();
        public FormAddWorker()
        {
            InitializeComponent();
        }

        private void FormAddWorker_Shown(object sender, EventArgs e)
        {
            ObjectDBLUCBPositionsSet.SetMasStringsValues(ObjectDBLUCBPositionsSet.GetDataForComboBox("[dbo].[PositionsSet]"));
            ObjectDBLUCBPositionsSet.HookOnComboBox(ComboBoxPositionID);
            ComboBoxPositionID.SelectedIndex = 0;
        }

        private void ButtonAddWorker_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(TextBoxFIO.Text+" "+ DateTimePickerBornDate.Value.ToString()+ " " + DateTimePickerArriveDate.Value.ToString() + " " + TextBoxContactData.Text);

            //insert in DB
            WorkersSet ObjectWorkersSet = new WorkersSet();
            ObjectWorkersSet.InsertIntoTable(TextBoxFIO.Text, DateTimePickerBornDate.Value.ToString(), ObjectDBLUCBPositionsSet.iD[ComboBoxPositionID.SelectedIndex], DateTimePickerArriveDate.Value.ToString(), TextBoxContactData.Text);

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshWorkersSetDGV();
            }
        }
    }
}
