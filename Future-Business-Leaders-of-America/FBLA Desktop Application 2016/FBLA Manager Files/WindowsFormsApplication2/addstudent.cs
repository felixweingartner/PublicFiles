using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApplication2
{
    public partial class addstudent : Form
    {
        string a = null;
        System.Drawing.Color cola = Color.SkyBlue;
        System.Drawing.Color normalcola = Color.SteelBlue;
        public addstudent()
        {
            InitializeComponent();
        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void r2_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submit_MouseHover(object sender, EventArgs e)
        {
            submit.BackColor = cola;
        }

        private void submit_MouseLeave(object sender, EventArgs e)
        {
            submit.BackColor = normalcola;
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            back.BackColor = cola;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.BackColor = normalcola;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            

                //reset error
                bool proceed = true;
            error.Visible = false;
            //the user clicked sumit, check if all entries are leginimate//

            //test if anything is empty
            if (t2.Text == null || t3.Text == null || t4.Text == null || t5.Text == null || t6.Text == null || t7.Text == null || t8.Text == null || t9.Text == null)
            {
                //something is empty! show error
                error.Text = "*Error, one or text fields are empty";
                error.Visible = true;
                proceed = false;
            }
            //continue testing
            if (proceed == true)
            {
                //test if string fields contain anything but string
                if (Regex.IsMatch(t2.Text, @"^[a-zA-Z]+$") == true && Regex.IsMatch(t3.Text, @"^[a-zA-Z]+$") == true && Regex.IsMatch(t4.Text, @"^[a-zA-Z ]+$") == true && Regex.IsMatch(t6.Text, @"^[a-zA-Z]+$") == true &&  Regex.IsMatch(t8.Text, @"^[0-9]+$") == true && Regex.IsMatch(t9.Text, @"^[0-9.@]+$") == true && Regex.IsMatch(t5.Text, @"^[0-9]+$") == true)
                {
                    Console.WriteLine("We are good as golden");
                    //everything is good time to save
                    //open excel sheets
                    Excel.Application myExcelApp;
                    Excel.Workbooks myExcelWorkbooks;
                    Excel.Workbook myExcelWorkbook;
                    object misValue = System.Reflection.Missing.Value;
                    Console.WriteLine("stuff has been created");
                    myExcelApp = new Excel.Application();
                    myExcelApp.Visible = false;
                    myExcelApp.DisplayAlerts = false;
                    myExcelWorkbooks = myExcelApp.Workbooks;
                    Console.WriteLine("More stuff has been created lljlkjlj");
                    string fileName = "C:\\fblaManager\\fblaDatabase.xls";

                    myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, "lambda3b", misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
                    Excel.Worksheet myExcelWorksheet = (Excel.Worksheet)myExcelWorkbook.ActiveSheet;

                    string studN = "hey";
                    
                    int x = 1;
                    while (studN != "" || x == 1)
                    {
                        studN = myExcelWorksheet.get_Range("A"+x, misValue).Formula.ToString();
                        Console.WriteLine(x + " time");
                        x = x + 1;
                    }
                    x = x - 1;
                    //the radio button thing
                    if (r1.Checked == true)
                    {
                        a = "yes";
                    }
                    else
                    {
                        a = "no";
                    }
                    myExcelWorksheet.get_Range("A" + x, misValue).Formula = x-1;
                    myExcelWorksheet.get_Range("B" + x, misValue).Formula = t2.Text;
                    myExcelWorksheet.get_Range("C" + x, misValue).Formula = t3.Text;
                    myExcelWorksheet.get_Range("D" + x, misValue).Formula = t4.Text;
                    myExcelWorksheet.get_Range("E" + x, misValue).Formula = t5.Text;
                    myExcelWorksheet.get_Range("F" + x, misValue).Formula = t6.Text;
                    myExcelWorksheet.get_Range("G" + x, misValue).Formula = t7.Text;
                    myExcelWorksheet.get_Range("H" + x, misValue).Formula = t8.Text;
                    myExcelWorksheet.get_Range("I" + x, misValue).Formula = a;
                    myExcelWorksheet.get_Range("J" + x, misValue).Formula = t9.Text;
                    myExcelWorkbook.Save();
                    myExcelApp.Quit();
                    Close();

                }
                else
                {
                    //an entry does not only contain letters !
                    error.Text = "*Error, one or more invalid entries";
                    error.Visible = true;
                    proceed = false;
                }
            }


        }
    }
}
