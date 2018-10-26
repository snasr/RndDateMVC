﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TextWebService
{
    /// <summary>
    /// Summary description for TextWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TextWebService : System.Web.Services.WebService
    {
        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}

        [WebMethod]
        public string toUpper(string parm1)
        {
            return parm1.ToUpper();
        }

        [WebMethod]
        public string toLower(string parm1)
        {
            return parm1.ToLower();
        }
    }
}
