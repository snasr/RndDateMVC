using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextWebServiceClient2
{
    public partial class Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetLower_Click(object sender, EventArgs e)
        {
            var ws = new TextWS2.TextWebServiceSoapClient();
            tbOut.Text = ws.toLower(tbIn.Text);
        }
    }
}