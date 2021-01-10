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
        Controller C1 = new Controller();
        int FTID;
        public MyLeagues(int FantasyTeamId)
        {
            InitializeComponent();
            FTID = FantasyTeamId;
        }

        private void MyLeagues_Load(object sender, EventArgs e)
        {
           DataTable dt1= C1.LeaguesName(FTID);
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

        private void ViewLeague_Click(object sender, EventArgs e)
        {
            string L1 = listBox1.GetItemText(listBox1.SelectedItem);
            dataGridView1.DataSource = C1.LeagueStandings(L1);
            dataGridView1.Refresh();
        }
    }
}
