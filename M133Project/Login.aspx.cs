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
        private string RedirectUrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new M133_GoInternationalEntities1();
            var user = new User();
            user.Username = "slfhls";
            user.Password = "lsfhalshfa";

            if (Request.QueryString["redirectUrl"] != null)
            {
                RedirectUrl = Server.UrlDecode(Request.QueryString["redirectUrl"]);
            }
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

                Session.Timeout = 20;

                db.User.First(usr => usr.Username == username && usr.Password == password).SessionId =
                    Session.SessionID;
                db.SaveChanges();
                SiteMaster.Username = username;

                Response.Redirect(RedirectUrl ?? "/Default.aspx");
            }
            catch (Exception )
            {
                LabelError.Visible = true;
            }

            TextBoxPassword.Text = String.Empty;
        }
    }
    
}