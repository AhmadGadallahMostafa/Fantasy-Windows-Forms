using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy
{
    public partial class adminPlayersView : Form
    {
        Controller ControllerObj;
        public adminPlayersView()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            dataGridView1.DataSource = ControllerObj.getFootBallerForAdmin();
            DataTable ClubNames = ControllerObj.GetClubsNames();
            ClubsComboBox.DataSource = ClubNames;
            ClubsComboBox.DisplayMember = "Club_name";
            ClubComboBoxForDataGridView.DataSource = ClubNames;
            ClubComboBoxForDataGridView.DisplayMember = "Club_name";
            styleDataGrid();
            dataGridView1.ClearSelection();
            posComboBox.DataSource = new List<String> { "GoalKeepers", "Defenders", "Midfielders", "Forwards" };
            comboBox1.DataSource = new List<String> {  "Club" };
        }

        private void ClubsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminPlayersView_Load(object sender, EventArgs e)
        {
            firstNameWarning.Visible = false;
            LastNameWarning.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void styleDataGrid()
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.SkyBlue;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 15);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Height = 70;
            //dataGridView1.Columns.Width = 100;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 18);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ClearSelection();
        }
        private bool validateInput()
        {
            bool firstName = true;
            bool lastName = true;
            if (Validations.EmptyInputField(firstNameTextBox.Text))
            {
                firstName = false;
            }
            if (Validations.EmptyInputField(lastNameTextBox.Text))
            {
                lastName = false;
            }
            if (firstName && lastName )
            {
                return true;
            }
            else
            {
                return false;
            }
                    
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            if (!validateInput())
            {
                firstNameWarning.Visible = true;
                LastNameWarning.Visible = true;
            }
            else
            {
                //Get Club First 
                int clubID = ControllerObj.getClubIdByName(ClubsComboBox.Text);
                //adding the player
                int flag = ControllerObj.addFootballerStoredProc(clubID,firstNameTextBox.Text,
                    lastNameTextBox.Text,posComboBox.SelectedIndex,(int)priceNumeric.Value, (int)AgeNumeric.Value, (int)PointsNumeric.Value);
                if (flag == 1 )
                {
                    MessageBox.Show("Player Added");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ControllerObj.GetFootBallersByClubNameForDelete(ClubComboBoxForDataGridView.Text);
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void ClubComboBoxForDataGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ControllerObj.GetFootBallersByClubNameForDelete(ClubComboBoxForDataGridView.Text);
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Please Select a player");
            }
            else
            {
                string fname = dataGridView1.SelectedCells[0].Value.ToString();
                string lname = dataGridView1.SelectedCells[1].Value.ToString();
                int flag = ControllerObj.deletePlayerByNames(fname, lname);
                if (flag == 1)
                {
                    MessageBox.Show("deleted");
                    dataGridView1.DataSource = ControllerObj.GetFootBallersByClubNameForDelete(ClubComboBoxForDataGridView.Text);
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed");

                }



            }

        }
    }
}
