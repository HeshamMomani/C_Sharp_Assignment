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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            close.Location = new Point(845, 0);
            back.Location = new Point(789, 1);
            //////tabel titel 
            label1.Text = "Name";
            label3.Text = "Date";
            label5.Text = "Duration";
            label7.Text = "Score";
            label9.Text = "Level";
            /////////////
            name.Text = Profile.player_Name(); //player name
            date.Text = DateTime.Today.ToString(); //date
            //duration depend on level the player is arrive
            if (newGame.level == 1) 
                dura.Text = Convert.ToString(30 - Level1.S_timer_result()) + " S";
            else if (newGame.level == 2)
                dura.Text = Convert.ToString(Level2.S_timer_result())+" S";
            if (newGame.level == 3)
                dura.Text = Convert.ToString(Level3.S_timer_result()) + " S";
            ///////////////////////
            sco.Text = Convert.ToString(newGame.user_all_score); //all score due the game 
            level.Text = Convert.ToString(newGame.level); //  the level the player is arrive
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 MainMenu = new Form2();
            MainMenu.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            @static x = new @static();
            x.Show();
            this.Hide();
        }

        private void titel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
