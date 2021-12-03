using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            string hide = HidePass.Text;
            if (hide.Length == 0) // chek if heid empty .
            {
                ShowPass.Text = "";
            }  else
            {
                ShowPass.Text = hide;
            }
        }
    }
}
