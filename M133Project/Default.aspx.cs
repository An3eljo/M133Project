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
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var connection = new MyDbEntities)
            {
                
            }

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

        protected void btnHelloWorld_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello, world - this is a fresh message from ASP.NET AJAX! The time right now is: " + DateTime.Now.ToLongTimeString();
        }

        [System.Web.Services.WebMethod]
        public static string GetCurrentTime(string name)
        {
            return "Hello " + name + Environment.NewLine + "The Current Time is: "
                   + DateTime.Now.ToString();
        }
    }
}