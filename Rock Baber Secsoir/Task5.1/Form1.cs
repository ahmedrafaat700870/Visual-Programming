using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int How_Play = 0;
        static int Score_Player_One = 0;
        static int Score_Player_Tow = 0;
        static string player_one = "";
        static string player_two = "";
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel1.Enabled = true;
            if (checkBox1.Checked)
            {
                this.Rock.Click += (s, ev) =>  Button_Click("rock", "", "Palyer One Win", "Player Tow Win", "Equal");
                this.Baber.Click += (s, ev) => Button_Click("baber", "", "Palyer One Win", "Player Tow Win", "Equal");
                this.Para.Click += (s, ev) => Button_Click("para", "", "Palyer One Win", "Player Tow Win", "Equal");
            } if (checkBox2.Checked)
            {
                this.Rock.Click += (s, ev) => Button_Click("rock", "com", "Palyer One Win", "Computer  Win", "Equal");
                this.Baber.Click += (s, ev) => Button_Click("baber", "com", "Palyer One Win", "Computer Win", "Equal");
                this.Para.Click += (s, ev) => Button_Click("para", "com", "Palyer One Win", "Computer Win", "Equal");
                // paly with Computer .
            }
        }
         private void Button_Click(string choice ,string frindOrCom , string pla_one_win , string pal_tow_win , string equal)
         {
            play(choice, frindOrCom);
            playAgain(how_win(player_one, player_two), pla_one_win, pal_tow_win, equal);
            textBox1.Text = Convert.ToString(Score_Player_One);
            textBox2.Text = Convert.ToString(Score_Player_Tow);
         }
       
        public void play(string str , string p)
        {
            if (How_Play == 0 && !p.Equals("com"))
            {
                player_one = str;
                Form1.How_Play++;
            }
            else if (How_Play == 0 && p.Equals("com"))
            {
                // play with Computer .
                if (Computer_Play().Equals(0))
                {
                    player_one = str;
                    player_two = "rock";
                }
                else if (Computer_Play().Equals(1))
                {
                    player_one = str;
                    player_two = "para";
                }
                else if (Computer_Play().Equals(2))
                {
                    player_one = str;
                    player_two = "baber";
                }
            }
            else 
            {
                // play with Player .
                player_two = str;
                Form1.How_Play--;
            }
        }
        public int how_win (string playerOne , string playerTow)
        {
            if (playerOne.Equals("rock"))
            {
                if (playerTow.Equals("para"))
                {
                    return 0;
                }
                else if (playerTow.Equals("baber"))
                {
                    return 1;
                }
                else if (playerTow.Equals("rock")) 
                {
                    return 2;
                } else
                {
                    return 3;
                }
            } 
            else if (playerOne.Equals("para"))
            {
                if (playerTow.Equals("rock"))
                {
                    return 1;
                } else if (playerTow.Equals("baber"))
                {
                    return 0;
                }
                else if (playerTow.Equals("para"))
                {
                    return 2;
                } else
                {
                    return 3;
                }
            } 
            else if (playerOne.Equals("baber"))
            {
                if (playerTow.Equals("rock"))
                {
                    return 0;
                }
                else if (playerTow.Equals("para"))
                {
                    return 1;
                }
                else if (playerTow.Equals("baber")) 
                {
                    return 2;
                }  else
                {
                    return 3;
                }
            }
            else
            {
                return 3; // palyer one and palyer tow play the same play . 
            }
        }
        public void playAgain (int n , string m1 ,string m2 , string m3)
        {
            DialogResult r;
            if (n == 0 ) // playre one how win .
            {
                Score_Player_One++;
                r = MessageBox.Show(m1 +" if you want to paly again press yes", "The Winner", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    player_one = "";
                    player_two = "";
                } else
                {
                    MessageBox.Show(Winer(Score_Player_One,Score_Player_Tow,m1 ,m2, m3));
                    Score_Player_One = 0;
                    Score_Player_Tow = 0;
                    player_one = "";
                    player_two = "";
                } 
            } else if (n == 1)
            {
                Score_Player_Tow++;
                r = MessageBox.Show(m2+" if you wnat to play again press yes ", "the Winner", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    player_one = "";
                    player_two = "";

                } else
                {
                    MessageBox.Show(Winer(Score_Player_One, Score_Player_Tow, m1, m2, m3));
                    Score_Player_One = 0;
                    Score_Player_Tow = 0;
                    player_one = "";
                    player_two = "";
                }
            } else if (n == 2)
            {
                r = MessageBox.Show(m3 + " if you wnat to play anain press Yes", "Equal", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    player_one = "";
                    player_two = "";
                }
                else
                {
                    MessageBox.Show(Winer(Score_Player_One, Score_Player_Tow, m1, m2, m3));
                    Score_Player_One = 0;
                    Score_Player_Tow = 0;
                    player_one = "";
                    player_two = "";
                }
            }
        }
        public string Winer(int score_one, int Score_tow ,string str,string str2 ,string str3)
        {
            if (score_one > Score_tow)
            {
                return str;
            } else if (score_one < Score_tow)
            {
                return str2;
            } else
            {
                return str3;
            }

        }
        public int Computer_Play ()
        {
            Random n = new Random();
            return n.Next(0, 3);
        }
    }
}
