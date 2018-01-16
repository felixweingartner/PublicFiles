using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class home : Form
    {
        System.Drawing.Color cola = Color.SkyBlue;
        System.Drawing.Color normalcola = Color.SteelBlue;
        public home()
        {
            InitializeComponent();
        }
        private void settings_mousehover(object sender, EventArgs e)
        {
          
            button3.BackColor = cola;

        }
        private void edit_MouseHover(object sender, EventArgs e)
        {
          
            button2.BackColor = cola;
        }
        private void add_MouseHover(object sender, EventArgs e)
        {
          
            
            button1.BackColor = cola;
           
        }
        private void report_MouseHover(object sender, EventArgs e)
        {
            
            button4.BackColor = cola;
        }

        private void add_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = normalcola;
        }

        private void edit_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = normalcola;
        }

        private void settings_mouseleave(object sender, EventArgs e)
        {
            button3.BackColor = normalcola;
        }

        private void report_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = normalcola;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addstudent add = new addstudent();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //edit student button clicked
            editstudent es = new editstudent();
            es.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //view report clicked
            viewreport vr = new viewreport();
            vr.Show();
            Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.BackColor = cola;
            exit.ForeColor = Color.RoyalBlue;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackColor = normalcola;
            exit.ForeColor = Color.Silver;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            help newhelp = new help();
            newhelp.Show();
        }
    }
}
