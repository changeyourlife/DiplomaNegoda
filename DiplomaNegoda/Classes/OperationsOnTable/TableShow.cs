using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaNegoda.Classes
{
    class TableShow
    {
        DBConnection sqlConn = new DBConnection("airport");
        OperationOnDB.DBRequestParam sqlComm = new OperationOnDB.DBRequestParam();

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

        public SqlDataReader CreateDataReaderVariable()//создаём перменную для сохранения возвращаемой информации из БД; используем её например в GetTableData()
        {
            SqlDataReader dataReader = sqlComm.ExecuteReader();
            return dataReader;
        }
    }
}
