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
    public partial class FormChangeAviacompany : Form
    {
        public string ID;
        public FormChangeAviacompany(string iD, string Name)
        {
            InitializeComponent();
            FormAdmin ObjectFormAdmin = this.Owner as FormAdmin;
            ID = iD;
            TextBoxName.Text = Name;
        }

        private void ButtonUpdateAviacompany_Click(object sender, EventArgs e)
        {
            //insert in DB
            Classes.TablesOnlyPK.AviacompaniesSet ObjectAviacompaniesSet = new Classes.TablesOnlyPK.AviacompaniesSet();
            ObjectAviacompaniesSet.UpdateRowInTable(ID,TextBoxName.Text);

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshAviacompaniesSetDGV();
            }
        }

        private void FormChangeAviacompany_Shown(object sender, EventArgs e)
        {

        }
    }
}
