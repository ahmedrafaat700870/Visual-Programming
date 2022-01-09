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
    public partial class Admain_Form : Form
    {
        public Admain_Form()
        {
            InitializeComponent();
        }
        public ArrayList serial = new ArrayList();

        // for Examibel (users Requestes is ) array from data {user Name , phone , email , 
        // dataBase .
        // lets say this tabel name = users .
        int counter = 0;
        string [,] users  = new string [,] {
            {"0" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","0" },// .... complet data
            {"1" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","0"}, 
            {"2" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","1"},
            {"3" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","1"},
            {"4" , "ahmed rafaat", "rafaatahmed380@gmail.com", "01287580904","2"}
        };
        string[,] users_BoocksReaded = new string[,] {
            {"0" , "0"},// .... {user_id , Boock_Id }
            {"0" , "1"}, 
            {"2" , "1"},
            {"1" , "0"},
            {"1" , "3"}
        };
        // lets say this tabel name = users .
        string[,] Boocks = new string[,] {
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

        // *******************************************************    Start Events    *****************************************************************// 
        // strart User Events.
        // 1. show  . 
        string info;
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("UserShowHeader", 330, 10, "Show Users"));
            for (int i = 0; i < 5; i++)
            {
                if (users[i, 4] == "1") // Mening the Boock is PDF .
                {
                    info = count + "    name :     " + users[i, 1] + "     gamil :     " + users[i, 2] + "     Phone :   " + users[i, 3];
                    panel1.Controls.Add(GlolbalShowData("user" + i, 100, 100 + counter, info));
                    count++;
                }
                
            }
        }
        // 2. Add .
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("UserAddHeader", 330, 10, "Add New User"));
            for (int i = 0; i < 5; i++)
            {
                if (users[i, 4] == "0")
                {
                    info = count + "    name :     " + users[i, 1] + "     gamil     " + users[i, 2] + "     Phone    " + users[i, 3];
                    panel1.Controls.Add(GlolbalShowData("user" + i, 100, 100 + counter, info));
                    panel1.Controls.Add(AddButtonAddUser("ButtonAdd" + i, 100, 100 + counter, "Add", i));
                    panel1.Controls.Add(RemoveButtonAddUser("buttonReomve" + i, 670, 100+ counter,"Remove" , i));
                    count++;
                }
            }
        }
        // 3. Remove .
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("UserRemoveHeader", 330, 10, "Remove Old User"));
            for (int i = 0; i < 5; i++)
            {
                if (users[i, 4] == "1")
                {
                    info = count + "    name :     " + users[i, 1] + "     gamil     " + users[i, 2] + "     Phone    " + users[i, 3];
                    panel1.Controls.Add(GlolbalShowData("user" + i, 100, 100 + counter, info));
                    panel1.Controls.Add(RemoveOldUser("btnReomve" + i, 670, 100 + counter, "Remove", i));
                    count++;
                }
            }
        }
        // End User Event .
        
        // Strart Boock Events .
        // 1. Add .
        // 1.0 Add PDF .
        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("BoockAddBdf", 330, 10, "Add New Boock PDF"));
            for (int i = 1; i < 7; i++)
            {
                if (i == 6) // index type =>  PDF 
                {
                    break;
                }
                else 
                {
                    panel1.Controls.Add(GlobalTextBox("textAddPdf" + i, 400, 100+ counter ,""));
                    panel1.Controls.Add(GlolbalShowData("Show" + i, 250, 100 + counter, count + ". " + name[i]));
                    count++;
                }
            }
            panel1.Controls.Add(AddPDF("btnAdd", 820, 350, "Add"));
        } 
        // 1.1 Add  Normal .
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("BoockAddnormal", 330, 10, "Add New Boock Normal"));
            for (int i = 1; i < 7; i++)
            {
                if (i == 6)
                {
                    break;
                }
                else
                {
                    panel1.Controls.Add(GlobalTextBox("textNormalAdd" + i, 400, 100 + counter , ""));
                    panel1.Controls.Add(GlolbalShowData("Show" + i, 250, 100 + counter, count + ". " + name[i]));
                    count++;
                }
            }
            panel1.Controls.Add(AddNormal("btnAdd", 820, 350, "Add"));
        } 
        // 1.2 Add Boock naraml && PDF .
        private void pDFNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("BoockAddnormal&PDF", 330, 10, "Add New Boock Normal && PDF"));
            for (int i = 1; i < 7; i++)
            {
                if (i == 6)
                {
                    break;
                }
                else
                {
                    panel1.Controls.Add(GlobalTextBox("textAllAdd" + i, 400, 100 + counter, ""));
                    panel1.Controls.Add(GlolbalShowData("Show" + i, 250, 100 + counter, count + ". " + name[i]));
                    count++;
                }
            }
            panel1.Controls.Add(AddAll("btnAdd", 820, 350, "Add"));
        } 
        // 2. Remove Boock .
        private void removeBoockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            counter = 0;
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("RemoveBoock", 330, 10, "Remove Boock"));
            for (int i = 0; i < 5; i++)
            {
                    info = count + " -   Boock Name    " + Boocks[i, 1] + "    Author Name   " + Boocks[i, 2] + "   Serial    " + Boocks[i, 3] + "    nobza     " + Boocks[i, 4] + "    Section   " + Boocks[i, 5];
                    panel1.Controls.Add(GlolbalShowData("Boock" + i, 100, 100 + counter, info));
                    panel1.Controls.Add(RemoveBoock("btnReomve" + i, 100, 100 + counter, "Remove", i));
                    count++;
            }
        }
        // 3. Update Boock
        private void upDateBoockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("RemoveBoock", 330, 10, "Remove Boock"));
            for (int i = 0; i < 5; i++)
            {
                info = count + " -   Boock Name    " + Boocks[i, 1] + "    Author Name   " + Boocks[i, 2] + "   Serial    " + Boocks[i, 3] + "    nobza     " + Boocks[i, 4] + "    Section   " + Boocks[i, 5];
                panel1.Controls.Add(GlolbalShowData("Boock" + i, 100, 100 + counter, info));
                panel1.Controls.Add(updateBoock("btnUpdate" + i, 100, 100 + counter, "Update", i));
                count++;
            }
        }
        // 4. show Boock 
        // 4.1 Show Boock PDF
        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("showBoockPDF", 330, 10, "Show Boocks PDF"));
            for (int i = 0; i < 5; i++)
            {
                if (Boocks[i, 6] == "pdf")
                {
                    info = count + " -   Boock Name    " + Boocks[i, 1] + "    Author Name   " + Boocks[i, 2] + "   Serial    " + Boocks[i, 3] + "    nobza     " + Boocks[i, 4] + "    Section   " + Boocks[i, 5];
                    panel1.Controls.Add(GlolbalShowData("Boock" + i, 20, 100 + counter, info));
                    count++;
                }
            }
        }
        // 4.2 Show Boock normal
        private void pDFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("showBoockNormal", 330, 10, "Show Boocks Normal"));
            for (int i = 0; i < 5; i++)
            {
                if (Boocks[i, 6] == "normal")
                {
                    info = count + " -   Boock Name    " + Boocks[i, 1] + "    Author Name   " + Boocks[i, 2] + "   Serial    " + Boocks[i, 3] + "    nobza     " + Boocks[i, 4] + "    Section   " + Boocks[i, 5];
                    panel1.Controls.Add(GlolbalShowData("Boock" + i, 20, 100 + counter, info));
                    count++;
                }
            }
        }
        // 4.3 Show Boock normal and Pdf 
        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("showBoockNormal", 330, 10, "Show Boocks PDF & Normal"));
            for (int i = 0; i < 5; i++)
            {
                if (Boocks[i, 6] == "all")
                {
                    info = count + " -   Boock Name    " + Boocks[i, 1] + "    Author Name   " + Boocks[i, 2] + "   Serial    " + Boocks[i, 3] + "    nobza     " + Boocks[i, 4] + "    Section   " + Boocks[i, 5];
                    panel1.Controls.Add(GlolbalShowData("Boock" + i, 20, 100 + counter, info));
                    count++;
                }
            }
        }
        // 5.Section Setting .
        // 5.1 Add Boock To Section .
        private void addBoockToSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            counter = 0;
            ComboBox AddBoockcobo = GlobelComboBox("combo1", 500, 100);
            ListBox AddBoockList = GloblaListBox("ListBock1", 200, 100);
            Button button = GlobalButton("Add", 800, 340);
            // header .
            panel1.Controls.Add(GlobalHeaderLabel("AddBoockToSection", 330, 10, "Add Boock To Section"));
            panel1.Controls.Add(AddBoockList);
            panel1.Controls.Add(AddBoockcobo);
            panel1.Controls.Add(button);


            for (int i = 0; i < 5; i++)
            {
                if (Boocks[i, 5] == "No Section")
                {
                    AddBoockList.Items.Add("Boock Name " + Boocks[i, 1] + " Boock Serial " + Boocks[i, 3]);
                }
            }
            for (int i = 0; i < sectionName.Length; i++)
            {
                AddBoockcobo.Items.Add(sectionName[i]);
            }
            button.Click += (s, ev) =>
            {
                string[] serial = Serial(AddBoockList.SelectedItems);
                string section = AddBoockcobo.SelectedItem.ToString();
                for (int i = 0; i < serial.Length; i++)
                {
                    if (serial[i] == null && serial[i] == "")
                    {
                        MessageBox.Show("please Selct Boock");
                    }
                    else
                    {
                        if (section == null && section == "")
                        {
                            MessageBox.Show("please Selct Section");
                        }
                        else
                        {
                            MessageBox.Show(section);
                            MessageBox.Show(serial[i]);
                        }
                    }
                }
            };
        }
        // 5.2 Remove Boock From Section .
        private void removeBoockFromSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            panel1.Controls.Clear();
            panel1.Controls.Add(GlobalHeaderLabel("ReomveBoockToSection", 330, 10, "Remove Boock To Section"));
            ListBox list;
            Label l ;
            Button b;
            int n  = 0;
            int x = 0;
            int y= 0;
            for (int i = 0; i < sectionName.Length; i++)
            {
                if (n == 2)
                {
                    n = 0;
                    x = 0;
                    y += 350;
                }
                l = GlolbalShowData("header" + i, 20+ x , 100+ y, sectionName[i]);
                panel1.Controls.Add(l);
                list = GloblaListBox("remove" + i, 20 + x, 150 + y);
                panel1.Controls.Add(list);
                panel1.Controls.Add(RemoveBoockFromSection("remove" + i, 20+ x, 400+ y, "Remove", list));
                for (int j = 0; j < 3; j++)
                {
                    list.Items.Add("Name Boock : " + ai[i,2] + " Serial of Boock " + ai[i, 1]);// add serial in ListBox .
                }
                    
                n++;
                x += 350;
            }
        }
        // End Boock Events .




        // Start Section Event .
        // 1. Add Section .
        private void addSectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // first clear Banel . and counter will be Zero .
            counter = 0;
            panel1.Controls.Clear();
            panel1.Controls.Add(GlobalHeaderLabel("ReomveBoockToSection", 330, 10, "Add New Sectoin"));
            // 1. drowing Laber and TextBox .
            panel1.Controls.Add(GlolbalShowData("name", 200, 210, "Enter Name of Secton : "));
            TextBox t = GlobalTextBox("textboxSection", 400, 200,"");
            panel1.Controls.Add(t);
            // 2 . drowing Button .
            panel1.Controls.Add(AddSectionBtn("SectionBtn", 850, 350, "Add" ,t));
        }
        // 2. Remove Section .
        private void removeSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Claer panel1 && Set Counter 0 .
            counter = 0;
            panel1.Controls.Clear();
            // 1. dorw Label Header . 
            panel1.Controls.Add(GlobalHeaderLabel("header", 315, 10, "Romving Section"));
            // 2. dorw ListBox .
            ListBox list = GloblaListBox("listBox1", 300, 100);
            panel1.Controls.Add(list);
            for (int i = 0; i < sectionName.Length; i++)
            {
                // add all itemes in ListBox .
                list.Items.Add(sectionName[i]);
            }
            // 3. dorw Button Remove . 
            panel1.Controls.Add(RemoveSectionButton("button1", 800, 330, "Remove", list));
        }
        // 3. Update Section .
        
        private void updateSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clear panel && counter => 0 . 
            panel1.Controls.Clear();
            counter = 0;
            // 1. create Label Header update .
            panel1.Controls.Add(GlobalHeaderLabel("header", 330, 10, "Update Section"));
            // 2. create ComboX .
            ComboBox updatSectoin = GlobelComboBox("combo", 300, 100);
            panel1.Controls.Add(updatSectoin);
            for (int i = 0; i < sectionName.Length; i++)
            {
                updatSectoin.Items.Add(sectionName[i]);
            }
            updatSectoin.SelectedIndexChanged += (s,ev) =>{
                Label show = GlolbalShowData("show",200,210, "Enter New Name");
                TextBox box = GlobalTextBox("inputText" , 400, 200 ,"");
                Button btn = GlobalButton("Update",820,350);
                panel1.Controls.Add(show);
                panel1.Controls.Add(box);
                panel1.Controls.Add(btn);
                btn.Click += (se,eve) => {
                    string OldSectionName = updatSectoin.SelectedItem.ToString();
                    string NewSectonName = box.Text;
                    if (NewSectonName == "")
                    {
                        MessageBox.Show("Please Enter New Section Name");
                    }
                    else
                    {
                        MessageBox.Show(OldSectionName);
                        MessageBox.Show(NewSectonName);
                    }
                };
            };
       }
        // 4. Show Sectiones.
        
        private void showSectionesToolStripMenuItem_Click(object sender, EventArgs e)
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
                    "ai","senice","programging language"
                };
                ListBox list = GloblaListBox("list", 325 ,150);
                panel1.Controls.Add(list);
                MessageBox.Show(SectionName);
                for (int i = 0; i < data.Length; i++)
                {
                    list.Items.Add(data[i]);
                    MessageBox.Show(data[i]);
                }
                
            };
        }
        // End Section Event .


        // Start Exit Event .
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // End Exit Event .

        // *******************************************************     End Event    *****************************************************************// 






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
            counter += 40;
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
        public TextBox GlobalTextBox(string name, int x, int y , string text)
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

        // Strat User Desgine . 
        // 1. Add User .
        // 1.0 Button Add . 
        public Button AddButtonAddUser(string name, int x, int y, string text , int Index)
        {
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                MessageBox.Show("Add User");
            };
            return b;
        }
        // 1.1 Button Remove .
        public Button RemoveButtonAddUser(string name, int x, int y, string text, int Index)
        {
            counter += 40;
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                MessageBox.Show("Remove User");
            };
            return b;
        }
        // 2. Remove .
        // 2.1 Button Remove .
        public Button RemoveOldUser(string name, int x, int y, string text, int Index)
        {
            counter += 40;
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                MessageBox.Show("Remove User");
            };
            return b;
        }
        // End User Desgine .

        // Strat Boock Desgine .
        // 1. Add . 
        // 1.1 Add PDF .
        public Button AddPDF(string name, int x, int y, string text)
        {
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                MessageBox.Show("Add PDF");
            };
            return b;
        }
        // 1.2 Add Normal .
        public Button AddNormal(string name, int x, int y, string text)
        {
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                MessageBox.Show("Add Normal");
            };
            return b;
        }
        // 1.3 Add Normal & PDF .
        public Button AddAll(string name, int x, int y, string text)
        {
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                MessageBox.Show("Add All");
            };
            return b;
        }
        // 2. Remove .
        // 2.1 Remove Boock Button .
        public Button RemoveBoock(string name, int x, int y, string text, int Index)
        {
            counter += 40;
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                MessageBox.Show("Remove Boock " + Index);
            };
            return b;
        }
        // 3. update
        // 3.1 Update Boock Button .
        public Button updateBoock(string text, int x, int y, string name, int Index)
        {
            counter += 40;
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                // call function update Boock.
                update(Index);
            };
            return b;
        }
        public Button updateBoockDataBase(string text, int x, int y, string name, int Index)
        {
            counter += 40;
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.AutoSize = true;
            b.Font = new Font("Georgia", 16);
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                MessageBox.Show("Updated");
            };
            return b;
        }
        // 4 Sectoin Boock .
        // 4.1 Add Boock To Section .
        // 4.2 Remove Boock From Section .
        // 4.2.1 button Rembove 
        public Button RemoveBoockFromSection(string name, int x, int y, string text, ListBox l)
        {
            counter += 60;
            Button b = new Button();
            b.Padding = new System.Windows.Forms.Padding(10);
            b.BackColor = Color.White;
            b.Name = name;
            b.AutoSize = true;
            b.Text = text;
            b.Location = new Point(x, y);
            b.Click += (s, e) =>
            {
                string[] serial = Serial(l.SelectedItems);
                if (serial.Length != 0)
                {
                    // here update htis boock in data base => Serction => No Section.
                    MessageBox.Show("Remove");
                    for (int i = 0; i < serial.Length; i++)
                    {
                        MessageBox.Show(serial[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Please Selected Itemes from ListBox");
                }
            };
            return b;
        }
        // start Section Desgine .
        // 1. Add New Section .
        // 1.1 Button Add .
        public Button AddSectionBtn(string name, int x, int y, string text, TextBox t)
        {
            Button b = new Button();
            b.Name = name;
            b.Text = text;
            b.Location = new Point(x, y);
            b.Width = 70;
            b.Height = 50;
            b.Padding = new System.Windows.Forms.Padding(10);
            b.Click += (s, e) =>
            {
                if (t.Text == null || t.Text == "")
                {
                    MessageBox.Show("please Enter Secton Name !");
                }
                else
                {
                    // hearing conde SQL 
                    // Add new Section in Data Base 
                    // for Test print Message . 
                    MessageBox.Show("Add");
                }
            };
            return b;
        }
        // 2. Remove Section .
        // 2.1 button Remove .
        public Button RemoveSectionButton(string name, int x, int y, string text, ListBox l)
        {
            Button b = new Button();
            b.Text = text;
            b.Name = name;
            b.ForeColor = Color.Black;
            b.Font = new Font("Georgia", 20);
            b.Location = new Point(x, y);
            b.AutoSize = true;
            b.Click += (s, e) =>
            {
                ListBox.SelectedObjectCollection selected = l.SelectedItems;
                if (selected.Count != 0)
                {
                    // Remove Selected Section from DataBase .
                    // for test print remove .
                    MessageBox.Show("Remove");
                }
                else
                {
                    MessageBox.Show("Please Select Section You Wanted To Rmove it");
                }

            };
            return b;
        }
        // End Section Desgine .

        // ...................................................... Start Function click   ...............................................................//

        // Start Boock 
        // 3. Update Fucntion
        public void update(int index)
        {
            // get Data boock from data base by index . {"0" , "algorizme", "ahmed", "112" , "aaaaaaaaaaa","No Section","pdf" }
            string [] dataBoock = new string [] {"0" , "algorizme", "ahmed", "112" , "aaaaaaaaaaa","pdf","AI" };
            counter = 0;
            panel1.Controls.Clear();
            int count = 1;
            panel1.Controls.Add(GlobalHeaderLabel("update", 330, 10, "Update Boock"));
            for (int j = 1; j < dataBoock.Length; j++)
            {
            panel1.Controls.Add(GlobalTextBox("update" , 400, 100+ counter,dataBoock[j]));
            panel1.Controls.Add(GlolbalShowData("Show" , 250, 100 + counter, count + ". " + name[j]));
            count++;
            }
            panel1.Controls.Add(updateBoockDataBase("buttonUpdate", 750, 350, "Update" , index));
        }


        // ...................................................... End Function click   ...............................................................//


        // *******************************************************    End Desgine    *****************************************************************// 

        

        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& Global Function &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&//
        // 1- fucntion taske object of stringes and return array of stringes (serial number) . 
        public string []Serial(ListBox.SelectedObjectCollection s)
        {
            string [] array = new string[s.Count] ;
            string [] serial = new string[s.Count] ;
            char[] cha; 
            string str;
            for (int i = 0; i < s.Count; i++)
            {
                serial[i] = "";
                str = s[i].ToString();
                cha = str.ToCharArray();
                for (int j = 0; j < str.Length; j++)
                {
                    if (cha[j].Equals('0') || cha[j].Equals('1') || cha[j].Equals('2') || cha[j].Equals('3') || cha[j].Equals('4') || cha[j].Equals('5') || cha[j].Equals('6') || cha[j].Equals('7') || cha[j].Equals('8') || cha[j].Equals('9'))
                    {
                        serial[i] += cha[j];
                    }
                }
            }
            return serial;
        }

        
      
    }
}
