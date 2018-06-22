using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 10;
        }

        protected void Submit_OnClick(object sender, EventArgs e)
        {
            var username = TextBoxUsername.Text;
            Response.Redirect("About.aspx");
        }

        [WebMethod]
        public static string OnLoginClick(string name)
        {
            return "hello" + name;
        }
    }
    
}