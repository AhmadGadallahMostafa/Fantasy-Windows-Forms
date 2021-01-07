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
    public partial class Sign_InForm : Form
    {
        
        enum accountTypes 
        {
            admin=1,
            player=2,
            journalist=3
        }
        SignInController controlObj;
        public Sign_InForm()
        {
            InitializeComponent();
            controlObj = new SignInController();
            
        }

        private void button1_Click(object sender, EventArgs e)
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
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new SignUpForm());
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sign_InForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Validations.ValidEmail(textBox1.Text))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }

            if (Validations.EmptyInputField(textBox2.Text))
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }


            object accountType = controlObj.LoginVerification(textBox1.Text, textBox2.Text);
            if (accountType == null)
            {
                label6.Visible = true;
                return;
            }
            else 
            {
                MessageBox.Show("login");
                label6.Visible = false;
            }

            switch ((int)accountType)
            {
                case (int)accountTypes.admin:
                    
                    // admin view
                    break;
                case (int)accountTypes.player:
                    // player view
                    break;
                case (int)accountTypes.journalist:
                    // journalist view : player view + add player profile + scout selection
                    break;
            }

        }
    }
}
