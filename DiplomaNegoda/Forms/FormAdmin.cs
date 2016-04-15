using DiplomaNegoda.Classes.TablesOnlyPK;
using DiplomaNegoda.Forms.InsertForms;
using DiplomaNegoda.Forms.UpdateForms;
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
            FormEnter ObjectFormEnter = this.Owner as FormEnter;
        }

        private void FormAdmin_Shown(object sender, EventArgs e)
        {
            AviacompaniesSet ObjectAviacompaniesSet = new AviacompaniesSet();
            tabControl1.SelectedIndex = 0;
            RefreshAviacompaniesSetDGV();
        }

        private void ButtonAddAviacompany_Click(object sender, EventArgs e)
        {
            FormAddAviacompany ObjectFormAddAviacompany = new FormAddAviacompany();
            ObjectFormAddAviacompany.Owner = this;
            ObjectFormAddAviacompany.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        RefreshAviacompaniesSetDGV();
                        break;
                    }
                case 1:
                    {
                        RefreshCitiesSetDGV();
                        break;
                    }
                case 2:
                    {
                        RefreshClassPlaceSetDGV();
                        break;
                    }
                case 3:
                    {
                        RefreshPlanesSetDGV();
                        break;
                    }
                case 4:
                    {
                        RefreshPositionsSetDGV();
                        break;
                    }
                case 5:
                    {
                        RefreshPlaceStatusSetDGV();
                        break;
                    }
                case 6:
                    {
                        RefreshAccountsSetDGV();
                        break;
                    }
                case 7:
                    {
                        RefreshFlightsArchiveSetDGV();
                        break;
                    }
                case 8:
                    {
                        RefreshFlightsCurrentSetDGV();
                        break;
                    }
                case 9:
                    {
                        RefreshTicketsSetDGV();
                        break;
                    }
                case 10:
                    {
                        RefreshWorkersSetDGV();
                        break;
                    }
            }
        }

        private void ButtonDeleteAviacompany_Click(object sender, EventArgs e)
        {
            AviacompaniesSet ObjectAviacompaniesSet = new AviacompaniesSet();
            ObjectAviacompaniesSet.DeleteFromTable(DGVaviacompanies[0, DGVaviacompanies.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshAviacompaniesSetDGV();
        }

        private void ButtonChangeAviacompany_Click(object sender, EventArgs e)
        {
            FormChangeAviacompany ObjectFormChangeAviacompany = new FormChangeAviacompany
                (
                DGVaviacompanies[0, DGVaviacompanies.CurrentCellAddress.Y].Value.ToString(), 
                DGVaviacompanies[1, DGVaviacompanies.CurrentCellAddress.Y].Value.ToString()
                );
            ObjectFormChangeAviacompany.Owner = this;
            ObjectFormChangeAviacompany.ShowDialog();
        }

        private void ButtonAddAccount_Click(object sender, EventArgs e)
        {
            FormAddAccount ObjectFormAddAccount = new FormAddAccount();
            ObjectFormAddAccount.Owner = this;
            ObjectFormAddAccount.ShowDialog();
        }

        private void ButtonChangeAccount_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DGVaccounts.CurrentCellAddress.X.ToString() + DGVaccounts.CurrentCellAddress.Y.ToString());
            //MessageBox.Show(DGVaccounts[3, DGVaccounts.CurrentCellAddress.Y].Value.ToString());
            FormChangeAccount ObjectFormChangeAccount = new FormChangeAccount
                (
                DGVaccounts[0, DGVaccounts.CurrentCellAddress.Y].Value.ToString(), 
                DGVaccounts[1, DGVaccounts.CurrentCellAddress.Y].Value.ToString(), 
                DGVaccounts[2, DGVaccounts.CurrentCellAddress.Y].Value.ToString(), 
                DGVaccounts[3, DGVaccounts.CurrentCellAddress.Y].Value.ToString(), 
                DGVaccounts[4, DGVaccounts.CurrentCellAddress.Y].Value.ToString()
                );
            ObjectFormChangeAccount.Owner = this;
            ObjectFormChangeAccount.ShowDialog();
        }

        private void ButtonDeleteAccount_Click(object sender, EventArgs e)
        {
            AccountsSet ObjectAccountsSet = new AccountsSet();
            ObjectAccountsSet.DeleteFromTable(DGVaccounts[0, DGVaccounts.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshAccountsSetDGV();
        }

        private void ButtonDeleteFlightArchive_Click(object sender, EventArgs e)
        {
            FlightsArchiveSet ObjectFlightsArchiveSet = new FlightsArchiveSet();
            ObjectFlightsArchiveSet.DeleteFromTable(DGVflightsArchive[0, DGVflightsArchive.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshFlightsArchiveSetDGV();
        }

        private void ButtonDeleteTicket_Click(object sender, EventArgs e)
        {
            TicketsSet ObjectTicketsSet = new TicketsSet();
            ObjectTicketsSet.DeleteFromTable(DGVtickets[0, DGVtickets.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshTicketsSetDGV();
        }

        private void ButtonDeleteCity_Click(object sender, EventArgs e)
        {
            CitiesSet ObjectCitiesSet = new CitiesSet();
            ObjectCitiesSet.DeleteFromTable(DGVcities[0, DGVcities.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshCitiesSetDGV();
        }

        private void ButtonAddCity_Click(object sender, EventArgs e)
        {
            FormAddCity ObjectFormAddCity = new FormAddCity();
            ObjectFormAddCity.Owner = this;
            ObjectFormAddCity.ShowDialog();
        }

        private void ButtonChangeCity_Click(object sender, EventArgs e)
        {
            FormChangeCity ObjectFormChangeCity = new FormChangeCity
                (
                DGVcities[0, DGVcities.CurrentCellAddress.Y].Value.ToString(), 
                DGVcities[1, DGVcities.CurrentCellAddress.Y].Value.ToString()
                );
            ObjectFormChangeCity.Owner = this;
            ObjectFormChangeCity.ShowDialog();
        }

        private void ButtonAddClassPlace_Click(object sender, EventArgs e)
        {
            FormAddClassPlace ObjectFormAddClassPlace = new FormAddClassPlace();
            ObjectFormAddClassPlace.Owner = this;
            ObjectFormAddClassPlace.ShowDialog();
        }

        private void ButtonChangeClassPlace_Click(object sender, EventArgs e)
        {
            FormChangeClassPlace ObjectFormChangeClassPlace = new FormChangeClassPlace
                (
                DGVclassPlace[0, DGVclassPlace.CurrentCellAddress.Y].Value.ToString(), 
                DGVclassPlace[1, DGVclassPlace.CurrentCellAddress.Y].Value.ToString()
                );
            ObjectFormChangeClassPlace.Owner = this;
            ObjectFormChangeClassPlace.ShowDialog();
        }

        private void ButtonDeleteClassPlace_Click(object sender, EventArgs e)
        {
            ClassPlaceSet ObjectClassPlaceSet = new ClassPlaceSet();
            ObjectClassPlaceSet.DeleteFromTable(DGVclassPlace[0, DGVclassPlace.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshClassPlaceSetDGV();
        }

        private void ButtonAddPlane_Click(object sender, EventArgs e)
        {
            FormAddPlane ObjectFormAddPlane = new FormAddPlane();
            ObjectFormAddPlane.Owner = this;
            ObjectFormAddPlane.ShowDialog();
        }

        private void ButtonChangePlane_Click(object sender, EventArgs e)
        {
            FormChangePlane ObjectFormChangePlane = new FormChangePlane
                (
                DGVplanes[0, DGVplanes.CurrentCellAddress.Y].Value.ToString(), 
                DGVplanes[1, DGVplanes.CurrentCellAddress.Y].Value.ToString(), 
                DGVplanes[2, DGVplanes.CurrentCellAddress.Y].Value.ToString(), 
                DGVplanes[3, DGVplanes.CurrentCellAddress.Y].Value.ToString()
                );
            ObjectFormChangePlane.Owner = this;
            ObjectFormChangePlane.ShowDialog();
        }

        private void ButtonDeletePlane_Click(object sender, EventArgs e)
        {
            PlanesSet ObjectPlanesSet = new PlanesSet();
            ObjectPlanesSet.DeleteFromTable(DGVplanes[0, DGVplanes.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshPlanesSetDGV();
        }

        private void ButtonAddPosition_Click(object sender, EventArgs e)
        {
            FormAddPosition ObjectFormAddPosition = new FormAddPosition();
            ObjectFormAddPosition.Owner = this;
            ObjectFormAddPosition.ShowDialog();
        }

        private void ButtonChangePosition_Click(object sender, EventArgs e)
        {
            FormChangePosition ObjectFormChangePosition = new FormChangePosition
                (
                DGVpositions[0, DGVpositions.CurrentCellAddress.Y].Value.ToString(), 
                DGVpositions[1, DGVpositions.CurrentCellAddress.Y].Value.ToString()
                );
            ObjectFormChangePosition.Owner = this;
            ObjectFormChangePosition.ShowDialog();
        }

        private void ButtonDeletePosition_Click(object sender, EventArgs e)
        {
            PositionsSet ObjectPositionsSet = new PositionsSet();
            ObjectPositionsSet.DeleteFromTable(DGVpositions[0, DGVpositions.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshPositionsSetDGV();
        }

        private void ButtonAddTicketStatus_Click(object sender, EventArgs e)
        {
            FormAddPlaceStatus ObjectFormAddTicketStatus = new FormAddPlaceStatus();
            ObjectFormAddTicketStatus.Owner = this;
            ObjectFormAddTicketStatus.ShowDialog();
        }

        private void ButtonChangeTicketStatus_Click(object sender, EventArgs e)
        {
            FormChangePlaceStatus ObjectFormChangeTicketStatus = new FormChangePlaceStatus
                (
                DGVplaceStatus[0, DGVplaceStatus.CurrentCellAddress.Y].Value.ToString(), 
                DGVplaceStatus[1, DGVplaceStatus.CurrentCellAddress.Y].Value.ToString()
                );
            ObjectFormChangeTicketStatus.Owner = this;
            ObjectFormChangeTicketStatus.ShowDialog();
        }

        private void ButtonDeleteTicketStatus_Click(object sender, EventArgs e)
        {
            PlaceStatusSet ObjectTicketStatusSet = new PlaceStatusSet();
            ObjectTicketStatusSet.DeleteFromTable(DGVplaceStatus[0, DGVplaceStatus.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshPlaceStatusSetDGV();
        }

        private void ButtonAddWorker_Click(object sender, EventArgs e)
        {
            FormAddWorker ObjectFormAddWorker = new FormAddWorker();
            ObjectFormAddWorker.Owner = this;
            ObjectFormAddWorker.ShowDialog();
        }

        private void ButtonChangeWorker_Click(object sender, EventArgs e)
        {
            FormChangeWorker ObjectFormChangeWorker = new FormChangeWorker
                (
                DGVworkers[0, DGVworkers.CurrentCellAddress.Y].Value.ToString(), 
                DGVworkers[1, DGVworkers.CurrentCellAddress.Y].Value.ToString(), 
                DGVworkers[2, DGVworkers.CurrentCellAddress.Y].Value.ToString(), 
                DGVworkers[3, DGVworkers.CurrentCellAddress.Y].Value.ToString(), 
                DGVworkers[4, DGVworkers.CurrentCellAddress.Y].Value.ToString(), 
                DGVworkers[5, DGVworkers.CurrentCellAddress.Y].Value.ToString()
                );
            ObjectFormChangeWorker.Owner = this;
            ObjectFormChangeWorker.ShowDialog();
        }

        private void ButtonDeleteWorker_Click(object sender, EventArgs e)
        {
            WorkersSet ObjectWorkersSet = new WorkersSet();
            ObjectWorkersSet.DeleteFromTable(DGVworkers[0, DGVworkers.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshWorkersSetDGV();
        }

        private void ButtonAddFlightCurrent_Click(object sender, EventArgs e)
        {
            FormAddFlightCurrent ObjectFormAddFlightCurrent = new FormAddFlightCurrent();
            ObjectFormAddFlightCurrent.Owner = this;
            ObjectFormAddFlightCurrent.ShowDialog();
        }

        private void ButtonChangeFlightCurrent_Click(object sender, EventArgs e)
        {
            FormChangeFlightCurrent ObjectFormChangeFlightCurrent = new FormChangeFlightCurrent
                (
                DGVflightsCurrent[0, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString(),
                DGVflightsCurrent[1, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString(),
                DGVflightsCurrent[2, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString(),
                DGVflightsCurrent[3, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString(),
                DGVflightsCurrent[4, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString(),
                DGVflightsCurrent[5, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString(),
                DGVflightsCurrent[6, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString(),
                DGVflightsCurrent[7, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString(),
                DGVflightsCurrent[8, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString()
                );
            ObjectFormChangeFlightCurrent.Owner = this;
            ObjectFormChangeFlightCurrent.ShowDialog();
        }

        private void ButtonDeleteFlightAccount_Click(object sender, EventArgs e)
        {
            FlightsCurrentSet ObjectFlightsCurrentSet = new FlightsCurrentSet();
            ObjectFlightsCurrentSet.DeleteFromTable(DGVflightsCurrent[0, DGVflightsCurrent.CurrentCellAddress.Y].Value.ToString()); //DGVaviacompanie[X=column, Y=row]
            this.RefreshFlightsCurrentSetDGV();
        }

        private void ButtonAddTicket_Click(object sender, EventArgs e)
        {
            FormAddTicket ObjectFormAddFormAddTicket = new FormAddTicket();
            ObjectFormAddFormAddTicket.Owner = this;
            ObjectFormAddFormAddTicket.ShowDialog();
        }

        private void ButtonChangeTicket_Click(object sender, EventArgs e)
        {
            FormChangeTicket ObjectFormChangeTicket = new FormChangeTicket
               (
               DGVtickets[0, DGVtickets.CurrentCellAddress.Y].Value.ToString(),
               DGVtickets[1, DGVtickets.CurrentCellAddress.Y].Value.ToString(),
               DGVtickets[2, DGVtickets.CurrentCellAddress.Y].Value.ToString(),
               DGVtickets[3, DGVtickets.CurrentCellAddress.Y].Value.ToString(),
               DGVtickets[4, DGVtickets.CurrentCellAddress.Y].Value.ToString(),
               DGVtickets[5, DGVtickets.CurrentCellAddress.Y].Value.ToString(),
               DGVtickets[6, DGVtickets.CurrentCellAddress.Y].Value.ToString()
               );
            ObjectFormChangeTicket.Owner = this;
            ObjectFormChangeTicket.ShowDialog();
        }
    }
}
