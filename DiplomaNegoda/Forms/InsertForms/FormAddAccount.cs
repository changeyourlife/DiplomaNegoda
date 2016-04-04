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
    public partial class FormAddAccount : Form
    {
        public FormAddAccount()
        {
            InitializeComponent();
        }

        private void FormAddAccount_Shown(object sender, EventArgs e)
        {
            Classes.DBLookUpComboBox ObjectDBLUCBWorkerssSet = new Classes.DBLookUpComboBox();
            ObjectDBLUCBWorkerssSet.SetMasStringsValues(ObjectDBLUCBWorkerssSet.GetDataForComboBox("[dbo].[WorkersSet]"));
            ObjectDBLUCBWorkerssSet.HookOnComboBox(ComboBoxWorker);
            ComboBoxWorker.SelectedIndex = 0;

            Classes.DBLookUpComboBox ObjectDBLUCBPositionsSet = new Classes.DBLookUpComboBox();
            ObjectDBLUCBPositionsSet.SetMasStringsValues(ObjectDBLUCBPositionsSet.GetDataForComboBox("[dbo].[PositionsSet]"));
            ObjectDBLUCBPositionsSet.HookOnComboBox(ComboBoxPosition);
            ComboBoxPosition.SelectedIndex = 0;
        }
    }
}
