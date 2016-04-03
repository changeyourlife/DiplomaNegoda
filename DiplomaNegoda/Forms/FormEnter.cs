using DiplomaNegoda.Classes;
using DiplomaNegoda.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaNegoda
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            List<DbDataRecord> arrList = new List<DbDataRecord>();
            Login ObjectLogin = new Login(); //create object of class "Login"
            ObjectLogin.SetLoginPasswordForEnter(textBoxLogin.Text, textBoxPassword.Text);
            arrList = ObjectLogin.Enter(ObjectLogin.CreateDataReaderVariable());
            
            if (arrList.Count != 0)
            {
                MessageBox.Show("NOT NULL");
                //if (arrList[0].)
                if (arrList[0].GetValue(4).ToString().Equals("1"))
                {
                    MessageBox.Show("YOU ADMIN");
                    FormAdmin ObjectFormAdmin = new FormAdmin();
                    ObjectFormAdmin.Owner= this;
                    ObjectFormAdmin.ShowDialog();
                }
                else if (arrList[0].GetValue(4).ToString().Equals("2"))
                {
                    MessageBox.Show("YOU KAS");
                }
            else
            {
                MessageBox.Show("INCORRECT");
            }
            }
            else
            {
                MessageBox.Show("NULL");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
