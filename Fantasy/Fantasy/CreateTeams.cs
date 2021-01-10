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
    public partial class CreateTeams : Form
    {

        Controller C1 = new Controller();

        int ChosenPlayerNo = -1;
        string[] Team = new string[15];
        int FTID;
        bool found = false;

        string path = Path.Combine(Directory.GetCurrentDirectory(), @"Images/");

        public CreateTeams(int FT)
        {
            InitializeComponent();
            FTID = FT;
            styleDataGrid();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            C1.SetFunds(FTID);
            textBox1.Text = C1.GetTeamFunds(FTID).ToString();
        }
        private void styleDataGrid()
        {

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.RowTemplate.Height = 70;
            //dataGridView1.Columns.Width = 100;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ClearSelection();
        }



        
            
        private void GK1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetGK();

           

            ChosenPlayerNo = 0;

        }
        private void GK2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetGK();

            

            ChosenPlayerNo = 1;
        }

        private void DEF1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();

           

            ChosenPlayerNo = 2;

        }

        private void DEF2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();

            

            ChosenPlayerNo = 3;
        }

        private void DEF3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();

           

            ChosenPlayerNo = 4;
        }

        private void DEF4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();
            ChosenPlayerNo = 5;
        }

        private void DEF5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetDefender();

          

            ChosenPlayerNo = 6;

        }

        private void MID1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

            

            ChosenPlayerNo = 7;

        }

        private void MID2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

           

            ChosenPlayerNo = 8;
        }

        private void MID3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

            

            ChosenPlayerNo = 9;
        }

        private void MID4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

            

            ChosenPlayerNo = 10;
        }

        private void MID5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetMidFielder();

           

            ChosenPlayerNo = 11;

        }

        private void ATT1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetStriker();

            

            ChosenPlayerNo = 12;
        }

        private void ATT2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetStriker();

           

            ChosenPlayerNo = 13;
        }

        private void ATT3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C1.GetStriker();

            

            ChosenPlayerNo = 14;
        }



        private void GKBT1_Click(object sender, EventArgs e)
        {

            if (Team[0] != null)
            {

                GK1.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[0]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[0]));
                Team[0] = null;
            }
        }

        private void GKBT2_Click(object sender, EventArgs e)
        {
            if (Team[11] != null)
            {


                GK2.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[11]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[11]));

                Team[11] = null;
            }

        }

        private void DBT1_Click(object sender, EventArgs e)
        {
            if (Team[1] != null)
            {


                DEF1.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[1]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[1]));

                Team[1] = null;
            }
        }

        private void DBT2_Click(object sender, EventArgs e)
        {
            if (Team[2] != null)
            {


                DEF2.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[2]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[2]));

                Team[2] = null;
            }
        }

        private void DBT3_Click(object sender, EventArgs e)
        {
            if (Team[3] != null)
            {


                DEF3.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[3]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[3]));

                Team[3] = null;
            }
        }

        private void DBT4_Click(object sender, EventArgs e)
        {
            if (Team[4] != null)
            {


                DEF4.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[4]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[4]));

                Team[4] = null;

            }
        }

        private void DBT5_Click(object sender, EventArgs e)
        {
            if (Team[12] != null)
            {


                DEF5.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[12]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[12]));

                Team[12] = null;
            }
        }

        private void MFBT1_Click(object sender, EventArgs e)
        {
            if (Team[5] != null)
            {

                MID1.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[5]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[5]));

                Team[5] = null;
            }
        }

        private void MFBT2_Click(object sender, EventArgs e)
        {
            if (Team[6] != null)
            {

                MID2.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[6]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[6]));

                Team[6] = null;
            }
        }

        private void MFBT3_Click(object sender, EventArgs e)
        {
            if (Team[7] != null)
            {

                MID3.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[7]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[7]));

                Team[7] = null;
            }
        }

        private void MFBT4_Click(object sender, EventArgs e)
        {
            if (Team[8] != null)
            {


                MID4.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[8]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[8]));

                Team[8] = null;
            }
        }

        private void MFBT5_Click(object sender, EventArgs e)
        {
            if (Team[13] != null)
            {


                MID5.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[13]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[13]));

                Team[13] = null;
            }
        }

        private void SBT1_Click(object sender, EventArgs e)
        {
            if (Team[9] != null)
            {

                ATT1.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[9]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[9]));

                Team[9] = null;
            }
        }

        private void SBT2_Click(object sender, EventArgs e)
        {
            if (Team[10] != null)
            {


                ATT2.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[10]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[10]));

                Team[10] = null;

            }
        }

        private void SBT3_Click(object sender, EventArgs e)
        {
            if (Team[14] != null)
            {


                ATT3.Load(path + "download (1) (1).png");
                C1.RemovePlayer(FTID, Team[14]);
                textBox1.Text = C1.GetTeamFunds(FTID).ToString();
                C1.DeletePlayer(FTID, C1.GetPlayerId(Team[14]));

                Team[14] = null;
            }
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            PlayerView PLayerView = new PlayerView(FTID);
            PLayerView.Show();
            string TeamName = teamName.Text;
            C1.SetTeamName(FTID, TeamName);

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validations.EmptyInputField(teamName.Text))
            {
                enternamewarning.Visible = true;
            }
            else
            {
                
                
                string TeamName = teamName.Text;
                C1.SetTeamName(FTID, TeamName);
                this.Close();

            }
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

        private void addPlayer_Click_1(object sender, EventArgs e)
        {
            string PlayerName = dataGridView1.SelectedCells[0].Value.ToString();

            if (dataGridView1.CurrentCell == null) 
            {
                MessageBox.Show("Please Select a player!");
                return;
            }
            for (int i = 0; i < 14; i++)
            {
                if (PlayerName == Team[i])
                {
                    found = true;
                }
            }
            if (found == false)
            {
              
                if (C1.GetTeamFunds(FTID) > C1.GetPrice(PlayerName))
                {

                    if (ChosenPlayerNo == 0)
                    {


                        GK1.Load(path + PlayerName + ".png");
                        Team[0] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                        
                    }
                    else if (ChosenPlayerNo == 1)
                    {
                        GK2.Load(path + PlayerName + ".png");
                        Team[11] = PlayerName;
                        C1.BuyingOutPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();


                    }
                    else if (ChosenPlayerNo == 2)
                    {
                        DEF1.Load(path + PlayerName + ".png");
                        Team[1] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();


                    }
                    else if (ChosenPlayerNo == 3)
                    {
                        DEF2.Load(path + PlayerName + ".png");
                        Team[2] = PlayerName;

                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 4)
                    {
                        DEF3.Load(path + PlayerName + ".png");
                        Team[3] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 5)
                    {
                        DEF4.Load(path + PlayerName + ".png");
                        Team[4] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 6)
                    {
                        DEF5.Load(path + PlayerName + ".png");
                        Team[12] = PlayerName;
                        C1.BuyingOutPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 7)
                    {
                        MID1.Load(path + PlayerName + ".png");
                        Team[5] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 8)
                    {
                        MID2.Load(path + PlayerName + ".png");
                        Team[6] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 9)
                    {
                        MID3.Load(path + PlayerName + ".png");
                        Team[7] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 10)
                    {
                        MID4.Load(path + PlayerName + ".png");
                        Team[8] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 11)
                    {
                        MID5.Load(path + PlayerName + ".png");
                        Team[13] = PlayerName;
                        C1.BuyingOutPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 12)
                    {
                        ATT1.Load(path + PlayerName + ".png");
                        Team[9] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 13)
                    {
                        ATT2.Load(path + PlayerName + ".png");
                        Team[10] = PlayerName;
                        C1.BuyingInPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                    else if (ChosenPlayerNo == 14)
                    {
                        ATT3.Load(path + PlayerName + ".png");
                        Team[14] = PlayerName;
                        C1.BuyingOutPLayer(FTID, PlayerName);
                        textBox1.Text = C1.GetTeamFunds(FTID).ToString();

                    }
                }
                else
                {
                    MessageBox.Show("you dont have enough money");
                }
            }
            found = false;
        }

        private void PlayersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
