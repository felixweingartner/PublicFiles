using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2
{
    class ExcelReaderInterop
    {
        /// <summary>
        /// Store the Application object we can use in the member functions.
        /// </summary>
        Excel.Application _excelApp;

        /// <summary>
        /// Initialize a new Excel reader. Must be integrated
        /// with an Excel interface object.
        /// </summary>
        public ExcelReaderInterop()
        {
            _excelApp = new Excel.Application();
        }
    }

    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        static public void ProcessObjects(object[,] array)
        {
            Console.WriteLine(array[1,1]);
        }
        static public void ExcelScanIntenal(Excel.Workbook workBookIn)
        {
            Console.WriteLine("ExcelScanINternal being used");
            //
            // Get sheet Count and store the number of sheets.
            //
            int numSheets = workBookIn.Sheets.Count;

            //
            // Iterate through the sheets. They are indexed starting at 1.
            //
            for (int sheetNum = 1; sheetNum < numSheets + 1; sheetNum++)
            {
                Excel.Worksheet sheet = (Excel.Worksheet)workBookIn.Sheets[sheetNum];
                sheet.Cells[1, 1] = "NotJimmyDean";

                //
                // Take the used range of the sheet. Finally, get an object array of all
                // of the cells in the sheet (their values). You can do things with those
                // values. See notes about compatibility.
                //
                Excel.Range excelRange = sheet.UsedRange;
                object[,] valueArray = (object[,])excelRange.get_Value(
                    Excel.XlRangeValueDataType.xlRangeValueDefault);

                //
                // Do something with the data in the array with a custom method.
                //
                ProcessObjects(valueArray);
            }
        }
        static public void ExcelOpenSpreadsheets(string thisFileName)
        {
            try
            {
                //
                // This mess of code opens an Excel workbook. I don't know what all
                // those arguments do, but they can be changed to influence behavior.
                //
                Excel.Application app = new Excel.Application();
                Excel.Workbook workBook = app.Workbooks.Open(thisFileName,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);

                //
                // Pass the workbook to a separate function. This new function
                // will iterate through the worksheets in the workbook.
                //
                //
                // Get sheet Count and store the number of sheets.
                //
                int numSheets = workBook.Sheets.Count;

                //
                // Iterate through the sheets. They are indexed starting at 1.
                //
                for (int sheetNum = 1; sheetNum < numSheets + 1; sheetNum++)
                {
                    Excel.Worksheet sheet = (Excel.Worksheet)workBook.Sheets[sheetNum];

                    //
                    // Take the used range of the sheet. Finally, get an object array of all
                    // of the cells in the sheet (their values). You can do things with those
                    // values. See notes about compatibility.
                    //
                    Excel.Range excelRange = sheet.UsedRange;
                    object[,] valueArray = (object[,])excelRange.get_Value(
                        Excel.XlRangeValueDataType.xlRangeValueDefault);

                    //
                    // Do something with the data in the array with a custom method.
                    //
                    ProcessObjects(valueArray);

                    //
                    // Clean up.
                    //

                    workBook.Close(false, thisFileName, null);
                    Marshal.ReleaseComObject(workBook);
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            error.Visible = false;


            //testing
            string thisFileName = "c:\\mehFolder\\fblaDatabase.xls";
            Console.WriteLine("Starting...");
            ExcelOpenSpreadsheets(thisFileName);

        }
    }
}
