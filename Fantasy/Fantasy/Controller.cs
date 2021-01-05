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

        public int SignUpUser(string email, DateTime dateOfBirth, string password, string gender,string confimpassword) 
        {
            string sql = $"insert into Account values ('{email}','{dateOfBirth.ToShortDateString()}',2,'{password}','{gender}')";
            return dbMan.ExecuteNonQuery(sql);
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
    }
}