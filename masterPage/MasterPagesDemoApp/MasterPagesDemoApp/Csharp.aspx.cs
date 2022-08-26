using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesDemoApp
{
    public partial class Csharp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDemo_Click(object sender, EventArgs e)
        {
            Label lbl = (Label) Master.FindControl("lblInMaster");
            lbl.Text = "From button click of C#page";
        }
    }
}