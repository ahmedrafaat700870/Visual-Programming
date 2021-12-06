using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenratePassword
{
    public partial class Form1 : Form
    {
        static int Size;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Size = Convert.ToInt32(textBox1.Text);
            if (checkBox1.Checked)
            {
                // leter and number .
                
                if (LowerCase.Checked)
                {
                    // Letter Lower Case and Numbers .
                    label2.Text = GenrateThePassWord(Size, "No", "Yes",Charcter);
                } else
                {
                    // Leter upper Case and Numbers .
                    label2.Text = GenrateThePassWord(Size, "Yes", "Yes", Charcter);
                }
            } else
            {
                // genrate Number .
                label2.Text = GenrateThePassWord(Size, "No", "No", Charcter);
            }
        }
        public static Random Charcter = new Random();
        public static string GenrateThePassWord(int Size,string upperCase ,string Letter,Random num)
        {
            string[] pass = new string[Size];
            string lastPass = "";
            int b = num.Next(0, 3);
            if (Letter.Equals("No"))
            {
                // genrate Number.
                for (int i = 0; i < pass.Length; i++)
                {
                    
                    pass[i] = Convert.ToString(getrateNum(Charcter));
                }
            } else if (upperCase.Equals("No"))
            { // genrate Numbers And Lerter LowerCase .
                for (int i = 0; i < Size; i++)
                {
                    if (b == 0)
                    {
                        //genrate Number .
                        pass[i] = Convert.ToString(getrateNum(Charcter));
                        b = num.Next(0, 2);
                    }
                    else
                    {
                        //genrate Char .
                        pass[i] = Convert.ToString(Charcters(Charcter));
                        b = num.Next(0, 2);
                    }
                }
            } else
            { // genrate Number and Letter upperCase .
                for (int i = 0; i < Size; i++)
                {
                    if (b == 0)
                    {
                        //genrate Number .
                        pass[i] = Convert.ToString(getrateNum(Charcter));
                        b = num.Next(0, 2);
                    }
                    else
                    {
                        //genrate Char .
                        pass[i] = Convert.ToString(Charcters(Charcter)).ToUpper();
                        b = num.Next(0, 2);
                    }
                }
            }
            for (int i = 0; i< pass.Length; i++)
            {
                lastPass += pass[i];
            }
            return lastPass;
            
        }
        public static int getrateNum(Random num)
        {
            int Number = num.Next(0, 10);
            return Number;
        }
        public static char Charcters (Random c)
        {
            char charcter = (char) ('a' + c.Next(0, 26));
            return charcter;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = true;   
        }
    }
}
