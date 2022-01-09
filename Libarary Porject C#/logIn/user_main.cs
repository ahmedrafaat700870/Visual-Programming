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
    public partial class user_main : Form 
    {
        public user_main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = Form1.user_name;

        }
        public static int User_id = 0;
        string[,] users = new string[,] {
            {"0" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","Acivate" , "123"},// .... complet data
            {"1" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","Acivate" ,"233"}, 
            {"2" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","Acivate","444"},
            {"3" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","Acivate","555"},
            {"4" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","Not Acivate","666"}
        };
        string [] users_name_table = new string [] {
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
        public static int counter = 0;

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
        // 1. show 
        string info;
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info = "";
            counter = 0;
            string []  data;
            panel1.Controls.Clear();
            panel1.Controls.Add(GlobalHeaderLabel("HeaderShow ", 275, 30,"Show Acount"));
            for (int i = 0; i < 5; i++)
            {
                if (User_id.ToString() == users[i, 0])
                {
                    
                    for (int j = 1; j < 6; j++)
                    {
                        info = users_name_table[j] + " : " + users[i,j] ;
                        panel1.Controls.Add(GlolbalShowData("label" + i, 20, 120+ counter,info));
                        counter += 40;
                    }
                }
            }
        }
        // 2. Update
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
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
                        info = users_name_table[j] + " : " ;
                        panel1.Controls.Add(GlolbalShowData("label" + i, 20, 120 + counter, info));
                        panel1.Controls.Add(GlobalTextBox("textFiled" + i, 200, 120 + counter, users[i, j]));
                        counter += 40;
                    }
                }
            }
            panel1.Controls.Add(b);
            b.Click += (s,ev) =>
            {
                MessageBox.Show("Updated");
            };
        }
        // 3. Exit .
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Event Hendler Boock .
        // 1. Readed .
        private void readedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info = "";
            counter = 0;
            string[] data;
            panel1.Controls.Clear();
            Button b = GlobalButton("Update", 630, 330);
            panel1.Controls.Add(GlobalHeaderLabel("header_Reader", 275, 30, "Readed Boocks"));
            // selct boock readed from dataBase by User_ID .
            string[,] boocks_Readed = new string[,] {
                {"0" , "algorizme", "ahmed", "112" , "aaaaaaaaaaa","No Section","pdf" },// .... complet data
                {"1" , "data starture", "ahmed", "013" , "bbbbbbbbbbbbbbbbbbb","senice","normal" },
                {"2" , "c#", "ahmed", "111" , "cccccccccccccccc","Progrming Language","all" }
            };
            for (int i = 0; i < 3; i++)
            {
               info = name[1] + " : "+ boocks_Readed[i,1] + name[2] + " : " +boocks_Readed[i,2] + name[3] + " : " +boocks_Readed[i,3]  + name[5] + " : "+ boocks_Readed[i,5] + name[6] + " : " +boocks_Readed[i,6];
                panel1.Controls.Add(GlolbalShowData("label" + i, 20, 100 + counter, info));
                counter += 40;
            }
        }
        // 2. Licked
        private void likedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info = "";
            counter = 0;
            string[] data;
            panel1.Controls.Clear();
            Button b = GlobalButton("Update", 630, 330);
            panel1.Controls.Add(GlobalHeaderLabel("header_Reader", 275, 30, "Licked Boocks"));
            // selct boock readed from dataBase by User_ID .
            string[,] Boock_Liked = new string[,] {
                {"0" , "algorizme", "ahmed", "112" , "aaaaaaaaaaa","No Section","pdf" }// .... complet data
            };
            for (int i = 0; i < 1; i++)
            {
                info = name[1] + " : "+ Boock_Liked[i,1] + name[2] + " : " + Boock_Liked[i,2] + name[3] + " : " +Boock_Liked[i,3]  + name[5] + " : "+ Boock_Liked[i,5] + name[6] + " : " +Boock_Liked[i,6];
                panel1.Controls.Add(GlolbalShowData("label" + i, 20, 100 + counter, info));
                counter += 40;
            }
        }
        // 3. Borrowed .
        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info = "";
            counter = 0;
            panel1.Controls.Clear();
            Button b = GlobalButton("Update", 630, 330);
            panel1.Controls.Add(GlobalHeaderLabel("header_Reader", 275, 30, "Brrowed Boocks"));
            // selct boock readed from dataBase by User_ID .
            string[,] Boock_Brrowed = new string[,] {
               {"1" , "data starture", "ahmed", "013" , "bbbbbbbbbb","senice","normal" }// .... complet data
            };
            for (int i = 0; i < 1; i++)
            {
                info = name[1] + " : " + Boock_Brrowed[i, 1] + name[2] + " : " + Boock_Brrowed[i, 2] + name[3] + " : " + Boock_Brrowed[i, 3]  + name[5] + " : " + Boock_Brrowed[i, 5] + name[6] + " : " + Boock_Brrowed[i, 6];
                panel1.Controls.Add(GlolbalShowData("label" + i, 20, 100 + counter, info));
                counter += 40;
            }
        }
        // Event hendler Show .
        // 1. all Boocks
        private void allBoocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info = "";
            counter = 0;
            panel1.Controls.Clear();
            panel1.Controls.Add(GlobalHeaderLabel("header_Reader", 275, 30, "PDF & Normal Boocks"));
            // selct boock readed from dataBase by User_ID .
            
            for (int i = 0; i < 5; i++)
            {
                if (Boocks[i, 6] == "all")
                {
                    info = name[1] + " : " + Boocks[i, 1] + name[2] + " : " + Boocks[i, 2] + name[3] + " : " + Boocks[i, 3] + name[5] + " : " + Boocks[i, 5];
                    panel1.Controls.Add(GlolbalShowData("label" + i, 20, 100 + counter, info));
                    counter += 40;
                }
                
            }
        }
        // 2. pdf
        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info = "";
            counter = 0;
            panel1.Controls.Clear();
            panel1.Controls.Add(GlobalHeaderLabel("header_Reader", 275, 30, "PDF Boocks"));
            // selct boock readed from dataBase by User_ID .

            for (int i = 0; i < 5; i++)
            {
                if (Boocks[i, 6] == "pdf")
                {
                    info = name[1] + " : " + Boocks[i, 1] + name[2] + " : " + Boocks[i, 2] + name[3] + " : " + Boocks[i, 3] + name[5] + " : " + Boocks[i, 5];
                    panel1.Controls.Add(GlolbalShowData("label" + i, 20, 100 + counter, info));
                    counter += 40;
                }

            }
        }
        // 3. Normal
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info = "";
            counter = 0;
            panel1.Controls.Clear();
            panel1.Controls.Add(GlobalHeaderLabel("header_Reader", 275, 30, "Normal Boocks"));
            // selct boock readed from dataBase by User_ID .

            for (int i = 0; i < 5; i++)
            {
                if (Boocks[i, 6] == "normal")
                {
                    info = name[1] + " : " + Boocks[i, 1] + name[2] + " : " + Boocks[i, 2] + name[3] + " : " + Boocks[i, 3] + name[5] + " : " + Boocks[i, 5];
                    panel1.Controls.Add(GlolbalShowData("label" + i, 20, 100 + counter, info));
                    counter += 40;
                }

            }
        }
        // 4. Section .
        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            // 1. create Label Header update .
            panel1.Controls.Add(GlobalHeaderLabel("header", 330, 10, "Show Sectione"));
            ComboBox showSection = GlobelComboBox("combo", 300, 100);
            panel1.Controls.Add(showSection);
            for (int i = 0; i < sectionName.Length; i++)
            {
                showSection.Items.Add(sectionName[i]);
            }
            string SectionName;
            showSection.SelectedIndexChanged += (obj, ev) =>
            {
                // selct data From DataBase by SectionName
                SectionName = showSection.SelectedItem.ToString();
                string[] data = new string[] {
                    "ai","java","c++"
                };
                ListBox list = GloblaListBox("list", 325, 150);
                panel1.Controls.Add(list);
                for (int i = 0; i < data.Length; i++)
                {
                    list.Items.Add(data[i]);
                }

            };
        }


        // Event Hendler Search .
        // Id
        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            // 1. create Label Header update .
            panel1.Controls.Add(GlobalHeaderLabel("header", 280, 10, "Search By Serial"));
            panel1.Controls.Add(GlolbalShowData("show", 40, 100 , "Enter Serial Of Boock"));
            TextBox t = GlobalTextBox("textBox", 250, 100 , "");
            ListBox list = GloblaListBox("list", 270, 150);
            panel1.Controls.Add(t);
            t.KeyUp += (s, ev) =>
            {
                list.Items.Clear();
                panel1.Controls.Add(list);
                ArrayList Book = searchSeial(t.Text.ToString());
                for (int i = 0; i < Book.Count; i++)
                {
                    list.Items.Add(Book[i]);
                }
            };
        }
        // Boock Name 
        private void nameOfBoockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            // 1. create Label Header update .
            panel1.Controls.Add(GlobalHeaderLabel("header", 280, 10, "Search By Name"));
            panel1.Controls.Add(GlolbalShowData("show", 40, 100 , "Enter Name Of Boock"));
            TextBox t = GlobalTextBox("textBox", 250, 100 , "");
            ListBox list = GloblaListBox("list", 270, 150);
            panel1.Controls.Add(t);
            t.KeyUp += (s, ev) =>
            {
                list.Items.Clear();
                panel1.Controls.Add(list);
                ArrayList Book = searchName(t.Text.ToString());
                for (int i = 0; i < Book.Count; i++)
                {
                    list.Items.Add(Book[i]);
                }
            };
        }
        // ********************************** start Global Funciton ************************************//
        // function tack text and return array List Contains all boock containing charcters in this text .
        public static ArrayList searchName (string text ) {
            char[] getText = text.ToCharArray();
            char[] boock;
            ArrayList array = new ArrayList();
            Boolean done;
            if (text != "")
            {
                for (int i = 0; i < 5; i++)
                {
                    done = true;
                    boock = Boocks[i, 1].ToCharArray();
                    for (int j = 0; j < getText.Length; j++)
                    {
                        try
                        {
                            if (getText[j] != boock[j])
                            {
                                done = false;
                            }
                        }
                        catch (Exception e) { }

                    }
                    if (done)
                    {
                        array.Add(Boocks[i, 1]);
                    }

                }
            }
            return array;
        }
        public static ArrayList searchSeial(string text)
        {
            char[] getText = text.ToCharArray();
            char[] boock;
            ArrayList array = new ArrayList();
            Boolean done;
            if (text != "")
            {
                for (int i = 0; i < 5; i++)
                {
                    done = true;
                    boock = Boocks[i, 3].ToCharArray();
                    for (int j = 0; j < getText.Length; j++)
                    {
                        try
                        {
                            if (getText[j] != boock[j])
                            {
                                done = false;
                            }
                        }
                        catch (Exception e) { }

                    }
                    if (done)
                    {
                        array.Add(Boocks[i, 3]);
                    }
                }
            }
            return array;
        }


    }
}
