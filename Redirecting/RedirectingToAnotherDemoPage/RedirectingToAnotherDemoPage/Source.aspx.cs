using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedirectingToAnotherDemoPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            // This code will not execute on refresh page..
            // here, HTTP get will use
            string value = txtDemo.Text;
            Response.Redirect("Target.aspx?demo=" + value);
        }

        public string Demotxt
        {
            get
            {
                return txtDemo.Text;
            }
        }

        protected void btnTrasfer_Click(object sender, EventArgs e)
        {
            // This code will execute on refresh page..
            Context.Items["demo"] = txtDemo.Text;
            Server.Transfer("Target.aspx");
        }

        protected void btnCrossPagePostback_Click(object sender, EventArgs e)
        {
            // we have no write any code for this.. we directly give the url from property in rawupl
            // here, HTTP post will use
        }
    }
}