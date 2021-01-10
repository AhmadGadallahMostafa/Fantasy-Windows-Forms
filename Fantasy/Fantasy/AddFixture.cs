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
        IEnumerable<Week> weeks;

        string[] clubs = new string[20];
        string[] clubs2 = new string[20];



        public AddFixture()
        {
            InitializeComponent();
            controlObj = new Controller();

        }
        private IEnumerable<Week> ConvertToWeeks(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                yield return new Week
                {
                    Week_Number = Convert.ToInt32(row["Week_Number"]),
                    Season_Number = Convert.ToInt32(row["Season_Number"]),
                    Start_Date = (DateTime)(row["Start_Date"]),
                    End_Date =(DateTime)(row["End_Date"]),
                   

                };
            }

        }
        private void AddFixture_Load(object sender, EventArgs e)
        {
            
             
            DataTable dt = controlObj.GetClubsName();
          
           

          
            int count1 = dt.Rows.Count;
            if (count1 > 0)
            {
               
                for (int i = 0; i < count1; i++)
                {
                    clubs[i] = dt.Rows[i][0].ToString();
                
                    
                }
            }
            int count2 = dt.Rows.Count;
            if (count2 > 0)
            {

                for (int i = 0; i < count2; i++)
                {
                    clubs2[i] = dt.Rows[i][0].ToString();


                }
            }
            comboBox1.DataSource = clubs;
            comboBox2.DataSource = clubs2;
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GuestBox.Load(path + comboBox2.Text + ".png");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HomeBox.Load(path + comboBox1.Text + ".png");
        }
        
        private void AddFix_Click(object sender, EventArgs e)
        {
            if ((int)controlObj.getWeekCount()%10==0)
            {
                controlObj.InsertSeason(dateTimePicker1.Value.Year.ToString());
            }
            int weekNumber = 0;
            int season = 0;
            if (comboBox1.Text == "" && comboBox2.Text == "")
            {
                MessageBox.Show("No more clubss");
                return;
            }
            int hostId= controlObj.getClubIdByName(comboBox1.Text);
            int guestID =controlObj.getClubIdByName(comboBox2.Text);
           
            if (hostId == guestID)
            {
                Error.Visible = true;
                return;
            }
            else { Error.Visible = false; }
            
            DateTime endDate = dateTimePicker1.Value.AddDays(7);
            DataTable weeksData = controlObj.GetWeeks();
            if (weeksData != null)
            {
                weeks = ConvertToWeeks(weeksData);
                foreach (Week w in weeks)
                {
                    if (dateTimePicker1.Value > w.Start_Date && dateTimePicker1.Value < w.End_Date) // there are weeks and the date entered is in w 
                    {
                        weekNumber = w.Week_Number;
                        season = w.Season_Number;
                        if (controlObj.InsertFixture(hostId, guestID, weekNumber, season, "N/A") != 0)
                        {
                            var AvailableClubs1 = new List<string>(clubs);
                            var AvailableClubs2 = new List<string>(clubs2);

                            AvailableClubs1.Remove(comboBox1.Text);
                            AvailableClubs1.Remove(comboBox2.Text);
                            AvailableClubs2.Remove(comboBox1.Text);
                            AvailableClubs2.Remove(comboBox2.Text);

                            comboBox1.DataSource = AvailableClubs1;
                            comboBox2.DataSource = AvailableClubs2;
                            clubs = AvailableClubs1.ToArray();
                            clubs2 = AvailableClubs2.ToArray();


                            MessageBox.Show("Fixture added");
                            return;
                        }

                    }

                }
                if (weekNumber == 0) // there are weeks but none correspond to match day
                {
                    controlObj.InsertWeek(dateTimePicker1.Value, endDate.Date);
                     weeksData = controlObj.GetWeeks();
                    weeks = ConvertToWeeks(weeksData);
                    foreach (Week w in weeks)
                    {
                        if (dateTimePicker1.Value > w.Start_Date && dateTimePicker1.Value < w.End_Date) // there are weeks and the date entered is in w 
                        {
                            weekNumber = w.Week_Number;
                            season = w.Season_Number;
                            if (controlObj.InsertFixture(hostId, guestID, weekNumber, season, "N/A") != 0) 
                            {
                                var AvailableClubs1 = new List<string>(clubs);
                                var AvailableClubs2 = new List<string>(clubs2);

                                AvailableClubs1.Remove(comboBox1.Text);
                                AvailableClubs1.Remove(comboBox2.Text);
                                AvailableClubs2.Remove(comboBox1.Text);
                                AvailableClubs2.Remove(comboBox2.Text);


                                comboBox1.DataSource = AvailableClubs1;
                                comboBox2.DataSource = AvailableClubs2;

                                clubs = AvailableClubs1.ToArray();
                                clubs2 = AvailableClubs2.ToArray();
                                MessageBox.Show("Fixture added");
                                return;
                            }
                            

                        }

                    }
                }
            }
            else// this is the first week to be added 
            {
                
                controlObj.InsertWeek(dateTimePicker1.Value, endDate.Date);
                weeksData = controlObj.GetWeeks();
                weeks = ConvertToWeeks(weeksData);
                foreach (Week w in weeks)
                {
                    if (dateTimePicker1.Value > w.Start_Date && dateTimePicker1.Value < w.End_Date) // there are weeks and the date entered is in w 
                    {
                        weekNumber = w.Week_Number;
                        season = w.Season_Number;
                        if (controlObj.InsertFixture(hostId, guestID, weekNumber, season, "N/A") != 0)
                        {
                            var AvailableClubs1 = new List<string>(clubs);
                            var AvailableClubs2 = new List<string>(clubs2);

                            AvailableClubs1.Remove(comboBox1.Text);
                            AvailableClubs1.Remove(comboBox2.Text);
                            AvailableClubs2.Remove(comboBox1.Text);
                            AvailableClubs2.Remove(comboBox2.Text);


                            comboBox1.DataSource = AvailableClubs1;
                            comboBox2.DataSource = AvailableClubs2;
                            clubs = AvailableClubs1.ToArray();
                            clubs2 = AvailableClubs2.ToArray();
                            MessageBox.Show("Fixture added");
                            return;

                        }

                    }

                }
            }

            





        }

     

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
