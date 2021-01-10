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

    public partial class MyLeagues : Form
    {
        List<Fantasy_League> Leagues;
        Controller C1 = new Controller();
        int FTID;
        public MyLeagues(int FantasyTeamId)
        {
            InitializeComponent();
            FTID = FantasyTeamId;
            styleDataGrid();
        }

        private void MyLeagues_Load(object sender, EventArgs e)
        {
            DataTable dt1= C1.LeaguesName(FTID);
            if (dt1 != null)
            {
                /*Leagues = new List<Fantasy_League>();
                Leagues = (from DataRow dr in dt1.Rows
                           select new Fantasy_League()
                           {
                               League_Id = (int)dr["League_Id"],
                               League_Name = dr["League_Name"].ToString(),
                               Country = dr["Country"].ToString(),
                           }).ToList();*/
                if (dt1 == null)
                {
                    label2.Visible = true;
                }
                else
                {
                    int count = dt1.Rows.Count;
                    if (count > 0)
                    {
                        //listView1.Items.Clear();
                        listBox1.Items.Clear();
                        label2.Visible = false;
                        for (int i = 0; i < count; i++)
                        {
                            //listView1.Items.Add(dt);
                            listBox1.Items.Add(dt1.Rows[i][0].ToString());
                        }
                    }
                }

            }
        }

        private void ViewLeague_Click(object sender, EventArgs e)
        {
            string L1 = listBox1.GetItemText(listBox1.SelectedItem);
            dataGridView1.DataSource = C1.LeagueStandings(L1);
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //dataGridView1.RowTemplate.Height = 70;
            //dataGridView1.Columns.Width = 100;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ClearSelection();
           
        }
    }
}
