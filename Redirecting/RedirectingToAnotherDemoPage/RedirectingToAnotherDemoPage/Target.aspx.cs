using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedirectingToAnotherDemoPage
{
    public partial class Target : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!IsPostBack)
            //{
            //    Response.Write("HyperLink / Redirect <br>");
            //}
            //else
            if(PreviousPage == null)
            {
                string value = Request.QueryString["demo"];
                Response.Write("HyperLink / Redirect <br> reciverd data = " + value);
            }
            else if(PreviousPage.IsCrossPagePostBack)
            {
                //string value = Request.Form["txtDemo"];
                //TextBox txtDemo = (TextBox)PreviousPage.FindControl("txtDemo");
                //string value = txtDemo.Text;
                //string value = ((WebForm1)PreviousPage).Demotxt; // If we don't need to casting by a page then we have added '<%@ PreviousPageType virtualPath="~/Source.aspx"%>' in Target.aspx page
                string value = PreviousPage.Demotxt;
                Response.Write("cross page PostBack <br> reciverd data = " + value);
            }
            else
            {
                //string value = Context.Items["demo"].ToString();
                //TextBox txtDemo = (TextBox)PreviousPage.FindControl("txtDemo");
                //string value = txtDemo.Text;
                string value = ((WebForm1)PreviousPage).Demotxt;
                Response.Write("Transfer <br> reciverd data = " + value );
            }            
        }
    }
}