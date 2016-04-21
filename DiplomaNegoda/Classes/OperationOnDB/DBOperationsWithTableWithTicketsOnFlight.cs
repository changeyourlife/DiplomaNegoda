using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaNegoda.Classes.OperationOnDB
{
    class DBOperationsWithTableWithTicketsOnFlight
    {
        public const string nameOfDB = "airport"; //имя БД
        public static DBConnection sqlConn = new DBConnection(nameOfDB);
        public static SqlCommand sqlComm = new SqlCommand();

        public DBOperationsWithTableWithTicketsOnFlight()
        {

        }

        public void CreateTable(string NameOfTableForCreate)
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = "CREATE TABLE [" + NameOfTableForCreate + "] (NumOfPlace int NOT NULL IDENTITY (1, 1), ClassOfPlaceID int, StatusOfTicketID int);";
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void FillTableWithPlacesForFlight(string NameOfTableForCreate, string ClassOfPlace, string StatusOfPlace)
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"INSERT INTO [airport].[dbo].["+ NameOfTableForCreate + "] (ClassOfPlaceID, StatusOfTicketID) VALUES (@CLASSOFPLACE, @STATUSOFPLACE);";
            //sqlComm.Parameters.AddWithValue("@NAMEOFTABLEFORCREATE", NameOfTableForCreate);
            sqlComm.Parameters.AddWithValue("@CLASSOFPLACE", ClassOfPlace);
            sqlComm.Parameters.AddWithValue("@STATUSOFPLACE", StatusOfPlace);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}