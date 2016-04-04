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
    class DBLookUpComboBox
    {
        public const string nameOfDB = "airport"; //имя БД
        public static string connectString = @"Data Source=(local);Initial Catalog=" + nameOfDB + ";Integrated Security=True"; //строка подключения
        public static SqlConnection sqlConn = new SqlConnection(connectString); //переменная соединения с БД
        public static SqlCommand sqlComm = new SqlCommand("", sqlConn); //переменная запроса
        public static List<string> iD = new List<string>();
        public static List<string> textInComboBox = new List<string>();

        public DBLookUpComboBox()
        {

        }

        private List<DbDataRecord> GetTableData(SqlDataReader DataReader)//получаем данные из таблицы, method SELECT
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

        private SqlDataReader CreateDataReaderVariable()//создаём перменную для сохранения возвращаемой информации из БД; используем её например в GetTableData()
        {
            sqlConn.Open();
            SqlDataReader dataReader = sqlComm.ExecuteReader();
            return dataReader;
        }

        private void SetCommandTextSelectBySecondaryKey(string NameOfTable)
        {
            sqlComm.CommandText = "SELECT * FROM " + NameOfTable + ";";
        }

        public List<string[]> GetDataForComboBox(string nameOfTable)
        {
            List<DbDataRecord> arrList;
            SetCommandTextSelectBySecondaryKey(nameOfTable);
            arrList = GetTableData(CreateDataReaderVariable());
            List<string[]> masList = new List<string[]>();
            if (arrList[0].FieldCount != 0)
            {
                for (int i = 0; i < arrList.Count; i++)
                {
                    string[] masStringOneItem = new string[arrList[0].FieldCount];
                    //masList.Add();
                    //masList[i].SetValue(arrList[i].GetValue(0).ToString(), 0);
                    //masList[i].SetValue(arrList[i].GetValue(1).ToString(), 1);
                    for (int j=0; j < arrList[0].FieldCount; j++)
                    {
                        masStringOneItem[j] = arrList[i].GetValue(j).ToString();
                    }
                    masList.Add(masStringOneItem);
                }
            }
            return masList;
        }

        public void SetMasStringsValues(List<string[]> listOfString)
        {
            iD.Clear();
            textInComboBox.Clear();
            for (int i = 0; i < listOfString.Count; i++)
                {
                    
                    iD.Add(listOfString[i].GetValue(0).ToString());
                    textInComboBox.Add(listOfString[i].GetValue(1).ToString());
                }
        }

        public void HookOnComboBox(ComboBox NameOfComboBox)
        {
            NameOfComboBox.Items.Clear();
            for (int i=0; i<textInComboBox.Count; i++)
            {
                NameOfComboBox.Items.Add(textInComboBox[i]);
            }

        }
    }
}
