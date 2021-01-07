﻿using System;
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
    public partial class Form3 : Form
    {

        Controller C1 = new Controller();

        int ChosenPlayerNo = -1;
        string[] Team = new string[15];
        int FTID;

        string path = Path.Combine(Directory.GetCurrentDirectory(), @"Images/");

        public Form3(int FT)
        {
            InitializeComponent();
            FTID = FT;
        }

        private void GK1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetGK();

            DataTable dt = C1.GetGK();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 0;

        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            string PlayerName = PlayersList.GetItemText(PlayersList.SelectedItem);

            

            if (C1.GetTeamFunds(FTID) > C1.GetPrice(PlayerName))
            {

                if (ChosenPlayerNo == 0)
                {
                    GK1.Load(path + PlayerName + ".png");
                    Team[0] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);
                }
                else if (ChosenPlayerNo == 1)
                {
                    GK2.Load(path + PlayerName + ".png");
                    Team[11] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 2)
                {
                    DEF1.Load(path + PlayerName + ".png");
                    Team[1] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);


                }
                else if (ChosenPlayerNo == 3)
                {
                    DEF2.Load(path + PlayerName + ".png");
                    Team[2] = PlayersList.GetItemText(PlayersList.SelectedItem);

                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 4)
                {
                    DEF3.Load(path + PlayerName + ".png");
                    Team[3] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 5)
                {
                    DEF4.Load(path + PlayerName + ".png");
                    Team[4] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 6)
                {
                    DEF5.Load(path + PlayerName + ".png");
                    Team[12] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 7)
                {
                    MID1.Load(path + PlayerName + ".png");
                    Team[5] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 8)
                {
                    MID2.Load(path + PlayerName + ".png");
                    Team[6] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 9)
                {
                    MID3.Load(path + PlayerName + ".png");
                    Team[7] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 10)
                {
                    MID4.Load(path + PlayerName + ".png");
                    Team[8] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 11)
                {
                    MID5.Load(path + PlayerName + ".png");
                    Team[13] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 12)
                {
                    ATT1.Load(path + PlayerName + ".png");
                    Team[9] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 13)
                {
                    ATT2.Load(path + PlayerName + ".png");
                    Team[10] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
                else if (ChosenPlayerNo == 14)
                {
                    ATT3.Load(path + PlayerName + ".png");
                    Team[14] = PlayersList.GetItemText(PlayersList.SelectedItem);
                    C1.BuyingFunction(FTID, PlayerName);
                    textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                    C1.InsertPlayer(C1.GetPlayerId(PlayerName), FTID);

                }
            }
            else
            {
                MessageBox.Show("you dont have enough money");
            }
        }

        private void GK2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetGK();

            DataTable dt = C1.GetGK();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 1;
        }

        private void DEF1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();

            DataTable dt = C1.GetDefender();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 2;

        }

        private void DEF2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();

            DataTable dt = C1.GetDefender();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 3;
        }

        private void DEF3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();

            DataTable dt = C1.GetDefender();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 4;
        }

        private void DEF4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();

            DataTable dt = C1.GetDefender();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 5;
        }

        private void DEF5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();

            DataTable dt = C1.GetDefender();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 6;

        }

        private void MID1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

            DataTable dt = C1.GetMidFielder();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 7;

        }

        private void MID2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

            DataTable dt = C1.GetMidFielder();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 8;
        }

        private void MID3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

            DataTable dt = C1.GetMidFielder();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 9;
        }

        private void MID4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

            DataTable dt = C1.GetMidFielder();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 10;
        }

        private void MID5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

            DataTable dt = C1.GetMidFielder();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 11;

        }

        private void ATT1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetStriker();

            DataTable dt = C1.GetStriker();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 12;
        }

        private void ATT2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetStriker();

            DataTable dt = C1.GetStriker();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 13;
        }

        private void ATT3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetStriker();

            DataTable dt = C1.GetStriker();
            PlayersList.DataSource = dt;
            PlayersList.DisplayMember = "Last_Name";

            ChosenPlayerNo = 14;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void GKBT1_Click(object sender, EventArgs e)
        {
            
            GK1.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[0]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
            C1.DeletePlayer(FTID, C1.GetPlayerId(Team[0]));
        }

        private void GKBT2_Click(object sender, EventArgs e)
        {
            
            GK2.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[1]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void DBT1_Click(object sender, EventArgs e)
        {
          
            DEF1.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[2]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void DBT2_Click(object sender, EventArgs e)
        {
            
            DEF2.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[3]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void DBT3_Click(object sender, EventArgs e)
        {
            
            DEF3.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[4]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void DBT4_Click(object sender, EventArgs e)
        {
           
            DEF4.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[5]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void DBT5_Click(object sender, EventArgs e)
        {
            
            DEF5.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[6]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void MFBT1_Click(object sender, EventArgs e)
        {
            
            MID1.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[7]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void MFBT2_Click(object sender, EventArgs e)
        {
            
            MID2.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[8]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void MFBT3_Click(object sender, EventArgs e)
        {
            
            MID3.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[9]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void MFBT4_Click(object sender, EventArgs e)
        {
            
            MID4.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[10]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void MFBT5_Click(object sender, EventArgs e)
        {
            
            MID5.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[11]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void SBT1_Click(object sender, EventArgs e)
        {
           
            ATT1.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[12]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void SBT2_Click(object sender, EventArgs e)
        {
            
            ATT2.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[13]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void SBT3_Click(object sender, EventArgs e)
        {
            
           ATT3.Load(path + "download (1) (1).png");
            C1.RemovePlayer(FTID, Team[14]);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            Form2 PLayerView = new Form2(FTID, Team);
            PLayerView.Show();

        }
    }
}
