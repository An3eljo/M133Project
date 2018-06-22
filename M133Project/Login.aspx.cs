using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            Session.Add("UserName", TextBoxNutzername.Text);
            Session.Add("UserEmail", TextBoxEmail.Text);
        }
        Response.Redirect("About.aspx");
    }
    
}