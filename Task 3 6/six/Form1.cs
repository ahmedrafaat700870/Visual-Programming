using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace six
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lenght = textBox1.Text;
            String f = creatArr(lenght, check(lenght, 200));
            if (f == "Error")
            {
                MessageBox.Show("You Can Not Enter mor than 200");
            }
            else
            {
                show.Text = f;
            }
        }
        bool check(string n , int length)
        {
            if (Convert.ToInt32(n) > length || n.Equals(null) || n.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }

        String creatArr(string length , bool done)
        {
            Random n = new Random();
            int a;
            String m = "";
            if (done)
            {
                String[] arr = new string[Convert.ToInt16(length)];
                for (int i = 0; i < Convert.ToInt16(length); i++)
                {
                    a = n.Next(20);
                    if (i % 45 != 0 || i == 0)
                    {
                        m = m + "  " + Convert.ToString(a);
                    }
                    else
                    {
                        m = m + "\n" + Convert.ToString(a);
                    }
                }
                return m;
            }
            else
            {
                return "Error";
            }
          
        }
    }
}
