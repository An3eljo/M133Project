using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class PublicUserInformation : System.Web.UI.Page
    {
        public User CurrentUser;
        public List<Product> ProductsFromUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            var userId = int.Parse(Request.QueryString["id"]);
            Initialize(userId);
        }

        private void Initialize(int id)
        {
            //todo: errorhandling
            var db = new M133_GoInternationalEntities1();
            var user = db.User.First(use => use.Id == id);

            ProductsFromUser = user.Product.ToList();

            CurrentUser = user;
        }
    }
}