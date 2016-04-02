using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaNegoda.Classes
{
    class DBConnection
    {
        public string nameOfDB = "airport"; //имя БД
        public string connectString;
        SqlConnection sqlConn = new SqlConnection();


        public DBConnection(string NameOfDB)
        {
            nameOfDB = NameOfDB;
            connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
            sqlConn.ConnectionString = connectString; //переменная соединения с БД
        }

        public void Open()
        {
            sqlConn.Open();
        }

        public void Close()
        {
            sqlConn.Close();
        }

        public SqlCommand CreateCommand()
        {
            return sqlConn.CreateCommand();
        }

        public SqlConnection GetConnection()
        {
            return sqlConn;
        }
    }
}
