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
    public partial class start2 : Form
    {
        public start2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level2 z = new Level2();
            z.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 MainMenu = new Form2();
            MainMenu.Show();
            this.Hide();
        }

        private void start2_Load(object sender, EventArgs e)
        {
            close.Location = new Point(603, 0);
            back.Location = new Point(556, 0);
        }
    }
}
