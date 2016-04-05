using DiplomaNegoda.Classes.TablesOnlyPK;
using DiplomaNegoda.Forms.InsertForms;
using DiplomaNegoda.Forms.UpdateForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaNegoda.Forms
{
    public partial class FormAdmin: Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            FormEnter ObjectFormEnter = this.Owner as FormEnter;
        }

        private void FormAdmin_Shown(object sender, EventArgs e)
        {
            AviacompaniesSet ObjectAviacompaniesSet = new AviacompaniesSet();
            tabControl1.SelectedIndex = 0;
            DGVaviacompanies.AutoGenerateColumns = true;
            ObjectAviacompaniesSet.SetCommandTextSelect();
            DGVaviacompanies.DataSource = ObjectAviacompaniesSet.GetTableData(ObjectAviacompaniesSet.CreateDataReaderVariable());
        }

        private void ButtonAddAviacompany_Click(object sender, EventArgs e)
        {
            FormAddAviacompany ObjectAddAviacompany = new FormAddAviacompany();
            ObjectAddAviacompany.Owner = this;
            ObjectAddAviacompany.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        RefreshAccountsSetDGV();
                        break;
                    }
                case 1:
                    {
                        RefreshCitiesSetDGV();
                        break;
                    }
                case 2:
                    {
                        RefreshClassPlaceSetDGV();
                        break;
                    }
                case 3:
                    {
                        RefreshPlanesSetDGV();
                        break;
                    }
                case 4:
                    {
                        RefreshPositionsSetDGV();
                        break;
                    }
                case 5:
                    {
                        RefreshTicketStatusSetDGV();
                        break;
                    }
                case 6:
                    {
                        RefreshAccountsSetDGV();
                        break;
                    }
            }
        }

        private void ButtonDeleteAviacompany_Click(object sender, EventArgs e)
        {
            AviacompaniesSet ObjectAviacompaniesSet = new AviacompaniesSet();
            ObjectAviacompaniesSet.DeleteFromTable(DGVaviacompanies[0, DGVaviacompanies.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshAviacompaniesSetDGV();
        }

        private void ButtonChangeAviacompany_Click(object sender, EventArgs e)
        {
            FormChangeAviacompany ObjectFormChangeAviacompany = new FormChangeAviacompany(DGVaviacompanies[0, DGVaviacompanies.CurrentCellAddress.Y].Value.ToString(), DGVaviacompanies[1, DGVaviacompanies.CurrentCellAddress.Y].Value.ToString());
            ObjectFormChangeAviacompany.Owner = this;
            ObjectFormChangeAviacompany.ShowDialog();
        }

        private void ButtonAddAccount_Click(object sender, EventArgs e)
        {
            FormAddAccount ObjectAddAccount = new FormAddAccount();
            ObjectAddAccount.Owner = this;
            ObjectAddAccount.ShowDialog();
        }

        private void ButtonChangeAccount_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DGVaccounts.CurrentCellAddress.X.ToString() + DGVaccounts.CurrentCellAddress.Y.ToString());
            //MessageBox.Show(DGVaccounts[3, DGVaccounts.CurrentCellAddress.Y].Value.ToString());
            FormChangeAccount ObjectChangeAccount = new FormChangeAccount(DGVaccounts[0, DGVaccounts.CurrentCellAddress.Y].Value.ToString(), DGVaccounts[1, DGVaccounts.CurrentCellAddress.Y].Value.ToString(), DGVaccounts[2, DGVaccounts.CurrentCellAddress.Y].Value.ToString(), DGVaccounts[3, DGVaccounts.CurrentCellAddress.Y].Value.ToString(), DGVaccounts[4, DGVaccounts.CurrentCellAddress.Y].Value.ToString());
            ObjectChangeAccount.Owner = this;
            ObjectChangeAccount.ShowDialog();
        }

        private void ButtonDeleteAccount_Click(object sender, EventArgs e)
        {
            AccountsSet ObjectAccountsSet = new AccountsSet();
            ObjectAccountsSet.DeleteFromTable(DGVaccounts[0, DGVaccounts.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshAccountsSetDGV();
        }
    }
}
