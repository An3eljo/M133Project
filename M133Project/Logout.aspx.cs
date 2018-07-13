using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new M133_GoInternationalEntities1();
            db.User.First(usr => usr.SessionId == Session.SessionID).SessionId = null;
            db.SaveChanges();

            Session.Clear();
            Session.Abandon();

            Response.Redirect("/Default.aspx");
        }
    }
}