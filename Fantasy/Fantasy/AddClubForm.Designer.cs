
namespace Fantasy
{
    partial class AddClubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ClubName = new System.Windows.Forms.Label();
            this.StadName = new System.Windows.Forms.Label();
            this.ManagerName = new System.Windows.Forms.Label();
            this.FoundationDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddClub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.URLb = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.Label();
            this.StadField = new System.Windows.Forms.Label();
            this.ManagerField = new System.Windows.Forms.Label();
            this.UrlField = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(618, 284);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(618, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(618, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 20);
            this.textBox5.TabIndex = 4;
            // 
            // ClubName
            // 
            this.ClubName.AutoSize = true;
            this.ClubName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClubName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClubName.Location = new System.Drawing.Point(618, 93);
            this.ClubName.Name = "ClubName";
            this.ClubName.Size = new System.Drawing.Size(93, 23);
            this.ClubName.TabIndex = 10;
            this.ClubName.Text = "Club Name";
            this.ClubName.Click += new System.EventHandler(this.ClubName_Click);
            // 
            // StadName
            // 
            this.StadName.AutoSize = true;
            this.StadName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StadName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StadName.Location = new System.Drawing.Point(618, 168);
            this.StadName.Name = "StadName";
            this.StadName.Size = new System.Drawing.Size(122, 23);
            this.StadName.TabIndex = 11;
            this.StadName.Text = "Staduim Name";
            // 
            // ManagerName
            // 
            this.ManagerName.AutoSize = true;
            this.ManagerName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManagerName.Location = new System.Drawing.Point(618, 245);
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.Size = new System.Drawing.Size(140, 23);
            this.ManagerName.TabIndex = 12;
            this.ManagerName.Text = "Manager\'s Name";
            // 
            // FoundationDate
            // 
            this.FoundationDate.AutoSize = true;
            this.FoundationDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoundationDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FoundationDate.Location = new System.Drawing.Point(618, 329);
            this.FoundationDate.Name = "FoundationDate";
            this.FoundationDate.Size = new System.Drawing.Size(148, 23);
            this.FoundationDate.TabIndex = 13;
            this.FoundationDate.Text = "Founadation Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(618, 365);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // AddClub
            // 
            this.AddClub.BackColor = System.Drawing.Color.MediumVioletRed;
            this.AddClub.FlatAppearance.BorderSize = 0;
            this.AddClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClub.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClub.ForeColor = System.Drawing.SystemColors.Control;
            this.AddClub.Location = new System.Drawing.Point(668, 555);
            this.AddClub.Name = "AddClub";
            this.AddClub.Size = new System.Drawing.Size(124, 40);
            this.AddClub.TabIndex = 15;
            this.AddClub.Text = "Add Club";
            this.AddClub.UseVisualStyleBackColor = false;
            this.AddClub.Click += new System.EventHandler(this.AddClub_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(636, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Upload Club Picture";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(917, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // URLb
            // 
            this.URLb.Location = new System.Drawing.Point(618, 446);
            this.URLb.Name = "URLb";
            this.URLb.Size = new System.Drawing.Size(256, 20);
            this.URLb.TabIndex = 18;
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.URL.Location = new System.Drawing.Point(618, 411);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(81, 23);
            this.URL.TabIndex = 19;
            this.URL.Text = "Logo URL";
            this.URL.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1148, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 45);
            this.button3.TabIndex = 36;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(837, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 39);
            this.label2.TabIndex = 39;
            this.label2.Text = "New Club";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(84, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 39);
            this.label3.TabIndex = 40;
            this.label3.Text = "Existing Club";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(142, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 40);
            this.button2.TabIndex = 41;
            this.button2.Text = "Add Club";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameField
            // 
            this.NameField.AutoSize = true;
            this.NameField.ForeColor = System.Drawing.Color.Red;
            this.NameField.Location = new System.Drawing.Point(794, 137);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(101, 13);
            this.NameField.TabIndex = 42;
            this.NameField.Text = "Field can\'t be empty";
            this.NameField.Visible = false;
            // 
            // StadField
            // 
            this.StadField.AutoSize = true;
            this.StadField.ForeColor = System.Drawing.Color.Red;
            this.StadField.Location = new System.Drawing.Point(794, 206);
            this.StadField.Name = "StadField";
            this.StadField.Size = new System.Drawing.Size(101, 13);
            this.StadField.TabIndex = 43;
            this.StadField.Text = "Field can\'t be empty";
            this.StadField.Visible = false;
            // 
            // ManagerField
            // 
            this.ManagerField.AutoSize = true;
            this.ManagerField.ForeColor = System.Drawing.Color.Red;
            this.ManagerField.Location = new System.Drawing.Point(794, 284);
            this.ManagerField.Name = "ManagerField";
            this.ManagerField.Size = new System.Drawing.Size(101, 13);
            this.ManagerField.TabIndex = 44;
            this.ManagerField.Text = "Field can\'t be empty";
            this.ManagerField.Visible = false;
            // 
            // UrlField
            // 
            this.UrlField.AutoSize = true;
            this.UrlField.ForeColor = System.Drawing.Color.Red;
            this.UrlField.Location = new System.Drawing.Point(880, 449);
            this.UrlField.Name = "UrlField";
            this.UrlField.Size = new System.Drawing.Size(101, 13);
            this.UrlField.TabIndex = 45;
            this.UrlField.Text = "Field can\'t be empty";
            this.UrlField.Visible = false;
            // 
            // AddClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1195, 798);
            this.Controls.Add(this.UrlField);
            this.Controls.Add(this.ManagerField);
            this.Controls.Add(this.StadField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.URLb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddClub);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FoundationDate);
            this.Controls.Add(this.ManagerName);
            this.Controls.Add(this.StadName);
            this.Controls.Add(this.ClubName);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClubForm";
            this.Text = "AddClubForm";
            this.Load += new System.EventHandler(this.AddClubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label ClubName;
        private System.Windows.Forms.Label StadName;
        private System.Windows.Forms.Label ManagerName;
        private System.Windows.Forms.Label FoundationDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddClub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox URLb;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NameField;
        private System.Windows.Forms.Label StadField;
        private System.Windows.Forms.Label ManagerField;
        private System.Windows.Forms.Label UrlField;
    }
}