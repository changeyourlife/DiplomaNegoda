using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaNegoda.Forms
{
    public partial class FormAdmin: Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Shown(object sender, EventArgs e)
        {
            Classes.TablesOnlyPK.AviacompaniesSet ObjectAviacompaniesSet = new Classes.TablesOnlyPK.AviacompaniesSet();
            tabControl1.SelectedIndex = 0;
            DGVaviacompanies.AutoGenerateColumns = true;
            ObjectAviacompaniesSet.SetCommandText();
            DGVaviacompanies.DataSource = ObjectAviacompaniesSet.GetTableData(ObjectAviacompaniesSet.CreateDataReaderVariable());
        }

        private void ButtonAddAviacompany_Click(object sender, EventArgs e)
        {
            InsertForms.AddAviacompany formAddAviacompany = new InsertForms.AddAviacompany();
            formAddAviacompany.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        Classes.TablesOnlyPK.AviacompaniesSet ObjectAviacompaniesSet = new Classes.TablesOnlyPK.AviacompaniesSet();
                        DGVaviacompanies.AutoGenerateColumns = true;
                        ObjectAviacompaniesSet.SetCommandText();
                        DGVaviacompanies.DataSource = ObjectAviacompaniesSet.GetTableData(ObjectAviacompaniesSet.CreateDataReaderVariable());
                        break;
                    }
                case 1:
                    {
                        Classes.TablesOnlyPK.CitiesSet ObjectCitiesSet = new Classes.TablesOnlyPK.CitiesSet();
                        DGVcities.AutoGenerateColumns = true;
                        ObjectCitiesSet.SetCommandText();
                        DGVcities.DataSource = ObjectCitiesSet.GetTableData(ObjectCitiesSet.CreateDataReaderVariable());
                        break;
                    }
                case 2:
                    {
                        Classes.TablesOnlyPK.ClassPlaceSet ObjectClassPlaceSet = new Classes.TablesOnlyPK.ClassPlaceSet();
                        DGVclassPlace.AutoGenerateColumns = true;
                        ObjectClassPlaceSet.SetCommandText();
                        DGVclassPlace.DataSource = ObjectClassPlaceSet.GetTableData(ObjectClassPlaceSet.CreateDataReaderVariable());
                        break;
                    }
                case 3:
                    {
                        Classes.TablesOnlyPK.PlanesSet ObjectPlanesSet = new Classes.TablesOnlyPK.PlanesSet();
                        DGVplanes.AutoGenerateColumns = true;
                        ObjectPlanesSet.SetCommandText();
                        DGVplanes.DataSource = ObjectPlanesSet.GetTableData(ObjectPlanesSet.CreateDataReaderVariable());
                        break;
                    }
                case 4:
                    {
                        Classes.TablesOnlyPK.PositionsSet ObjectPositionsSet = new Classes.TablesOnlyPK.PositionsSet();
                        DGVpositions.AutoGenerateColumns = true;
                        ObjectPositionsSet.SetCommandText();
                        DGVpositions.DataSource = ObjectPositionsSet.GetTableData(ObjectPositionsSet.CreateDataReaderVariable());
                        break;
                    }
                case 5:
                    {
                        Classes.TablesOnlyPK.TicketStatusSet ObjectTicketStatusSet = new Classes.TablesOnlyPK.TicketStatusSet();
                        DGVticketStatus.AutoGenerateColumns = true;
                        ObjectTicketStatusSet.SetCommandText();
                        DGVticketStatus.DataSource = ObjectTicketStatusSet.GetTableData(ObjectTicketStatusSet.CreateDataReaderVariable());
                        break;
                    }
            }
        }
    }
}
