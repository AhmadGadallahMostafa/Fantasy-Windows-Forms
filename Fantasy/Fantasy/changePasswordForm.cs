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
    public partial class changePasswordForm : Form
    {
        AccountController ControllerObj;
        string userEmail;
        public changePasswordForm(string email)
        {
            InitializeComponent();
            ControllerObj = new AccountController();
            userEmail = email;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Validations.EmptyInputField(textBox2.Text))
            {
                string password = Validations.EncodePasswordToBase64(textBox2.Text);
                int flag = ControllerObj.updatePassword(password,userEmail);
                if (flag ==1)
                {
                    MessageBox.Show("Changed Successfully");
                }
                else { MessageBox.Show("Failed"); }
            }
            else
            {
                label5.Visible = true;
            }

        }

        private void changePasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
