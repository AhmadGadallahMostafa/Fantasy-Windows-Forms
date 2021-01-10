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
    public partial class PlayersForm : Form
    {
        Controller ControllerObj;
        public PlayersForm()
        {
            InitializeComponent();
            comboBox1.DataSource = new List<String> {"Points", "Club", "Poisition" };
            ControllerObj = new Controller();
            dataGridView1.DataSource = ControllerObj.GetFootBallersByPoints();
            styleDataGrid();
            DataTable ClubNames = ControllerObj.GetClubsNames();
            ClubsComboBox.DataSource = ClubNames;
            ClubsComboBox.DisplayMember = "Club_name";
            dataGridView1.ClearSelection();
            posComboBox.DataSource = new List<String> {  "GoalKeepers" , "Defenders", "Midfielders", "Forwards" };
            posComboBox.Visible = false;
            poslabel.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            ClubsComboBox.Visible = false;
            ClubsLabel.Visible = false;
            comboBox1.DataSource = new List<String> { "Points", "Club","Position" };
            ControllerObj = new Controller();
            dataGridView1.DataSource = ControllerObj.GetFootBallersByPoints();
            styleDataGrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 )
            {
               dataGridView1.DataSource = ControllerObj.GetFootBallersByPoints();
                dataGridView1.ClearSelection();
                ClubsLabel.Visible = false;
                ClubsComboBox.Visible = false;
                posComboBox.Visible = false;
                poslabel.Visible = false;
                styleDataGrid();
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                ClubsLabel.Visible = true;
                ClubsComboBox.Visible = true;
                dataGridView1.DataSource = ControllerObj.GetFootBallersByClubName(ClubsComboBox.Text);
                dataGridView1.ClearSelection();
                dataGridView1.Refresh();
                posComboBox.Visible = false;
                poslabel.Visible = false;
            }
            else
            {
                ClubsLabel.Visible = false;
                ClubsComboBox.Visible = false;
                posComboBox.Visible = true;
                poslabel.Visible = true;
                dataGridView1.DataSource = ControllerObj.getPlayerByPos(posComboBox.SelectedIndex);
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();
            }
        }
        private void styleDataGrid()
        {
            dataGridView1.Columns[0].HeaderText = "Last Name";
            dataGridView1.Columns[1].HeaderText = "Points";
            dataGridView1.Columns[2].HeaderText = "Price";
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

        private void ClubsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClubsLabel.Visible = true;
            ClubsComboBox.Visible = true;
            dataGridView1.DataSource = ControllerObj.GetFootBallersByClubName(ClubsComboBox.Text);
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ControllerObj.getPlayerByPos(posComboBox.SelectedIndex);
            dataGridView1.ClearSelection();
        }
    }
}
