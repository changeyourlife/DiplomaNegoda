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
    public partial class FormChangePlaceStatus : Form
    {
        public string ID;
        public FormChangePlaceStatus(string iD, string Name)
        {
            InitializeComponent();
            ID = iD;
            TextBoxName.Text = Name;
        }

        private void ButtonChangeTicketStatus_Click(object sender, EventArgs e)
        {
            //insert in DB
            Classes.TablesOnlyPK.PlaceStatusSet ObjectTicketStatusSet = new Classes.TablesOnlyPK.PlaceStatusSet();
            ObjectTicketStatusSet.UpdateRowInTable(ID, TextBoxName.Text);

            //refresh DGV
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshPlaceStatusSetDGV();
            }
        }
    }
}
