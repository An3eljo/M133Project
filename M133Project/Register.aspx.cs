using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133Project
{
    public partial class Register : System.Web.UI.Page
    {
        public List<string> Text = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Text.AddRange(new []
            {
                "1",
                "2",
                "3"
            });
        }

        protected void OnClick(object sender, EventArgs e)
        {
            
        }
    }
}