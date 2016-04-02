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
    public partial class AddAviacompany : Form
    {
        public AddAviacompany()
        {
            InitializeComponent();
        }

        private void ButtonAddAviacompany_Click(object sender, EventArgs e)
        {
            Classes.TablesOnlyPK.AviacompaniesSet ObjectAviacompaniesSet = new Classes.TablesOnlyPK.AviacompaniesSet();
            ObjectAviacompaniesSet.InsertIntoTable(TextBoxName.Text);
        }
    }
}
