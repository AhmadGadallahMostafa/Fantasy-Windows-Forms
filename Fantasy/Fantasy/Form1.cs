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
    public partial class Form1 : Form
    {
        string SignInAsAdmin = "";
        string SignInAsUser = "";
        string SignInAsJourn = "";

        int userId;

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;

        private void openSignedInForm(Sign_InForm childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.SignedIn_AsAdmin += OnSignedIn_AsAdmin;
            childForm.SignedIn_AsUser += OnSignedIn_AsUser;
            childForm.SignedIn_AsJourn += OnSignedIn_AsJourn;
        }

       


     
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        protected void OnSignedIn_AsAdmin(object sender,string email)
        {
            SignInAsAdmin = email;
            label3.Text = $"Signed In as {SignInAsAdmin}";
            SignInButton.Text = "Sign Out";
        }
        protected void OnSignedIn_AsUser(object sender, string userName)
        {
            SignInAsUser = userName;
            label3.Text = $"Signed In as {SignInAsUser}";
            SignInButton.Text = "Sign Out";
        }
        protected void OnSignedIn_AsJourn(object sender, string userName)
        {
            SignInAsJourn = userName;
            label3.Text = $"Signed In as {SignInAsJourn}";
            SignInButton.Text = "Sign Out";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (SignInAsUser!="" || SignInAsAdmin!="" || SignInAsJourn!="")
            {
                SignInAsJourn = "";
                SignInAsAdmin = "";
                SignInAsUser = "";
                SignInButton.Text = "Sign In";
                label3.Text="";
            }
            else 
            { 
                openSignedInForm(new Sign_InForm());
            }
        }

        ~Form1()
        {
            this.Close();
        }

        private void ClubsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ClubsForm(true));
        }

        private void FixturesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new FixturesForm());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new PlayersForm());
        }

        private void TablesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new TablesForm());
        }
    }
}
