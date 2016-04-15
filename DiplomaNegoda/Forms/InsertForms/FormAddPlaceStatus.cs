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
    public partial class FormAddPlaceStatus : Form
    {
        public FormAddPlaceStatus()
        {
            InitializeComponent();
        }

        private void ButtonAddTicketStatus_Click(object sender, EventArgs e)
        {
            //insert in DB
            Classes.TablesOnlyPK.PlaceStatusSet ObjectTicketStatusSet = new Classes.TablesOnlyPK.PlaceStatusSet();
            ObjectTicketStatusSet.InsertIntoTable(TextBoxName.Text);

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshPlaceStatusSetDGV();
            }
        }
    }
}
