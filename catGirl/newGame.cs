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
    public partial class newGame : Form
        
    {    public static int Game_number=0;
        public static newGame instance2;//to allow acess this form
        public TextBox tb;//to be able to access on name textbox 
        public static int user_all_score = 0;
        List <string> All_Player_Name=new List<string>();
        public static int count_palyer=0;
        public static int level = 1;
        public newGame()
        {
            InitializeComponent();
            instance2 = this;//to be able to save all form information
            tb = username; // name of textbox
        }

   
         private void start_Click(object sender, EventArgs e)
        {
            //search about player profile if has an account or not 
            if (All_Player_Name.Count == 0) { All_Player_Name.Add(Profile.player_Name()); count_palyer++; }
            else {
                for (int i = 0; i < All_Player_Name.Count(); i++)
                {
                    if (!All_Player_Name.Contains(Profile.player_Name()))
                        count_palyer++;
                }

            }
            this.Hide();
            Game_number++; //how much the player is played
            statL1 Go = new statL1();
            Go.Show();
           
            
        }
       
        private void newGame_Load(object sender, EventArgs e)
        {

        }
    }
}
