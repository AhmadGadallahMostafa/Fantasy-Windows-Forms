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

            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Images/Clubs/");
            

            ClubName.Text = Club.Name;
            clubPointsLabel.Text = Club.Points.ToString();
            ManagerLabel.Text = Club.ManagerName;
            FoundationLabel.Text = Club.FoundationDate;
            StadiumLabel.Text = Club.StadiumName;
            clubRankLabel.Text = Club.Rank.ToString();
            ClubPicture.Load(path + Club.Name + ".png");
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
    }
}
