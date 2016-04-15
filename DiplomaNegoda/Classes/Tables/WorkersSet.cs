using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaNegoda.Classes.TablesOnlyPK
{
    class WorkersSet
    {
        public const string nameOfDB = "airport"; //имя БД
        public const string nameofTable = "WorkersSet";
        public static string connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand("", sqlConn); //переменная запроса

        public WorkersSet()
        {
            sqlComm = sqlConn.CreateCommand();
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

        public void SetCommandTextSelect()
        {
            sqlComm.CommandText = "SELECT * FROM [" + nameofTable + "]";
        }

        public void InsertIntoTable(string FIO, string BornDate, string PositionID, string ArriveDateOfWorker, string ContactData) //method INSERT
        {
            sqlComm.CommandText = @"INSERT INTO [" + nameofTable + "]" +
                "(FIO, BornDate, PositionID, ArriveDateOfWorker, ContactData)" +
                "VALUES" +
                "(@FIO, @BORNDATE, @POSITIONID, @ARRIVEDATEOFWORKER, @CONTACTDATA);";
            sqlComm.Parameters.Add("@FIO", SqlDbType.VarChar);
            sqlComm.Parameters["@FIO"].Value = FIO;
            sqlComm.Parameters.Add("@BORNDATE", SqlDbType.VarChar);
            sqlComm.Parameters["@BORNDATE"].Value = BornDate;
            sqlComm.Parameters.Add("@POSITIONID", SqlDbType.VarChar);
            sqlComm.Parameters["@POSITIONID"].Value = PositionID;
            sqlComm.Parameters.Add("@ARRIVEDATEOFWORKER", SqlDbType.VarChar);
            sqlComm.Parameters["@ARRIVEDATEOFWORKER"].Value = ArriveDateOfWorker;
            sqlComm.Parameters.Add("@CONTACTDATA", SqlDbType.VarChar);
            sqlComm.Parameters["@CONTACTDATA"].Value = ContactData;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void UpdateRowInTable(string iD, string FIO, string BornDate, string PositionID, string ArriveDateOfWorker, string ContactData) //method UPDATE
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"UPDATE [" + nameofTable + "]" +
                " SET FIO=@FIO, BornDate=@BORNDATE, PositionID=@POSITIONID, ArriveDateOfWorker=@ARRIVEDATEOFWORKER, ContactData=@CONTACTDATA WHERE Id=@ID";
            sqlComm.Parameters.Add("@ID", SqlDbType.VarChar);
            sqlComm.Parameters["@ID"].Value = iD;
            sqlComm.Parameters.Add("@FIO", SqlDbType.VarChar);
            sqlComm.Parameters["@FIO"].Value = FIO;
            sqlComm.Parameters.Add("@BORNDATE", SqlDbType.VarChar);
            sqlComm.Parameters["@BORNDATE"].Value = BornDate;
            sqlComm.Parameters.Add("@POSITIONID", SqlDbType.VarChar);
            sqlComm.Parameters["@POSITIONID"].Value = PositionID;
            sqlComm.Parameters.Add("@ARRIVEDATEOFWORKER", SqlDbType.VarChar);
            sqlComm.Parameters["@ARRIVEDATEOFWORKER"].Value = ArriveDateOfWorker;
            sqlComm.Parameters.Add("@CONTACTDATA", SqlDbType.VarChar);
            sqlComm.Parameters["@CONTACTDATA"].Value = ContactData;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void DeleteFromTable(string iD) //method DELETE
        {
            sqlComm.CommandText = @"DELETE FROM [" + nameofTable + "] WHERE Id=@ID";
            sqlComm.Parameters.Add("@ID", SqlDbType.VarChar);
            sqlComm.Parameters["@ID"].Value = iD;
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
