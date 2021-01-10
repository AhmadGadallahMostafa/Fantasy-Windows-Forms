using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            string encryptedPassword = getEncryptedPassword(email);
            string decryptedPassword = Validations.DecodeFrom64(encryptedPassword);
            if (decryptedPassword == password)
            {
                string sql = $"Select Account_Type from Account where  Email ='{email}';";
                return dbMan.ExecuteScalar(sql);
            }
            else
                return null;
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
        public string getEncryptedPassword(string email)
        {
            string query = $"select password from Account where email = '{email}'";
            return dbMan.ExecuteScalar(query).ToString();
        }
        public int updatePassword(string password, string email)
        {
            string query = $"update account set password = '{password}' where  email = '{email}'";
            return dbMan.ExecuteNonQuery(query);
        }
        public string getEmailFromUserName(string username)
        {
            string query = $"select account.Email from account, fantasy_player_team where player_username = '{username}' and Fantasy_Player_Team.Email = Account.Email ";
            return dbMan.ExecuteScalar(query).ToString();
        }
        public int requestAnalystAccount(string email, DateTime birthdate, string password,string gender) 
        {
            string query = $"Insert INTO ACCOUNT values('{email}','{birthdate.ToShortDateString()}',4,'{password}','{gender}')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetAnalysRequests() 
        {
            string query = "SELECT email,Date_Of_Birth,Gender FROM ACCOUNT WHERE Account_Type = 4 ";
            return dbMan.ExecuteReader(query);
        }
        public int AcceptRequest(string email)
        {
            string query = $"UPDATE ACCOUNT set Account_Type = 1 Where Email='{email}'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DenyRequest(string email)
        {
            string query = $"DELETE FROM Account Where Email='{email}'";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
