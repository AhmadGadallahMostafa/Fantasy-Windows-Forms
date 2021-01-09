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
            lw.BringToFront();
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
    }
}
