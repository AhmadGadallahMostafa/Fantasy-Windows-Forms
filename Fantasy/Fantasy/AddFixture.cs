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
    public partial class AddFixture : Form
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), @"Images/Clubs/");
        Controller controlObj;
        public AddFixture()
        {
            InitializeComponent();
            controlObj = new Controller();
        }

        private void AddFixture_Load(object sender, EventArgs e)
        {
            DataTable dt = controlObj.GetClubsInLeague();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Club_Name";
            comboBox1.Refresh();

            DataTable dt2 = controlObj.GetClubsInLeague();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Club_Name";
            comboBox2.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GuestBox.Load(path + comboBox2.Text + ".png");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HomeBox.Load(path + comboBox1.Text + ".png");
        }
    }
}
