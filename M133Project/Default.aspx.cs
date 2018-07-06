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
    }
}