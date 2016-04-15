using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiplomaNegoda.Classes.TablesOnlyPK;

namespace DiplomaNegoda.Forms.InsertForms
{
    public partial class FormAddAccount : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBWorkersSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBPositionsSet = new Classes.DBLookUpComboBox();
        public FormAddAccount()
        {
            InitializeComponent();
        }

        private void FormAddAccount_Shown(object sender, EventArgs e)
        {
            ObjectDBLUCBWorkersSet.SetMasStringsValues(ObjectDBLUCBWorkersSet.GetDataForComboBox("[dbo].[WorkersSet]"));
            ObjectDBLUCBWorkersSet.HookOnComboBox(ComboBoxWorker);
            ComboBoxWorker.SelectedIndex = 0;

            
            ObjectDBLUCBPositionsSet.SetMasStringsValues(ObjectDBLUCBPositionsSet.GetDataForComboBox("[dbo].[PositionsSet]"));
            ObjectDBLUCBPositionsSet.HookOnComboBox(ComboBoxPosition);
            ComboBoxPosition.SelectedIndex = 0;
        }

        private void ButtonAddAccount_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ObjectDBLUCBWorkersSet.iD[ComboBoxWorker.SelectedIndex]);

            //insert in DB
            AccountsSet ObjectAccountsSet = new AccountsSet();
            ObjectAccountsSet.InsertIntoTable(ObjectDBLUCBWorkersSet.iD[ComboBoxWorker.SelectedIndex], TextBoxLogin.Text, TextBoxPassword.Text, ObjectDBLUCBPositionsSet.iD[ComboBoxPosition.SelectedIndex]);

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshAccountsSetDGV();
            }
        }
    }
}
