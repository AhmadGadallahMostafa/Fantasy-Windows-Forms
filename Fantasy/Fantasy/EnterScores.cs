using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy
{
    public partial class EnterScores : Form
    {
        int HomeGoals = 0;
        int GuestGoals = 0;
        int HomeAssists = 0;
        int GuestAssists = 0;
        int thisweek = 0;
        string HomeClub = "";
        string GuestClub="";
        Controller controlObj;
        string[] HomePlayersBackLine = new string[3];
        string[] AwayPlayersBackLine = new string[3];

        public EnterScores(string HTeam,string GTeam,int week)
        {
            InitializeComponent();
            HomeClub = HTeam;
            GuestClub = GTeam;
            controlObj = new Controller();
            thisweek = week;

        }
      
        private void EnterScores_Load(object sender, EventArgs e)
        {
            DataTable homeClub = controlObj.GetFootBallersByClubName(HomeClub);
            listBox1.DataSource = homeClub;
            listBox1.DisplayMember = "Last_Name";
            DataTable guestClub = controlObj.GetFootBallersByClubName(GuestClub);
            listBox2.DataSource = guestClub;
            listBox2.DisplayMember = "Last_Name";
            label1.Text = HomeClub;
            label2.Text = GuestClub;

            DataTable dt1 = controlObj.GetDefendersAndGkNamesInClub(HomeClub);
            DataTable dt2 = controlObj.GetDefendersAndGkNamesInClub(GuestClub);
            int count1 = dt1.Rows.Count;
            if (count1 > 0)
            {

                for (int i = 0; i < count1; i++)
                {
                    HomePlayersBackLine[i] = dt1.Rows[i][0].ToString();
                }
            }
            int count2 = dt2.Rows.Count;
            if (count2 > 0)
            {

                for (int i = 0; i < count2; i++)
                {
                    AwayPlayersBackLine[i] = dt2.Rows[i][0].ToString();

                }
            }
        }

        private void GuestTeam_Click(object sender, EventArgs e)
        {

        }

        private void EnterScore_Click(object sender, EventArgs e)
        {
            if (HomeGoals == 0) 
            {
                for (int i = 0; i < AwayPlayersBackLine.Length; i++) 
                {
                    controlObj.PlayerCleanSheet(AwayPlayersBackLine[i]);

                }
            }
            if (GuestGoals == 0) 
            {
                //cleansheet for home team
                for(int i = 0; i < HomePlayersBackLine.Length; i++) 
                {
                    controlObj.PlayerCleanSheet(HomePlayersBackLine[i]);
                }
            }
            controlObj.UpdateClubAfterMatch(HomeClub, GuestGoals, HomeGoals);
            controlObj.UpdateClubAfterMatch(GuestClub, HomeGoals, GuestGoals);

            string score = HomeGoals.ToString() + "-" + GuestGoals.ToString();
            if (controlObj.UpdateFixtureScore(HomeClub, GuestClub, thisweek, score, DateTime.Today.Year.ToString()) != 0)
            {
                MessageBox.Show("Fxiture Updated!");
                UpdatedFixture?.Invoke(this, EventArgs.Empty);
                this.Close();
                

            }
        }
        public event EventHandler UpdatedFixture;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HScore_Click(object sender, EventArgs e)
        {
            HomeGoals++;
            label3.Text = HomeGoals.ToString();
            var playerName=  listBox1.Text;
            controlObj.PlayerScored(playerName);

        }

        private void HAssist_Click(object sender, EventArgs e)
        {
            HomeAssists++;
            if (HomeAssists > HomeGoals)
            {
                HomeAssists--;
                MessageBox.Show("A Goal must be scored to add an assist!");
            }
            else
            {
                var playerName = listBox1.Text;
                controlObj.PlayerAssisted(playerName);
            }
        }

        private void AScore_Click(object sender, EventArgs e)
        {
            GuestGoals++;
            label4.Text = GuestGoals.ToString();
            var playerName = listBox2.Text;
            controlObj.PlayerScored(playerName);

        }

        private void AAssist_Click(object sender, EventArgs e)
        {
            GuestAssists++;
            if (GuestAssists > GuestGoals)
            {
                GuestAssists--;
                MessageBox.Show("A Goal must be scored to add an assist!");
            }
            else
            {
                var playerName = listBox2.Text;
                controlObj.PlayerAssisted(playerName);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AwaySus_Click(object sender, EventArgs e)
        {
            controlObj.InsertPlayerUnavailable(listBox2.Text,true,false,DateTime.Today,7);
        }

        private void AwaInjure_Click(object sender, EventArgs e)
        {
            controlObj.InsertPlayerUnavailable(listBox2.Text, false, true, DateTime.Today, (int)numericUpDown1.Value);
        }

        private void HomeSus_Click(object sender, EventArgs e)
        {
            controlObj.InsertPlayerUnavailable(listBox1.Text, true, false, DateTime.Today, 7);
        }

        private void HomeInjure_Click(object sender, EventArgs e)
        {
            controlObj.InsertPlayerUnavailable(listBox2.Text, false, true, DateTime.Today, (int)numericUpDown2.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
