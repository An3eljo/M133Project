using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class Profile : System.Web.UI.Page
    {
        public User User;
        protected void Page_Load(object sender, EventArgs e)
        {
            //todo: errorhandling
            var currentUser = (User) Session["user"];

            this.User = currentUser;
        }
    }
}