using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Fantasy
{
    public partial class PlayerView : Form
    {
        Controller C1 = new Controller();

        int FTID;
        string path = Path.Combine(Directory.GetCurrentDirectory(), @"Images/");
       


        public PlayerView(int FantasyTeamId)
        {
            InitializeComponent();
            FTID = FantasyTeamId;
            CustomizeDesign();

            



        }

        private void CustomizeDesign()
        {
            panel2.Hide();
            EnterLeagueIDText.Hide();
            EnterLeagueID.Hide();
            button15.Hide();
            LeagueName.Hide();
            LeagueNameText.Hide();
            Country.Hide();
            CountryText.Hide();
            CreateButt.Hide();

        }



        private void Form2_Load(object sender, EventArgs e)
        {
            
            
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnterLeagueIDText.Show();
            EnterLeagueID.Show();
            button15.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int LeagueID=Int32.Parse(EnterLeagueIDText.Text);

            C1.JoinLeague(FTID, LeagueID);
        }

        private void CreateLeagueButt_Click(object sender, EventArgs e)
        {
            LeagueName.Show();
            LeagueNameText.Show();
            CreateButt.Show();
            Country.Show();
            CountryText.Show();

        }

        private void CreateButt_Click(object sender, EventArgs e)
        {
            C1.InsertLeague(LeagueNameText.Text, CountryText.SelectedItem.ToString());
        }
    }
}
