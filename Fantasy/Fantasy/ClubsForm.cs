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
    public partial class ClubsForm : Form
    {
        Controller ControllerObj;
        Club c;
        public ClubsForm(bool SignedInAsAdmin)
        {
            InitializeComponent();
            ControllerObj = new Controller();

        }
        private Form activeForm = null;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Southampton.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c,true));
        }

        private void ClubsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Arsenal.Name);
            this.openChildForm(new ClubsInfoForms(c, true));
        }


        private void pictureBox13_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(ManchesterUnited.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(mancity.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Chelsea.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void Liverpool_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Liverpool.AccessibleName);
             this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Spurs.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void AstonVilla_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(AstonVilla.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void Brighton_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Brighton.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void Burnely_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Burnely.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void crystal_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(crystal.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void Fulham_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Fulham.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void Leeds_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Leeds.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void LeicesterCity_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(LeicesterCity.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void NewCastle_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(NewCastle.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void Sheffield_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Sheffield.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void WestBromich_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(WestBromich.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void WestHam_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(WestHam.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void Wolves_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Wolves.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }

        private void Everton_Click(object sender, EventArgs e)
        {
             c = ControllerObj.GetClub(Everton.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c, true));
        }
    }
}
