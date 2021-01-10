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
    public partial class adminFixturesForm : Form
    {
        Controller ControllerObj;
        public adminFixturesForm()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

     
        private void styleDataGrid()
        {
            dataGridView1.Columns[0].HeaderText = "Host Name";
            dataGridView1.Columns[1].HeaderText = "Score";
            dataGridView1.Columns[2].HeaderText = "Guest Name";
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

        private void AddFixture_Click(object sender, EventArgs e)
        {
           openChildForm( new AddFixture());
        }
        private Form activeForm = null;
        private void openScores(EnterScores childForm)
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
            childForm.UpdatedFixture += OnUpdatedFixture;


        }
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
        public event EventHandler RefreshFixtures;
        protected void OnUpdatedFixture(object sender, EventArgs e)
        {
            RefreshFixtures?.Invoke(this, EventArgs.Empty);
        }
        private void EnterScore_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Please Select a Fixture");
            }
            else
            {
                string Home = dataGridView1.SelectedCells[0].Value.ToString();
                
                string Away = dataGridView1.SelectedCells[2].Value.ToString();
                openScores(new EnterScores(Home, Away, (int)numericUpDown1.Value));
                this.adminFixturesForm_Load_1(this, EventArgs.Empty);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetFixturesByWeek((int)numericUpDown1.Value);
            if (dt != null)
            {
                label3.Visible = false;
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                styleDataGrid();
                dataGridView1.Refresh();
                dataGridView1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
                label3.Visible = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminFixturesForm_Load_1(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            dataGridView1.DataSource = ControllerObj.GetFixturesByWeek(1);

            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
            styleDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
