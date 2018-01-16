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
namespace WindowsFormsApplication2
{
    public partial class newaccount : Form
    {
        int x = -1;
        public newaccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is the back button
            login back = new login();
            back.Show();
            Close();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string text3 = textBox3.Text;
            string text4 = textBox4.Text;
            bool proceed = true;
            //create button run check before submission
            errorlabel.Visible = false;
            //is anything blank?
            if (text1 == null || text2 == null || text3 == null || text4 == null)
            {
                //something is blank
                errorlabel.Text = "*A text entry was left blank";
                proceed = false;
            }
            //check if account key is correct
            if (text1 == "fblaRocks!")
            {
                proceed = true;
            }
            else
            {
                proceed = false;
            }
            
            
            //check if passwords match
            if (text3 == text4)
            {
                //passwords match
            }
            else
            {
                //passwords do not match
                proceed = false;
                errorlabel.Text = "*Passwords do not match";
                errorlabel.Visible = true;
            }
            string location = null;
            string location2 = null;
            //if its passed all the tests save user information & continue to login screen
            //username cannot previously exist, check
            if (proceed == true)
            {
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
                string fileName = "C:\\fblaManager\\fblaLogins.xls";

                myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, "lambda3b", misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
                Excel.Worksheet myExcelWorksheet = (Excel.Worksheet)myExcelWorkbook.ActiveSheet;
                string userData = "hey";
                string loc = null;
                x = 1;
                while (userData != "" || x == 1)
                {
                    Console.WriteLine(x + " time");
                    loc = "A" + x;
                    userData = myExcelWorksheet.get_Range(loc, misValue).Formula.ToString();
                    if (userData != text2)
                    {
                        //this one isnt the username
                    }
                    else
                    {
                        //this one IS the username, username already exists!
                        Console.WriteLine("username already exists!");
                        proceed = false;
                        errorlabel.Text = "*User name already exists";
                        errorlabel.Visible = true;
                        break;

                    }
                    x = x + 1;
                }
                
                if (proceed == true)
                {
                    x = x - 1;
                    location = "A" + x;
                    location2 = "B" + x;
                    myExcelWorksheet.get_Range(location, misValue).Formula = text2;
                    myExcelWorksheet.get_Range(location2, misValue).Formula = text3;
                    myExcelWorkbook.Save();
                }
                //close everything out
                
                Console.WriteLine("All Done :)");
                myExcelApp.Quit();
                if (proceed == true)
                {
                    login nl = new login();
                    nl.Show();
                    Close();
                }
            }
            

        }
        System.Drawing.Color cola = Color.SkyBlue;
        System.Drawing.Color normalcola = Color.SteelBlue;

        private void create_MouseHover(object sender, EventArgs e)
        {
            create.BackColor = cola;
        }

        private void create_MouseLeave(object sender, EventArgs e)
        {
            create.BackColor = normalcola;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = cola;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = normalcola;
        }
    }
}