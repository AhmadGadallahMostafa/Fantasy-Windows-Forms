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
    public partial class AnalystRequests : Form
    {
        AccountController controlObj;
        public AnalystRequests()
        {
            controlObj = new AccountController();
            InitializeComponent();
        }

        private void AnalystRequests_Load(object sender, EventArgs e)
        {
            DataTable dt = controlObj.GetAnalysRequests();
            if (dt == null)
            {
                label3.Visible = true;
                dataGridView1.Visible = false;

                return;
            }
            else
            {
                label3.Visible = false;
                dataGridView1.DataSource = dt;
               
                dataGridView1.ClearSelection();
                styleDataGrid();
                dataGridView1.Refresh();
            }
        }
        
        private void styleDataGrid()
        {
            dataGridView1.Columns[0].HeaderText = "Email";
            dataGridView1.Columns[1].HeaderText = "Birth Date";
            dataGridView1.Columns[2].HeaderText = "Gender";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Please Select a request");
            }
            else
            {
                string email = dataGridView1.SelectedCells[0].Value.ToString();
                controlObj.AcceptRequest(email);
               

               
            }
            this.AnalystRequests_Load(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Please Select a request");
            }
            else
            {
                string email = dataGridView1.SelectedCells[0].Value.ToString();
                controlObj.DenyRequest(email);
                
            }
            this.AnalystRequests_Load(this, EventArgs.Empty);

        }
    }
}
