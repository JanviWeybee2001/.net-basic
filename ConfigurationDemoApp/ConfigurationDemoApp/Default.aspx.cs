using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConfigurationDemoApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MetaKeywords = "asp.net,C#";
            Page.MetaDescription = "This is an asp.net site that hosts asp.net tutorials";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ltrDemo.Text = txtDemo.Text;
        }

        protected void btnException_Click(object sender, EventArgs e)
        {
            throw new ApplicationException("Error.. by throw new applicationException..");
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            
        }
    }
}