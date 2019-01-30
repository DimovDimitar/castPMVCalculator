using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop.Excel;

namespace PMV_Tool
{
    class ExcelOne
    {

        Excel.Application excel = new Excel.Application();
        string path = @"MMC.xlsx";
        Excel.Workbook wb;
        Excel.Worksheet ws;
        Excel.Range range;

        public void Excel()
        {
            //this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[1];

            int rowCnt;
            range = ws.UsedRange;

            for (rowCnt = 1; rowCnt <= range.Rows.Count; rowCnt++)
            {

                string Charity = (string)(range.Cells[rowCnt, 1] as Excel.Range).Value;
                string Country = (string)(range.Cells[rowCnt, 2] as Excel.Range).Value;
                System.Console.WriteLine(Charity + " --- " + Country);

            }

        }
    }
}
