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
            var db = new M133_GoInternationalEntities1();
            string output = null;
            var username = TextBoxUsername.Text;
            var password = TextBoxPassword.Text;
            try
            {
                var user = db.User.First(use => use.Username == username);
                if (user.Password != password)
                {
                    LabelError.Visible = true;
                    TextBoxPassword.Text = String.Empty;
                    return;
                }

                Session.Add("user", user);
            }
            catch (Exception )
            {
                LabelError.Visible = true;
            }

            TextBoxPassword.Text = String.Empty;
        }

        [WebMethod]
        public static string OnLoginClick(string name)
        {
            return "hello" + name;
        }
    }
    
}