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


    public partial class Profile : Form
    {
        public static Profile instance;// in order to be able to acess this form
        public static  Profile NP; //control on the profile //static d

        public static Dictionary<string, string> user_profile_info = new Dictionary<string, string>(); //linq x["name"]="nour"
        // يخزن المعلومات و يسمح بنقلها بين الفورمات 
        private  string pName;
        private string pGender;
       // private string pColor;
        private string pAge;
        private static int num_Player = 0; //  كم مره لعب 
        public static int count_palyer = 0; // عدد اللاعبين// اللاهب يسجل اسمه مره وحده
        List<string> All_Player_Name = new List<string>(); 
        public int _numPlayer
        {
            get { return num_Player; }
        }
        public string _Name
        {
            get { return pName; }
            set { pName = playername.Text;  }
        }

        public string _Gender
        {

            get { return pGender; }
            set { pGender = value; }
        }

        /*public string _Color
        {

            get { return pColor; }
            set { pColor = value; }
        }*/
        public string _Age
        {

            get { return pAge; }
            set { pAge = age.Text;  }
        }


        public Profile()
        {
            InitializeComponent();

            num_Player += 1;
             NP=this; // نتحكم بال profile 
            instance = this;// since this folder is created it will save its information
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            instance.pGender = "Female"; //this

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            instance.pGender = "Male"; //this
        }

        private void save_Click(object sender, EventArgs e)
        {
            //search about player profile if has an account or not 
            if (All_Player_Name.Count == 0) { All_Player_Name.Add(Profile.player_Name()); count_palyer++; }
            else
            {
                for (int i = 0; i < All_Player_Name.Count(); i++)
                {
                    if (!All_Player_Name.Contains(Profile.player_Name()))
                        count_palyer++;
                }

            }
            NP.pName = playername.Text;
            NP.pAge = age.Text;
            //dictionary //
            user_profile_info.Add(age.Text, age.Text); //key == value 
            user_profile_info.Add(playername.Text, playername.Text); //key == value

            this.Hide();
            newGame Gamee = new newGame();
            newGame.instance2.tb.Text = _Name;// retreve the name to new page
            Gamee.Show();
            this.Hide();
        }
       

        //LINQ //sql save data 
        public static string player_Name()
        {
            //user_profile_info[key] == key (value)
            return user_profile_info.Where(x => x.Key == NP.pName /*this name*/).Select(x => x.Value).FirstOrDefault(); 
            //dictionary iterator/pointer 
        }


        public static string player_Age()
        {
            //user_profile_info[key] == key (value)
            return user_profile_info.Where(x => x.Key == NP.pAge).Select(x => x.Value).FirstOrDefault();
        }
        //
        private void Profile_Load(object sender, EventArgs e)
        {

        }
        public override string ToString()
        {
            return playername.Text;
        }
    }
}
