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
        SignInController SignController;
        bool SignedIn;
        
        public Form1()
        {
            InitializeComponent();
            SignController = new SignInController();
            // SignedIn = (bool)SignController.GetSignedIn();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;

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

        

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Sign_InForm());
        }

      
        ~Form1()
        {
            this.Close();
        }

        private void ClubsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ClubsForm());
        }

       
    }
}
