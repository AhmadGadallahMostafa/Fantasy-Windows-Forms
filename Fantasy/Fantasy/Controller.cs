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
            string query = "SELECT Team_Funds From Fantasy_Player_Team Where Fantasy_Team_ID=" + TeamID + ";";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int BuyingFunction(int TeamID, string LastName)
        {
            int NewFunds = GetTeamFunds(TeamID) - GetPrice(LastName);

            string query = "UPDATE Fantasy_Player_Team   Set Team_Funds=" + NewFunds + " WHERE Fantasy_Team_ID=" + TeamID + " ; ";
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
        public int LastClubID()
        {
            string sql = "select max(Club_Id) from Club ";
            return (int)dbMan.ExecuteScalar(sql);
        }
        public int InsertClub(Club clubToAdd)
        {
            int ClubId = LastClubID() + 1;
            int ClubRank = ClubId;
            string query = $"Insert into Club values({ClubId},{ClubRank},'{clubToAdd.Name}',0,0,0,'{clubToAdd.StadiumName}','{clubToAdd.ManagerName}','{clubToAdd.FoundationDate}',0)";
            return dbMan.ExecuteNonQuery(query);
        }
        public int RemoveClub(string clubName)
        {
            string query = $"update Club set inFpl = 0 where Club_Name='{clubName}'";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetClubsInLeague()
        {
            string query = "Select* From  Club  order by  inFpl desc";
            return dbMan.ExecuteReader(query);

        }
        public DataTable GetClubs()
        {
            string query = "Select* From  Club where inFpl=0  order by Club_Name asc ";
            return dbMan.ExecuteReader(query);

        }
        public int InsertClubInLeague(string clubName) 
        {
            string query = $"Update club set inFpl =1 where Club_Name='{clubName}'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int ClubCount() 
        {
            string query = "select count(Club_Id) from Club where inFpl=1";
            return (int)dbMan.ExecuteScalar(query);
        }

    }
}