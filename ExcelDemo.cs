using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;

namespace Nunitfram
{
    [TestFixture]
    internal class ExcelDemo
    {

        [Test]
        public void ExcelTest()
        {
            //Demo of GITHUB
            String path = @"C:\Users\rohit\Desktop\Demo.xlsx";

            var excelFile = new excel.Application();
            Workbook workbook = excelFile.Workbooks.Open(path);
            Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

            for(int row=1,col=1;row<=3;row++)
            {
                string val = worksheet.Cells[row, col].ToString();
              Console.WriteLine(val);
            }
 
        }
    }
}
