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
        List<Unavailable_Player> unAvailablefootballers;
        string dummy = "T";
        int chosenNumber;
        bool found = false;



        public PlayerView(int FantasyTeamId)
        {
            InitializeComponent();
            FTID = FantasyTeamId;
            CustomizeDesign();
            if (C1.GetTransfers(FTID) == 0)
            {
                transfersButton.Visible = false;
            }
            styleDataGrid();



        }
        private void styleDataGrid()
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.SkyBlue;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 8);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.RowTemplate.Height = 70;
            //dataGridView1.Columns.Width = 100;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ClearSelection();
        }

        private void CustomizeDesign()
        {
            panel2.Hide();
            EnterLeagueIDText.Hide();
            EnterLeagueID.Hide();
            JoinButton.Hide();
            LeagueName.Hide();
            LeagueNameText.Hide();
            Country.Hide();
            CountryText.Hide();
            CreateButt.Hide();

        }



        private void Form2_Load(object sender, EventArgs e)
        { 
            CreateLeagueButt.Visible = false;
            JoinLeagueButt.Visible = false;
            MyLeaguesButt.Visible = false;
            //displaying player info 
            int Funds = C1.GetTeamFunds(FTID);
            int points = C1.getPointsByID(FTID);
            FundsValueLabel.Text = Funds.ToString();
            PointsValueLabel.Text = points.ToString();
            DataTable name = C1.getNameByID(FTID);
            TeamNameLabel.Text = name.Rows[0][0].ToString();
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

            //unavailable check
            DateTime today = DateTime.Today;
            check();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            EnterLeagueIDText.Show();
            EnterLeagueID.Show();
            JoinButton.Show();
            LeagueName.Visible = false;
            LeagueName.Visible = false;
            CreateButt.Visible = false;
            Country.Visible = false;
            CountryText.Visible = false;
            LeagueNameText.Visible = false;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {

            CreateLeagueButt.Visible = true;
            JoinLeagueButt.Visible = true;
            MyLeaguesButt.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button15_Click(object sender, EventArgs e)
        {
            string LeagueName = EnterLeagueIDText.Text;

            C1.JoinLeague(FTID, LeagueName);
        }

        private void CreateLeagueButt_Click(object sender, EventArgs e)
        {
            LeagueName.Show();
            LeagueNameText.Show();
            CreateButt.Show();
            Country.Show();
            CountryText.Show();
            JoinButton.Visible = false;
            EnterLeagueID.Visible = false;
            EnterLeagueIDText.Visible = false;

        }

        private void CreateButt_Click(object sender, EventArgs e)
        {
            C1.InsertLeague(LeagueNameText.Text, CountryText.SelectedItem.ToString(), FTID);
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
            this.Form2_Load(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void MyLeaguesButt_Click(object sender, EventArgs e)
        {
            openChildForm(new MyLeagues(FTID));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            transfermid1.Visible = true;
            transfermid2.Visible = true;
            transfermid3.Visible = true;
            transfermid4.Visible = true;
            transfergk1.Visible = true;
            transferatt1.Visible = true;
            transferatt2.Visible = true;
            transferdef1.Visible = true;
            transferdef2.Visible = true;
            transferdef3.Visible = true;
            transferdef4.Visible = true;
            dataGridView1.Visible = true;
            acceptTransfer.Visible = true;


        }
        private void hidetransfersButtons()
        {
            transfermid1.Visible = false;
            transfermid2.Visible = false;
            transfermid3.Visible = false;
            transfermid4.Visible = false;
            transfergk1.Visible = false;
            transferatt1.Visible = false;
            transferatt2.Visible = false;
            transferdef1.Visible = false;
            transferdef2.Visible = false;
            transferdef3.Visible = false;
            transferdef4.Visible = false;
            dataGridView1.Visible = false;
            acceptTransfer.Visible = false;
        }

        private void transferdef1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();
            chosenNumber = 1;
            dataGridView1.Refresh();
        }

        private void transferdef2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();
            chosenNumber = 2;
            dataGridView1.Refresh();
        }

        private void transferdef3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();
            chosenNumber = 3;
            dataGridView1.Refresh();
        }

        private void transferdef4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();
            chosenNumber = 4;
            dataGridView1.Refresh();
        }

        private void acceptTransfer_Click(object sender, EventArgs e)
        {
            //Funds Check
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Select a player please");

            }
            else
            {
                string playerInLastName = dataGridView1.SelectedCells[0].Value.ToString();

                for (int i = 0; i < 10; i++)
                {
                    if (playerInLastName == OnPitch[i])
                    {
                        found = true;
                    }
                }
                for(int i=0;i<3;i++)
                {
                    if (playerInLastName == Subs[i])
                    {
                        found = true;
                    }

                }
                if (found == false)
                {
                    int playerInPrice = C1.GetPrice(playerInLastName);
                    string chosenPlayerName = OnPitch[chosenNumber];
                    int chosenPlayerPrice = C1.GetPrice(chosenPlayerName);
                    int newFunds = C1.GetTeamFunds(FTID) + chosenPlayerPrice - playerInPrice;
                    if (newFunds < 0)
                    {
                        MessageBox.Show("You Dont Have Enough Money To Make This Transfer");
                    }
                    else
                    {
                        int flag = C1.transfer(playerInLastName, chosenPlayerName, FTID, newFunds);
                        if (flag == 1)
                        {
                            FundsValueLabel.Text = newFunds.ToString();
                            OnPitch[chosenNumber] = playerInLastName;
                            C1.updateTransfers(FTID, 0);
                            hidetransfersButtons();
                            transfersButton.Visible = false;
                            //Update the photo
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
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a player that you dont have");
                }
                found = false;
            }
        }

   

       
        private void transfergk1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetGK();
            chosenNumber = 0;
            dataGridView1.Refresh();
        }

        private void transfermid1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();
            chosenNumber = 5;
            dataGridView1.Refresh();
        }

        private void transfermid2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();
            chosenNumber = 6;
            dataGridView1.Refresh();
        }

        private void transfermid3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();
            chosenNumber = 7;
            dataGridView1.Refresh();
        }

        private void transfermid4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();
            chosenNumber = 8;
            dataGridView1.Refresh();
        }

        private void transferatt1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetStriker();
            chosenNumber = 9;
            dataGridView1.Refresh();
        }

        private void transferatt2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetStriker();
            chosenNumber = 10;
            dataGridView1.Refresh();
        }

       
       /* private void checkUnavailable()
        {
            DateTime today = DateTime.Today;
            for (int i = 0; i < 10; i++)
            {
                int PlayerID = C1.GetPlayerId(OnPitch[i]);
                DataTable d = C1.isUnavailable(PlayerID);
                if (d == null)
                {
                    continue;
                }
                var row = d.AsEnumerable().FirstOrDefault();
                Unavailable_Player p = new Unavailable_Player()
                {
                    ID = row.Field<int>("ID"),
                    Start_Date = row.Field<DateTime>("Start_Date"),
                    Duration = row.Field<int>("Duration")
                };
                if (today > p.Start_Date && today < p.Start_Date.AddDays((double)p.Duration))
                {
                    unavailableFlag[i] = 1;
                    dataGridView2.Rows.Add("name");
                    dataGridView2.Rows.Insert(i,OnPitch[i]);
                }
                else
                {
                    unavailableFlag[i] = 0;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                int PlayerID = C1.GetPlayerId(Subs[i]);
                DataTable d = C1.isUnavailable(PlayerID);
                if (d == null)
                {
                    continue;
                }
                var row = d.AsEnumerable().FirstOrDefault();
                Unavailable_Player p = new Unavailable_Player()
                {
                    ID = row.Field<int>("ID"),
                    Start_Date = row.Field<DateTime>("Start_Date"),
                    Duration = row.Field<int>("Duration")
                };
                if (today > p.Start_Date && today < p.Start_Date.AddDays((double)p.Duration))
                {
                    unavailableFlag[i + 11] = 1;
                }
                else
                {
                    unavailableFlag[i + 11] = 0;
                }
            }
        }*/

        private void check()
        {
            DateTime today = DateTime.Today;
            DataTable t = C1.getAllUnavailableInTeam(FTID);
            if (t != null)
            {
                unAvailablefootballers = new List<Unavailable_Player>();
                unAvailablefootballers = (from DataRow dr in t.Rows
                                          select new Unavailable_Player()
                                          {
                                              ID = (int)dr["ID"],
                                              Start_Date = (DateTime)dr["Start_Date"],
                                              Duration = (int)dr["Duration"],
                                              name = dr["Last_Name"].ToString()
                                          }).ToList();


                foreach (Unavailable_Player p in unAvailablefootballers)
                {
                    if (!(today > p.Start_Date && today < p.Start_Date.AddDays((double)p.Duration)))
                    {
                        unAvailablefootballers.Remove(p);
                    }
                }


                comboBox1.DataSource = unAvailablefootballers;
                comboBox1.DisplayMember = "name";
            }
            

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }





