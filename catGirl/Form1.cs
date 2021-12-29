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
    public partial class Level1 : Form
    {
        Dictionary<string, int> tool = new Dictionary<string, int>() { { "score", 0 }, { "speed", 12 }, { "Missed", 0 }, { "ms_timer", 30 }, { "S_timer", 30 } };
        Dictionary<string, bool> move = new Dictionary<string, bool>() { { "GoLeft", false }, { "GoRight", false } };

        Random randA = new Random();
        Random randB = new Random();
        PictureBox drop = new PictureBox(); // create a new drop picture box, this will added dynamically

        public Level1()
        {
            InitializeComponent();
            Restart();
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            sc.Location = new Point(20, 30);
            miss.Location = new Point(220, 30);
            timer.Location = new Point(420, 30);
        }

        private void GameTick(object sender, EventArgs e)
        {
           sc.Text = "Score :" + tool["Score"]; //label
         miss.Text = "Misssed :" + tool["Missed"];//label;
           timer.Text = "Timer:  " + tool["S_timer"] + " : " + tool["ms_timer"]--;//timer label
           //if milisecond equal 0 the second will decresse by 1 and the ms_timer will back to 59ms
            if (tool["ms_timer"] == 0)
            {
                tool["S_timer"]--;
                tool["ms_timer"] = 30;
            }


            // if the go left boolean is true AND player left is greater than 0
            if (move["GoLeft"] == true && player.Left > 0)
            {
                // then we move the chicken 10 pixels to the left
                player.Left -= 10;
                //checken image will be change to the one moving left
                player.Image = Properties.Resources.girl2;
            }

            //if the go right is true AND player width and left is less than form width
            // meaning the player is still within the frame of the game
            if (move["GoRight"] == true && player.Left + player.Width < this.ClientSize.Width)
            {
                // move the player 10 pixels to the right
                player.Left += 10;
                // change the player image to the one moving right
                player.Image = Properties.Resources.girl2;
            }

            //below for loop will check the strawberry dropping from the top
            // for each Control we are calling strawberry in this form
            foreach (Control strawberry in this.Controls)
            {
               
                // if strawberry is a type of picture box AND it has the tag of fruit
                if (strawberry is PictureBox && (string)strawberry.Tag == "fruit")
                {
                    // then move strawberry towards the bottom
                    strawberry.Top += tool["speed"];


                    // if the strawberry reaches bottom of the screen
                    if (strawberry.Top + strawberry.Height > this.ClientSize.Height)
                    {
                        // if the strawberry hit the floor then we show the drop image
                        drop.Image = Properties.Resources.drop; // set the drop image
                        drop.Location = strawberry.Location; // drop shows up on the same location as the strawberry
                        drop.Height = 200; // set the height
                        drop.Width = 150; // set the width
                        drop.BackColor = System.Drawing.Color.Transparent; // apply transparent background to the picture box

                        this.Controls.Add(drop); // add the drop picture to the form

                        strawberry.Top = randA.Next(20, 100) * -1; // position the strawberry to a random  location
                        strawberry.Left = randB.Next(5, this.ClientSize.Width - strawberry.Width); // position the strawberry to a random location
                        tool["Missed"]++; // add 1 to the missed integer

                    }

                    // if the strawberry bound with the player image
                    // if both picture boxes collide
                    if (strawberry.Bounds.IntersectsWith(player.Bounds))
                    {
                        strawberry.Top = randA.Next(80, 100) * -1; // position the strawberry to a random  location
                        strawberry.Left = randB.Next(5, this.ClientSize.Width - strawberry.Width); // position the strawberry to a random X location
                        tool["Score"]++; // add 1 to the score
                    }

                    // if the score is equals to or greater than 20
                    if (tool["Score"] >= 20)
                    {
                        tool["speed"] = 16; // increase the strawberry speed to 20
                    }

                    // if the missed number is greater than 5
                    // we need to stop the game
                    if (tool["Missed"] > 10 || tool["S_timer"] <= 0)
                    {
                        MainTimer1.Stop(); // stop the game timer
                        // show the message box to say game is over. 
                        if (tool["Missed"] > 10)
                        {
                            MessageBox.Show("Game Over!! We lost good Strawberry" + "\r\n" + "Click OK to Restart");
                            tool["S_timer"] = 0;
                        }
                        else
                            MessageBox.Show("Game Over!! Time is out" + "\r\n" + "Click OK to Restart");

                        // once the players clicks OK we restart the game again
                        Restart();
                    }

                }

            }

        }

      

       
     

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //if left or rigth key pressed it going to change
            if (e.KeyCode == Keys.Left)
                move["GoLeft"] = true;
            if (e.KeyCode == Keys.Right)
                move["GoRight"] = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //keys are released
            if (e.KeyCode == Keys.Left)
                move["GoLeft"] = false;
            if (e.KeyCode == Keys.Right)
                move["GoRight"] = false;
        }
        public void Restart() { 
        foreach(Control strawberry in this.Controls)
            {
                // friut move
                if(strawberry is PictureBox && (string)strawberry.Tag=="fruit")
                    // make fuits apper randomly
                    strawberry.Top = randA.Next(5, 100) * -1; // -1 to move down
                strawberry.Left = randB.Next(5, this.ClientSize.Width - strawberry.Width); // to apper random from left 5 and the right we should calculate it
            }
        // starting value
            tool["Score"] = 0;
            tool["speed"] = 5;
            tool["Missed"] = 0;
            tool["S_timer"] = 30;

            //start timer
           MainTimer1.Start();

           player.Left = this.ClientSize.Width / 2; // reset the player to middle of the form
            player.Image = Properties.Resources.girl2; // change the player picture to face left



        }

        private void timer_Click(object sender, EventArgs e)
        {

        }
    }
}
