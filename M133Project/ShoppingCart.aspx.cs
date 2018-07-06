using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        //todo: sql database login with session id
        public List<Product> ShoppingCardFromUser;
        private string redirectUrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["redirectUrl"] != null)
            {
                redirectUrl = Server.UrlDecode(Request.QueryString["redirectUrl"]);
            }

            if (Session["shoppingCart"] is List<Product> shoppingCart)
            {
                this.ShoppingCardFromUser = shoppingCart;
            }
        }

        protected void OnCheckoutClick(object sender, EventArgs e)
        {

        }

        protected void OnBackClick(object sender, EventArgs e)
        {
            Response.Redirect(redirectUrl);
        }

        protected void ButtonHome_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        protected void ButtonCheckout_OnClick(object sender, EventArgs e)
        {
            
        }
    }
}