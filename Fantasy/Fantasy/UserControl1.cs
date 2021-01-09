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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public string GetScoredBy()
        {
            return this.ScoredBy.Text;
        }

        public string GetLabel1Value()
        {
            return this.label1.Text;
        }

        public void SetScoredBy(string newText)
        {
            this.ScoredBy.Text = newText;
        }

        public void SetLabelValue(string newText)
        {
            this.label1.Text = newText;
        }


        public string GetAssistedBy()
        {
            return this.AssistedBy.Text;
        }

        public string GetLabel2Value()
        {
            return this.label2.Text;
        }

        public void SetAssistedBy(string newText)
        {
            this.AssistedBy.Text = newText;
        }

        public void SetLabel2Value(string newText)
        {
            this.label2.Text = newText;
        }
    }
}
