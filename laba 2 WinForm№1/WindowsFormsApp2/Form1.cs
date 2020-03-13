using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a;

            a = Convert.ToInt32(int.Parse(textBox1.Text));
            if (textBox1.Text == "")
                label1.Text = "Введите значение";
            else
            {
                if (a % 10 == 1) label1.Text = a + " рубль";

                
                if (a % 10 >= 2 && a % 10 <= 4) label1.Text = a + " рубля";

                
                if ((a % 100 >= 10 & a % 100 <= 20) || (a % 10 >= 5 && a % 10 <= 9) || (a % 10 == 0)) label1.Text = a + " рублей";

                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}