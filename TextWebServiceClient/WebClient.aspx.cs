using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextWebServiceClient
{
    public partial class WebClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnToLower_Click(object sender, EventArgs e)
        {
            var tw = new TextWS.TextWebServiceSoapClient();
            tbResult.Text = tw.toLower(tbInput.Text);
        }
    }
}