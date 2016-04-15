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
    public partial class FormChangePosition : Form
    {
        public string ID;
        public FormChangePosition(string iD, string Name)
        {
            InitializeComponent();
            ID = iD;
            TextBoxName.Text = Name;
        }

        private void ButtonChangePosition_Click(object sender, EventArgs e)
        {
            //insert in DB
            Classes.TablesOnlyPK.PositionsSet ObjectPositionsSet = new Classes.TablesOnlyPK.PositionsSet();
            ObjectPositionsSet.UpdateRowInTable(ID, TextBoxName.Text);

            //refresh DGV
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshPositionsSetDGV();
            }
        }
    }
}
