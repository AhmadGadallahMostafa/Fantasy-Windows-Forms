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
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetFixturesByWeek(int weekNumber)
        {
            string query = $"select c1.club_name , Club_Fixtures.Score , c2.club_name  from Club as c1 , club as c2 , Club_Fixtures where c1.Club_Id = Club_Fixtures.Host_id and c2.Club_Id = Club_Fixtures.Guest_Id and Club_Fixtures.Week_number = {weekNumber}";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetFootBallersByClubName(string club_name)
        {
            string query = $"select Footballer.Last_Name,Footballer.Points,Footballer.Price from footballer,club where footballer.Club_id = Club.Club_id and Club.club_name = '{club_name}'  order by points desc; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetFootBallersByPoints()
        {
            string query = $"select Footballer.Last_Name,Footballer.Points,Footballer.Price from footballer order by points desc; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetClubsNames()
        {
            string query = $"Select Club_Name from club ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getPlayerByPos(int pos)
        {
            string query = $"select Footballer.Last_Name,Footballer.Points,Footballer.Price from footballer where poisition ='{pos}'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getClubsByRank()
        {
            string query = "Select Club_Rank, Club_Name,Club_Points,Total_Goals,Goals_Against From Club order by club_rank asc";
            return dbMan.ExecuteReader(query);
        }
        public int SetFunds(int FTID)
        {
            string query = "UPDATE Fantasy_Player_Team SET Team_Funds=100 WHERE Fantasy_Team_Id=" + FTID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int SetTeamName(int FTID, String FTName)
        {
            string query = "UPDATE Fantasy_Player_Team SET Team_Name='" + FTName + "'WHERE Fantasy_Team_Id=" + FTID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateTotalPlayers(int LeagueId)
        {
            string query = "UPDATE Fantasy_League SET Total_Players=Total_Players+1 WHERE League_Id=" + LeagueId + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int JoinLeague(int FTID, int LeagueId)
        {
            UpdateTotalPlayers(LeagueId);

            string query = "INSERT INTO Comepteing_Leauges Values(" + FTID + "," + LeagueId + ");";
            return dbMan.ExecuteNonQuery(query);

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

<<<<<<< Updated upstream
=======


        public int getClubIdByName(string name)
        {
            string query = $"select club.Club_Id from Club where Club.Club_Name = '{name}';";
            return (int)dbMan.ExecuteScalar(query);
        }
        
        public int deletePlayerByNames(string fname, string lname)
        {
            string query = $"delete from footballer where First_Name = '{fname}' and Last_Name = '{lname}' ";
            return dbMan.ExecuteNonQuery(query);
        }


        //testing stored procs
        public DataTable getTeamsByRankStoredProc()
        {
            string name = StoredProcedures.getClubsByRank;
            return dbMan.ExecuteReaderSto(name, null);
        }
        public DataTable getFootBallerForAdmin()
        {
            string name = StoredProcedures.getFootballlerNameAndClub;
            return dbMan.ExecuteReaderSto(name, null);
        }
        public int addFootballerStoredProc(int clubID, string fname, string lname, int position, int price, int age, int points)
        {
            string name = StoredProcedures.addFootballer;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@clubID", clubID);
            parameters.Add("@firstName", fname);
            parameters.Add("@lastName ", lname);
            parameters.Add("@position", position);
            parameters.Add("@price", price);
            parameters.Add("@age ", age);
            parameters.Add("@points", points);
            return dbMan.ExecuteNonQuerySto(name, parameters);
        }
>>>>>>> Stashed changes
    }
}