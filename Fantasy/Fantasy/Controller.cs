using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Fantasy
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public object LoginVerification(string email,string password) 
        {
            string sql = $"Select Account_Type from Account where Password='{password}' and Email ='{email}';";
            return  dbMan.ExecuteScalar(sql);
        }

        public int SignUpUser(string email, DateTime dateOfBirth, string password, string gender) 
        {
            string sql = $"insert into Account values ('{email}','{dateOfBirth.ToShortDateString()}',2,'{password}','{gender}')";
            return dbMan.ExecuteNonQuery(sql);
        }
        public bool UniqueUsername(string username) 
        {
            string sql = $"select Player_Username FROM Fantasy_Player_Team where Player_Username = '{username}'";
            if (dbMan.ExecuteScalar(sql) == null)
            {
                return true;
            }
            else return false;
        }
        public int CreateFantasyTeam(string userName,string email,int age) 
        {
            Object count = dbMan.ExecuteScalar("SELECT count(Fantasy_Team_ID) FROM Fantasy_Player_Team");
         
            
            int newId;
            if ((int)count == 0 )
            {
                newId = 1;
            }
            else
            {
                newId =(int) dbMan.ExecuteScalar("SELECT max(Fantasy_Team_ID) FROM Fantasy_Player_Team") + 1;

            }
            string sql = $"Insert into Fantasy_Player_Team (Player_Username,Fantasy_Team_ID,Email,age) values('{userName}',{newId},'{email}',{age})";
            return dbMan.ExecuteNonQuery(sql);
        
        }
        public DataTable GetGK()
        {
            string query = "SELECt Last_Name,Price,Goals,Assists,CleanSheets From Footballer WHERE Poisition=0 ";
            return dbMan.ExecuteReader(query);


        }
        public DataTable GetDefender()
        {
            string query = "SELECT Last_Name,Price,Goals,Assists,CleanSheets From Footballer WHERE Poisition=1 ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetMidFielder()
        {
            string query = "SELECT Last_Name,Price,Goals,Assists,CleanSheets From Footballer WHERE Poisition=2 ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetStriker()
        {
            string query = "SELECT Last_Name,Price,Goals,Assists From Footballer WHERE Poisition=3 ";
            return dbMan.ExecuteReader(query);
        }
        public int GetPrice(String LastName)
        {
            string query = "SELECT Price From Footballer Where Last_Name='" + LastName + "';";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int GetTeamFunds(int TeamID)
        {
            string query = "SELECT Team_Funds From Fantasy_Player_Team Where Fantasy_Team_ID=" +TeamID + ";";
            return (int)dbMan.ExecuteScalar(query);

        }

       public int BuyingFunction(int TeamID,string LastName)
        {
            int NewFunds = GetTeamFunds(TeamID) - GetPrice(LastName);

            string query = "UPDATE Fantasy_Player_Team   Set Team_Funds=" + NewFunds + " WHERE Fantasy_Team_ID="+TeamID +" ; ";
            return dbMan.ExecuteNonQuery(query);
        }
        public int GetPlayerId(String LastName)
        {
            string query = "SELECT Player_id From Footballer Where Last_Name='" + LastName + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int InsertPlayer(int PlayerId, int FantasyTeamId)
        {
            string query = "Insert INTO Plays_In_Fantasy_Team VALUES (" + PlayerId + "," + FantasyTeamId + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public Club GetClub(string ClubName)
        {
            Club c;
            string query = $"select * from Club where club_name = '{ClubName}' ";
            c = new Club(dbMan.ExecuteReader(query));
            return c;
        }
    }
}