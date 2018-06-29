using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void OnClick(object sender, EventArgs e)
        {
            var db = new M133_GoInternationalEntities1();


            var username = TextBoxUsername.Text;
            var password = TextBoxPassword.Text;
            var wallettAddress = TextBoxWalletAddress.Text;

            if (db.User.Any(existinguser => existinguser.Username == username))
            {
                LabelErrorUserExists.Visible = true;
                TextBoxPassword.Text = String.Empty;
                return;
            }
            

            if (username != String.Empty && password != String.Empty)
            {
                var user = new User();
                user.Username = username;
                user.Password = password;


                if (wallettAddress != String.Empty)
                {
                    user.WalletAddress = wallettAddress;
                }

                db.User.Add(user);
                db.SaveChanges();
                
            }
            else
            {
                LabeErrorEmptyFields.Visible = true;
                TextBoxPassword.Text = String.Empty;
                return;
            }
        }
    }
}