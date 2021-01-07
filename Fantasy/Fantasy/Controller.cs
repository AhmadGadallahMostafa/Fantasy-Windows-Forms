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
            string query1 = $"select * from Club where club_name = '{ClubName}' ";
            string query2 = $"select Footballer.First_Name,Footballer.Last_Name,Footballer.poisition from Footballer,Club  where Club.club_name = '{ClubName}' and Footballer.Club_id = Club.Club_id   ";
            c = new Club(dbMan.ExecuteReader(query1),dbMan.ExecuteReader(query2));
            return c;
        }


        public int RemovePlayer(int TeamID, string LastName)
        {
            int NewFunds = GetTeamFunds(TeamID) + GetPrice(LastName);

            string query = "UPDATE Fantasy_Player_Team   Set Team_Funds=" + NewFunds + " WHERE Fantasy_Team_ID=" + TeamID + " ; ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeletePlayer(int TeamId, int PlayerId)
        {
            string query = "Delete FROM Plays_In_Fantasy_Team WHERE Player_ID=" + PlayerId + "AND Fantasy_Team_Id=" + TeamId + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int GetLeaguesCount()
        {
            string query = "COUNT(*) FROM Fantasy_League";
            return (int)dbMan.ExecuteScalar(query);
        }


        public int InsertLeague(String LeagueName)
        {
            int LeagueId = GetLeaguesCount() + 1;
            string query = "INSERT INTO Fantasy_League (League_Id,League_Name) Values(" + LeagueId + "," + LeagueName + ");";
            return (int)dbMan.ExecuteScalar(query);
        }

    }
}