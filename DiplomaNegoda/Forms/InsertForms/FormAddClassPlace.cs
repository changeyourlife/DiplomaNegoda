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
    public partial class FormAddClassPlace : Form
    {
        public FormAddClassPlace()
        {
            InitializeComponent();
        }

        private void ButtonAddClassPlace_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ObjectDBLUCBWorkersSet.iD[ComboBoxWorker.SelectedIndex]);

            //insert in DB
            ClassPlaceSet ObjectClassPlaceSet = new ClassPlaceSet();
            ObjectClassPlaceSet.InsertIntoTable(TextBoxName.Text);

            //refresh DGV
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshClassPlaceSetDGV();
            }
        }
    }
}
