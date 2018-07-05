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
        public List<Product> ShoppingCardFromUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["shoppingCart"] is List<Product> shoppingCart)
            {
                this.ShoppingCardFromUser = shoppingCart;
            }
        }

        protected void OnCheckoutClick(object sender, EventArgs e)
        {

        }
    }
}