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
    public partial class start3 : Form
    {
        public start3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level3 z = new Level3();
            z.Show();
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

        private void start3_Load(object sender, EventArgs e)
        {
            close.Location = new Point(759, 2);
            back.Location = new Point(712, 2);
        }
    }
}
