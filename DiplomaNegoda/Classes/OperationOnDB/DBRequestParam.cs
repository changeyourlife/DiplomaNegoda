using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaNegoda.Classes.OperationOnDB
{
    class DBRequestParam
    {
        public string requestText; //строка в которую записываем текст запроса
        public SqlCommand sqlCommand = new SqlCommand(); //переменная запроса

        public bool SetRequest(string RequestText)//задаём текст запроса
        {
            requestText = "";
            requestText = RequestText;
            if (requestText.Length > 0)
            {
                sqlCommand.CommandText = requestText;
                return true;
            }
            return false;
        }

        public void ClearParameters()
        {
            sqlCommand.Parameters.Clear();
        }

        public void SetPropertiesForParameters(DBConnection SqlConn)
        {
            ClearParameters();
            sqlCommand.Connection = SqlConn.GetConnection();
            sqlCommand = SqlConn.CreateCommand();
        }

        public void AddParameter(string NameOfParam, string ValueOfParam)
        {
            sqlCommand.Parameters.AddWithValue(NameOfParam, ValueOfParam);
        }

        public string ExecuteScalar()
        {
            return sqlCommand.ExecuteScalar().ToString();
        }

        public SqlDataReader ExecuteReader()
        {
            return sqlCommand.ExecuteReader();
        }

    }
}
