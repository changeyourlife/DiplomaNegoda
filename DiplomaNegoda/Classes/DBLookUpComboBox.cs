using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaNegoda.Classes
{
    class DBLookUpComboBox
    {
        public const string nameOfDB = "airport"; //имя БД
        public const string nameofTable = "AviacompaniesSet";
        public static string connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand("", sqlConn); //переменная запроса

        DBLookUpComboBox(string ID, string TextField)
        {
            SetCommandTextSelect();
            GetTableData(CreateDataReaderVariable());
        }

        public ArrayList GetTableData(SqlDataReader DataReader)//получаем данные из таблицы, method SELECT
        {
            ArrayList allProd = new ArrayList();
            if (DataReader.HasRows)
            {
                foreach (DbDataRecord result in DataReader)
                {
                    allProd.Add(result);
                }
            }
            sqlConn.Close();
            return allProd;
        }

        public SqlDataReader CreateDataReaderVariable()//создаём перменную для сохранения возвращаемой информации из БД; используем её например в GetTableData()
        {
            sqlConn.Open();
            SqlDataReader dataReader = sqlComm.ExecuteReader();
            return dataReader;
        }

        public void SetCommandTextSelect()
        {
            sqlComm.CommandText = "SELECT * FROM [" + nameofTable + "]";
        }
    }
}
