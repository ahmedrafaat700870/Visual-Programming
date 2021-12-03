using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Char_KeyUp(object sender, KeyEventArgs e)
        {
            String tex = text1.Text;
            string cha = Char.Text;
            if (check(Convert.ToString(cha)))
            {
                char[] arr = ConvertToArry(tex);
                re.Text = "The " + cha + " Repited " + Convert.ToString(CountCharFromText(arr, cha)) + " Times";

            } else
            {
                MessageBox.Show("You Can Not Enter Charcter More Than 1  ");
            }
        } 
        bool check (string t)
        {
            if (t.Length > 1)
            {
                return false;
            }
            return true;
        }
        char [] ConvertToArry(string Text)
        {
                char[] ar = new char[Text.Length];
                for (int i = 0; i < Text.Length; i++)
                {
                    ar[i] = Text[i];
                }
                return ar;
        }
        int CountCharFromText(char[] arr, string c)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Convert.ToString(arr[i]) == c)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
