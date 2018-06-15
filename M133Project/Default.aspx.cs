using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace M133Project
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;Port=3306;database=test0;uid=root;SslMode=0;password=");

            //open the connection
            connection.Open();

            //close the connection
            connection.Close();
        }
    }
}