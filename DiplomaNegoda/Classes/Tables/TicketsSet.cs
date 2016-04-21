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
    class TicketsSet
    {
        public const string nameOfDB = "airport"; //имя БД
        public const string nameofTable = "TicketsSet";
        public static string connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand("", sqlConn); //переменная запроса

        public TicketsSet()
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
                "SELECT NumOfTicket, NumOfPlace, FlightID, ClassOfPlaceID OfPlaceID, Cost, FIO, PersonalDataSpecial, NumOfTicket AS[Номер билета], NumOfPlace AS[Номер места], FlightID AS[Номер рейса], citiesFROM.Name AS[Куда], citiesTO.Name AS[Откуда], [dbo].[ClassPlaceSet].Name AS[Клас места], Cost AS[Стоимость], FIO AS[ФИО], PersonalDataSpecial AS[Персональные данные] " +
                "FROM([airport].[dbo].TicketsSet " +
                "INNER JOIN[airport].[dbo].ClassPlaceSet ON TicketsSet.ClassOfPlaceID = ClassPlaceSet.Id) " +
                "INNER JOIN[airport].[dbo].CitiesSet citiesTO ON citiesTO.Id = (SELECT toID FROM FlightsCurrentSet WHERE NumberOfFlight = TicketsSet.FlightID) " +
                "INNER JOIN[airport].[dbo].CitiesSet citiesFROM ON citiesFROM.Id = (SELECT fromID FROM FlightsCurrentSet WHERE NumberOfFlight = TicketsSet.FlightID)";
        }

        public void InsertIntoTable(string NumOfPlace, string FlightID, string ClassOfPlaceID, string Cost, string FIO, string PersonalDataSpecial) //method INSERT
        {
            sqlComm.CommandText = @"INSERT INTO [" + nameofTable + "]" +
                "(NumOfPlace, FlightID, ClassOfPlaceID, Cost, FIO, PersonalDataSpecial)" +
                "VALUES" +
                "(@NUMOFPALCE, @FLIGHTID, @CLASSOFPLACEID, @COST, @FIO, @PERSONALDATASPECIAL);";
            sqlComm.Parameters.Add("@NUMOFPALCE", SqlDbType.VarChar);
            sqlComm.Parameters["@NUMOFPALCE"].Value = NumOfPlace;
            sqlComm.Parameters.Add("@FLIGHTID", SqlDbType.VarChar);
            sqlComm.Parameters["@FLIGHTID"].Value = FlightID;
            sqlComm.Parameters.Add("@CLASSOFPLACEID", SqlDbType.VarChar);
            sqlComm.Parameters["@CLASSOFPLACEID"].Value = ClassOfPlaceID;
            sqlComm.Parameters.Add("@COST", SqlDbType.VarChar);
            sqlComm.Parameters["@COST"].Value = Cost;
            sqlComm.Parameters.Add("@FIO", SqlDbType.VarChar);
            sqlComm.Parameters["@FIO"].Value = FIO;
            sqlComm.Parameters.Add("@PERSONALDATASPECIAL", SqlDbType.VarChar);
            sqlComm.Parameters["@PERSONALDATASPECIAL"].Value = PersonalDataSpecial;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void UpdateRowInTable(string iD, string NumOfPlace, string FlightID, string ClassOfPlaceID, string Cost, string FIO, string PersonalDataSpecial) //method UPDATE
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"UPDATE [" + nameofTable + "]" +
                "SET NumOfPlace=@NUMOFPLACE, FlightID=@FLIGHTID, ClassOfPlaceID=@CLASSOFPLACEID, Cost=@COST, FIO=@FIO, PersonalDataSpecial=@PERSONALDATASPECIAL WHERE NumOfTicket=@ID";
            sqlComm.Parameters.Add("@ID", SqlDbType.VarChar);
            sqlComm.Parameters["@ID"].Value = iD;
            sqlComm.Parameters.Add("@NUMOFPLACE", SqlDbType.VarChar);
            sqlComm.Parameters["@NUMOFPLACE"].Value = NumOfPlace;
            sqlComm.Parameters.Add("@FLIGHTID", SqlDbType.VarChar);
            sqlComm.Parameters["@FLIGHTID"].Value = FlightID;
            sqlComm.Parameters.Add("@CLASSOFPLACEID", SqlDbType.VarChar);
            sqlComm.Parameters["@CLASSOFPLACEID"].Value = ClassOfPlaceID;
            sqlComm.Parameters.Add("@COST", SqlDbType.VarChar);
            sqlComm.Parameters["@COST"].Value = Cost;
            sqlComm.Parameters.Add("@FIO", SqlDbType.VarChar);
            sqlComm.Parameters["@FIO"].Value = FIO;
            sqlComm.Parameters.Add("@PERSONALDATASPECIAL", SqlDbType.VarChar);
            sqlComm.Parameters["@PERSONALDATASPECIAL"].Value = PersonalDataSpecial;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void DeleteFromTable(string iD) //method DELETE
        {
            sqlComm.CommandText = @"DELETE FROM [" + nameofTable + "] WHERE NumOfTicket=@ID";
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
