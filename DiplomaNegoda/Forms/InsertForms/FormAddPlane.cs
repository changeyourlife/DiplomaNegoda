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
    public partial class FormAddPlane : Form
    {
        public FormAddPlane()
        {
            InitializeComponent();
        }

        private void ButtonAddPlane_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ObjectDBLUCBWorkersSet.iD[ComboBoxWorker.SelectedIndex]);

            //insert in DB
            PlanesSet ObjectPlanesSet = new PlanesSet();
            ObjectPlanesSet.InsertIntoTable(TextBoxModel.Text, TextBoxCountOfPlacesEco.Text, TextBoxCountOfPlacesBusiness.Text);

            //refresh DGV
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshPlanesSetDGV();
            }
        }
    }
}
