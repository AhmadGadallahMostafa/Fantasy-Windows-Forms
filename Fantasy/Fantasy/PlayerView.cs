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

        string[] OnPitch = new string[11];
        string[] Subs = new string[4];
        string dummy="T";


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
            DataTable dt1 = C1.OnPitchList(FTID);
            DataTable dt2 = C1.SubsList(FTID);


            int count1 = dt1.Rows.Count;
            if (count1 > 0)
            {
                //listView1.Items.Clear();

                for (int i = 0; i < count1; i++)
                {
                    //listView1.Items.Add(dt);
                    OnPitch[i] = dt1.Rows[i][0].ToString();
                }
            }

            int count2 = dt2.Rows.Count;
            if (count2 > 0)
            {
                //listView1.Items.Clear();

                for (int i = 0; i < count2; i++)
                {
                    //listView1.Items.Add(dt);
                    Subs[i] = dt2.Rows[i][0].ToString();
                }
            }


            GK1.Load(path + OnPitch[0] + ".png");
            DEF1.Load(path + OnPitch[1] + ".png");
            DEF2.Load(path + OnPitch[2] + ".png");
            DEF3.Load(path + OnPitch[3] + ".png");
            DEF4.Load(path + OnPitch[4] + ".png");
            MID1.Load(path + OnPitch[5] + ".png");
            MID2.Load(path + OnPitch[6] + ".png");
            MID3.Load(path + OnPitch[7] + ".png");
            MID4.Load(path + OnPitch[8] + ".png");
            ATT1.Load(path + OnPitch[9] + ".png");
            ATT2.Load(path + OnPitch[10] + ".png");
            GK2.Load(path + Subs[0] + ".png");
            DEF5.Load(path + Subs[1] + ".png");
            MID5.Load(path + Subs[2] + ".png");
            ATT3.Load(path + Subs[3] + ".png");







            /*int count = dt1.Rows.Count;
            if (count > 0)
            {
                //listView1.Items.Clear();
                listBox1.Items.Clear();

                for (int i = 0; i < count; i++)
                {
                    //listView1.Items.Add(dt);
                    listBox1.Items.Add(dt1.Rows[i][0].ToString());
                }
            }*/





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

        private void SubGK1_Click(object sender, EventArgs e)
        {

            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[0]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[0]), 0);
            dummy = OnPitch[0];
            OnPitch[0] = Subs[0];
            Subs[0] = dummy;
           
            GK1.Load(path + OnPitch[0] + ".png");
            GK2.Load(path + Subs[0] + ".png");







        }

        private void SubDEF1_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[1]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[1]), 0);
            dummy = OnPitch[1];
            OnPitch[1] = Subs[1];
            Subs[1] = dummy;

            DEF1.Load(path + OnPitch[1] + ".png");
            DEF5.Load(path + Subs[1] + ".png");
        }

        private void SubDEF2_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[2]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[1]), 0);
            dummy = OnPitch[2];
            OnPitch[2] = Subs[1];
            Subs[1] = dummy;

            DEF2.Load(path + OnPitch[2] + ".png");
            DEF5.Load(path + Subs[1] + ".png");
        }

        private void SubDEF3_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[3]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[1]), 0);
            dummy = OnPitch[3];
            OnPitch[3] = Subs[1];
            Subs[1] = dummy;

            DEF3.Load(path + OnPitch[3] + ".png");
            DEF5.Load(path + Subs[1] + ".png");

        }

        private void SubDEF4_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[4]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[1]), 0);
            dummy = OnPitch[4];
            OnPitch[4] = Subs[1];
            Subs[1] = dummy;

            DEF4.Load(path + OnPitch[4] + ".png");
            DEF5.Load(path + Subs[1] + ".png");
        }

        private void SubMID1_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[5]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[2]), 0);
            dummy = OnPitch[5];
            OnPitch[5] = Subs[2];
            Subs[2] = dummy;

            MID1.Load(path + OnPitch[5] + ".png");
            MID5.Load(path + Subs[2] + ".png");
        }

        private void SubMID2_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[6]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[2]), 0);
            dummy = OnPitch[6];
            OnPitch[6] = Subs[2];
            Subs[2] = dummy;

            MID2.Load(path + OnPitch[6] + ".png");
            MID5.Load(path + Subs[2] + ".png");
        }

        private void SubMID3_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[7]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[2]), 0);
            dummy = OnPitch[7];
            OnPitch[7] = Subs[2];
            Subs[2] = dummy;

            MID3.Load(path + OnPitch[7] + ".png");
            MID5.Load(path + Subs[2] + ".png");
        }

        private void SubMID4_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[8]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[2]), 0);
            dummy = OnPitch[8];
            OnPitch[8] = Subs[2];
            Subs[2] = dummy;

            MID4.Load(path + OnPitch[8] + ".png");
            MID5.Load(path + Subs[2] + ".png");
        }

        private void SubATT1_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[9]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[3]), 0);
            dummy = OnPitch[9];
            OnPitch[9] = Subs[3];
            Subs[3] = dummy;

            ATT1.Load(path + OnPitch[9] + ".png");
            ATT3.Load(path + Subs[3] + ".png");
        }

        private void SubATT2_Click(object sender, EventArgs e)
        {
            C1.Substitute(FTID, C1.GetPlayerId(OnPitch[10]), 1);
            C1.Substitute(FTID, C1.GetPlayerId(Subs[3]), 0);
            dummy = OnPitch[10];
            OnPitch[10] = Subs[3];
            Subs[3] = dummy;

            ATT2.Load(path + OnPitch[10] + ".png");
            ATT3.Load(path + Subs[3] + ".png");
        }
    }
}
