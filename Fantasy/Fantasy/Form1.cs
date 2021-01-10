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

        bool AsAdmin;
        Controller ControllerObj;
        AccountController AccountController;
        public Form1()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            AccountController = new AccountController();
            teamButton.Visible = false;
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
            childForm.SignedUp2 += OnSignedUp2;
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

        private void openClubsForm(ClubsForm childForm)
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
            childForm.RemovedClub += OnRemovedClub;
            childForm.AddedClub2 += OnAddedClub;

        }
        private void openAdminViewsForm(adminFixturesForm childForm)
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
            childForm.RefreshFixtures += OnRefreshFixtures;


        }
        protected void OnRefreshFixtures(object sender, EventArgs e)
        {
            activeForm.Close();
            this.openAdminViewsForm(new adminFixturesForm());
        }
        protected void OnSignedUp2(object sender, string userName)
         {
            activeForm.Close();
            SignInAsUser = userName;
            AsAdmin = false;
            label3.Text = $"Signed In as {SignInAsUser}";
            SignInButton.Text = "Sign Out";
            int playerID = ControllerObj.getUserTeamId(userName);
            teamButton.Visible = true;
            this.openChildForm(new CreateTeams(playerID));
        }
   
   
        protected void OnSignedIn_AsAdmin(object sender,string email)
        {
            SignInAsAdmin = email;
            AsAdmin = true;
            label3.Text = $"Signed In as {SignInAsAdmin}";
            SignInButton.Text = "Sign Out";
            changePassword.Visible = true;
            button1.Visible = true;
        }
        protected void OnSignedIn_AsUser(object sender, string userName)
        {
            SignInAsUser = userName;
            AsAdmin = false;
            label3.Text = $"Signed In as {SignInAsUser}";
            SignInButton.Text = "Sign Out";
            int playerID = ControllerObj.getUserTeamId(userName);
            teamButton.Visible = true;
            changePassword.Visible = true;
            //openChildForm(new PlayerView(playerID));
        }
        protected void OnSignedIn_AsJourn(object sender, string userName)
        {
            SignInAsJourn = userName;
            AsAdmin = false;
            label3.Text = $"Signed In as {SignInAsJourn}";
            SignInButton.Text = "Sign Out";
        }
       

        protected void OnRemovedClub(object sender,EventArgs e)
        {
           
          activeForm.Close();
          this.openClubsForm(new ClubsForm());

        }
        protected void OnAddedClub(object sender, EventArgs e)
        {

            activeForm.Close();
            this.openClubsForm(new ClubsForm());

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
                AsAdmin = false;
                teamButton.Visible = false;
                changePassword.Visible = false;
                button1.Visible = false;
                activeForm.Close();

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

            if (AsAdmin)
            {
                openClubsForm(new ClubsForm());

            }
            else openChildForm(new ClubsUser());
      
        }

        private void FixturesButton_Click(object sender, EventArgs e)
        {
            if (AsAdmin)
            {
                 openAdminViewsForm(new adminFixturesForm());
            }
            else
            {
                openChildForm(new FixturesForm());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayersButton_Click(object sender, EventArgs e)
        {
            if (AsAdmin)
            {
                openChildForm(new adminPlayersView());  
            }
            else openChildForm(new PlayersForm());

        }

        private void TablesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new TablesForm());
        }

        private void childPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teamButton_Click(object sender, EventArgs e)
        {
            int id = ControllerObj.getUserTeamId(SignInAsUser);
            openChildForm(new PlayerView(id));
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            if (AsAdmin)
            {
                string email = AccountController.getEmailFromUserName(SignInAsAdmin);
                openChildForm(new changePasswordForm(email));
            }
            else
            {
                string email = AccountController.getEmailFromUserName(SignInAsUser);
                openChildForm(new changePasswordForm(email));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AnalystRequests a= new AnalystRequests();
            a.Show();
        }
    }
}
