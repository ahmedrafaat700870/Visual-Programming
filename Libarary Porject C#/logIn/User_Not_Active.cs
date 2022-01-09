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
    public partial class User_Not_Active : Form
    {
        public User_Not_Active()
        {
            InitializeComponent();
        }
        int counter = 0;
        public static int User_id = 4;
        string[,] users = new string[,] {
            {"0" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","Acivate" , "123"},// .... complet data
            {"1" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","Acivate" ,"233"}, 
            {"2" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","Acivate","444"},
            {"3" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","Acivate","555"},
            {"4" , "Mohamed Ali", "Meo123@gmail.com", "01287580904","Not Acivate","666"}
        };
        string[] users_name_table = new string[] {
            "" ,"User Name", "Gmail" , "Phone", "Acivate","User PassWord"
        };
        // lets say this tabel name = users .
        public static string[,] Boocks = new string[,] {
            {"0" , "algorizme", "ahmed", "112" , "aaaaaaaaaaa","No Section","pdf" },// .... complet data
            {"1" , "data starture", "ahmed", "013" , "bbbbbbbbbbbbbbbbbbb","senice","normal" },
            {"2" , "c#", "ahmed", "111" , "cccccccccccccccc","Progrming Language","all" },
            {"3" , "C++", "ahmed", "000" , "ddddddddddddddddd","Progrming Language","all" },
            {"4" , "Java", "ahmed", "011" , "fffffffffffffff","Progrming Language","pdf" }
        };
        string[] name = new string[] {
           "","Boock Name", "Author Name","serial","Nobza","type","section"
        };
        // lets say this is table Sectoin . 
        string[,] Sections = new string[,] {
            {"0" , "ai", "0"},// .... complet data
            {"1" , "senice", "1"},
            {"2" , "Progrming Language", "2"},
            {"3" , "Progrming Language", "3"},
            {"4" , "Progrming Language", "4"},
        };
        string[] sectionName = new string[] {
            "ai","senice","programging language"
        };
        // get data ai from database . 
        string[,] ai = new string[,] {
            {"0","123","nameBoock"},
            {"1","133","nameBoock"},
            {"2","443","nameBoock"}
        };
        // *******************************************************    Start Desgine    *****************************************************************// 

        // Strat global Desgine 
        // 1. Header Label .
        public Label GlobalHeaderLabel(string name, int x, int y, string text)
        {
            Label l = new Label();
            l.Text = text;
            l.Name = name;
            l.Location = new Point(x, y);
            l.Padding = new System.Windows.Forms.Padding(10);
            l.AutoSize = true;
            l.BackColor = Color.White;
            l.BorderStyle = BorderStyle.FixedSingle;
            l.Font = new Font("Georgia", 22);
            return l;
        }
        // 2. Label Show Data .
        public Label GlolbalShowData(string name, int x, int y, string text)
        {
            Label l = new Label();
            l.Text = text;
            l.Name = name;
            l.Location = new Point(x, y);
            l.Padding = new System.Windows.Forms.Padding(4);
            l.AutoSize = true;
            l.BackColor = Color.White;
            l.BorderStyle = BorderStyle.FixedSingle;
            l.Font = new Font("Georgia", 12);
            l.ForeColor = System.Drawing.ColorTranslator.FromHtml("#777");
            return l;
        }
        // 3 TextBox .
        public TextBox GlobalTextBox(string name, int x, int y, string text)
        {
            TextBox t = new TextBox();
            t.Name = name;
            t.Text = text;
            t.Font = new Font("Georgia", 16);
            t.Location = new Point(x, y);
            t.Width = 350;
            t.Height = 40;
            t.AutoSize = false;
            return t;
        }
        // 4 ComboBox .
        public ComboBox GlobelComboBox(string name, int x, int y)
        {
            ComboBox c = new ComboBox();
            c.Name = name;
            c.Width = 350;
            c.Height = 200;
            c.AutoSize = false;
            c.Font = new Font("Georgia", 18);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
            c.Location = new Point(x, y);

            // 1. creat TextBox show Data
            //TextBoxInUpdateSectionCombbBox = ComboTextBox("textBox1", 20, 200);
            //panel1.Controls.Add(TextBoxInUpdateSectionCombbBox);
            // 2. create Button Update . 
            // ButtonUpdateSectionCombox = UpdateSectionButton("button", 800, 330, TextBoxInUpdateSectionCombbBox, updatSectoin);
            // panel1.Controls.Add(ButtonUpdateSectionCombox);

            return c;
        }
        // 5 ListBox .
        public ListBox GloblaListBox(string name, int x, int y)
        {
            ListBox l = new ListBox();
            l.Name = name;
            l.Width = 300;
            l.Height = 250;
            l.BackColor = Color.White;
            l.SelectionMode = SelectionMode.MultiSimple;
            l.Font = new Font("Georgia", 12);
            l.Location = new Point(x, y);
            //l.Visible = false;
            return l;
        }
        // 6 Global Button 
        public Button GlobalButton(string text, int x, int y)
        {
            Button b = new Button();
            b.Name = "button";
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            return b;
        }
        // End global Desgine 


        // .............................................. Event Hendler ...........................................//
        // event henler Acount .
        string info;
        private void showToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            info = "";
            counter = 0;
            string[] data;
            panel1.Controls.Clear();
            panel1.Controls.Add(GlobalHeaderLabel("HeaderShow ", 275, 30, "Show Acount"));
            for (int i = 0; i < 5; i++)
            {
                if (User_id.ToString() == users[i, 0])
                {

                    for (int j = 1; j < 6; j++)
                    {
                        info = users_name_table[j] + " : " + users[i, j];
                        panel1.Controls.Add(GlolbalShowData("label" + i, 20, 120 + counter, info));
                        counter += 40;
                    }
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            info = "";
            counter = 0;
            string[] data;
            panel1.Controls.Clear();
            Button b = GlobalButton("Update", 630, 330);
            panel1.Controls.Add(GlobalHeaderLabel("Header Update", 275, 30, "Update Acount"));
            for (int i = 0; i < 5; i++)
            {
                if (User_id.ToString() == users[i, 0])
                {

                    for (int j = 1; j < 6; j++)
                    {
                        info = users_name_table[j] + " : ";
                        panel1.Controls.Add(GlolbalShowData("label" + i, 20, 120 + counter, info));
                        panel1.Controls.Add(GlobalTextBox("textFiled" + i, 200, 120 + counter, users[i, j]));
                        counter += 40;
                    }
                }
            }
            panel1.Controls.Add(b);
            b.Click += (s, ev) =>
            {
                MessageBox.Show("Updated");
            };
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        // Event Hendler Boock .
    }
}
