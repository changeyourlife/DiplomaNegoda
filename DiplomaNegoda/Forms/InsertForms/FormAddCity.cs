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
    public partial class FormAddCity : Form
    {
        public FormAddCity()
        {
            InitializeComponent();
        }

        private void ButtonAddCity_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ObjectDBLUCBWorkersSet.iD[ComboBoxWorker.SelectedIndex]);

            //insert in DB
            CitiesSet ObjectCitiesSet = new CitiesSet();
            ObjectCitiesSet.InsertIntoTable(TextBoxName.Text);

            //refresh DGV
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshCitiesSetDGV();
            }
        }
    }
}
