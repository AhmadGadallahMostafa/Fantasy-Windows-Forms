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
        public ClubsForm()
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

        }

        private void ClubsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Club c = ControllerObj.GetClub(Arsenal.Name);
            this.openChildForm(new ClubsInfoForms(c));
        }


        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Club c = ControllerObj.GetClub(ManchesterUnited.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Club c = ControllerObj.GetClub(mancity.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Club c = ControllerObj.GetClub(Chelsea.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));
        }

        private void Liverpool_Click(object sender, EventArgs e)
        {
            Club c = ControllerObj.GetClub(Liverpool.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Club c = ControllerObj.GetClub(Spurs.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));
        }
    }
}
