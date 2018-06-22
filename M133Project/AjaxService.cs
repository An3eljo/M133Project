using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace M133Project
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService] // Don't forget to uncomment it.
    public class AjaxService : System.Web.Services.WebService
    {
        [WebMethod]
        public static string GetDateTime(string name)
        {
            return "hello" + name + "Time: " + DateTime.Now.ToString();
        }
    }
}