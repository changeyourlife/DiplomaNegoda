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
    public partial class FormChangeAccount : Form
    {
        Classes.DBLookUpComboBox ObjectDBLUCBWorkersSet = new Classes.DBLookUpComboBox();
        Classes.DBLookUpComboBox ObjectDBLUCBPositionsSet = new Classes.DBLookUpComboBox();
        public string iDRow, login, password, iDWorkersSet, iDPositionsSet;

        public FormChangeAccount(string IDRow, string IDWorkersSet, string Login, string Password, string IDPositionsSet)
        {
            InitializeComponent();
            iDRow = IDRow;
            login = Login;
            password = Password;
            iDWorkersSet = IDWorkersSet;
            iDPositionsSet = IDPositionsSet;
        }

        private void FormChangeAccount_Shown(object sender, EventArgs e)
        {
            ObjectDBLUCBWorkersSet.SetMasStringsValues(ObjectDBLUCBWorkersSet.GetDataForComboBox("[dbo].[WorkersSet]"));
            ObjectDBLUCBWorkersSet.HookOnComboBox(ComboBoxWorker);
            ComboBoxWorker.SelectedIndex = ObjectDBLUCBWorkersSet.ReturnIndexOfElementID(iDWorkersSet);

            TextBoxLogin.Text = login;

            TextBoxPassword.Text = password;

            ObjectDBLUCBPositionsSet.SetMasStringsValues(ObjectDBLUCBPositionsSet.GetDataForComboBox("[dbo].[PositionsSet]"));
            ObjectDBLUCBPositionsSet.HookOnComboBox(ComboBoxPosition);
            ComboBoxPosition.SelectedIndex = ObjectDBLUCBPositionsSet.ReturnIndexOfElementID(iDPositionsSet);
        }

        private void ButtonChangeAccount_Click(object sender, EventArgs e)
        {
            //insert in DB
            AccountsSet ObjectAccountsSet = new AccountsSet();
            ObjectAccountsSet.UpdateRowInTable(iDRow, ObjectDBLUCBWorkersSet.iD[ComboBoxWorker.SelectedIndex], TextBoxLogin.Text, TextBoxPassword.Text, ObjectDBLUCBPositionsSet.iD[ComboBoxPosition.SelectedIndex]);

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshAccountsSetDGV();
            }
        }
    }
}
