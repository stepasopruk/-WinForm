using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2_WinForm__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, y = 0;

            if (textBox1.Text == "")
                label1.Text = "Введите значение";
            else
            {
                a = Convert.ToDouble(double.Parse(textBox1.Text));
                if (a <= -6)
                {
                    y = 12.0;
                    label1.Text = "" + y;
                }
                else
                      if (a > -6 && a <= -2)
                {
                    y = 0.5 + 0.25 * a;
                    label1.Text = "" + y;
                }
                else
                        if (a > -2 && a <= 0)
                {
                    y = 2 - Math.Sqrt(4 - (a + 2) * (a + 2));
                    label1.Text = "" + y;
                }
                else
                          if (a > 0 && a <= 2.0)
                {
                    y = Math.Sqrt(4 - a * a);
                    label1.Text = "" + y;
                }
                else
                {
                    y = 2 - a;
                    label1.Text = "" + y;
                }
            }
        }
    }
}
