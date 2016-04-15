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
    public partial class FormChangeClassPlace : Form
    {
        public string ID;
        public FormChangeClassPlace(string iD, string Name)
        {
            InitializeComponent();
            //FormAdmin ObjectFormAdmin = this.Owner as FormAdmin;
            ID = iD;
            TextBoxName.Text = Name;
        }

        private void ButtonChangeClassPlace_Click(object sender, EventArgs e)
        {
            //update DB
            Classes.TablesOnlyPK.ClassPlaceSet ObjectClassPlaceSet = new Classes.TablesOnlyPK.ClassPlaceSet();
            ObjectClassPlaceSet.UpdateRowInTable(ID, TextBoxName.Text);

            //refresh DGV
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshClassPlaceSetDGV();
            }
        }
    }
}
