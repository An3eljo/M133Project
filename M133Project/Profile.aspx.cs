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
        public User CurrentUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            //todo: errorhandling
            var currentUser = (User) Session["user"];

            this.CurrentUser = currentUser;
        }

        protected void OnSafeClick(object sender, EventArgs e)
        {
            //todo: errorhandling
            var db = new M133_GoInternationalEntities1();
            var currentUser = (User)Session["user"];

            //todo: html
            //if (Username != currentUser.Username)
            //{
            //    db.User.First(usr => usr.Id == currentUser.Id).Username = Username;
            //}

            //if (Password != currentUser.Password)
            //{
            //    db.User.First(usr => usr.Id == currentUser.Id).Password = Password;
            //}

            //if (WalletAddress != currentUser.WalletAddress)
            //{
            //    db.User.First(usr => usr.Id == currentUser.Id).WalletAddress = WalletAddress;
            //}

            db.SaveChanges();
        }
    }
}