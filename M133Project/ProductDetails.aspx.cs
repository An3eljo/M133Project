using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        public Product Product;
        public User Seller;
        protected void Page_Load(object sender, EventArgs e)
        {
            var productId = int.Parse(Request.QueryString["id"]);
            Initialize(productId);
        }

        private void Initialize(int id)
        {
            var db = new M133_GoInternationalEntities1();
            var product = db.Product.First(prd => prd.Id == id);
            this.Product = product;

            var seller = db.User.First(user => product.Seller == user.Id);
            this.Seller = seller;
        }

        protected void OnBuyClick(object sender, EventArgs e)
        {
            if (Session["shoppingCart"] == null)
            {
                Session["shoppingCart"] = new List<Product>();
            }

            ((List<Product>)Session["shoppingCart"]).Add(Product);

            var currentUrl = Request.Url.PathAndQuery;

            Response.Redirect($"/ShoppingCart.aspx/?redirectUrl={currentUrl}");
        }
    }
}