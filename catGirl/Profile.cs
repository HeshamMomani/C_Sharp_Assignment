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

        public Profile NP;
        public static Dictionary<string, string> user_profile_info = new Dictionary<string, string>();
        private string pName;
        private string pGender;
        private string pColor;
        private string pAge;
        private static int num_Player = 0;
   

        public int _numPlayer
        {
            get { return num_Player; }
        }
        public string _Name
        {
            get { return pName; }
            set { pName = playername.Text; user_profile_info.Add("Name",pName); }
        }

        public string _Gender
        {

            get { return pGender; }
            set { pGender = value; }
        }

        public string _Color
        {

            get { return pColor; }
            set { pColor = value; }
        }
        public string _Age
        {

            get { return pAge; }
            set { pAge = age.Text; user_profile_info.Add("Age", pAge); }
        }


        public Profile()
        {
            InitializeComponent();

            num_Player += 1;
            NP = this;
            instance = this;// since this folder is created it will save its information
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            instance.pGender = "Female";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            instance.pGender = "Male";
        }

        private void save_Click(object sender, EventArgs e)
        {
            NP.pName = playername.Text;
            NP.pAge = age.Text;
      
            this.Hide();
            newGame Gamee = new newGame();
            newGame.instance2.tb.Text = _Name;// retreve the name to new page
            Gamee.Show();
            this.Hide();
        }
       

        //LINQ
        public static string player_Name()
        {
            return user_profile_info.Where(x => x.Key == "Name").Select(x => x.Value).FirstOrDefault();
        }


        public static string player_Age()
        {
            return user_profile_info.Where(x => x.Key == "Age").Select(x => x.Value).FirstOrDefault();
        }
        //
        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
