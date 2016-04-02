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

        public ArrayList GetTableData(SqlDataReader DataReader)//получаем данные из таблицы, method SELECT
        {
            ArrayList allProd = new ArrayList();
            sqlConn.Open();
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
            SqlDataReader dataReader = sqlComm.ExecuteReader();
            return dataReader;
        }

        public void InsertIntoTable(string Name, string Buz, string Eco) //method INSERT
        {
            sqlComm.CommandText = @"INSERT INTO [" + nameofTable + "] (Model, CountOfPlacesAll, CountOfPlacesBusiness, CountOfPlacesEco) VALUES (@MODEL, @ALL, @BUZ, @ECO);";
            sqlComm.Parameters.Add("@MODEL", SqlDbType.VarChar);
            sqlComm.Parameters["@MODEL"].Value = Name;
            sqlComm.Parameters.Add("@ALL", SqlDbType.VarChar);
            sqlComm.Parameters["@ALL"].Value = Int32.Parse(Buz) + Int32.Parse(Eco);
            sqlComm.Parameters.Add("@BUZ", SqlDbType.VarChar);
            sqlComm.Parameters["@BUZ"].Value = Buz;
            sqlComm.Parameters.Add("@ECO", SqlDbType.VarChar);
            sqlComm.Parameters["@ECO"].Value = Eco;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SQLCOMMclear();
            sqlConn.Close();
        }

        public void UpdateRowInTable(string iD, string Name, string Buz, string Eco) //method UPDATE
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"UPDATE [" + nameofTable + "] SET Model=@NAME, CountOfPlacesAll=@ALL, CountOfPlacesBusiness=@BUZ, CountOfPlacesEco=@ECO WHERE Id=@ID";
            sqlComm.Parameters.Add("@ID", SqlDbType.VarChar);
            sqlComm.Parameters["@ID"].Value = iD;
            sqlComm.Parameters.Add("@MODEL", SqlDbType.VarChar);
            sqlComm.Parameters["@MODEL"].Value = Name;
            sqlComm.Parameters.Add("@ALL", SqlDbType.VarChar);
            sqlComm.Parameters["@ALL"].Value = Int32.Parse(Buz) + Int32.Parse(Eco);
            sqlComm.Parameters.Add("@BUZ", SqlDbType.VarChar);
            sqlComm.Parameters["@BUZ"].Value = Int32.Parse(Buz);
            sqlComm.Parameters.Add("@ECO", SqlDbType.VarChar);
            sqlComm.Parameters["@ECO"].Value = Int32.Parse(Eco);
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
