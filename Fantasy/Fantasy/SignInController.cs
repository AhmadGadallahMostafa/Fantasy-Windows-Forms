using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
   public class SignInController
    {
        DBManager dbMan;

        public SignInController()
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
    }
}
