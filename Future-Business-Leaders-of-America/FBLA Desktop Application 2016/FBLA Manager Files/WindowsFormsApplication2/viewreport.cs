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
    public partial class viewreport : Form
    {
        bool a, b, c, d, el, f, g, h, i, j, k, l, m, n, o = false;
        
        int z = 1;
        
        System.Drawing.Color cola = Color.SkyBlue;
        System.Drawing.Color normalcola = Color.SteelBlue;
        System.Drawing.Color sl = Color.Silver;
        System.Drawing.Color s2 = Color.DarkGray;
        public viewreport()
        {
            InitializeComponent();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = cola;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = normalcola;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = cola;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = normalcola;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            newRepBtn.BackColor = cola;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            newRepBtn.BackColor = normalcola;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cancel button clicked
            home h = new home();
            h.Show(); 
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open report button clicked
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Fbla Files (*.xls*)|*.xls*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.

            //openFileDialog1.ShowDialog();
            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("openfiledialog.showdialog() == dialogeResult.ok");
                Excel.Application myExcelApp;
                Excel.Workbooks myExcelWorkbooks;
                Excel.Workbook myExcelWorkbook;
                object misValue = System.Reflection.Missing.Value;
           
                myExcelApp = new Excel.Application();
                myExcelApp.Visible = true;
                myExcelApp.DisplayAlerts = false;
                myExcelWorkbooks = myExcelApp.Workbooks;
            
                string fileName = openFileDialog1.FileName;
                try
                {
                    myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
                    //myExcelWorkbook.PrintPreview();
                }
                catch
                {
                    //whatever it failed, users fault not programs
                }
                
            }

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            int lx = groupBox1.Location.X;
            int ly = groupBox1.Location.Y;
            int lx2 = groupBox2.Location.X;
            int ly2 = groupBox2.Location.Y;
            int nSize = viewreport.ActiveForm.Size.Height;
            int nSize2 = viewreport.ActiveForm.Size.Width;
            nSize = nSize + 240;
            int lX = Location.X;
            int lY = Location.Y;
            Location = new Point(lX, lY - 150);
            ly = ly - 200;
            ly2 = ly2 - 200;
            groupBox1.Location = new Point(lx, ly);
            groupBox2.Location = new Point(lx2, ly2);
            viewreport.ActiveForm.Size = new Size(nSize2, nSize);
            changeLable.Text = "New Report";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button25_MouseHover(object sender, EventArgs e)
        {

            if (a == false) { button25.BackColor = cola; }
           
        }

        private void button25_MouseLeave(object sender, EventArgs e)
        {
            if (a == false){ button25.BackColor = normalcola;}
        }

        private void button24_MouseHover(object sender, EventArgs e)
        {
            if (b == false) { button24.BackColor = cola; }
        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            if (b == false) { button24.BackColor = normalcola; }
        }

        private void button23_MouseHover(object sender, EventArgs e)
        {
            if (c == false) { button23.BackColor = cola; }
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            if (c == false) { button23.BackColor = normalcola; }
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            //if (i == "false") { button16.BackColor = cola; }

        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            //if (i == "false") { button16.BackColor = normalcola; }

        }

        private void button22_MouseHover(object sender, EventArgs e)
        {
            if (d == false) { button22.BackColor = cola; }
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            if (d == false) { button22.BackColor = normalcola; }
        }

        private void button21_MouseHover(object sender, EventArgs e)
        {
            if (el == false) { button21.BackColor = cola; }
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            if (el == false) { button21.BackColor = normalcola; }
        }

        private void button20_MouseHover(object sender, EventArgs e)
        {
            if (f == false) { button20.BackColor = cola; }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                button24.BackColor = sl;
                b = true;
            }
            else if (b == true)
            {
                button24.BackColor = normalcola;
                b = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                button23.BackColor = sl;
                c = true;
            }
            else if(c == true)
            {
                button23.BackColor = normalcola;
                c = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (d == false)
            {
                button22.BackColor = sl;
                d = true;
            }
            else if (d == true)
            {
                button22.BackColor = normalcola;
                d = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (el == false)
            {
                button21.BackColor = sl;
                el = true;
            }
            else if (el == true)
            {
                button21.BackColor = normalcola;
                el = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (f == false)
            {
                button20.BackColor = sl;
                f = true;
            }
            else if (f == true)
            {
                button20.BackColor = normalcola;
                f = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (g == false)
            {
                button19.BackColor = sl;
                g = true;
            }
            else if (g == true)
            {
                button19.BackColor = normalcola;
                g = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (h == false)
            {
                button18.BackColor = sl;
                h = true;
            }
            else if (h == true)
            {
                button18.BackColor = normalcola;
                h = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //active box
            /*
            if (i == "false")
            {
                active.Text = "If Active";
                button16.BackColor = sl;
                i = "true";
            }
            else if (i == "true")
            {
                active.Text = "If Not Active";
                button16.BackColor = s2;
                i = "none";
            }
            else if (i == "none")
            {
                active.Text = "N.D Active";
                button16.BackColor = normalcola;
                i = "false";
            }
            */
           
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if (k == false)
            {
                button4.BackColor = normalcola;
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            if (l == false)
            {
                button5.BackColor = cola;
            }
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            if (l == false)
            {
                button5.BackColor = normalcola;
            }
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            if (m == false)
            {
                button6.BackColor = cola;
            }
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            if (m == false)
            {
                button6.BackColor = normalcola;
            }
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            if (n == false)
            {
                button1.BackColor = cola;
            }
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            if (n == false)
            {
                button1.BackColor = normalcola;
            }
        }
        string data = null;
        bool ch1, ch2, ch3 = false;
        int cb1, cb2 = 1 ;
        int daIndex = 0;
        int[] daOne;
        private void button1_Click_1(object sender, EventArgs e)
        {
            // SUBMIT BUTTON CLICKED //
            daIndex = 0;
           daOne = new int[100];
            daOne[0] = -10;
            //set error visibility 
            error.ForeColor = System.Drawing.Color.LightGreen;
            error.Text = "Creating Report...";
            error.Visible = true;
            bool pass = true;
            bool proceed = true;
            //check box fileters
            if (checkBox1.Checked == true)
            {
                ch1 = true;
            }
            if (checkBox2.Checked == true)
            {
                ch2 = true;
            }
            if (checkBox3.Checked == true)
            {
                ch3 = true;
            }

            //combo box filters
           
            
            if (comboBox1.SelectedIndex == 0)
            {
                cb1 = 1; 
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                cb1 = 2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                cb1 = 3;
            }
            
            if (comboBox2.SelectedIndex == 0)
            {
                cb2 = 1;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                cb2 = 2;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                cb2 = 3;
            }

            //make sure combo box's are not both empty
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
            {
                Console.WriteLine("past stage 1");
                if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 1 || comboBox2.SelectedIndex == 2)
                {
                    Console.WriteLine("past stage 2");
                    if (button4.BackColor.Equals(normalcola) == false || button6.BackColor.Equals(normalcola) == false)
                    {
                        //test if everything was left blank
                        if (a == false && b == false && c == false && d == false && el == false && f == false && g == false && h == false)
                        {
                            //error nothing was selected
                            error.Text = "*At least one field selection is required";
                            error.Visible = true;
                        }
                        else
                        {
                            //something was selected continue
                            //open fbla database
                            Excel.Application myExcelApp2;
                            Excel.Workbooks myExcelWorkbooks2;
                            Excel.Workbook myExcelWorkbook2;
                            object misValue = System.Reflection.Missing.Value;
                            Console.WriteLine("stuff has been created");
                            myExcelApp2 = new Excel.Application();
                            myExcelApp2.Visible = false;
                            myExcelApp2.DisplayAlerts = false;
                            
                            Console.WriteLine("More stuff has been created lljlkjlj");
                            string fileName = "C:\\fblaManager\\fblaDatabase.xls";
                            //myExcelWorkbooks2 = myExcelApp2.Workbooks;
                            myExcelWorkbook2 = myExcelApp2.Workbooks.Open(fileName, misValue, misValue, misValue, "lambda3b", misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
                            Excel.Worksheet myExcelWorksheet2 = (Excel.Worksheet)myExcelWorkbook2.ActiveSheet;
                            
                            //now read and find results based on user filters
                            //row read x int
                            int x = 0;
                            while (data != "" || x == 0)
                            {
                                pass = true;
                                //if first intracation
                                if (x == 0)
                                {
                                    x += 1;
                                }
                                data = myExcelWorksheet2.get_Range("A" + x, misValue).Formula.ToString();
                                //school checkmark filter
                                if (ch1 == true)
                                {
                                    if (t1.Text == myExcelWorksheet2.get_Range("D" + x).Formula.ToString())
                                    {
                                        //passes the filter
                                    }
                                    else
                                    {
                                        //does not pass the filter
                                        pass = false;
                                    }
                                }
                                //grade checkmark filter
                                if (ch2 == true)
                                {
                                    if (t2.Text == myExcelWorksheet2.get_Range("E" + x).Formula.ToString())
                                    {
                                        Console.WriteLine("Passed the filter!");
                                        //passes the filter
                                    }
                                    else
                                    {
                                        //does not pass the filter
                                        pass = false;
                                    }
                                }
                                //state checkmark filter
                                if (ch3 == true)
                                {
                                    if (t3.Text == myExcelWorksheet2.get_Range("F" + x).Formula.ToString())
                                    {
                                        //passes the filter
                                    }
                                    else
                                    {
                                        //does not pas the filter
                                        pass = false;
                                    }
                                }

                                //if it passed checkmark filters
                                if (pass == true)
                                {
                                    //passed
                                    //see if it passes the combobox filter
                                    if (cb1 == 1)
                                    {
                                        //active state doesnt matter
                                        pass = true;
                                    }
                                    else if (cb1 == 2)
                                    {
                                        //active only
                                        if ("yes" == myExcelWorksheet2.get_Range("I" + x).Formula.ToString())
                                        {
                                            pass = true;
                                        }
                                        else
                                        {
                                            //person is not active
                                            pass = false;
                                        }
                                    }
                                    else if (cb1 == 3)
                                    {
                                        //nonactive only
                                        if ("no" == myExcelWorksheet2.get_Range("I" + x).Formula.ToString())
                                        {
                                            pass = true;
                                        }
                                        else
                                        {
                                            //person is not nonactive
                                            pass = false;
                                        }
                                    }

                                    //we finished filter tests
                                    if (pass == true)
                                    {
                                        Console.WriteLine("setting daOne[daIndex] to " + daIndex + " [] " + x);
                                        daOne[daIndex] = x;
                                        daIndex++;
                                    }
                                    else
                                    {
                                        //just move on again, current x does not qualify
                                        Console.WriteLine(x + " Did not qualify");
                                    }

                                }
                                else
                                {
                                    //didnt pass
                                }
                                x++;
                            }
                            //read loop is done!

                            //check if there are no results
                            if (daOne[0] == -10)
                            {
                                //no results
                                error.Text = "*No results";
                                error.Visible = true;
                            }
                            else
                            {
                                //there were results
                                //now create report not closing read file cuz we still need to read and write
                                //create temp file
                                Excel.Application startup = new Excel.Application();
                                startup.Visible = false;
                                startup.DisplayAlerts = false;
                                Excel.Workbooks startWorkbooks;
                                Excel.Workbook startWorkbook;
                                Excel.Worksheet startWorksheet;
                                object misValue2 = System.Reflection.Missing.Value;
                                startWorkbooks = startup.Workbooks;
                                startWorkbook = startup.Workbooks.Add(misValue2);
                                startWorksheet = (Excel.Worksheet)startWorkbook.ActiveSheet;
                                startWorksheet.Name = "FBLA Report";
                                //write to that temp file
                                string[] alpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
                                int daNumber = daOne.Length;
                                Console.WriteLine("The length of daONe.length is " + daNumber);
                                int nRow = 1;
                                int cd = 0;
                                
                                int readRow = -1;
                                for (int bb = 0; bb < daNumber; bb++)
                                {
                                    if (nRow == 1)
                                    {
                                        bb = 0;
                                    }
                                    cd = 0;
                                    readRow = daOne[bb];
                                    Console.WriteLine(readRow.ToString());
                                    if (readRow != 0)
                                    {
                                        Console.WriteLine("Another one");
                                        Console.WriteLine(readRow.ToString());
                                        if (a == true)
                                        {
                                            if (nRow == 1) { startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "MemberNumber"; cd++; }
                                            else
                                            {
                                                Console.WriteLine("Done Deal a == true");
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("A" + readRow, misValue).Formula.ToString();
                                                cd++;
                                            }
                                        }
                                        if (b == true)
                                        {
                                            if (nRow == 1) { startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "First"; cd++; }
                                            else
                                            {
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("B" + readRow, misValue).Formula.ToString();
                                                cd++;
                                            }
                                        }
                                        if (c == true)
                                        {
                                            if (nRow == 1) { startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "Last"; cd++; }
                                            else
                                            {
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("C" + readRow, misValue).Formula.ToString();
                                                cd++;
                                            }
                                        }
                                        if (d == true)
                                        {
                                            if (nRow == 1) { startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "School"; cd++; }
                                            else
                                            {
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("D" + readRow, misValue).Formula.ToString();
                                                cd++;
                                            }
                                        }
                                        if (el == true)
                                        {
                                            if (nRow == 1) { startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "Grade"; cd++; }
                                            else
                                            {
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("E" + readRow, misValue).Formula.ToString();
                                                cd++;
                                            }
                                        }
                                        if (f == true)
                                        {
                                            if (nRow == 1) { startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "State"; cd++; }
                                            else
                                            {
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("F" + readRow, misValue).Formula.ToString();
                                                cd++;
                                            }
                                        }
                                        if (g == true)
                                        {
                                            if (nRow == 1) { startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "Email"; cd++; }
                                            else
                                            {
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("G" + readRow, misValue).Formula.ToString();
                                                cd++;
                                            }
                                        }
                                        if (h == true)
                                        {
                                            if (nRow == 1) { startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "Year Joined"; cd++; }
                                            else
                                            {
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("H" + readRow, misValue).Formula.ToString();
                                                cd++;
                                            }
                                        }
                                      if (i == true)
                                        {
                                            if (nRow == 1)
                                            {
                                                startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "Active?";
                                            }
                                            else
                                            {
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("I" + readRow, misValue).Formula.ToString();

                                            }
                                            cd++;
                                        }
                                        
                                       if (j == true)
                                        {
                                            if (nRow == 1)
                                            {
                                                startWorksheet.get_Range(alpha[cd] + 1, misValue2).Formula = "Money Owed";

                                            }
                                            else
                                            {
                                                startWorksheet.get_Range(alpha[cd] + nRow, misValue2).Formula = myExcelWorksheet2.get_Range("J" + readRow, misValue).Formula.ToString();
                                                cd++;
                                            }
                                        }


                                        if (nRow == 1) {
                                            
                                            cd = 0;
                                        }
                                        
                                        nRow++;
                                    }
                                    else
                                    {
                                        //dont add this one
                                    }
                                }
                                Console.WriteLine("done writing");
                                //done writing now to view save print based on user standards and close everything out
                                //close reading stream
                                myExcelWorkbook2.Close();
                                myExcelApp2.Quit();
                                Console.WriteLine("done closing and quitting excelapp2 and worksheet2");
                                //format width autofit
                                
                                Excel.Range excelCells = (Excel.Range)startWorksheet.UsedRange;
                                excelCells.Columns.AutoFit();
                               excelCells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                error.Visible = false;
                                //save?
                                if (l == true)
                                {
                                    startup.Visible = true;
                                    startup.DisplayAlerts = true;
                                    startup.UserControl = true;
                                    try
                                    {
                                        startWorkbook.SaveCopyAs(misValue);
                                    }
                                    catch
                                    {
                                        //whatever big deal
                                    }
                                }

                                //print?
                                if (m == true)
                                {
                                    startup.Visible = true;
                                    startup.DisplayAlerts = true;
                                    try
                                    {
                                        startWorksheet.PrintPreview();
                                        //don't do .printoutEx() bad dont do
                                    }
                                    catch
                                    {
                                        //whatever big deal
                                    }
                                }

                                //view?
                                if (k == true)
                                {
                                    startup.Visible = true;
                                }
                                //do not quit written file for it is in eyes of user

                                home backHome = new home();
                                backHome.Show();
                                Close();


                            }

                        }
                    }
                    else
                    {
                        //something must be selected
                        error.Text = "*At least view or print must be selected";
                        error.Visible = true;
                    }
                }
                else {
                    error.Text = "*Combo boxes cannot remain empty";
                    error.Visible = true;
                }

                }
                else
                {
                    error.Text = "*Combo boxes cannot remain null";
                    error.Visible = true;
                    proceed = false;
                }

             
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //reset button
            button25.BackColor = normalcola;
            a = false;
            button24.BackColor = normalcola;
            b = false;
            button23.BackColor = normalcola;
            c = false;
            button22.BackColor = normalcola;
            d = false;
            button21.BackColor = normalcola;
            el = false;
            button20.BackColor = normalcola;
            f = false;
            button19.BackColor = normalcola;
            g = false;
            button18.BackColor = normalcola;
            h = false;
            button8.BackColor = normalcola;
            i = false;
            button9.BackColor = normalcola;
            j = false;
            button4.BackColor = normalcola;
            k = false;
            button6.BackColor = normalcola;
            m = false;
            
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = cola;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = normalcola;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (k == false)
            {
                button4.BackColor = sl;
                k = true;
            }
            else if (k == true)
            {
                button4.BackColor = normalcola;
                k = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (l == false)
            {
                button5.BackColor = sl;
               l = true;
            }
            else if (l == true)
            {
                button5.BackColor = normalcola;
                l = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (m == false)
            {
                button6.BackColor = sl;
                m = true;
            }
            else if (m == true)
            {
                button6.BackColor = normalcola;
                m = false;
            }
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            if (i == false) { button8.BackColor = cola; }
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            if (i == false) { button8.BackColor = normalcola; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (i == false)
            {
                button8.BackColor = sl;
                i = true;
            }
            else if (i == true)
            {
                button8.BackColor = normalcola;
                i = false;
            }
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            if (j == false) { button9.BackColor = cola; }
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            if (j == false) { button9.BackColor = normalcola; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (j == false)
            {
                button9.BackColor = sl;
                j = true;
            }
            else if (j == true)
            {
                button9.BackColor = normalcola;
                j = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //this school only
            if (checkBox1.Checked == true)
            {
                t1.Enabled = true;
            }
            else
            {
                t1.Text = null;
                t1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                t2.Enabled = true;
            }
            else
            {
                t2.Text = null;
                t2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                t3.Enabled = true;
            }
            else
            {
                t3.Text = null;
                t3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void button15_Click(object sender, EventArgs e)
        {
            /*
            //owes money box
            if (j == "false")
            {
                money.Text = "Owes Money";
                button15.BackColor = sl;
                j = "true";
            }
            else if (j == "true")
            {
                money.Text = "Does Not Owe Money";
                button15.BackColor = s2;
                j = "none";
            }
            else if (j == "none")
            {
                money.Text = "N.D Money";
                button15.BackColor = normalcola;
                j = "false";
            }
            */

        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            if (f == false) { button20.BackColor = normalcola; }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //back button
            //slide back
        
            int lx = groupBox1.Location.X;
            int ly = groupBox1.Location.Y;
            int lx2 = groupBox2.Location.X;
            int ly2 = groupBox2.Location.Y;
            double nSize = viewreport.ActiveForm.Size.Height;
            int nSize2 = viewreport.ActiveForm.Size.Width;
            nSize = nSize - 240;
            ly = ly + 200;
            ly2 = ly2 + 200;
            //make it slide
            double ss2 = 240;
            int lX = Location.X;
            int lY = Location.Y;
            Location = new Point(lX, lY + 150);
            groupBox1.Location = new Point(lx, (int)(ly));
            groupBox2.Location = new Point(lx2, (int)(ly2));
            viewreport.ActiveForm.Size = new Size(nSize2, (int)(nSize));
            changeLable.Text = "View Report";


        }





        private void button15_MouseHover(object sender, EventArgs e)
        {
            //if (j == "false") { button15.BackColor = cola; }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            if (k == false) { button4.BackColor = cola; }
        }


        private void button15_MouseLeave(object sender, EventArgs e)
        {
           //  0    if (j == "false") { button15.BackColor = normalcola; }
        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            if (g == false) { button19.BackColor = cola; }
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            if (g == false) { button19.BackColor = normalcola; }
        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
            if (h == false) { button18.BackColor = cola; }
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            if (h == false) { button18.BackColor = normalcola; }
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            button17.BackColor = cola;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = normalcola;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //student id
            if (a == false)
            {
                button25.BackColor = sl;
                a = true;
            }
            else if (a == true)
            {
                button25.BackColor = normalcola;
                a = false;
            }

        }
    }
    }
    

