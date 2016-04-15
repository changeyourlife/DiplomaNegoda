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
    class PlanesSet
    {
        public const string nameOfDB = "airport"; //имя БД
        public const string nameofTable = "PlanesSet";
        public static string connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand("", sqlConn); //переменная запроса

        public PlanesSet()
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
            sqlComm.CommandText = "SELECT *, Model AS [Модель], CountOfplacesEco AS [Кол-во мест эконом класса], CountOfPlacesBusiness AS [Кол-во мест бизнес класса], CountOfPlacesAll AS [Всего мест] FROM [" + nameofTable + "]";
        }

        public void InsertIntoTable(string Model, string Eco, string Buis) //method INSERT
        {
            sqlComm.CommandText = @"INSERT INTO [" + nameofTable + "] (Model, CountOfPlacesEco, CountOfPlacesBusiness) VALUES (@MODEL, @ECO, @BUIS);";
            sqlComm.Parameters.Add("@MODEL", SqlDbType.VarChar);
            sqlComm.Parameters["@MODEL"].Value = Model;
            sqlComm.Parameters.Add("@ECO", SqlDbType.VarChar);
            sqlComm.Parameters["@ECO"].Value = Eco;
            sqlComm.Parameters.Add("@BUIS", SqlDbType.VarChar);
            sqlComm.Parameters["@BUIS"].Value = Buis;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void UpdateRowInTable(string iD, string Model, string Eco, string Buis) //method UPDATE
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"UPDATE [" + nameofTable + "] SET Model=@MODEL, CountOfPlacesEco=@ECO, CountOfPlacesBusiness=@BUIS WHERE Id=@ID";
            sqlComm.Parameters.Add("@ID", SqlDbType.VarChar);
            sqlComm.Parameters["@ID"].Value = iD;
            sqlComm.Parameters.Add("@MODEL", SqlDbType.VarChar);
            sqlComm.Parameters["@MODEL"].Value = Model;
            sqlComm.Parameters.Add("@ECO", SqlDbType.VarChar);
            sqlComm.Parameters["@ECO"].Value = Int32.Parse(Eco);
            sqlComm.Parameters.Add("@BUIS", SqlDbType.VarChar);
            sqlComm.Parameters["@BUIS"].Value = Int32.Parse(Buis);
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
