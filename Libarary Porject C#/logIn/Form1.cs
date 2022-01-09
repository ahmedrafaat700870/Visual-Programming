using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace logIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // create object from user_main class 
        user_main formUser = new user_main();
        // create object from Admain_Form class 
        Admain_Form admain  = new Admain_Form();
        Regester regester = new Regester();
        User_Not_Active not_Active = new User_Not_Active();
        // Small Data User User Name / User Password / User Type(admain or user) / user_id 
        string [,] dataLogIn = new string[,] {
            {"0","ahmed","123","1","Active"},
            {"1","ali","123","2","0"}, 
            {"2","mohamed","123","1","Not Active"}
        };
        public static string user_name ;
        public static string user_password;
        public static string user_id;
        private void button1_Click(object sender, EventArgs e)
        {
            user_name = textBox1.Text;
            user_password = textBox2.Text;
            for (int i = 0; i < 3; i++)
            {
                if (user_name.Equals(dataLogIn[i, 1]) && user_password.Equals(dataLogIn[i, 2]))
                {
                    user_id = dataLogIn[i, 0];
                    if (dataLogIn[i,3].Equals("1")) // then he/she user.
                    {
                        // go to form Users . 
                        if (dataLogIn[i,4].Equals("Active"))
                        {
                            formUser.Show();
                        }
                        else
                        {
                            not_Active.Show();
                        }
                        //this.Close();
                    }
                    else // then he/she admain.
                    {
                        admain.Show();
                        // go to form admain . 
                    }
                }
            }
               
        }
        private void label4_Click(object sender, EventArgs e)
        {
            regester.Show();
        }
    }
}
