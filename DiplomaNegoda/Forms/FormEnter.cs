using DiplomaNegoda.Classes;
using DiplomaNegoda.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DiplomaNegoda
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            List<DbDataRecord> arrList = new List<DbDataRecord>();
            Login ObjectLogin = new Login(); //create object of class "Login"
            ObjectLogin.SetLoginPasswordForEnter(textBoxLogin.Text, textBoxPassword.Text);
            arrList = ObjectLogin.Enter(ObjectLogin.CreateDataReaderVariable());
            
            if (arrList.Count != 0)
            {
                //MessageBox.Show("NOT NULL");
                //if (arrList[0].)
                if (arrList[0].GetValue(4).ToString().Equals("1"))
                {
                    //MessageBox.Show("YOU ADMIN");
                    FormAdmin ObjectFormAdmin = new FormAdmin();
                    ObjectFormAdmin.Owner= this;
                    ObjectFormAdmin.ShowDialog();
                }
                else if (arrList[0].GetValue(4).ToString().Equals("2"))
                {
                    //MessageBox.Show("YOU KAS");
                    FormCassier ObjectFormCassier = new FormCassier();
                    ObjectFormCassier.Owner = this;
                    ObjectFormCassier.ShowDialog();
                }
            else
            {
                MessageBox.Show("INCORRECT");
            }
            }
            else
            {
                MessageBox.Show("NULL");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Excel.Sheets excelsheets;
        private Excel.Worksheet excelworksheet;
        public Excel.Range Cells { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Excel.Application application = new Excel.Application();
            Object missing = Type.Missing;
            //добавили книгу
            application.Workbooks.Add(missing);
            Excel.Worksheet sheet = (Excel.Worksheet)application.ActiveSheet;
            //вписываем текст
            sheet.Cells[1, 1] = "hi!";
            ((Excel.Range)sheet.Columns).ColumnWidth = 15;
            //жирность
            (sheet.Cells[1, 1] as Excel.Range).Font.Bold = true;
            //размер шрифта
            (sheet.Cells[1, 1] as Excel.Range).Font.Size = 16;
            //название шрифта
            (sheet.Cells[1, 1] as Excel.Range).Font.Name = "Times New Roman";
            //стиль границы
            (sheet.Cells[1, 1] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
            //толщина границы
            (sheet.Cells[1, 1] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;
            //выравнивание по горизонтали
            (sheet.Cells[1, 1] as Excel.Range).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //выравнивание по вертикали
            (sheet.Cells[1, 1] as Excel.Range).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            //объединение ячеек
            Excel.Range oRange;

            oRange = sheet.Range[sheet.Cells[1, 1], sheet.Cells[4,4]];
            oRange.Merge(Type.Missing);
            application.Visible = true;*/

            Excel.Application application = new Excel.Application();
            Object missing = Type.Missing;
            application.Workbooks.Add(missing);
            Excel.Worksheet sheet = (Excel.Worksheet)application.ActiveSheet;
            Excel.Range oRange;

            //Настройка всего документа
            oRange = sheet.Range[sheet.Cells[1, 1], sheet.Cells[15, 14]];
            oRange.Font.FontStyle = "Calibri";
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            oRange.Font.Size = 10;
            oRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;

            //Объединяем ячейки
            oRange = sheet.Range[sheet.Cells[1, 1], sheet.Cells[11, 3]];
            //(sheet.Cells[1, 1] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Font.Bold = true;
            oRange.Value = "БИЛЕТ";
            oRange.Font.Size = 48;
            oRange.Font.Color = System.Drawing.Color.DarkGreen;
            oRange.Orientation = +90;

            oRange = sheet.Range[sheet.Cells[12, 1], sheet.Cells[12, 3]];
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Value = "Дата вылета:";
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            oRange = sheet.Range[sheet.Cells[13, 1], sheet.Cells[13, 3]];
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Value = "Время вылета:";
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            oRange = sheet.Range[sheet.Cells[14, 1], sheet.Cells[14, 3]];
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Value = "Дата прилёта:";
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            oRange = sheet.Range[sheet.Cells[15, 1], sheet.Cells[15, 3]];
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Value = "Время прилёта:";
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            oRange = sheet.Range[sheet.Cells[2, 4], sheet.Cells[2, 5]];
            oRange.Merge(Type.Missing);
            oRange.Font.Bold = true;
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            oRange.Value = "Номер места:";

            oRange = sheet.Range[sheet.Cells[2, 6], sheet.Cells[2, 7]];
            oRange.Merge(Type.Missing);
            oRange.Value = "[Номер места]";
            oRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            application.Visible = true;

            oRange = sheet.Range[sheet.Cells[2, 8], sheet.Cells[2, 9]];
            oRange.Merge(Type.Missing);
            oRange.Font.Bold = true;
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            oRange.Value = "Класс билета:";

            oRange = sheet.Range[sheet.Cells[2, 10], sheet.Cells[2, 11]];
            oRange.Merge(Type.Missing);
            oRange.Value = "[Класс билета]";
            oRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            application.Visible = true;

            oRange = sheet.Range[sheet.Cells[4, 4], sheet.Cells[4, 5]];
            oRange.Merge(Type.Missing);
            oRange.Font.Bold = true;
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            oRange.Value = "Стоимость:";

            oRange = sheet.Range[sheet.Cells[4, 6], sheet.Cells[4, 7]];
            oRange.Merge(Type.Missing);
            oRange.Value = "[Стоимость]";
            oRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            application.Visible = true;

            oRange = sheet.Range[sheet.Cells[6, 4], sheet.Cells[6, 5]];
            oRange.Merge(Type.Missing);
            oRange.Font.Bold = true;
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            oRange.Value = "№ рейса:";

            oRange = sheet.Range[sheet.Cells[6, 6], sheet.Cells[6, 7]];
            oRange.Merge(Type.Missing);
            oRange.Value = "[№ рейса]";
            oRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            application.Visible = true;

            oRange = sheet.Range[sheet.Cells[10, 4], sheet.Cells[10, 4]];
            oRange.Merge(Type.Missing);
            oRange.Font.Bold = true;
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            oRange.Value = "Маршрут:";

            oRange = sheet.Range[sheet.Cells[10, 5], sheet.Cells[10, 8]];
            oRange.Merge(Type.Missing);
            oRange.Value = "[из_города]-[в_город]";
            oRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            application.Visible = true;

            oRange = sheet.Range[sheet.Cells[10, 9], sheet.Cells[10, 11]];
            oRange.Merge(Type.Missing);
            oRange.Font.Bold = true;
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            oRange.Value = "Серия-номер пасспорта:";

            oRange = sheet.Range[sheet.Cells[10, 12], sheet.Cells[10, 13]];
            oRange.Merge(Type.Missing);
            oRange.Value = "[Серия-номер пасспорта]";
            oRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            application.Visible = true;

            oRange = sheet.Range[sheet.Cells[11, 12], sheet.Cells[11, 13]];
            oRange.Merge(Type.Missing);
            oRange.Value = "(серийный номер)";
            application.Visible = true;

            oRange = sheet.Range[sheet.Cells[13, 4], sheet.Cells[13, 5]];
            oRange.Merge(Type.Missing);
            oRange.Font.Bold = true;
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            oRange.Value = "Пассажир:";

            oRange = sheet.Range[sheet.Cells[13, 6], sheet.Cells[13, 13]];
            oRange.Merge(Type.Missing);
            oRange.Value = "[Пассажир]";
            oRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            application.Visible = true;

            oRange = sheet.Range[sheet.Cells[14, 8], sheet.Cells[14, 11]];
            oRange.Merge(Type.Missing);
            oRange.Value = "(полное ФИО)";
            application.Visible = true;
        }
    }
}
