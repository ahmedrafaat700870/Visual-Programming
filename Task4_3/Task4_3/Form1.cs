using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            string tex = birthDate.Text;
            string[] date_Now = new string[]
            {
                DateTime.Now.Year.ToString(),
                DateTime.Now.Month.ToString(),
                DateTime.Now.Day.ToString()
            };
            string[] birth_Date = Detial_Date(tex);
            string[] age = clac_Age(birth_Date, date_Now);
            Age.Text = "Your Age is : " +age[0] + " Year  and " + age[1] + " Month and "+ age[2] +" Day";
        }
        string [] Detial_Date(string date) // function retrun array contian {year , month , days} from stirng year/month/day.
        {
            string[] Birth_Date ;
            int count = 0;
            string year = "";
            string mon = "";
            string day = "";
            for (int i = 0;i< date.Length; i++)
            {
                if (count == 0)
                {
                    if (date[i] == Convert.ToChar("/"))
                    {
                        count++;
                    } else
                    {
                        year += Convert.ToString(date[i]);
                    }
                } else if (count == 1) {
                    if (date[i] == Convert.ToChar("/"))
                    {
                        count++;
                    }
                    else
                    {
                        mon += Convert.ToString(date[i]);
                    }
                } else
                {
                    day += Convert.ToString(date[i]);
                }
            }
            Birth_Date = new string[3]
            {
                year, mon, day
            };
            return Birth_Date ;
        }
        string [] clac_Age (string [] birth , string [] date_now) // function calc Age .
        {
            int[] new_birth = converttointarry(birth);
            int[] new_Date_Now = converttointarry(date_now);
            int[] age = new int[birth.Length];
            string []new_age = new string [age.Length];
            if (new_birth[0] < new_Date_Now[0])
            {
                age[0] = new_Date_Now[0] - new_birth[0];
            } else
            {
                new_birth[0] += 30;
                new_birth[1] -= 1;
                age[0] = new_Date_Now[0] - new_birth[0];
            }
            if (new_birth[1] < new_Date_Now[1])
            {
                age[1] = new_Date_Now[1] - new_birth[1];
            }
            else
            {
                new_birth[1] += 12;
                new_birth[2] -= 1;
                age[1] = new_Date_Now[1] - new_birth[1];
            }
            age[2] = new_Date_Now[2] - new_birth[2];
            for (int i = 0; i < age.Length; i++)
            {
                new_age[i] = Convert.ToString(age[i]);
            }
            return new_age;
        }
        int [] converttointarry (string[] s) //function return int arr from string arr .
        {
            int[] n = new int[s.Length];
            for (int i = 0; i< s.Length; i++ )
            {
                n[i] = Convert.ToInt32(s[i]);
            }
            return n;
        }
     }
}
