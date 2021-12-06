using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class Form1 : Form
    {
        static int play = 1; // by default player one who paly in first .
        static int Player_One_Score = 0;
        static int Player_Two_Score = 0;
        static string[] game = new string [9];
        public Form1()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            play = 1;
            Player_One_Score = 0;
            Player_Two_Score = 0;
            play_again();
            if (frind.Checked)
            {
                // play with frind .
                l1.Click += (s,ev) => click_Button(l1,"frind");
                l2.Click += (s,ev) => click_Button(l2,"frind");
                l3.Click += (s, ev) => click_Button(l3,"frind");
                l4.Click += (s, ev) => click_Button(l4,"frind");
                l5.Click += (s, ev) => click_Button(l5,"frind");
                l6.Click += (s, ev) => click_Button(l6,"frind");
                l7.Click += (s, ev) => click_Button(l7,"frind");
                l8.Click += (s, ev) => click_Button(l8,"frind");
                l9.Click += (s, ev) => click_Button(l9,"frind");
            }
            else
            {
                // play with computer .
                l1.Click += (s, ev) => click_Button(l1, "com");
                l2.Click += (s, ev) => click_Button(l2, "com");
                l3.Click += (s, ev) => click_Button(l3, "com");
                l4.Click += (s, ev) => click_Button(l4, "com");
                l5.Click += (s, ev) => click_Button(l5, "com");
                l6.Click += (s, ev) => click_Button(l6, "com");
                l7.Click += (s, ev) => click_Button(l7, "com");
                l8.Click += (s, ev) => click_Button(l8, "com");
                l9.Click += (s, ev) => click_Button(l9, "com");
            }
        }
        public void click_Button (Label l , string Howplay)
        {
            DialogResult r;
            if (Howplay.Equals("frind"))
            {
                HowPlay(l, "frind");
                string winner = win(game);
                if (winner.Equals("X") || winner.Equals("O"))
                {
                    // then one from tow players win . the game will sotp and we will show how win .and if they wont play angain if not we will show all resault in match. 
                    r = MessageBox.Show(HowWin("frind","X") + "if You want to play agian press Yes", "Winer", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        // Here thay wnat to play again .
                        play_again();
                    }
                    else
                    {
                        MessageBox.Show(Last_Winner("frind"), "Game Over");
                        play_again();
                        Player_One_Score = 0;
                        Player_Two_Score = 0;
                    }

                }
                else if (winner.Equals("equal"))
                {
                    // then player and palyer tow are equals.
                    r = MessageBox.Show(HowWin("frind","X") + "if You want to play agian press Yes", "equal", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        // Here thay wnat to play again .
                        play_again();
                    }
                    else
                    {
                        MessageBox.Show(Last_Winner("frind"), "Game Over");
                        play_again();
                        Player_One_Score = 0;
                        Player_Two_Score = 0;
                    }
                }
                else
                {
                    // the game not Ended and we will nothing .
                }
                Score_One.Text = Convert.ToString(Player_One_Score);
                Score_Tow.Text = Convert.ToString(Player_Two_Score);
            } else // play with Computer .
            {
                HowPlay(l, "com");
                string winner = win(game);
                if (winner.Equals("X") || winner.Equals("O"))
                {
                    // then one from tow players win . the game will sotp and we will show how win .and if they wont play angain if not we will show all resault in match. 
                    r = MessageBox.Show(HowWin("com",winner) + "if You want to play agian press Yes", "Winer", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        // Here thay wnat to play again .
                        play_again();
                        Form1.count = 0;
                    }
                    else
                    {
                        MessageBox.Show(Last_Winner("com"), "Game Over");
                        play_again();
                        Player_One_Score = 0;
                        Player_Two_Score = 0;
                        Form1.count = 0;
                    }

                }
                else if (winner.Equals("equal"))
                {
                    // then player and palyer tow are equals.
                    r = MessageBox.Show(HowWin("com", winner) + "if You want to play agian press Yes", "equal", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        // Here thay wnat to play again .
                        play_again();
                        Form1.count = 0;
                    }
                    else
                    {
                        MessageBox.Show(Last_Winner("com"), "Game Over");
                        play_again();
                        Player_One_Score = 0;
                        Player_Two_Score = 0;
                        Form1.count = 0;
                    }
                }
                else
                {
                    // the game not Ended and we will nothing .
                }
                Score_One.Text = Convert.ToString(Player_One_Score);
                Score_Tow.Text = Convert.ToString(Player_Two_Score);
            }
        }
        public static int count = 0;
        public void HowPlay (Label l ,string whowPlay)
        {
            if (whowPlay == "frind") // play with frind .
            {
                if (play == 1) // player one who paly then player tow will pay .
                {
                    AddToArray(l, "X");
                    l.Text = "X";
                    l.Enabled = false;
                    play++;
                }
                else // player tow who paly then player one will pay .
                {
                    AddToArray(l, "O");
                    l.Text = "O";
                    l.Enabled = false;
                    play--;
                }
            } else // play with computer .
            {
                count++;
                AddToArray(l, "X");
                l.Text = "X";
                l.Enabled = false;
                if (count < 8)
                {
                    int computer_Play = ComputerPlay(count);
                    game[computer_Play] = "O";
                    disaple(computer_Play);
                }
            }
        }
        public void AddToArray( Label l ,string play) 
        {
            if (l.Name.Equals("l1"))
            {
                game[0] = play;
            } else if (l.Name.Equals("l2"))
            {
                game[1] = play;
            } else if (l.Name.Equals("l3"))
            {
                game[2] = play;
            } else if (l.Name.Equals("l4"))
            {
                game[3] = play;
            } else if (l.Name.Equals("l5"))
            {
                game[4] = play;
            } else if (l.Name.Equals("l6"))
            {
                game[5] = play;
            } else if (l.Name.Equals("l7"))
            {
                game[6] = play;
            } else if (l.Name.Equals("l8"))
            {
                game[7] = play;
            } else if (l.Name.Equals("l9"))
            {
                game[8] = play;
            }
        }
        public string win(string [] game)
        {

            if (game[0]==(game[1])&& game[0]==(game[2]) && game[0]!=(null)) // chek if squre one == squre tow if true then check if squre one == choice ;
            {
                return game[0];
            }
            else if (game[3]==(game[4]) && game[3]==(game[5]) && game[3]!=(null))// chek if squre five == squre six if true then check if squre five == choice ;
            {
                return game[3];
            }
            else if (game[6]==(game[7]) && game[6]==(game[8]) && game[6]!=(null))// chek if squre 7 == squre 8 if true then check if squre 7 == choice ;
            {
                return game[6];
            }
            else if (game[0]==(game[4]) && game[0]==(game[8])  && game[0]!=(null))
            {
                return game[0];
            }
            else if (game[2]==(game[4]) && game[2]==(game[6]) && game[2]!=(null))
            {
                return game[2];
            }
            else if (game[0]==(game[3]) && game[0]==(game[6]) && game[0]!=(null))
            {
                return game[0];
            }
            else if (game[1]==(game[4]) && game[1]==(game[7]) && game[1]!=(null))
            {
                return game[1];
            }
            else if (game[2]==(game[5]) && game[2]==(game[8]) && game[2]!=(null))
            {
                return game[2];
            }
            else if (game[0]!=(null) && game[1]!=(null) && game[2]!=(null) && game[3]!=(null) && game[4]!=(null) && game[5]!=(null) && game[6]!=(null) && game[7]!=(null) && game[8]!=(null)) // player one and tow are equel.
            {
                return "equal";
            }
            return "scape";
        }
        public string HowWin(string whoPlay , string whowin)
        {
            if (whoPlay.Equals("frind")) // play with frind .
            {
                if (play == 1)
                {
                    // then palyer one who win in this game .
                    Player_Two_Score++;
                    return "Player Tow Win ";
                }
                else
                {
                    // then player tow who win in this game .
                    Player_One_Score++;
                    return "Player One Win ";
                }
            } else // paly with Computer .
            {
                if (whowin.Equals("X"))
                {
                    // then palyer one who win in this game .
                    Player_One_Score++;
                    return "Player One Win ";
                }
                else
                {
                    // then player tow who win in this game .
                    Player_Two_Score++;
                    return "Computer Win ";
                }
            }
        }
        public void play_again()
        {
            l1.Enabled = true;
            l2.Enabled = true;
            l3.Enabled = true;
            l4.Enabled = true;
            l5.Enabled = true;
            l6.Enabled = true;
            l7.Enabled = true;
            l8.Enabled = true;
            l9.Enabled = true;
            l1.Text = null;
            l2.Text = null;
            l3.Text = null;
            l4.Text = null;
            l5.Text = null;
            l6.Text = null;
            l7.Text = null;
            l8.Text = null;
            l9.Text = null;
            for (int i = 0; i < game.Length; i++)
            {
                game[i] = null;
            }
        }
        public string Last_Winner(string whoPlay)
        {
            if (whoPlay.Equals("frind")) {
                if (Player_One_Score > Player_Two_Score)
                {
                    return "Player One Last Winner";
                }
                else if (Player_Two_Score > Player_One_Score)
                {
                    return "Player Tow Last Winner";
                }
                else
                {
                    return "Last Resualt Equal";
                }
            } else
            {
                if (Player_One_Score > Player_Two_Score)
                {
                    return "Player One Last Winner";
                }
                else if (Player_Two_Score > Player_One_Score)
                {
                    return "Computer Last Winner";
                }
                else
                {
                    return "Last Resualt Equal";
                }
            }
          
        }
        Random choice = new Random();
        int ComputerPlay (int count)
        {
            // 1- we need the Index in game array == null 
            // 2- create new arry and pass Index == null.
            // 3- choice one of those Index Randomly .
            int [] IndexEmpty = new int[game.Length-count] ;
            int c;
            int Counter = 0;
            for (int i = 0; i < game.Length; i++)
            {
                if (game[i]==null)
                {
                    IndexEmpty[Counter] = i;
                    Counter++;
                }
            } 
            
            c = choice.Next(0, IndexEmpty.Length);
            Form1.count++;
            return IndexEmpty[c];
        } void disaple(int n)
        {
            if (n==0)
            {
                l1.Enabled = false;
                l1.Text = "O";
            } else if (n == 1)
            {
                l2.Enabled = false;
                l2.Text = "O";
            } else if (n == 2)
            {
                l3.Enabled = false;
                l3.Text = "O";
            }
            else if (n == 3)
            {
                l4.Enabled = false;
                l4.Text = "O";
            }
            else if (n == 4)
            {
                l5.Enabled = false;
                l5.Text = "O";
            }
            else if (n == 5)
            {
                l6.Enabled = false;
                l6.Text = "O";
            }
            else if (n == 6)
            {
                l7.Enabled = false;
                l7.Text = "O";
            }
            else if (n == 7)
            {
                l8.Enabled = false;
                l8.Text = "O";
            }
            else if (n == 8)
            {
                l9.Enabled = false;
                l9.Text = "O";
            }
        }
    }
}
