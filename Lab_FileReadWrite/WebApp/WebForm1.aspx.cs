using System;
using System.Configuration;  //Requires System.Configuration.DLL

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string counterVal = ConfigurationManager.AppSettings["Counter"];  //Requires System.Configuration.DLL
            Response.Write("Counter=" + counterVal);
        }
    }
}