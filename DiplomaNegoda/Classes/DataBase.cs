using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaNegoda.Classes
{
    class DataBase
    {
        //остановился 22.03.2016 в 1:08 ночи на методах добавления, изменения и удаления из таблицы
        //переменные
        //переменные
        //переменные
        public const string nameOfDB = "airport"; //имя БД
        public static string requestText; //строка в которую записываем текст запроса
        public static string connectString = @"Data Source=(local);Initial Catalog="+nameOfDB+";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand(requestText, sqlConn); //переменная запроса
        


        //методы
        //методы
        //методы
        public ArrayList GetTableData(SqlDataReader DataReader)//получаем данные из таблицы
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

        public void SetRequest(string RequestText)//задаём текст запроса
        {
            requestText = "";
            requestText = RequestText;
        }

        public SqlDataReader CreateDataReaderVariable()//создаём перменную для сохранения возвращаемой информации из БД; используем её например в GetTableData()
        {
            SqlDataReader dataReader = sqlComm.ExecuteReader();
            return dataReader;
        }

        public bool IsBDexist(string NameOfTable)//проверяем ест ли таблица в БД
        {
            sqlConn.Open();
            SetRequest("IF NOT EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME=@NAME AND xtype='U') Select 'false' ELSE Select 'true'");
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = requestText;
            sqlComm.Parameters.AddWithValue("@Name", NameOfTable);
            if (sqlComm.ExecuteScalar().ToString() == "false")
            {
                MessageBox.Show("Таблицы " + NameOfTable + " НЕТ");
                sqlComm.Parameters.Clear();
                sqlConn.Close();
                return false;
            }
            else
            {
                MessageBox.Show("Таблица " + NameOfTable + " ЕСТЬ");
                sqlComm.Parameters.Clear();
                sqlConn.Close();
                return true;
            }
        }

        public void AppendToRequest(string Text)
        {
            requestText += Text;
        }

        public void CreateTable(string NameOfTable)
        {
            sqlConn.Open();
            sqlComm = sqlConn.CreateCommand();
            SetRequest("CREATE TABLE [" + NameOfTable + "] (ID int NOT NULL IDENTITY (1, 1), NAME varchar (200), PRICE int, COUNT int, COST int);");
            sqlComm.CommandText = requestText;
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void InsertIntoTable(string NameOfTable)
        {

        }
    }
}
