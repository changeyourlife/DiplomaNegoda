using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaNegoda.Classes.OperationOnDB
{
    class DBIsTableExist
    {
        string nameOfDB;

        public DBIsTableExist(string NameOfDB)
        {
            nameOfDB = NameOfDB;
        }

        public bool IsTableExist(string NameOfTable)//проверяем ест ли таблица в БД
        {
            DBConnection sqlConn = new DBConnection(nameOfDB);
            DBRequestParam sqlComm = new DBRequestParam();
            sqlConn.Open();
            sqlComm.SetRequest("IF NOT EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME=@NAME AND xtype='U') Select 'false' ELSE Select 'true'");
            sqlComm.AddParameter("@Name", NameOfTable);
            sqlComm.SetPropertiesForParameters(sqlConn);
            if (sqlComm.ExecuteScalar() == "false")
            {
                MessageBox.Show("Таблицы " + NameOfTable + " НЕТ");
                sqlComm.ClearParameters();
                sqlConn.Close();
                return false;
            }
            else
            {
                MessageBox.Show("Таблица " + NameOfTable + " ЕСТЬ");
                sqlComm.ClearParameters();
                sqlConn.Close();
                return true;
            }
        }
    }
}
