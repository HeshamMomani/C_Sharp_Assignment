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
    public partial class Level2 : Form
    {
        Dictionary<string, int> tool = new Dictionary<string, int>() { { "Score", 0 }, { "Speed", 12 }, { "Missed", 0 }, { "MS_Timer", 20 }, { "S_Timer", 30 } };
        Dictionary<string, bool> Move = new Dictionary<string, bool>() { { "GoLeft", false }, { "GoRight", false } };
        public static Dictionary<string, int> Data = new Dictionary<string, int>() { { "Score", 0 }, { "speed", 12 }, { "Missed", 0 }, { "ms_timer", 30 }, { "S_timer", 30 } };

        Random randA = new Random();
        Random randB = new Random();

        private void Reset()
        {
            foreach (Control Jewels in this.Controls)
            {
                //jewel Move
                if (Jewels is PictureBox && (string)Jewels.Tag == "TimeBonus" || (string)Jewels.Tag == "Jewel" || (string)Jewels.Tag == "Bomb")
                {
                    Jewels.Top = randA.Next(5, 100) * -1;
                    Jewels.Left = randB.Next(5, this.ClientSize.Width - Jewel.Width);

                }
            }

            //Reset values
            tool["Score"] = 0;
            tool["Speed"] = 5;
            tool["Missed"] = 0;
            tool["S_Timer"] = 30;
            tool["MS_Timer"] = 20;

            //Starting timer
            timer1.Start();

            PinkPanther.Left = this.ClientSize.Width / 2;
            PinkPanther.Image = Properties.Resources.PinkPanther;

        }

        public Level2()
        {
            InitializeComponent();
            newGame.level = 2;
            Reset();
        }
        private void Level2_Load(object sender, EventArgs e)
        {
            Score.Location = new Point(20, 30);
            Missed.Location = new Point(220, 30);
            Timer.Location = new Point(420, 30);
            close.Location = new Point(845, 0);
            back.Location = new Point(789, 1);
            name.Location = new Point(552, 0);
            name.Text = "Name: " + Profile.player_Name();
        }

        private void GameTick(object sender, EventArgs e)
        {
            history b = new history();
            Score.Text = "Score: " + tool["Score"]; // Score Lable 
            Timer.Text = "Timer: " + tool["S_Timer"] + " : " + tool["MS_Timer"]--;
            Missed.Text = "Missed: " + tool["Missed"];
            //Decrement The Time
            if (tool["MS_Timer"] == 0)
            {
                tool["S_Timer"]--;
                tool["MS_Timer"] = 30;
            }
            if (tool["Score"] >= 40)
            {
                timer1.Stop();
                start3 x = new start3();
                x.Show();
                this.Hide();

            }
            if (Move["GoLeft"] == true && PinkPanther.Left > 0)
            {
                if (tool["Score"] >= 15 && tool["Score"] < 30)
                    PinkPanther.Left -= 20;
                else
                    PinkPanther.Left -= 15;

                PinkPanther.Image = Properties.Resources.PinkPanther;
            }

            if (Move["GoRight"] == true && PinkPanther.Right < this.ClientSize.Width)
            {
                if (tool["Score"] >= 15 && tool["Score"] < 30)
                    PinkPanther.Left += 20;
                else
                    PinkPanther.Left += 15;

                PinkPanther.Image = Properties.Resources.PinkPanther;
            }

            foreach (Control Jewel in this.Controls)
            {

                if (Jewel is PictureBox && (string)Jewel.Tag == "Jewel" || (string)Jewel.Tag == "TimeBonus" || (string)Jewel.Tag == "Bomb")
                {
                    Jewel.Top += tool["Speed"];

                    if (Jewel.Top + Jewel.Height > this.ClientSize.Height)
                    {

                        Jewel.Top = randA.Next(20, 100) * -1;
                        Jewel.Left = randB.Next(5, this.ClientSize.Width - Jewel.Width);
                        if ((String)Jewel.Tag == "Jewel")
                            tool["Missed"]++;

                    }

                    if (Jewel.Bounds.IntersectsWith(PinkPanther.Bounds))
                    {
                        Jewel.Top = randA.Next(80, 100) * -1;
                        Jewel.Left = randB.Next(5, this.ClientSize.Width - Jewel.Width);
                        if ((string)Jewel.Tag == "Jewel")
                            tool["Score"]++;
                        else if ((string)Jewel.Tag == "TimeBonus")
                        { tool["Score"] += 5; tool["S_Timer"] += 5; }
                        else if ((string)Jewel.Tag == "Bomb")
                            tool["S_Timer"] -= 7;
                    }
                    if (tool["S_Timer"] <= 0)
                    {
                        timer1.Stop();
                        Data["Score"] = tool["Score"];
                        Data["Missed"] = tool["Missed"];
                        Data["S_timer"] = tool["S_Timer"];
                        Data["ms_timer"] = tool["MS_Timer"];
                        // add all score
                        newGame.user_all_score += tool["Score"];

                        MessageBox.Show("Game Over!! Time is out" + "\r\n" + "Click OK to Restart");
                        history a = new history();
                        b.Show();
                        this.Hide();
                       
                    }
                 if (tool["Missed"] >= 15)
                    {
                        timer1.Stop();
                        Data["Score"] = tool["Score"];
                        Data["Missed"] = tool["Missed"];
                        Data["S_timer"] = tool["S_Timer"];
                        Data["ms_timer"] = tool["MS_Timer"];
                        // add all score
                        newGame.user_all_score += tool["Score"];

                        MessageBox.Show("Game Over!! We lost alot of Jewels" + "\r\n" + "Click OK to Restart");
                        b.Show();
                        this.Hide();
                       
                    }

                    if (tool["Score"] >= 10 && tool["Score"] < 15)
                    {
                        tool["Speed"] = 10;
                    }

                    if (tool["Score"] >= 25 && tool["Score"] <40)
                    {
                        tool["Speed"] = 15;
                    }

                }

            }




        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {




        }


        //LINQ
        public static int Score_result()
        {
            return Data.Where(x => x.Key == "Score").Select(x => x.Value).FirstOrDefault();
        }
        //return missed
        public static int Missed_result()
        {
            return Data.Where(y => y.Key == "Missed").Select(y => y.Value).FirstOrDefault();
        }
        // return millisecond
        public static int ms_timer_result()
        {
            return Data.Where(x => x.Key == "MS_Timer").Select(x => x.Value).FirstOrDefault();
        }
        //return seconds
        public static int S_timer_result()
        {
            return Data.Where(x => x.Key == "S_Timer").Select(x => x.Value).FirstOrDefault();
        }

        //End of LINQ





        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                Move["GoLeft"] = true;
            if (e.KeyCode == Keys.Right)
                Move["GoRight"] = true;
        }

        private void Level2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                Move["GoLeft"] = false;
            if (e.KeyCode == Keys.Right)
                Move["GoRight"] = false;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PinkPanther_Click(object sender, EventArgs e)
        {

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
