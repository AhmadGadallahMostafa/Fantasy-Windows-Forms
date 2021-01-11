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
    public partial class Statistics : Form
    {
        Controller controlObj;
        public Statistics()
        {
            InitializeComponent();
            controlObj = new Controller();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            DataTable topPlayers = controlObj.HighestPlayer();

            if (topPlayers != null)
            {
                dataGridView1.DataSource = topPlayers;
                dataGridView1.Refresh();
                styleDataGrid1();
            }
            else
            {
                dataGridView1.Visible = true;

            }
            DataTable mostPickedPlayers = controlObj.getMostPickedFootballer();

            if (mostPickedPlayers != null)
            {
                dataGridView4.DataSource = mostPickedPlayers;
                dataGridView4.Refresh();
                styleDataGrid4();
            }
            else
            {
                dataGridView4.Visible = true;

            }
        }
        private void styleDataGrid1()
        {
            dataGridView1.Columns[0].HeaderText = "First Name";
            dataGridView1.Columns[1].HeaderText = "Last Name";
            dataGridView1.Columns[2].HeaderText = "Points";


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
        private void styleDataGrid4()
        {
            dataGridView4.Columns[0].HeaderText = "First Name";
           

            dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView4.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            dataGridView4.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView4.BackgroundColor = Color.SkyBlue;
            dataGridView4.DefaultCellStyle.Font = new Font("Calibri", 15);
            dataGridView4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.RowTemplate.Height = 70;
            //dataGridView4.Columns.Width = 100;
            dataGridView4.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 18);
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
