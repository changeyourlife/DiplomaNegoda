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
    class AccountsSet
    {
        public const string nameOfDB = "airport"; //имя БД
        public const string nameofTable = "AccountsSet";
        public static string connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand("", sqlConn); //переменная запроса

        public AccountsSet()
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
            sqlComm.CommandText =
                "SELECT [AccountsSet].[Id], [AccountsSet].[WorkerID], [AccountsSet].[Login], [AccountsSet].[Password], [AccountsSet].[PositionID], [WorkersSet].FIO AS [ФИО], [Login] AS Логин, [Password] AS Пароль, [PositionsSet].[Name] AS Должность"+
                " FROM ([airport].[dbo].[AccountsSet]"+
                " INNER JOIN [airport].[dbo].[WorkersSet] ON [WorkersSet].[ID] = [airport].[dbo].[AccountsSet].[WorkerID])"+
                " INNER JOIN[airport].[dbo].[PositionsSet] ON [PositionsSet].[Id] = [airport].[dbo].[AccountsSet].PositionID"
                ;
        }

        public void InsertIntoTable(string WorkerID, string Login, string Password, string PositionID) //method INSERT
        {
            sqlComm.CommandText = @"INSERT INTO [" + nameofTable + "] (WorkerID, Login, Password, PositionID) VALUES (@WORKERID, @LOGIN, @PASSWORD, @POSITIONID);";
            sqlComm.Parameters.Add("@WORKERID", SqlDbType.VarChar);
            sqlComm.Parameters["@WORKERID"].Value = WorkerID;
            sqlComm.Parameters.Add("@LOGIN", SqlDbType.VarChar);
            sqlComm.Parameters["@LOGIN"].Value = Login;
            sqlComm.Parameters.Add("@PASSWORD", SqlDbType.VarChar);
            sqlComm.Parameters["@PASSWORD"].Value = Password;
            sqlComm.Parameters.Add("@POSITIONID", SqlDbType.VarChar);
            sqlComm.Parameters["@POSITIONID"].Value = PositionID;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void UpdateRowInTable(string iD, string WorkerID, string Login, string Password, string PositionID) //method UPDATE
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"UPDATE [" + nameofTable + "] SET WorkerID=@WORKERID, Login=@LOGIN, Password=@PASSWORD, PositionID=@POSITIONID WHERE Id=@ID";
            sqlComm.Parameters.Add("@ID", SqlDbType.VarChar);
            sqlComm.Parameters["@ID"].Value = iD;
            sqlComm.Parameters.Add("@WORKERID", SqlDbType.VarChar);
            sqlComm.Parameters["@WORKERID"].Value = WorkerID;
            sqlComm.Parameters.Add("@LOGIN", SqlDbType.VarChar);
            sqlComm.Parameters["@LOGIN"].Value = Login;
            sqlComm.Parameters.Add("@PASSWORD", SqlDbType.VarChar);
            sqlComm.Parameters["@PASSWORD"].Value = Password;
            sqlComm.Parameters.Add("@POSITIONID", SqlDbType.VarChar);
            sqlComm.Parameters["@POSITIONID"].Value = PositionID;
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
