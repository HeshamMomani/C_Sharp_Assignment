using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catGirl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile N = new Profile();
            N.ShowDialog();
            this.Show();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            newGame P = new newGame();
            P.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void startbutto_Click(object sender, EventArgs e)
        {
            newGame x = new newGame();
            x.Show();
            this.Hide();
        }
    }
}
