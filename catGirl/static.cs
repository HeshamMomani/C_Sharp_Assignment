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
    public partial class @static : Form
    {
        public @static()
        {
            InitializeComponent();
        }

        private void static_Load(object sender, EventArgs e)
        {

            num_game.Text = Convert.ToString(newGame.Game_number);
            num_profile.Text = Convert.ToString(Profile.count_palyer);
           int max_sc = Math.Max(Level1.Score_result(),Math.Max(Level2.Score_result(), Level3.Score_result()));
            highest.Text=Convert.ToString(max_sc);
            int min_sc = Math.Min(Level1.Score_result(), Math.Min(Level2.Score_result(), Level3.Score_result()));
            lowest.Text=Convert.ToString(min_sc);
            int min_du= Math.Min(Level1.S_timer_result(), Math.Min(Level2.S_timer_result(), Level3.S_timer_result()));
            mindu.Text= Convert.ToString(min_du);
            int max_du = Math.Max(Level1.S_timer_result(), Math.Max(Level2.S_timer_result(), Level3.S_timer_result()));
            maxdu.Text = Convert.ToString(max_du);
            total_sc.Text = Convert.ToString(newGame.user_all_score);
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
    }
}
