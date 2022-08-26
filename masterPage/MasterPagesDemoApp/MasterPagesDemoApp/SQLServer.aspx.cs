using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesDemoApp
{
    public partial class SQLServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) // If I write here "Page_LoadComplete", then it will override the page load of master.. 
        {
            Label lbl = (Label)Master.FindControl("lblInMaster");
            lbl.Text = "From Page load of SQL Server..";
        }
    }
}