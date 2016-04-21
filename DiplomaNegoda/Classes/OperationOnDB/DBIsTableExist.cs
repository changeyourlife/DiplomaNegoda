using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaNegoda.Classes.OperationOnDB
{
    class DBIsTableExist
    {
        public const string nameOfDB = "airport"; //имя БД

        public bool IsTableExist(string NameOfTable)//проверяем ест ли таблица в БД
        {
            DBConnection sqlConn = new DBConnection(nameOfDB);
            SqlCommand sqlCommand = new SqlCommand("IF NOT EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME=@NAME AND xtype='U') Select 'false' ELSE Select 'true'", sqlConn.GetConnection());
            sqlConn.Open();
            sqlCommand.CommandText = "IF NOT EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME=@NAME AND xtype='U') Select 'false' ELSE Select 'true'";
            sqlCommand.Parameters.AddWithValue("@NAME", NameOfTable);
            if (sqlCommand.ExecuteScalar().ToString() == "false")
            {
                sqlCommand.Parameters.Clear();
                sqlConn.Close();
                return false;
            }
            else
            {
                sqlCommand.Parameters.Clear();
                sqlConn.Close();
                return true;
            }
        }
    }
}
