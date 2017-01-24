using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace _01_ApiyEF
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Postman App
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
