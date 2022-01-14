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
    public partial class statL1 : Form
    {
        public statL1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level1 level1   = new Level1();
            level1.Show();
            this.Hide();    
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 MainMenu = new Form2();
            MainMenu.Show();
            this.Hide();
        }

        private void statL1_Load(object sender, EventArgs e)
        {
            close.Location = new Point(612, 1);
            back.Location = new Point(565, 1);
        }
    }
}
