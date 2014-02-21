using CoachUs.Data.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachUs.Security
{
    public static class SecurityManager
    {
        private const string userNameSeparator = "xXxXx";

        private static CoachUsSecurity manager = new CoachUsSecurity();


        public static string FindUserNameByEmailAsync(string email)
        {
            var user = manager.AspNetUsers.SingleOrDefault(item => item.Email == email);
            return user != null ? user.UserName : String.Empty;
        }

        public static bool ExistsEmail(string email)
        {
            var user = manager.AspNetUsers.SingleOrDefault(item => item.Email == email);
            return user != null;
        }

        public static string GetNextUserNameConsecutive(string userName)
        {
            return String.Format("{0}{1}{2}", userName, userNameSeparator, manager.AspNetUsers.Count(item => item.UserName.StartsWith(userName + userNameSeparator)) + 1);
        }
    }
}
