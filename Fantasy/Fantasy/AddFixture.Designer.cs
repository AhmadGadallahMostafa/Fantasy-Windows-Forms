
namespace Fantasy
{
    partial class AddFixture
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Host = new System.Windows.Forms.Label();
            this.Guest = new System.Windows.Forms.Label();
            this.HomeBox = new System.Windows.Forms.PictureBox();
            this.GuestBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddFix = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(441, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(256, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host.Location = new System.Drawing.Point(73, 32);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(100, 23);
            this.Host.TabIndex = 9;
            this.Host.Text = "Home Team";
            // 
            // Guest
            // 
            this.Guest.AutoSize = true;
            this.Guest.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest.Location = new System.Drawing.Point(523, 32);
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(97, 23);
            this.Guest.TabIndex = 10;
            this.Guest.Text = "Away Team";
            // 
            // HomeBox
            // 
            this.HomeBox.Location = new System.Drawing.Point(27, 128);
            this.HomeBox.Name = "HomeBox";
            this.HomeBox.Size = new System.Drawing.Size(256, 256);
            this.HomeBox.TabIndex = 11;
            this.HomeBox.TabStop = false;
            // 
            // GuestBox
            // 
            this.GuestBox.Location = new System.Drawing.Point(441, 128);
            this.GuestBox.Name = "GuestBox";
            this.GuestBox.Size = new System.Drawing.Size(256, 256);
            this.GuestBox.TabIndex = 12;
            this.GuestBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "VS";
            // 
            // AddFix
            // 
            this.AddFix.BackColor = System.Drawing.Color.MediumVioletRed;
            this.AddFix.FlatAppearance.BorderSize = 0;
            this.AddFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFix.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFix.ForeColor = System.Drawing.SystemColors.Control;
            this.AddFix.Location = new System.Drawing.Point(298, 491);
            this.AddFix.Name = "AddFix";
            this.AddFix.Size = new System.Drawing.Size(124, 40);
            this.AddFix.TabIndex = 14;
            this.AddFix.Text = "Add Fixture";
            this.AddFix.UseVisualStyleBackColor = false;
            this.AddFix.Click += new System.EventHandler(this.AddFix_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 446);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Match Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // AddFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(731, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AddFix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuestBox);
            this.Controls.Add(this.HomeBox);
            this.Controls.Add(this.Guest);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFixture";
            this.Text = "AddFixture";
            this.Load += new System.EventHandler(this.AddFixture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.Label Guest;
        private System.Windows.Forms.PictureBox HomeBox;
        private System.Windows.Forms.PictureBox GuestBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddFix;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}