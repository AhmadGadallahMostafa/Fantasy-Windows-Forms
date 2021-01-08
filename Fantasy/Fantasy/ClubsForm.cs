using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fantasy
{
    public partial class ClubsForm : Form
    {
       
        string path = Path.Combine(Directory.GetCurrentDirectory(), @"Images/Clubs/");
        Controller ControllerObj;
        IEnumerable<Club> clubs;

        public ClubsForm()
        {
            InitializeComponent();
            ControllerObj = new Controller();
           

        }
        private IEnumerable<Club> ConvertToClubs(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                yield return new Club
                {
                    ID = Convert.ToInt32(row["Club_Id"]),
                    Name = (row["Club_Name"]).ToString(),
                    Rank = Convert.ToInt32(row["Club_Rank"]),
                    Points = Convert.ToInt32(row["Club_Points"]),
                    GoalsAganist = Convert.ToInt32(row["Goals_Against"]),
                    TotalGoals = Convert.ToInt32(row["Total_Goals"]),
                    StadiumName = row["Stadium_Name"].ToString(),
                    ManagerName = row["ManagerName"].ToString(),
                    FoundationDate = row["FoundationDate"].ToString(),
                    InFpl = Convert.ToBoolean(row["inFpl"])

                };
            }

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

        private void openAddClubForm(AddClubForm childForm)
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
            childForm.AddedClub += OnAddedClub;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void ClubsForm_Load(object sender, EventArgs e)
        {
            clubs = ConvertToClubs(ControllerObj.GetClubsInLeague());
            
            if (clubs.ElementAt(0).InFpl)
            {
                FirstClub.AccessibleName = clubs.ElementAt(0).Name;
            }

            if (clubs.ElementAt(1).InFpl) { SecondClub.AccessibleName = clubs.ElementAt(1).Name; }

            if (clubs.ElementAt(2).InFpl) {   ThirdClub.AccessibleName = clubs.ElementAt(2).Name; }

            if (clubs.ElementAt(3).InFpl) { FourthClub.AccessibleName = clubs.ElementAt(3).Name;}


            if (clubs.ElementAt(4).InFpl) {   FifthClub.AccessibleName = clubs.ElementAt(4).Name; }
            if (clubs.ElementAt(5).InFpl) { SixthClub.AccessibleName = clubs.ElementAt(5).Name;}


            if (clubs.ElementAt(6).InFpl) { SeventhClub.AccessibleName = clubs.ElementAt(6).Name; }
            if (clubs.ElementAt(7).InFpl) { EighthClub.AccessibleName = clubs.ElementAt(7).Name; }

            if (clubs.ElementAt(8).InFpl) { NinthClub.AccessibleName = clubs.ElementAt(8).Name; }
            if (clubs.ElementAt(9).InFpl) {   TenthClub.AccessibleName = clubs.ElementAt(9).Name; }
            if (clubs.ElementAt(10).InFpl) {EleventhClub.AccessibleName = clubs.ElementAt(10).Name; }


            if (clubs.ElementAt(11).InFpl) { TwelvethClub.AccessibleName = clubs.ElementAt(11).Name; }



            if (clubs.ElementAt(12).InFpl) { ThirtieenthClub.AccessibleName = clubs.ElementAt(12).Name;}
            if (clubs.ElementAt(13).InFpl) {FourteenthClub.AccessibleName = clubs.ElementAt(13).Name; }


            if (clubs.ElementAt(14).InFpl) { Fifteenth.AccessibleName = clubs.ElementAt(14).Name; }
            if (clubs.ElementAt(15).InFpl) {SixteenthClub.AccessibleName = clubs.ElementAt(15).Name;
 }
            if (clubs.ElementAt(16).InFpl) { Seventeenth.AccessibleName = clubs.ElementAt(16).Name; }
            if (clubs.ElementAt(17).InFpl) { EighteenthClub.AccessibleName = clubs.ElementAt(17).Name; }


            if (clubs.ElementAt(14).InFpl) { NineteenthClub.AccessibleName = clubs.ElementAt(18).Name;}
            
            if (clubs.ElementAt(19).InFpl) {TwentiethClub.AccessibleName = clubs.ElementAt(19).Name; }
            



            
            ThirtieenthClub.Load(path + ThirtieenthClub.AccessibleName+ ".png");
            TwelvethClub.Load(path + TwelvethClub.AccessibleName + ".png");
            FirstClub.Load(path + FirstClub.AccessibleName + ".png");
            SecondClub.Load(path + SecondClub.AccessibleName + ".png");
            ThirdClub.Load(path + ThirdClub.AccessibleName + ".png");
            FourthClub.Load(path + FourthClub.AccessibleName + ".png");
            FifthClub.Load(path + FifthClub.AccessibleName + ".png");
            SixthClub.Load(path + SixthClub.AccessibleName + ".png");
            SeventhClub.Load(path + SeventhClub.AccessibleName + ".png");
            EighthClub.Load(path + EighthClub.AccessibleName + ".png");
            NinthClub.Load(path + NinthClub.AccessibleName + ".png");
            TenthClub.Load(path + TenthClub.AccessibleName + ".png");
            EleventhClub.Load(path + EleventhClub.AccessibleName + ".png");
            FourteenthClub.Load(path + FourteenthClub.AccessibleName + ".png");
            Fifteenth.Load(path + Fifteenth.AccessibleName + ".png");
            SixteenthClub.Load(path + SixteenthClub.AccessibleName + ".png");
            Seventeenth.Load(path + Seventeenth.AccessibleName + ".png");
            EighteenthClub.Load(path + EighteenthClub.AccessibleName + ".png");
            NineteenthClub.Load(path + NineteenthClub.AccessibleName + ".png");
            TwentiethClub.Load(path + TwentiethClub.AccessibleName + ".png");

            


        }
        protected void OnAddedClub(object sender, string club)
        {
            
            this.ClubsForm_Load(null, EventArgs.Empty);

        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (SixteenthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
                Club c = ControllerObj.GetClub(SixteenthClub.AccessibleName);
                this.openChildForm(new ClubsInfoForms(c));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FirstClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
                Club c = ControllerObj.GetClub(FirstClub.AccessibleName);
                this.openChildForm(new ClubsInfoForms(c));
            }
        }
    

        private void pictureBox13_Click(object sender, EventArgs e)
        {

            if (ThirtieenthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
                        Club c = ControllerObj.GetClub(ThirtieenthClub.AccessibleName);
                        this.openChildForm(new ClubsInfoForms(c));
            }
            
            
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            if (TwelvethClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
                Club c = ControllerObj.GetClub(TwelvethClub.AccessibleName);
                this.openChildForm(new ClubsInfoForms(c));
            }

            
            
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {


            if (FifthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
                Club c = ControllerObj.GetClub(FifthClub.AccessibleName);
                this.openChildForm(new ClubsInfoForms(c));
            }
            
            
            
        }
        
        private void Liverpool_Click(object sender, EventArgs e)
        {
            if (EleventhClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
                Club c = ControllerObj.GetClub(EleventhClub.AccessibleName);
                this.openChildForm(new ClubsInfoForms(c));
            }
           
            
           
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (Seventeenth.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
                Club c = ControllerObj.GetClub(Seventeenth.AccessibleName);
                this.openChildForm(new ClubsInfoForms(c));
            }
            
            
            
        }

        private void AstonVilla_Click(object sender, EventArgs e)
        {
            if (SecondClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
                          Club c = ControllerObj.GetClub(SecondClub.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));
            }
            
            
          
        }

        private void Brighton_Click(object sender, EventArgs e)
        {
            if (ThirdClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
                        Club c = ControllerObj.GetClub(ThirdClub.AccessibleName);
                 this.openChildForm(new ClubsInfoForms(c));
            }
           

            
            
        }

        private void Burnely_Click(object sender, EventArgs e)
        {
            if (FourthClub.AccessibleName == "EmptyClub")
            {
                this.openAddClubForm(new AddClubForm());
                
            }
            else
            {
                Club c = ControllerObj.GetClub(FourthClub.AccessibleName);
                this.openChildForm(new ClubsInfoForms(c));

            }
        }

        private void crystal_Click(object sender, EventArgs e)
        {
            if (SixthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
            Club c = ControllerObj.GetClub(SixthClub.AccessibleName);
                this.openChildForm(new ClubsInfoForms(c));

            }

            

        }

        private void Fulham_Click(object sender, EventArgs e)
        {

            if (EighthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {  Club c = ControllerObj.GetClub(EighthClub.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));

            }
          
            

        }

        private void Leeds_Click(object sender, EventArgs e)
        {
            if (NinthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {   Club c = ControllerObj.GetClub(NinthClub.AccessibleName);
           this.openChildForm(new ClubsInfoForms(c));

            }
         
            

        }

        private void LeicesterCity_Click(object sender, EventArgs e)
        {

            if (TenthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            { Club c = ControllerObj.GetClub(TenthClub.AccessibleName);
             this.openChildForm(new ClubsInfoForms(c));

            }
           
            

        }

        private void NewCastle_Click(object sender, EventArgs e)
        {
            if (FourteenthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {  Club c = ControllerObj.GetClub(FourteenthClub.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));

            }
          
            
           
        }

        private void Sheffield_Click(object sender, EventArgs e)
        {
            if (Fifteenth.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {    Club c = ControllerObj.GetClub(Fifteenth.AccessibleName);
             this.openChildForm(new ClubsInfoForms(c));
            

            }

        
 
        }

        private void WestBromich_Click(object sender, EventArgs e)
        {

            if (EighteenthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            { Club c = ControllerObj.GetClub(EighteenthClub.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));
            

            }
           
            
        }

        private void WestHam_Click(object sender, EventArgs e)
        {
            if (NineteenthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {    Club c = ControllerObj.GetClub(NineteenthClub.AccessibleName);
                this.openChildForm(new ClubsInfoForms(c));
            

            }

        

        }

        private void Wolves_Click(object sender, EventArgs e)
        {
            if (TwentiethClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {
     Club c = ControllerObj.GetClub(TwentiethClub.AccessibleName);
                    this.openChildForm(new ClubsInfoForms(c));
            }

       
        
       
        }

        private void Everton_Click(object sender, EventArgs e)
        {

            if (Seventeenth.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            { Club c = ControllerObj.GetClub(SeventhClub.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));
            

            }
           
         
        }


        private void EighthClub_Click(object sender, EventArgs e)
        {
            if (EighthClub.AccessibleName == "EmptyClub")
            {
                openAddClubForm(new AddClubForm());
            }
            else
            {      Club c = ControllerObj.GetClub(EighthClub.AccessibleName);
            this.openChildForm(new ClubsInfoForms(c));

            }
      
        }


        public event EventHandler<bool> RemovedClub;

        private void Club1_Click(object sender, EventArgs e)
        {
           if (ControllerObj.RemoveClub(FirstClub.AccessibleName) != 0)
            {
               
                RemovedClub?.Invoke(this, true);
  
            }
        }

        private void Club2Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(SecondClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }



        }
      

       
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (ControllerObj.ClubCount() < 20)
            {
                MessageBox.Show("You must have 20 teams!");
                return;
            }
            else
            {
                this.Close();
            }
        }

      

        private void Club3Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(ThirdClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }


        }

        private void Club4Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(FourthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }



        }

        private void Club5Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(FifthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }


        }

        private void Club6Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(SixthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club7Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(SeventhClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }


        }

        private void Club8Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(EighthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club9Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(NinthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }


        }

        private void Club10Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(TenthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }


        }

        private void Club11Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(EleventhClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club12Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(TwelvethClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club13Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(ThirtieenthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club14Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(FourteenthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club15Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(Fifteenth.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club16Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(SixteenthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club17Remove_Click(object sender, EventArgs e)
        {
            if(ControllerObj.RemoveClub(Seventeenth.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }


        }

        private void Club18Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(EighteenthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club19Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(NineteenthClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }

        private void Club20Remove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.RemoveClub(TwentiethClub.AccessibleName) != 0)
            {

                RemovedClub?.Invoke(this, true);

            }

        }
    }
}
