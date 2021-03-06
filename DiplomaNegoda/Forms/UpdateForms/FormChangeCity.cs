﻿using System;
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
    public partial class FormChangeCity : Form
    {
        public string ID;
        public FormChangeCity(string iD, string Name)
        {
            InitializeComponent();
            ID = iD;
            TextBoxName.Text = Name;
        }

        private void ButtonChangeCity_Click(object sender, EventArgs e)
        {
            //update DB
            Classes.TablesOnlyPK.CitiesSet ObjectCitiesSet = new Classes.TablesOnlyPK.CitiesSet();
            ObjectCitiesSet.UpdateRowInTable(ID, TextBoxName.Text);

            //refresh DFVaviacompanies
            FormAdmin ObjectFormAdmin = Owner as FormAdmin;
            if (ObjectFormAdmin != null)
            {
                ObjectFormAdmin.RefreshCitiesSetDGV();
            }
        }
    }
}
