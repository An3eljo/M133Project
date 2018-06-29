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


            //var product = new Product();

            //var user = new User();
            //user.Product = new List<Product>();
            //user.Username = "user1";
            //user.Password = "user1";
            //product.Id = 1;

            //product.Description = "description1";
            //product.Id = 1;
            //product.Price = 24.5F;
            //product.Quantity = 586.78F;
            //product.Seller = 1;
            //product.Name = "Luan";

            //user.Product.Add(product);

            //var db = new M133_GoInternationalEntities1();
            //db.Product.Add(product);
            //db.User.Add(user);
            //db.SaveChanges();   

            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //builder.DataSource = "andrischool.database.windows.net,1433";
            //builder.UserID = "andrijoos";
            //builder.Password = "Andrielia99";

            //using (var connection = new SqlConnection(builder.ConnectionString))
            //{
            //    connection.Open();
            //}

            //MySqlConnection connection = new MySqlConnection("server=localhost;Port=3306;database=test0;uid=root;SslMode=0;password=");

            ////open the connection
            //connection.Open();

            ////close the connection
            //connection.Close();
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

        private void SetUp()
        {
            var db = new M133_GoInternationalEntities1();
            foreach (var product in db.Product)
            {
                Products.Add(product);
            }
        }
    }
}