using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fantasy
{
    class Validations
    {

        public static bool ValidEmail(string email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
            }
            catch (ArgumentException)
            {
                return false;//
            }
            catch (FormatException)
            {
                return false;//

            }
            return true;
        }
        public static bool PasswordsMatch(string password, string confirmPassword) 
        {

            if (password == confirmPassword)
            {
                return true;
            }
            else 
            {
                return false;
            }
        
        }
        public static bool EmptyInputField(string input) 
        {
            if (input == "")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
  
}
