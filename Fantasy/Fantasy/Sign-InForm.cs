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
        public Sign_InForm()
        {
            InitializeComponent();
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
        
    }
}
