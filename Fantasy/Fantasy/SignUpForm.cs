using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace Fantasy
{
    public partial class SignUpForm : Form
        
    {
        AccountController controlObj;
        public SignUpForm()
        {
            InitializeComponent();
            controlObj = new AccountController();
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

        private void SignUp_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;
            string confirmPassword = textBox4.Text;
            DateTime birthDate = dateTimePicker1.Value;

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(birthDate.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            string gender="";

            if (radioButton1.Checked) 
            { gender = radioButton1.Text;  }
            if (radioButton2.Checked)
            { gender = radioButton2.Text; }
            if (radioButton3.Checked)
            { gender = radioButton3.Text; }



            if (validateInputs())
            {
                if (controlObj.UniqueUsername(username))
                {
                    label12.Visible = false;
                   

                    if (controlObj.SignUpUser(email, birthDate, password, gender) != 0 && (controlObj.CreateFantasyTeam(username, email, age) != 0))
                    {
                        
                        label14.Visible = false;
<<<<<<< Updated upstream
=======
                        int id = controlObj.getFantasyTeamId(email);
                        openChildForm(new CreateTeams(id));
>>>>>>> Stashed changes


                        
                    }
                    else 
                    {
                        label14.Visible = true;
                    }
                }
                else 
                {
                    label12.Visible = true;
                }

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
      
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private bool validateInputs() 
        {


            bool emailCheck = false;
            bool usernameCheck = false;
            bool passwordCheck = false;
            bool matchCheck = false;
            bool genderCheck = false;
            bool ageCheck = false;
            string email = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;
            string confirmPassword = textBox4.Text;
            DateTime birthDate = dateTimePicker1.Value;


            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(birthDate.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            if (age >= 15)
            {
                ageCheck = true;
                label15.Visible = false;
            }
            else
            {
                label15.Visible = true;

            }

            if (Validations.EmptyInputField(username))
            {
                label10.Visible = true;
                
            }
            else
            {
                label10.Visible = false;
                usernameCheck = true;
            }


            if (Validations.EmptyInputField(password))
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
                passwordCheck = true;
            }

            
            if (!Validations.ValidEmail(email))
            {

                label8.Visible = true;
            }
            else
            { 
                label8.Visible = false;
                emailCheck = true;
            }


            if (!Validations.PasswordsMatch(password, confirmPassword))
            {
               
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
                matchCheck = true;
            }


            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                label13.Visible = true;
                

            }
            else
            { 
                label13.Visible = false;
                genderCheck = true;
            }


            if (emailCheck && usernameCheck && passwordCheck && matchCheck && genderCheck&& ageCheck)
            {
                return true;
            }


            else return false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

      
        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
