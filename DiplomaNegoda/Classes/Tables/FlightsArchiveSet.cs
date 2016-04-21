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
    class FlightsArchiveSet
    {
        public const string nameOfDB = "airport"; //имя БД
        public const string nameofTable = "FlightsArchiveSet";
        public static string connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand("", sqlConn); //переменная запроса

        public FlightsArchiveSet()
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
                "SELECT AviacompanyID, PlaneID, toID, fromID, GoDateTime, ArriveDateTime, CostOfEcoClass, CostOfBusinessClass, EcoSold, BusSold, AllSold, [Money], AviacompaniesSet.Name AS Авиакомпания, PlanesSet.Model AS Самолёт, citiesTo.Name AS Откуда, citiesFrom.Name AS Куда, GoDateTime AS[Дата и время отправления], ArriveDateTime AS[Дата и время прибытия], CostOfEcoClass AS[Стоимость эконом класса], CostOfBusinessClass AS[Стоимость бизнес класса], EcoSold AS[Продано билетов эконом класса], BusSold AS[Продано биллетов бизнес класса], AllSold AS[Продано всего], [Money] AS[Прибыль]" +
                " FROM([airport].[dbo].FlightsArchiveSet" +
                " INNER JOIN[airport].[dbo].AviacompaniesSet ON AviacompaniesSet.Id = FlightsArchiveSet.AviacompanyID)" +
                " INNER JOIN[airport].[dbo].PlanesSet ON PlanesSet.Id = FlightsArchiveSet.PlaneID" +
                " INNER JOIN[airport].[dbo].CitiesSet citiesTo ON citiesTo.Id = FlightsArchiveSet.toID" +
                " INNER JOIN[airport].[dbo].CitiesSet citiesFrom ON citiesFrom.Id = FlightsArchiveSet.fromID";
        }

        public void InsertIntoTable(string AviacompanyID, string PlaneID, string toID, string fromID, string GoDateTime, string ArriveDateTime, string CostOfEcoClass, string CostOfBusinessClass) //method INSERT
        {
            sqlComm.CommandText = @"INSERT INTO [" + nameofTable + "]"+
                "(AviacompanyID, PlaneID, toID, fromID, GoDateTime, ArriveDateTime, CostOfEcoClass, CostOfBusinessClass)"+
                "VALUES" + 
                "(@AVIACOMPANYID, @PLANEID, @TOID, @FROMID, @GODATETIME, @ARRIVEDATETIME, @COSTOFECOCLASS, @COSTOFBUSINESSCLASS);";
            sqlComm.Parameters.Add("@AVIACOMPANYID", SqlDbType.VarChar);
            sqlComm.Parameters["@AVIACOMPANYID"].Value = AviacompanyID;
            sqlComm.Parameters.Add("@PLANEID", SqlDbType.VarChar);
            sqlComm.Parameters["@PLANEID"].Value = PlaneID;
            sqlComm.Parameters.Add("@TOID", SqlDbType.VarChar);
            sqlComm.Parameters["@TOID"].Value = toID;
            sqlComm.Parameters.Add("@FROMID", SqlDbType.VarChar);
            sqlComm.Parameters["@FROMID"].Value = fromID;
            sqlComm.Parameters.Add("@GODATETIME", SqlDbType.VarChar);
            sqlComm.Parameters["@GODATETIME"].Value = GoDateTime;
            sqlComm.Parameters.Add("@ARRIVEDATETIME", SqlDbType.VarChar);
            sqlComm.Parameters["@ARRIVEDATETIME"].Value = ArriveDateTime;
            sqlComm.Parameters.Add("@COSTOFECOCLASS", SqlDbType.VarChar);
            sqlComm.Parameters["@COSTOFECOCLASS"].Value = CostOfEcoClass;
            sqlComm.Parameters.Add("@COSTOFBUSINESSCLASS", SqlDbType.VarChar);
            sqlComm.Parameters["@COSTOFBUSINESSCLASS"].Value = CostOfBusinessClass;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void UpdateRowInTable(string iD, string AviacompanyID, string PlaneID, string toID, string fromID, string GoDateTime, string ArriveDateTime, string CostOfEcoClass, string CostOfBusinessClass) //method UPDATE
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"UPDATE [" + nameofTable + "]"+
                "SET AviacompanyID=@AVIACOMPANYID, PlaneID=@PLANEID, toID=@TOID, fromID=@FROMID, GoDateTime=@GODATETIME, ArriveDateTime=@ARRIVEDATETIME, CostOfEcoClass=@COSTOFECOCLASS, CostOfBusinessClass=@COSTOFBUSINESSCLASS WHERE NumberOfFlight=@ID";
            sqlComm.Parameters.Add("@ID", SqlDbType.VarChar);
            sqlComm.Parameters["@ID"].Value = iD;
            sqlComm.Parameters.Add("@AVIACOMPANYID", SqlDbType.VarChar);
            sqlComm.Parameters["@AVIACOMPANYID"].Value = AviacompanyID;
            sqlComm.Parameters.Add("@PLANEID", SqlDbType.VarChar);
            sqlComm.Parameters["@PLANEID"].Value = PlaneID;
            sqlComm.Parameters.Add("@TOID", SqlDbType.VarChar);
            sqlComm.Parameters["@TOID"].Value = toID;
            sqlComm.Parameters.Add("@FROMID", SqlDbType.VarChar);
            sqlComm.Parameters["@FROMID"].Value = fromID;
            sqlComm.Parameters.Add("@GODATETIME", SqlDbType.VarChar);
            sqlComm.Parameters["@GODATETIME"].Value = GoDateTime;
            sqlComm.Parameters.Add("@ARRIVEDATETIME", SqlDbType.VarChar);
            sqlComm.Parameters["@ARRIVEDATETIME"].Value = ArriveDateTime;
            sqlComm.Parameters.Add("@COSTOFECOCLASS", SqlDbType.VarChar);
            sqlComm.Parameters["@COSTOFECOCLASS"].Value = CostOfEcoClass;
            sqlComm.Parameters.Add("@COSTOFBUSINESSCLASS", SqlDbType.VarChar);
            sqlComm.Parameters["@COSTOFBUSINESSCLASS"].Value = CostOfBusinessClass;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void DeleteFromTable(string iD) //method DELETE
        {
            sqlComm.CommandText = @"DELETE FROM [" + nameofTable + "] WHERE NumberOfFlight=@ID";
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
