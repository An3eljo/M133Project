using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace M133Project
{
    public partial class _Default : Page
    {
        public List<Product> Products;
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new M133_GoInternationalEntities1();
            Products = db.Product.ToList();
            
        }

        //protected void OnClick(object sender, EventArgs e)
        //{
        //    Test.Text = "hallo";
        //}


        //[System.Web.Services.WebMethod]
        //public static string GetCurrentTime(string name)
        //{
        //    return "Hello " + name + Environment.NewLine + "The Current Time is: "
        //           + DateTime.Now.ToString();
        //}

        protected void OnProductClick(object sender, EventArgs e)
        {
            //todo: set id
            var id = 0;
            Response.Redirect($"ProductDetails.aspx/?id={id}");
        }
    }
}