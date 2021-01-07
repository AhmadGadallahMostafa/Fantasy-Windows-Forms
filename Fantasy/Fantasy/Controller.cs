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
            string query = $"select * from Club where club_name = '{ClubName}' ";
            c = new Club(dbMan.ExecuteReader(query));
            return c;
        }
    }
}