using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
   public class AccountController
    {
        DBManager dbMan;

        public AccountController()
        {
            dbMan = new DBManager();
        }
        public object LoginVerification(string email, string password)
        {
            string sql = $"Select Account_Type from Account where Password='{password}' and Email ='{email}';";
            return dbMan.ExecuteScalar(sql);
        }

        public object GetSignedIn(string email) 
        {
            string sql = $"select Signed_In from Account where Email='{email}'";
            return dbMan.ExecuteScalar(sql);
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
        public int CreateFantasyTeam(string userName, string email, int age)
        {
            Object count = dbMan.ExecuteScalar("SELECT count(Fantasy_Team_ID) FROM Fantasy_Player_Team");
            int rank = 0;
            rank = (int)count + 1;

            string sql = $"Insert into Fantasy_Player_Team  (Player_Username,Age,Email,Total_Value,Team_Funds,Total_Points,Total_Transfers,Overall_Rank)values('{userName}',{age},'{email}',0,100,0,1,{rank})";
            return dbMan.ExecuteNonQuery(sql);

        }

        public string GetUserName(string email) 
        {
            string sql = $"select Player_Username From Fantasy_Player_Team where Email='{email}';";
            return dbMan.ExecuteScalar(sql).ToString();

        }
        public int getFantasyTeamId(string email) 
        {
            string query = $"SELECT Fantasy_Team_ID FROM Fantasy_Player_Team where Email='{email}'";
            return (int)dbMan.ExecuteScalar(query);
        }

    }
}
