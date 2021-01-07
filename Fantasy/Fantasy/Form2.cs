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
    public partial class Form2 : Form
    {

        int FTID;
        string[] TeamChosen = new string[15];
        string path = Path.Combine(Directory.GetCurrentDirectory(), @"Images/");
       


        public Form2(int FantasyTeamId,string [] Team)
        {
            InitializeComponent();
            FTID = FantasyTeamId;
            TeamChosen = Team;
           



        }



        private void Form2_Load(object sender, EventArgs e)
        {
            
            
             GK1.Load((path + TeamChosen[0] + ".png"));
            GK2.Load(path + TeamChosen[11] + ".png");
            DEF1.Load(path + TeamChosen[1] + ".png");
            DEF2.Load(path + TeamChosen[2] + ".png");
            DEF3.Load(path + TeamChosen[3] + ".png");
            DEF4.Load(path + TeamChosen[4] + ".png");
            DEF5.Load(path + TeamChosen[12] + ".png");
            MID1.Load(path + TeamChosen[5] + ".png");
            MID2.Load(path + TeamChosen[6] + ".png");
            MID3.Load(path + TeamChosen[7] + ".png");
            MID4.Load(path + TeamChosen[8] + ".png");
            MID5.Load(path + TeamChosen[13] + ".png");
            ATT1.Load(path + TeamChosen[9] + ".png");
            ATT2.Load(path + TeamChosen[10] + ".png");
            ATT3.Load(path + TeamChosen[14] + ".png");
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            GK1.Load((path + TeamChosen[11] + ".png"));
            GK2.Load(path + TeamChosen[0] + ".png");



        }
    }
}
