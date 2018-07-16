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
            var db = new M133_GoInternationalEntities1();
            //todo: errorhandling
            var currentUser = db.User.First(usr => usr.SessionId == Data.SessionId);

            this.CurrentUser = currentUser;
        }

        protected void OnSafeClick(object sender, EventArgs e)
        {
            //todo: errorhandling
            var db = new M133_GoInternationalEntities1();
            var currentUser = db.User.First(usr => usr.SessionId == Data.SessionId);

            var username = TextBoxUsername.Text;
            var password = TextBoxPassword.Text;
            var walletaddress = TextBoxWalletAddress.Text;

            if (username != currentUser.Username)
            {
                db.User.First(usr => usr.Id == currentUser.Id).Username = username;
            }

            if (password != currentUser.Password)
            {
                db.User.First(usr => usr.Id == currentUser.Id).Password = password;
            }

            if (walletaddress != currentUser.WalletAddress)
            {
                db.User.First(usr => usr.Id == currentUser.Id).WalletAddress = walletaddress;
            }

            db.SaveChanges();
        }
    }
}