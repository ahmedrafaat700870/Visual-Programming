using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace logIn
{
    public partial class Regester : Form
    {
        public Regester()
        {
            InitializeComponent();
        }
        string[,] user = new string[,] {
            {"0","ahmed","123","gmail","phone","0"},
            {"1","ali","123","gmail","phone","0"}
        };
        string [] Errors = new string [4];
        Boolean done ;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Errors.Length; i++)
            {
                Errors[i] = null;
            }
            done = false;
            for (int i = 0; i < 2; i++)
            {
                if (user[i, 1] == textBox1.Text)
                {
                    done = true;
                    Errors[0] = "Change User Name" ;
                }
                else if (textBox3.Text == user[i, 3])
                {
                    done = true;
                    Errors[1] ="Change Gmail";
                }
                else if (textBox3.Text == "" || textBox2.Text == "" || textBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    done = true;
                    Errors[2] ="Enter All Feildes";
                }
                else if (textBox4.Text != textBox5.Text)
                {
                    done = true;
                    Errors[3] ="The pass and RePass not Equal";
                }

            }
            if (!done)
            {
                // dataBase Create New user .
                MessageBox.Show("Done");
            }
            else
            {
                for (int i = 0; i < Errors.Length; i++)
                {
                    if (Errors[i] != null)
                    {
                        MessageBox.Show(Errors[i]);
                    }
                }
            }
        }
    }
}
