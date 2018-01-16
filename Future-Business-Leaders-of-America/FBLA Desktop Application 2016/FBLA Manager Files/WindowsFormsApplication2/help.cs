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
namespace WindowsFormsApplication2
{
    public partial class help : Form
    {
        System.Drawing.Color cola = Color.SkyBlue;
        System.Drawing.Color normalcola = Color.SteelBlue;
        public help()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            back.BackColor = cola;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.BackColor = normalcola;
        }
        int gg = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (gg == 1)
            {
                button1.Text = "Confirm";
                gg = 2;

            }
            else {
                //uninstal time
                string path = "C://fblaManager";
                Directory.Delete(path, true);
                Application.Exit();
            }


        }
    }
}
