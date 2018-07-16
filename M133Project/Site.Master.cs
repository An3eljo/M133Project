using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class SiteMaster : MasterPage
    {
        public static string CurrentUrlRegister;
        public static string CurrentUrlLogin;
        public static string Username = "Login";
        protected void Page_Load(object sender, EventArgs e)
        {
            var currentUrl = Request.Url.PathAndQuery;
            CurrentUrlLogin = "/Login.aspx?redirectUrl=" + currentUrl;
            CurrentUrlRegister = "/Login.aspx?redirectUrl=" + currentUrl;
        }
    }
}