using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int calc_Year = 0;
        int calc_Month = 0;
        int calc_Week = 0;
        int calc_Day = 0;
        int calc_Hour = 0;
        int calc_Menit = 0;
        int Sumtion (int a , int b , int c , int d , int e , int f)
        {
            return a + b + c + d + e + f;
        }
        private void Month_KeyUp(object sender, KeyEventArgs e)
        {
            string[] month = new string[]
            {
                "Month",
                Month.Text
            };
            calc_Month = calc(month);
            Resalut.Text = Convert.ToString(Sumtion(calc_Year, calc_Month, calc_Week, calc_Day, calc_Hour, calc_Menit)) + " Seconds";
        }
        private void Year_KeyUp(object sender, KeyEventArgs e)
        {
            string[] year = new string[] { "Year", Year.Text };
            calc_Year = calc(year);
            Resalut.Text = Convert.ToString(Sumtion(calc_Year, calc_Month, calc_Week, calc_Day, calc_Hour, calc_Menit)) + " Seconds";
        }
        private void Week_KeyUp(object sender, KeyEventArgs e)
        {
            string[] week = new string[]
            {
                "Week",
                Week.Text
            };
            calc_Week = calc(week);
            Resalut.Text = Convert.ToString(Sumtion(calc_Year, calc_Month, calc_Week, calc_Day, calc_Hour, calc_Menit)) + " Seconds";
        }
        private void Day_KeyUp(object sender, KeyEventArgs e)
        {
            string[] day = new string[]
         {
                "Day" ,
                Day.Text
         };
            calc_Day = calc(day);
            Resalut.Text = Convert.ToString(Sumtion(calc_Year, calc_Month, calc_Week, calc_Day, calc_Hour, calc_Menit)) + " Seconds";
        }
        private void Hour_KeyUp(object sender, KeyEventArgs e)
        {
            string[] hour = new string[]
            {
                "Hour" ,
                Hour.Text
            };
            calc_Hour = calc(hour);
            Resalut.Text = Convert.ToString(Sumtion(calc_Year, calc_Month, calc_Week, calc_Day, calc_Hour, calc_Menit))+ " Seconds";
        }
        private void Menit_KeyUp(object sender, KeyEventArgs e)
        {
            string[] menit = new string[]
            {
                "Menit",
                Menit.Text
            };
            calc_Menit = calc(menit);
            Resalut.Text = Convert.ToString(Sumtion(calc_Year, calc_Month, calc_Week, calc_Day, calc_Hour, calc_Menit)) + " Seconds";
        }
        int calc(string[] info)
        {
            int a = 0;
            try
            {
                if (info[0] == "Year")
                {
                    a = Convert.ToInt32(info[1]) * 365 * 24 * 60 * 60;
                }
                else if (info[0] == "Month")
                {
                    a = Convert.ToInt32(info[1]) * 30 * 24 * 60 * 60;
                }
                else if (info[0] == "Week")
                {
                    a = Convert.ToInt32(info[1]) * 7 * 24 * 60 * 60;
                }
                else if (info[0] == "Day")
                {
                    a = Convert.ToInt32(info[1]) * 24 * 60 * 60;
                }
                else if (info[0] == "Hour")
                {
                    a = Convert.ToInt32(info[1]) * 60 * 60;
                }
                else if (info[0] == "Menit")
                {
                    a = Convert.ToInt32(info[1]) * 60;
                }
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine(e);
            }
            return a;
        }   
    }
}
