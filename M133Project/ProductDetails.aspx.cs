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
        protected void Page_Load(object sender, EventArgs e)
        {
            var productId = int.Parse(Request.QueryString["id"]);
            
            var db = new M133_GoInternationalEntities1();
            var product = db.Product.First(prd => prd.Id == productId);
            this.Product = product;
        }

        protected void OnBuyClick(object sender, EventArgs e)
        {

            if (Session["shoppingCart"] == null)
            {
                Session["shoppingCart"] = new List<Product>();
            }

            //todo: 
            //((List<Product>)Session["shoppingCart"]).Add(currentProduct);
        }
    }
}