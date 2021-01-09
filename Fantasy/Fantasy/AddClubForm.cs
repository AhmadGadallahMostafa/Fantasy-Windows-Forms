using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

using System.IO;


namespace Fantasy
{
    public partial class AddClubForm : Form
    {
        Controller controlObj;
        public AddClubForm()
        {
            
            InitializeComponent();
            controlObj = new Controller();
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validations.EmptyInputField(URLb.Text))
            {
                UrlField.Visible = true;
                return;
            }
            else
            {
                UrlField.Visible = false;
            }
            using (WebClient client = new WebClient())
            {

                client.DownloadFile(new Uri(URLb.Text), Path.Combine(Directory.GetCurrentDirectory(), $@"Images/Clubs/{textBox5.Text}.png"));
             
            }
            pictureBox1.Load(Path.Combine(Directory.GetCurrentDirectory(), $@"Images/Clubs/{textBox5.Text}.png"));


         
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddClub_Click(object sender, EventArgs e)
        {

            if (Validations.EmptyInputField(textBox5.Text))
            {
                NameField.Visible = true;
                return;
            }
            else
            {
                NameField.Visible = false;
            }

            if (Validations.EmptyInputField(textBox4.Text))
            {
                StadField.Visible = true;
                return;
            }
            else
            {
                StadField.Visible = false;
            }

            if (Validations.EmptyInputField(textBox3.Text))
            {
                ManagerField.Visible = true;
                return;
            }
            else
            {
                ManagerField.Visible = false;
            }

            if (Validations.EmptyInputField(URLb.Text))
            {
                UrlField.Visible = true;
            }
            else
            {
                UrlField.Visible = false;
            }

            Club club = new Club
            {
                Name = textBox5.Text,
                StadiumName = textBox4.Text,
                ManagerName = textBox3.Text,
                FoundationDate = dateTimePicker1.Value.ToShortDateString()



            };

            if (controlObj.InsertClub(club) != 0)
            {
                // AddedClub?.Invoke(this);

                DataTable dt = controlObj.GetClubs();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Club_Name";
                comboBox1.Refresh();
                //MessageBox.Show("added"); 
            }
        }

        private void ClubName_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler AddedClub1;

        private void AddClubForm_Load(object sender, EventArgs e)
        {
            DataTable dt  =controlObj.GetClubs();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember="Club_Name";
            comboBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlObj.InsertClubInLeague(comboBox1.Text);
            AddedClub1?.Invoke(this,EventArgs.Empty);
            this.Close();
        }
    }
}
