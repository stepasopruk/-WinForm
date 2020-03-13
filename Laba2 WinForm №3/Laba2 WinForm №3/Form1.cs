using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_WinForm__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            r = 1;
            if (textBox1.Text == "")
                label1.Text = "Введите значение заного ";
            else
            {


                if (((x >= 0 && y >= x) && (r * r >= y * y + x * x)) || (x <= 0 && y <= x && y <= x && r * r >= x * x + y * y))
                    label1.Text = "Входит в закрашенную область ";
                else
                    label1.Text = "Не входит в закрашенную область ";

            }



        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }


    }
}
