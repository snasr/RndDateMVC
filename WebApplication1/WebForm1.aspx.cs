using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random num1 = new Random();
            Random num2 = new Random();

            int num3 = num1.Next(11);
            int num4 = num2.Next(11);

            int Result = num3 * num4;
            TextBox1.Text = (Convert.ToString(Result));
        }
    }
}