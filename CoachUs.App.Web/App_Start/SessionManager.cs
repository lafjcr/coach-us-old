using System;
using System.Web.SessionState;

namespace CoachUs.App.Web
{
    public static class SessionManager
    {
        public static HttpSessionState Session { internal get; set; }
        
        public static string User
        {
            get { return Convert.ToString(Session[SessionConstants.User]); }
            set { Session[SessionConstants.User] = value; }
        }

        private static class SessionConstants
        {
            public const string User = "User";
        }
    }
}