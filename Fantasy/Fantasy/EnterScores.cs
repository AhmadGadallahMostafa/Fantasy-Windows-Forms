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
    public partial class EnterScores : Form
    {
        int HomeGoals = 0;
        int GuestGoals = 0;
        public EnterScores()
        {
            InitializeComponent();
        }

        private void EnterScores_Load(object sender, EventArgs e)
        {

        }

        private void GuestTeam_Click(object sender, EventArgs e)
        {

        }

        private void EnterScore_Click(object sender, EventArgs e)
        {
            int n = 3;
            UserControl1[] controls = new UserControl1[n];

            for (int i = 0; i < n; i++)
            {
                controls[i] = new UserControl1();

                controls[i].SetScoredBy("some value to display in text");
                controls[i].SetLabel2Value("some value to display in label");
                controls[i].GetScoredBy();
                controls[i].GetLabel1Value();
            }

            // This adds the controls to the form (you will need to specify thier co-ordinates etc. first)
          
            for (int i = 0; i < n; i++)
            {
                this.Controls.Add(controls[i]);
               
            }
            controls[1].Location = new Control(controls[1].GetScoredBy(), 49, 318, 150, 150).Location;
            controls[0].Location = new Control("", 200, 50, 20, 50).Location;
            controls[2].Location = new Control("", 300, 50, 30, 50).Location;



        }
    }
}
