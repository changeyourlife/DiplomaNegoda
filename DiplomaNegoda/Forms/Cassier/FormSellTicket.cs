using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DiplomaNegoda.Forms.Cassier
{
    public partial class FormSellTicket : Form
    {
        private Excel.Sheets excelsheets;
        private Excel.Worksheet excelworksheet;

        public FormSellTicket()
        {
            InitializeComponent();
        }

        public Excel.Range Cells { get; private set; }

        private void ButtonSellTicket_Click(object sender, EventArgs e)
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

            //Объединяем ячейки
            oRange = sheet.Range[sheet.Cells[1, 1], sheet.Cells[11, 3]];
            //(sheet.Cells[1, 1] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            oRange.Font.Bold = true;
            oRange.Value = "БИЛЕТ";
            oRange.Font.Size = 48;
            oRange.Font.FontStyle = "Calibri";
            oRange.Font.Color = System.Drawing.Color.DarkGreen;
            oRange.Orientation = +90;
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            oRange = sheet.Range[sheet.Cells[12, 1], sheet.Cells[12, 3]];
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            oRange = sheet.Range[sheet.Cells[13, 1], sheet.Cells[13, 3]];
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            oRange = sheet.Range[sheet.Cells[14, 1], sheet.Cells[14, 3]];
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            oRange = sheet.Range[sheet.Cells[15, 1], sheet.Cells[15, 3]];
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            oRange = sheet.Range[sheet.Cells[2, 4], sheet.Cells[2, 5]];
            oRange.Merge(Type.Missing);
            oRange.Font.Bold = true;
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            oRange.Value = "Номер места:";

            oRange = sheet.Range[sheet.Cells[2, 6], sheet.Cells[2, 7]];
            oRange.Merge(Type.Missing);
            oRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            application.Visible = true;
        }
    }
}
