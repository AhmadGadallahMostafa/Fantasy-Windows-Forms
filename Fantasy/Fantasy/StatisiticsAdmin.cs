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
    public partial class StatisiticsAdmin : Form
    {
        Controller controlObj;
        public StatisiticsAdmin()
        {
            InitializeComponent();
            controlObj = new Controller();
        }

        private void StatisiticsAdmin_Load(object sender, EventArgs e)
        {
           DataTable mostTransferedIn = controlObj.getMostTransferedInFootballer();
           
           if (mostTransferedIn != null) 
           {
                dataGridView1.DataSource = mostTransferedIn;
                dataGridView1.Refresh();
                styleDataGrid1();
           }
           else 
           {
                dataGridView1.Visible = true;

           }
            DataTable mostTransferedOut = controlObj.getMostTransferedOutFootballer();

            if (mostTransferedIn != null)
            {
                dataGridView2.DataSource = mostTransferedOut;
                dataGridView2.Refresh();
                styleDataGrid2();
            }
            else
            {
                dataGridView2.Visible = true;

            }
            DataTable topTeams = controlObj.getHighestPointsTeams();

            if (topTeams != null)
            {
                dataGridView3.DataSource = topTeams;
                dataGridView3.Refresh();
                styleDataGrid3();
            }
            else
            {
                dataGridView3.Visible = true;

            }
            DataTable popularLeagues = controlObj.getHighestParticpatingLeagues();

            if (popularLeagues != null)
            {
                dataGridView4.DataSource = popularLeagues;
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
        private void styleDataGrid2()
        {
            dataGridView2.Columns[0].HeaderText = "First Name";
            dataGridView2.Columns[1].HeaderText = "Last Name";

            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.BackgroundColor = Color.SkyBlue;
            dataGridView2.DefaultCellStyle.Font = new Font("Calibri", 15);
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.RowTemplate.Height = 70;
            //dataGridView2.Columns.Width = 100;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 18);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.ClearSelection();
        }
        private void styleDataGrid3()
        {
            dataGridView3.Columns[0].HeaderText = "Team Name";
            dataGridView3.Columns[1].HeaderText = "Total Points";

            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView3.BackgroundColor = Color.SkyBlue;
            dataGridView3.DefaultCellStyle.Font = new Font("Calibri", 15);
            dataGridView3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.RowTemplate.Height = 70;
            //dataGridView3.Columns.Width = 100;
            dataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 18);
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.ClearSelection();
        }
        private void styleDataGrid4()
        {
            dataGridView4.Columns[0].HeaderText = "First Name";
            dataGridView4.Columns[1].HeaderText = "Last Name";

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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
