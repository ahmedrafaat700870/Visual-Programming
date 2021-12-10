using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int FontSize = 15;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is ATest Formating Pragraming .");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.ForeColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.ForeColor = Color.Green;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontSize = 20; 
            Text.Font = new Font("", FontSize);
        }

        private void meiamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontSize = 30;
            Text.Font = new Font("", FontSize);
        }

        private void largToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontSize = 40; 
            Text.Font = new Font("", FontSize);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.Font = new Font("", FontSize, FontStyle.Bold);
            boldToolStripMenuItem.Checked = true;
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.Font = new Font("", FontSize, FontStyle.Italic);
        }
    }
}
