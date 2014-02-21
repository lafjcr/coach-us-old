using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace CoachUs.App.Web
{
    public static class Facebook
    {
        public class FacebookUserProfile
        {
            public string Id { private set; get; }
            public string Email { private set; get; }
            public string Name { private set; get; }
            public string FirstName { private set; get; }
            public string LastName { private set; get; }
            public string UserName { private set; get; }
            public string Gender { private set; get; }
            public string Birthday { private set; get; }
            public string Hometown { private set; get; }
            public string Link { private set; get; }
            public string Locale { private set; get; }
            public string City { private set; get; }
            public string Country { private set; get; }

            public FacebookUserProfile(IEnumerable<Claim> claims)
            {
                var claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.Id);
                Id = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.Email);
                Email = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.Name);
                Name = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.FirstName);
                FirstName = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.LastName);
                LastName = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.UserName);
                UserName = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.Gender);
                Gender = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.Birthday);
                Birthday = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.Hometown);
                Hometown = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.Link);
                Link = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.Locale);
                Locale = claim == null ? "" : claim.Value;
                claim = claims.FirstOrDefault(c => c.Type == FacebookClaims.Location);
                var location = claim.Value.Substring(claim.Value.IndexOf("\"name\": \"") + 9);
                location = location.Remove(location.IndexOf("\""));
                City = location.IndexOf(",") > 0 ? location.Substring(0, location.IndexOf(",")) : String.Empty;
                Country = location.IndexOf(",") > 0 ? location.Substring(location.IndexOf(",") + 2) : location;
            }
        }

        public static class FacebookConstants
        {
            public const string FacebookAppId = "Facebook:AppId";
            public const string FacebookAppSecret = "Facebook:AppSecret";
            public const string FacebookAccessToken = "Facebook:AccessToken";
        }

        public static class FacebookScope
        {
            public const string Email = "email";
            public const string UserAboutMe = "user_about_me";
            public const string Birthday = "user_birthday";
            public const string Location = "user_location";
            public const string Hometown = "user_hometown";
        }

        public static class FacebookClaims
        {
            public const string Id = "id";
            public const string Email = "email";
            public const string Name = "name";
            public const string FirstName = "first_name";
            public const string LastName = "last_name";
            public const string UserName = "username";
            public const string Gender = "gender";
            public const string Birthday = "user_birthday";
            public const string Hometown = "user_hometown";
            public const string Link = "link";
            public const string Locale = "locale";
            public const string Location = "location";
        }        
    }
}