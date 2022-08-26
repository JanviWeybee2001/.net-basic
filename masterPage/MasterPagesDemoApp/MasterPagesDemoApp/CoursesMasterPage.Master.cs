using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesDemoApp
{
    public partial class CoursesMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblInMaster.Text = "From Page load of Master";
        }

        protected void btnDemo_Click(object sender, EventArgs e)
        {
            lblInMaster.Text = "From button click of master page..";
        }

        public string MasterLabelText
        {
            get
            {
                return lblInMaster.Text;
            }
            set
            {
                lblInMaster.Text = value;
            }
        }
    }
}