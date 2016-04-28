using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaNegoda.Classes.OperationOnDB
{
    class ChangeStatusOfTicketSet
    {
        public const string nameOfDB = "airport"; //имя БД
        public static string nameOfTable, numOfPlace;
        public static string connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand("", sqlConn); //переменная запроса

        public ChangeStatusOfTicketSet(string NameOfTable, string NumOfPlace)
        {
            sqlComm = sqlConn.CreateCommand();
            nameOfTable = NameOfTable;
            numOfPlace = NumOfPlace;
        }

        public List<DbDataRecord> GetTableData(SqlDataReader DataReader)//получаем данные из таблицы, method SELECT
        {
            List<DbDataRecord> allProd = new List<DbDataRecord>();
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

        public void UpdateRowInTableSell() //method UPDATE
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"UPDATE [" + nameOfTable + "] SET StatusOfTicketID=@STATUSOFTICKETID WHERE NumOfPlace=@NUMOFPLACE";
            sqlComm.Parameters.Add("@STATUSOFTICKETID", SqlDbType.VarChar);
            sqlComm.Parameters["@STATUSOFTICKETID"].Value = 1;
            sqlComm.Parameters.Add("@NUMOFPLACE", SqlDbType.VarChar);
            sqlComm.Parameters["@NUMOFPLACE"].Value = numOfPlace;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void UpdateRowInTableReserve() //method UPDATE
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"UPDATE [" + nameOfTable + "] SET StatusOfTicketID=@STATUSOFTICKETID WHERE NumOfPlace=@NUMOFPLACE";
            sqlComm.Parameters.Add("@STATUSOFTICKETID", SqlDbType.VarChar);
            sqlComm.Parameters["@STATUSOFTICKETID"].Value = 2;
            sqlComm.Parameters.Add("@NUMOFPLACE", SqlDbType.VarChar);
            sqlComm.Parameters["@NUMOFPLACE"].Value = numOfPlace;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void SQLCOMMclear() //method that clear sqlcomm after using
        {
            sqlComm.CommandText = "";
            sqlComm.Parameters.Clear();
        }
    }
}
