
namespace Fantasy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.childPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablesButton = new System.Windows.Forms.Button();
            this.FixturesButton = new System.Windows.Forms.Button();
            this.ClubsButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.TopPlayersButton = new System.Windows.Forms.Button();
            this.PlayersButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.OldLace;
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(249, 674);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(937, 73);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "About";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // childPanel
            // 
            this.childPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.childPanel.Location = new System.Drawing.Point(249, 0);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(937, 678);
            this.childPanel.TabIndex = 1;
            this.childPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.childPanel_Paint);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 164);
            this.logoPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TablesButton);
            this.panel1.Controls.Add(this.FixturesButton);
            this.panel1.Controls.Add(this.ClubsButton);
            this.panel1.Controls.Add(this.SignInButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 301);
            this.panel1.TabIndex = 1;
            // 
            // TablesButton
            // 
            this.TablesButton.FlatAppearance.BorderSize = 0;
            this.TablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TablesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TablesButton.Location = new System.Drawing.Point(0, 246);
            this.TablesButton.Name = "TablesButton";
            this.TablesButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TablesButton.Size = new System.Drawing.Size(250, 62);
            this.TablesButton.TabIndex = 5;
            this.TablesButton.Text = "Tables";
            this.TablesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TablesButton.UseVisualStyleBackColor = true;
            // 
            // FixturesButton
            // 
            this.FixturesButton.FlatAppearance.BorderSize = 0;
            this.FixturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FixturesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FixturesButton.Location = new System.Drawing.Point(0, 184);
            this.FixturesButton.Name = "FixturesButton";
            this.FixturesButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FixturesButton.Size = new System.Drawing.Size(250, 62);
            this.FixturesButton.TabIndex = 4;
            this.FixturesButton.Text = "Fixtures";
            this.FixturesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FixturesButton.UseVisualStyleBackColor = true;
            this.FixturesButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ClubsButton
            // 
            this.ClubsButton.FlatAppearance.BorderSize = 0;
            this.ClubsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClubsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClubsButton.Location = new System.Drawing.Point(0, 124);
            this.ClubsButton.Name = "ClubsButton";
            this.ClubsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ClubsButton.Size = new System.Drawing.Size(250, 60);
            this.ClubsButton.TabIndex = 3;
            this.ClubsButton.Text = "Clubs";
            this.ClubsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClubsButton.UseVisualStyleBackColor = true;
            // 
            // SignInButton
            // 
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.SignInButton.Location = new System.Drawing.Point(0, 62);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SignInButton.Size = new System.Drawing.Size(250, 62);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Sign-in";
            this.SignInButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(250, 62);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.SideMenuPanel.Controls.Add(this.TopPlayersButton);
            this.SideMenuPanel.Controls.Add(this.PlayersButton);
            this.SideMenuPanel.Controls.Add(this.panel1);
            this.SideMenuPanel.Controls.Add(this.logoPanel);
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(250, 747);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // TopPlayersButton
            // 
            this.TopPlayersButton.FlatAppearance.BorderSize = 0;
            this.TopPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopPlayersButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.TopPlayersButton.Location = new System.Drawing.Point(0, 527);
            this.TopPlayersButton.Name = "TopPlayersButton";
            this.TopPlayersButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TopPlayersButton.Size = new System.Drawing.Size(250, 62);
            this.TopPlayersButton.TabIndex = 7;
            this.TopPlayersButton.Text = "Top Players";
            this.TopPlayersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TopPlayersButton.UseVisualStyleBackColor = true;
            this.TopPlayersButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // PlayersButton
            // 
            this.PlayersButton.FlatAppearance.BorderSize = 0;
            this.PlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayersButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PlayersButton.Location = new System.Drawing.Point(0, 465);
            this.PlayersButton.Name = "PlayersButton";
            this.PlayersButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PlayersButton.Size = new System.Drawing.Size(250, 62);
            this.PlayersButton.TabIndex = 6;
            this.PlayersButton.Text = "Players";
            this.PlayersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayersButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 745);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.SideMenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.SideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel childPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TablesButton;
        private System.Windows.Forms.Button FixturesButton;
        private System.Windows.Forms.Button ClubsButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button PlayersButton;
        private System.Windows.Forms.Button TopPlayersButton;
    }
}

