using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;
        string path = "C:\\fblaManager\\fblaDatabase.xls";
        string path2 = "C:\\fblaManager\\fblaLogins.xls";
        string direct = "C:\\fblaManager";
        public Form1()
        {
            InitializeComponent();
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            inFade.Start();
            timer1.Start();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y == 0)
            {
                label1.Text = "Loading...";
              
            }
            else if (y == 10)
            {
                label1.Text = "Loading.";

            }
            else if (y == 20)
            {
                label1.Text = "Loading..";
            }
            else if (y == 30)
            {
                label1.Text = "Loading...";
                
            }
            else if (y == 40)
            {
                label1.Text = "Loading.";
            }
            else if (y == 50)
            {
                label1.Text = "Loading..";
                y = -10;
            }
           
                y = y + 10;
            if (x == 0)
            {
                System.Threading.Thread.Sleep(1000);
                x = 2;
            }
            if (File.Exists(path) == true && File.Exists(path2))
            {
                //do nothing everything should be in place
                Console.WriteLine("File exists, proceeding");
 
                //TESTING
               

            }
            else
            {
                label1.Text = "Preforming First Time Setup...";
                Console.WriteLine("File does not exist, writing file...");
                //directory may not exit
                if (System.IO.Directory.Exists(direct) == true)
                {
                    //directory exists
                    Console.WriteLine("Directory exists");
                   
                   
                   
                }
                else
                {
                    //directory does not exist
                    Console.WriteLine("Directory does not exist, creating...");
                    System.IO.Directory.CreateDirectory(direct);
                    Console.WriteLine("Directory has been created");
                }

                
                //System.IO.File.Create("C:\\fblaManager\\fblaDatabase.xls"); DOES NOT WORK
                Excel.Application startup = new Excel.Application();
                startup.Visible = false;
                startup.DisplayAlerts = false;
                Excel.Workbooks startWorkbooks;
                Excel.Workbook startWorkbook;
                Excel.Worksheet startWorksheet;


                object misValue2 = System.Reflection.Missing.Value;
                startWorkbooks = startup.Workbooks;
                startWorkbook = startup.Workbooks.Add(misValue2);
                Excel.XlSaveAsAccessMode save = Excel.XlSaveAsAccessMode.xlNoChange;
                startWorkbook.SaveAs("C:\\fblaManager\\fblaDatabase.xls", misValue2, "lambda3b", misValue2, misValue2, misValue2, save, misValue2, misValue2, misValue2, misValue2, misValue2);
                startWorkbook.SaveAs("C:\\fblaManager\\fblaLogins.xls", misValue2, "lambda3b", misValue2, misValue2, misValue2, save, misValue2, misValue2, misValue2, misValue2, misValue2);
                startWorksheet = (Excel.Worksheet)startWorkbook.ActiveSheet;
                startWorksheet.Name = "fblaData";
                startWorkbook.Save();
                startWorkbook.Close();
                startup.Quit();
                Console.WriteLine("Were good to go");
                progressBar1.Increment(9);
                //setting up file
                Console.WriteLine("Testing write");
                Excel.Application myExcelApp;
                Excel.Workbooks myExcelWorkbooks;
                Excel.Workbook myExcelWorkbook;
                object misValue = System.Reflection.Missing.Value;
                Console.WriteLine("stuff has been created");
                myExcelApp = new Excel.Application();
                myExcelApp.Visible = false;

                myExcelWorkbooks = myExcelApp.Workbooks;
                Console.WriteLine("More stuff has been created lljlkjlj");
                string fileName = "C:\\fblaManager\\fblaDatabase.xls";
                //setting file information
                myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, "lambda3b", misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
                Excel.Worksheet myExcelWorksheet = (Excel.Worksheet)myExcelWorkbook.ActiveSheet;

                Console.WriteLine("whoa even more stuff)");
                Console.WriteLine("All Done part 1");

                //writing to file
                myExcelWorksheet.get_Range("A1", misValue).Formula = "MemberNumber";
                myExcelWorksheet.get_Range("B1", misValue).Formula = "First";
                myExcelWorksheet.get_Range("C1", misValue).Formula = "Last";
                myExcelWorksheet.get_Range("D1", misValue).Formula = "School";
                myExcelWorksheet.get_Range("E1", misValue).Formula = "Grade";
                myExcelWorksheet.get_Range("F1", misValue).Formula = "State";
                myExcelWorksheet.get_Range("G1", misValue).Formula = "Email";
                myExcelWorksheet.get_Range("H1", misValue).Formula = "YearJoined";
                myExcelWorksheet.get_Range("I1", misValue).Formula = "Active";
                myExcelWorksheet.get_Range("J1", misValue).Formula = "MoneyOwed";
                //this changes the cell value in C2 to "New Value";
                
                myExcelWorkbook.Save();
                myExcelWorkbook.Close();
                Console.WriteLine("All Done :)");
                myExcelApp.Quit();

                /* FOR READING
                string cellFormulaAsString = myExcelWorksheet.get_Range("A2", misValue).Formula.ToString();
                //this puts the formula in Cell A2 or text depending whats in it in the string.
                */


            }

            progressBar1.Increment(3);
            if (progressBar1.Value == 100)
            {
                System.Threading.Thread.Sleep(1000);
                this.Visible = false;
                login f2 = new login();
                f2.Show();
                timer1.Stop();
            }
        }

        private void inFade_Tick(object sender, EventArgs e)
        {
            
            
           
            for (double fade = .0001; fade <= 1; fade = fade + .00001)
            {
                
                this.Opacity = fade;
                
            }
            inFade.Stop();
            //timer1.Enabled = true;
            //timer1.Start();
        }
    }
}
