using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class RegisterProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            var db = new M133_GoInternationalEntities1();

            //todo: errorhandling
            if (TextBoxProductName.Text == String.Empty || TextBoxPrice.Text == String.Empty || TextBoxQuantity.Text == String.Empty || TextBoxDescription.Text == String.Empty)
            {
                return;
            }

            //todo: errorhandling
            var productName = TextBoxProductName.Text;
            var price = float.Parse(TextBoxPrice.Text);
            var quantity = float.Parse(TextBoxQuantity.Text);
            var description = TextBoxDescription.Text;

            //todo: errorhandling
            var currentUser = db.User.First(usr => usr.SessionId == Session.SessionID);

            var newProduct = new Product
            {
                Name = productName,
                Price = price,
                Quantity = quantity,
                Description = description,
                Seller = currentUser.Id
            };

            AddProductToUser(newProduct, currentUser, db);

            db.Product.Add(newProduct);
            db.SaveChanges();
        }

        private void AddProductToUser(Product product, User user, M133_GoInternationalEntities1 db)
        {
            db.User.Find(user).Product.Add(product);
        }
    }
}