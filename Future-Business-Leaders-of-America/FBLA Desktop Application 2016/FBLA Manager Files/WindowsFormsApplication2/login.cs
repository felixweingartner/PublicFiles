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
    public partial class login : Form
    {
        System.Drawing.Color cola = Color.SkyBlue;
        System.Drawing.Color normalcola = Color.SteelBlue;
        private string user = null;
        private string pass = null;
        public login()
        {
            InitializeComponent();
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            errorLabel.Visible = false;
            
            //check if credentials are correct
            user = usernameTextbox.Text;
            pass = passwordTextbox.Text;
            if (user == "")
            {

            }
            else
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

                //scan document for username match

                //myExcelWorksheet.UsedRange.Formula = "=LookUp(\"" + user + "\", A:A, B:B)";
                //write result to t21
                //myExcelWorksheet.get_Range("T21", misValue).Formula = "=LookUp(\""+ user + "\", A:A, B:B";
                //string resalt = myExcelWorksheet.get_Range("t1", "t2").Formula = "=LookUp(\"" + user + "\", A:A, B:B)";

                //Console.WriteLine("just checked for username");
                //read result from t21
                //string cellString = resalt;
                //cellString = myExcelWorksheet.get_Range("T21", misValue).Formula.ToString();
                //label1.Text = cellString;
                //Console.WriteLine(cellString);
                string userData = "hey";
                string passData = null;
                string loc = null;
                string loc2 = null;
                bool clear = false;
                int x = 1;
                while (userData != "" || x == 1)
                {

                    Console.WriteLine(x + " time");
                    loc = "A" + x;
                    userData = myExcelWorksheet.get_Range(loc, misValue).Formula.ToString();
                    if (userData != user || user == null)
                    {
                        //this one isnt the username
                    }
                    else
                    {
                        Console.WriteLine("Username Found!");
                        //username is found now to check password
                        loc2 = "B" + x;
                        passData = myExcelWorksheet.get_Range(loc2, misValue).Formula.ToString();
                        //checking password...
                        if (passData == pass)
                        {
                            //they  match!
                            Console.WriteLine("password is good");
                            clear = true;
                            break;
                        }
                        else
                        {
                            //they do not match!
                            Console.WriteLine("password is wrong");
                            clear = false;
                            break;
                        }

                    }

                    x = x + 1;
                }
                
                myExcelWorkbook.Close();
                //close everything out
                Console.WriteLine("All done");
                myExcelApp.Quit();

                //our check has been complete, now to decide whether to continue or not
                if (clear == true)
                {
                    //credentials are all correct
                    fadeOut.Start();
                   
                    
                }
                else
                {
                    //credentails were not correct
                    errorLabel.Visible = true;
                }









            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            newaccount kappa = new newaccount();
            kappa.Show();
            Close();
        }

        private void login_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = cola;
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = normalcola;
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = cola;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = normalcola;
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            for (double fade = .99; fade > 0; fade = fade - .01)
            {
                Console.WriteLine("this is how we dew fade");
                this.Opacity = fade;

            }
            fadeOut.Stop();
           
            home h = new home();
            h.Show();
            Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
