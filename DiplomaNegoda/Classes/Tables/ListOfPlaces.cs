using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaNegoda.Classes.Tables
{
    class ListOfPlaces
    {
        public const string nameOfDB = "airport"; //имя БД
        public static string nameofTable = "";
        public static string idClassPlace, idStatusPlace;
        public static string connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand("", sqlConn); //переменная запроса

        public ListOfPlaces(string NameOfTable, string IdClassPlace, string IdStatusPlace)
        {
            sqlComm = sqlConn.CreateCommand();
            nameofTable = NameOfTable;
            idClassPlace = IdClassPlace;
            idStatusPlace = IdStatusPlace;
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
                "SELECT NumOfPlace AS [Номер места], ClassPlaceSet.Name AS [Класс места],  PlaceStatusSet.Name AS [Статус места]"
                + " FROM ([" + nameofTable + "]"
                + " INNER JOIN ClassPlaceSet ON ClassPlaceSet.Id = ClassOfPlaceID)"
                + " INNER JOIN PlaceStatusSet ON PlaceStatusSet.Id = StatusOfTicketID"
                + " WHERE ClassOfPlaceID=" + idClassPlace + " AND StatusOfTicketID="+ idStatusPlace +";"
                ;
        }

        public void UpdateRowInTable(string iD, string Name) //method UPDATE
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"UPDATE [" + nameofTable + "] SET Name=@NAME WHERE Id=@ID";
            sqlComm.Parameters.Add("@ID", SqlDbType.VarChar);
            sqlComm.Parameters["@ID"].Value = iD;
            sqlComm.Parameters.Add("@NAME", SqlDbType.VarChar);
            sqlComm.Parameters["@NAME"].Value = Name;
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
