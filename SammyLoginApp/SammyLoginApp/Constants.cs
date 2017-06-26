using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammyLoginApp
{
    public static class Constants

    {

        public static string AppName = "SammyLoginApp";
        public static string iOSClientId = "<insert IOS client ID here>";
        public static string AndroidClientId = "274510503015556";
        // These values do not need changing
        public static string Scope = "";
        public static string AuthorizeUrl = "https://m.facebook.com/dialog/oauth/";
        public static string AccessTokenUrl = "https://m.facebook.com/dialog/oauth/token";
        public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";
        // Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
        public static string iOSRedirectUrl = "<insert IOS redirect URL here>:/oauth2redirect";
        public static string AndroidRedirectUrl = "http://www.facebook.com/connect/login_success.html";

    }
}
