
namespace Fantasy
{
    partial class ClubsInfoForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClubsInfoForms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ClubName = new System.Windows.Forms.Label();
            this.clubPointsLabel = new System.Windows.Forms.Label();
            this.clubRankLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ManagerLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FoundationLabel = new System.Windows.Forms.Label();
            this.StadiumLabel = new System.Windows.Forms.Label();
            this.ClubPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClubPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.ClubPicture);
            this.panel1.Controls.Add(this.StadiumLabel);
            this.panel1.Controls.Add(this.FoundationLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ManagerLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.clubRankLabel);
            this.panel1.Controls.Add(this.clubPointsLabel);
            this.panel1.Controls.Add(this.ClubName);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.CadetBlue;
            this.panel1.Location = new System.Drawing.Point(935, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 800);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Club Rank";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Club Points";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(191, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 45);
            this.button3.TabIndex = 35;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ClubName
            // 
            this.ClubName.AutoSize = true;
            this.ClubName.BackColor = System.Drawing.Color.Transparent;
            this.ClubName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClubName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClubName.Location = new System.Drawing.Point(32, 252);
            this.ClubName.Name = "ClubName";
            this.ClubName.Size = new System.Drawing.Size(65, 26);
            this.ClubName.TabIndex = 36;
            this.ClubName.Text = "label3";
            this.ClubName.Click += new System.EventHandler(this.label3_Click);
            // 
            // clubPointsLabel
            // 
            this.clubPointsLabel.AutoSize = true;
            this.clubPointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.clubPointsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubPointsLabel.ForeColor = System.Drawing.Color.Black;
            this.clubPointsLabel.Location = new System.Drawing.Point(150, 297);
            this.clubPointsLabel.Name = "clubPointsLabel";
            this.clubPointsLabel.Size = new System.Drawing.Size(50, 19);
            this.clubPointsLabel.TabIndex = 37;
            this.clubPointsLabel.Text = "label4";
            // 
            // clubRankLabel
            // 
            this.clubRankLabel.AutoSize = true;
            this.clubRankLabel.BackColor = System.Drawing.Color.Transparent;
            this.clubRankLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubRankLabel.ForeColor = System.Drawing.Color.Black;
            this.clubRankLabel.Location = new System.Drawing.Point(150, 341);
            this.clubRankLabel.Name = "clubRankLabel";
            this.clubRankLabel.Size = new System.Drawing.Size(50, 19);
            this.clubRankLabel.TabIndex = 38;
            this.clubRankLabel.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Foundation ";
            // 
            // ManagerLabel
            // 
            this.ManagerLabel.AutoSize = true;
            this.ManagerLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManagerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLabel.ForeColor = System.Drawing.Color.Black;
            this.ManagerLabel.Location = new System.Drawing.Point(150, 390);
            this.ManagerLabel.Name = "ManagerLabel";
            this.ManagerLabel.Size = new System.Drawing.Size(50, 19);
            this.ManagerLabel.TabIndex = 41;
            this.ManagerLabel.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Stadium";
            // 
            // FoundationLabel
            // 
            this.FoundationLabel.AutoSize = true;
            this.FoundationLabel.BackColor = System.Drawing.Color.Transparent;
            this.FoundationLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoundationLabel.ForeColor = System.Drawing.Color.Black;
            this.FoundationLabel.Location = new System.Drawing.Point(150, 435);
            this.FoundationLabel.Name = "FoundationLabel";
            this.FoundationLabel.Size = new System.Drawing.Size(50, 19);
            this.FoundationLabel.TabIndex = 44;
            this.FoundationLabel.Text = "label5";
            this.FoundationLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // StadiumLabel
            // 
            this.StadiumLabel.AutoSize = true;
            this.StadiumLabel.BackColor = System.Drawing.Color.Transparent;
            this.StadiumLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StadiumLabel.ForeColor = System.Drawing.Color.Black;
            this.StadiumLabel.Location = new System.Drawing.Point(150, 484);
            this.StadiumLabel.Name = "StadiumLabel";
            this.StadiumLabel.Size = new System.Drawing.Size(50, 19);
            this.StadiumLabel.TabIndex = 45;
            this.StadiumLabel.Text = "label5";
            // 
            // ClubPicture
            // 
            this.ClubPicture.BackColor = System.Drawing.Color.Transparent;
            this.ClubPicture.Location = new System.Drawing.Point(54, 54);
            this.ClubPicture.Name = "ClubPicture";
            this.ClubPicture.Size = new System.Drawing.Size(183, 185);
            this.ClubPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClubPicture.TabIndex = 46;
            this.ClubPicture.TabStop = false;
            this.ClubPicture.Click += new System.EventHandler(this.ClubPicture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(957, 800);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ClubsInfoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 798);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClubsInfoForms";
            this.Text = "ClubsInfoForms";
            this.Load += new System.EventHandler(this.ClubsInfoForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClubPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ClubName;
        private System.Windows.Forms.Label FoundationLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ManagerLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label clubRankLabel;
        private System.Windows.Forms.Label clubPointsLabel;
        private System.Windows.Forms.Label StadiumLabel;
        private System.Windows.Forms.PictureBox ClubPicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}