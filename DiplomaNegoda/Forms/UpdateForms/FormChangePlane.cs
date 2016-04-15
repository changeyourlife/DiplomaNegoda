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
    public partial class FormChangePlane : Form
    {
        public string ID;
        public FormChangePlane(string iD, string Model, string CountOfPlacesEco, string CountOfPlacesBusiness)
        {
            InitializeComponent();
            ID = iD;
            TextBoxModel.Text = Model;
            TextBoxCountOfPlacesEco.Text = CountOfPlacesEco;
            TextBoxCountOfPlacesBusiness.Text = CountOfPlacesBusiness;
        }

        private void ButtonChangePlane_Click(object sender, EventArgs e)
        {
            //insert in DB
            Classes.TablesOnlyPK.PlanesSet ObjectPlanesSet = new Classes.TablesOnlyPK.PlanesSet();
            ObjectPlanesSet.UpdateRowInTable(ID, TextBoxModel.Text, TextBoxCountOfPlacesEco.Text, TextBoxCountOfPlacesBusiness.Text);

            //refresh DGV
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshPlanesSetDGV();
            }
        }
    }
}
