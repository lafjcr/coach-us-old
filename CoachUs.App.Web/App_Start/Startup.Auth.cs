using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Facebook;
using Owin;
using System.Configuration;
using System.Security.Claims;

namespace CoachUs.App.Web
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //   consumerKey: "",
            //   consumerSecret: "");

            //var scope = new List<string>() { "email", "user_about_me", "user_hometown", "friends_about_me", "friends_photos" };
            var fbOptions = new FacebookAuthenticationOptions()
            {
                AppId = ConfigurationManager.AppSettings[Facebook.FacebookConstants.FacebookAppId],
                AppSecret = ConfigurationManager.AppSettings[Facebook.FacebookConstants.FacebookAppSecret],
                Provider = new FacebookAuthenticationProvider()
                {
                    OnAuthenticated = async context =>
                    {
                        foreach (var x in context.User)
                            context.Identity.AddClaim(new Claim(x.Key, x.Value.ToString()));
                        //Get the access token from FB and store it in the database and use FacebookC# SDK to get more information about the user
                        context.Identity.AddClaim(new Claim(Facebook.FacebookConstants.FacebookAccessToken, context.AccessToken));
                    }
                },
                SignInAsAuthenticationType = DefaultAuthenticationTypes.ExternalCookie
            };
            fbOptions.Scope.Add(Facebook.FacebookScope.Email);
            fbOptions.Scope.Add(Facebook.FacebookScope.UserAboutMe);
            fbOptions.Scope.Add(Facebook.FacebookScope.Birthday);
            fbOptions.Scope.Add(Facebook.FacebookScope.Location);
            fbOptions.Scope.Add(Facebook.FacebookScope.Hometown);
            app.UseFacebookAuthentication(fbOptions);

            //app.UseGoogleAuthentication();
        }
    }
}