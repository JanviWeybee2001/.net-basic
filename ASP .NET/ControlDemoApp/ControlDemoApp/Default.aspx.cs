using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemoApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text =  "a<b"; // it only print 'a'
                                  
            Label1.Text = Server.HtmlEncode("a<b"); // it only print 'a'
            //In literal := same problem here it only print 'a' so, we have to do Property Encode of mode in label's property'
 

            // text box have textmode property..

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Write("Deleted..");
        }

        protected void btnAdd_Command(object sender, CommandEventArgs e)
        {
            switch(e.CommandName)
            {
                case "Add":
                    Response.Write("Added");
                    break;
                case "Edit":
                    Response.Write("Edited");
                    break;
                case "Delete":
                    Response.Write("Deleted");
                    break;
                default:
                    break;
            }
        }

        protected void lbtn_Click(object sender, EventArgs e)
        {

        }

 
    }
}