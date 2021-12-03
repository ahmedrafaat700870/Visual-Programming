using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_form
{
    public partial class Form1 : Form
    {
        int a = 0 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void firstNum_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(t1.Text);
            int num2= Convert.ToInt32(t2.Text);
            int num3 = Convert.ToInt32(t3.Text);
            a = height(num1, num2, num3);
            t4.Text = " Max Numver is : "+ Convert.ToString(a);
        }

        private void t3_TextChanged(object sender, EventArgs e)
        {

        }
        int height(int first, int second, int third)
        {
            int h = 0 ;
            if (first >= second && first >= third)
            {
                h = first;

            }
            else if (second >= first && second >= third)
            {
                h = second;
            }
            else
            {
                h = third;
            }
            return h;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
