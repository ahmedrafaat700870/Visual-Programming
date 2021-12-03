using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_4
{
    
    public partial class Form1 : Form
    {
        char opr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opr = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opr = '/';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opr = '+';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opr = '-';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(firstNum.Text);
            int second = Convert.ToInt32(secondNum.Text);
            int resalt = res(first, second,opr);
            show.Text = firstNum.Text+" " + Convert.ToString(opr)+" " + secondNum.Text +" = " +Convert.ToString(resalt) ;
        }
        int res(int fir , int last , char op)
        {
            if (op == '+')
            {
                return fir + last;
            } else if (op == '-')
            {
                return fir - last;
            } else if (op == '/')
            {
                return fir / last;
            } else if (op == '*')
            {
                return fir * last;
            } else
            {
                return 0;
            }
        }
    }
}
