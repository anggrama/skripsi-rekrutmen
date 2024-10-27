using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RekrutmenTNI
{
    static class cSession
    {
        
        public const string sPangkat = "-- page pangkat --";
        public const string sUserStruct = "-- user struct --";
        public const string sUserType = "-- user type --";

        public const string sAdminStruct = "-- admin struct --";
        public const string sFilter_Pangkat = "-- filter pangkat --";
        public const string sFilter_Gelombang = "-- gelombang --";
        public const string sFilter_Tahun = "-- tahun daftar --";

        public static void checkAdminSession()
        {
            if (IsSessionExpired())
                HttpContext.Current.Response.Redirect("/notfound.aspx?err=9001");

            if (HttpContext.Current.Session[cSession.sAdminStruct] == null)
                HttpContext.Current.Response.Redirect("/administrator/default.aspx");

        }

        public static void checkUserSession()
        {
            if (IsSessionExpired())
                HttpContext.Current.Response.Redirect("notfound.aspx?err=9000");

            if (HttpContext.Current.Session[cSession.sUserStruct] == null)
                HttpContext.Current.Response.Redirect("default.aspx");
        }

        private static bool IsSessionExpired()
        {
            if (HttpContext.Current.Session != null)
            {
                if (HttpContext.Current.Session.IsNewSession)
                {
                    string CookieHeaders = HttpContext.Current.Request.Headers["Cookie"];

                    if ((null != CookieHeaders) && (CookieHeaders.IndexOf("ASP.NET_SessionId") >= 0))
                    {
                        // IsNewSession is true, but session cookie exists,
                        // so, ASP.NET session is expired
                        return true;
                    }
                }
            }

            // Session is not expired and function will return false,
            // could be new session, or existing active session
            return false;
        }
    }
    public class cSessionUser
    {
        public string UserEmail { get; set; }
        public string UserName { get; set; }
    }
    public class cSessionAdmin
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Panda { get; set; }
        public string AdminType { get; set; }
    }

}