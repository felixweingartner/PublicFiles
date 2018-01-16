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
using System.Text.RegularExpressions;
namespace WindowsFormsApplication2
{
    public partial class editstudent : Form
    {
        string a = null;
        public editstudent()
        {
            InitializeComponent();
        }
        string none = null;
        string ntwo = null;
        private void r1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
            //our name variables
            none = n1.Text;
            ntwo = n2.Text;
            finderror.Visible = false;
           if (none == "" || ntwo == "")
            {
                finderror.Text = "*Neither entry be empty";
                finderror.Visible = true;
            }
           else
            {
                //see if students exists
                //open excel database and read
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
                string firstData = "hey";
                string lastData = null;
                string loc = null;
                string loc2 = null;
                bool found = false;

                int x = 1;
                if (none == null || ntwo == null)
                {
                    x = -1;
                }
                while (firstData != "" || x == 1)
                {
                    Console.WriteLine(x + " time");
                    loc = "B" + x;
                    firstData = myExcelWorksheet.get_Range(loc, misValue).Formula.ToString();
                    if (firstData.Equals(none, StringComparison.InvariantCultureIgnoreCase) == false)
                    {
                        //this one isnt the first name
                    }
                    else
                    {
                        //this is the first name! check last name
                        loc2 = "C" + x;
                        lastData = myExcelWorksheet.get_Range(loc2, misValue).Formula.ToString();
                        if (lastData.Equals(ntwo, StringComparison.InvariantCultureIgnoreCase) == true)
                        {
                            //we have found our student!
                            found = true;
                            break;
                        }
                        else
                        {
                            //not our student keep searching
                        }

                    }

                    x = x + 1;
                }
                if (found == true)
                {
                    Console.WriteLine(x + " is the spot");
                    //now we need to read the data from that student and output
                    t2.Text = myExcelWorksheet.get_Range("B" + x, misValue).Formula.ToString();
                    t3.Text = myExcelWorksheet.get_Range("C" + x, misValue).Formula.ToString();
                    t4.Text = myExcelWorksheet.get_Range("D" + x, misValue).Formula.ToString();
                    t5.Text = myExcelWorksheet.get_Range("E" + x, misValue).Formula.ToString();
                    t6.Text = myExcelWorksheet.get_Range("F" + x, misValue).Formula.ToString();
                    t7.Text = myExcelWorksheet.get_Range("G" + x, misValue).Formula.ToString();
                    t8.Text = myExcelWorksheet.get_Range("H" + x, misValue).Formula.ToString();
                    if (myExcelWorksheet.get_Range("I" + x, misValue).Formula.ToString() == "yes")
                    {
                        //active member
                        r1.Checked = true;
                        r2.Checked = false;
                    }
                    else
                    {
                        //inactive member
                        r2.Checked = true;
                        r1.Checked = false;
                    }
                    t9.Text = myExcelWorksheet.get_Range("J" + x, misValue).Formula.ToString();
                    //previous information has been outputed now to remove the cover image
                    hideBox.Visible = false;
                    submit.Enabled = true;


                }
                else
                {
                    //student has not been found, display error and do nothing else
                    finderror.Visible = true;
                    hideBox.Visible = true;
                    submit.Enabled = false;
                }
                //save and close excel files and processes
                myExcelWorkbook.Save();
                myExcelWorkbook.Close();
                myExcelApp.Quit();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //should already be enabled
            //save information and exit form
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
                if (Regex.IsMatch(t2.Text, @"^[a-zA-Z]+$") == true && Regex.IsMatch(t3.Text, @"^[a-zA-Z]+$") == true && Regex.IsMatch(t4.Text, @"^[a-zA-Z ]+$") == true && Regex.IsMatch(t6.Text, @"^[a-zA-Z]+$") == true && Regex.IsMatch(t8.Text, @"^[0-9]+$") == true && Regex.IsMatch(t9.Text, @"^[0-9.@]+$") == true && Regex.IsMatch(t5.Text, @"^[0-9]+$") == true)
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
                        studN = myExcelWorksheet.get_Range("A" + x, misValue).Formula.ToString();
                        Console.WriteLine(x + " time");
                        x = x + 1;
                    }
                    x = x - 2;
                    //the radio button thing
                    if (r1.Checked == true)
                    {
                        a = "yes";
                    }
                    else
                    {
                        a = "no";
                    }
                    myExcelWorksheet.get_Range("A" + x, misValue).Formula = x - 1;
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
