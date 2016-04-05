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
    public partial class FormAddAviacompany : Form
    {
        public FormAddAviacompany()
        {
            InitializeComponent();
            FormAdmin ObjectFormAdmin = this.Owner as FormAdmin;
        }

        private void ButtonAddAviacompany_Click(object sender, EventArgs e)
        {
            //insert in DB
            Classes.TablesOnlyPK.AviacompaniesSet ObjectAviacompaniesSet = new Classes.TablesOnlyPK.AviacompaniesSet();
            ObjectAviacompaniesSet.InsertIntoTable(TextBoxName.Text);

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshAccountsSetDGV();
            }
        }

        private void AddAviacompany_Shown(object sender, EventArgs e)
        {
            TextBoxName.Clear();
        }
    }
}
