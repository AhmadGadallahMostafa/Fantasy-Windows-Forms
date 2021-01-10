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
    public partial class ClubsInfoForms : Form
    {
        Club Club;
        Controller ControllerObj;
        List<Footballer> List;
        public ClubsInfoForms( )
        {
            InitializeComponent();
        }

        public ClubsInfoForms(Club c)
        {
            InitializeComponent();
            Club = c;
            
        }

        private void ClubsInfoForms_Load(object sender, EventArgs e)
        {

            string ClubsPath = Path.Combine(Directory.GetCurrentDirectory(), @"Images/Clubs/");
            string PlayerPath = Path.Combine(Directory.GetCurrentDirectory(), @"Images/");

            ClubName.Text = Club.Name;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            clubPointsLabel.Text = Club.Points.ToString();
            ManagerLabel.Text = Club.ManagerName;
            FoundationLabel.Text = Club.FoundationDate;
            StadiumLabel.Text = Club.StadiumName;
            clubRankLabel.Text = Club.Rank.ToString();
            ClubPicture.Load(ClubsPath + Club.Name + ".png");
            gk.Load(PlayerPath + Club.Footballers[0].Last_Name + ".png");
            gklabel.Text = Club.Footballers[0].Last_Name;
            lb.Load(PlayerPath + Club.Footballers[1].Last_Name + ".png");
            lbLabel.Text = Club.Footballers[1].Last_Name;
            cb1.Load(PlayerPath + Club.Footballers[2].Last_Name + ".png");
            cb1Label.Text = Club.Footballers[2].Last_Name;
            cb2.Load(PlayerPath + Club.Footballers[3].Last_Name + ".png");
            cb2label.Text = Club.Footballers[3].Last_Name;
            rb.Load(PlayerPath + Club.Footballers[4].Last_Name + ".png");
            rblabel.Text = Club.Footballers[4].Last_Name;
            cdm.Load(PlayerPath + Club.Footballers[5].Last_Name + ".png");
            cdmlabel.Text = Club.Footballers[5].Last_Name;
            cm1.Load(PlayerPath + Club.Footballers[6].Last_Name + ".png");
            cm1label.Text = Club.Footballers[6].Last_Name;
            cm2.Load(PlayerPath + Club.Footballers[7].Last_Name + ".png");
            cm2label.Text = Club.Footballers[7].Last_Name;
            lw.Load(PlayerPath + Club.Footballers[8].Last_Name + ".png");
            lwlabel.Text = Club.Footballers[8].Last_Name;
            st.Load(PlayerPath + Club.Footballers[9].Last_Name + ".png");
            stlabel.Text = Club.Footballers[9].Last_Name;
            rw.Load(PlayerPath + Club.Footballers[10].Last_Name + ".png");
            rwlabel.Text = Club.Footballers[10].Last_Name;
            rw.BringToFront();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ClubPicture_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gklabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.premierleague.com/");
        }
    }
}
