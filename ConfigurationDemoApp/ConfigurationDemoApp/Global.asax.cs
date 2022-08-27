using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ConfigurationDemoApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string path = Request.Path;
            if (path.StartsWith("/product"))
            {
                string[] split = path.Split('/');
                string file = split[2].Split('.')[0];
                Context.RewritePath("~/Computer.aspx", "", "Id=" + file);
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Application Error
            Exception ex = Context.Error.InnerException;
            if (ex is ApplicationException)
            {
                Response.Write(ex.Message);

                Context.ClearError();
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}