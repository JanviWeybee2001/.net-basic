using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyfirstWebApp
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //protected void rbnRED_CheckedChanged(object sender, EventArgs e)
        //{
        //    lblDemo.ForeColor = System.Drawing.Color.Red;
        //}

        //protected void rbnGreen_CheckedChanged(object sender, EventArgs e)
        //{
        //    lblDemo.ForeColor = System.Drawing.Color.Green;
        //}

        //protected void rbnBlue_CheckedChanged(object sender, EventArgs e)
        //{
        //    lblDemo.ForeColor = System.Drawing.Color.Blue;
        //}

        protected void rbnColor_CheckedChanged(object sender, EventArgs e)
        {
            //    if (rbnRED.Checked)
            //        lblDemo.ForeColor = System.Drawing.Color.Red;
            //    else if (rbnGreen.Checked)
            //        lblDemo.ForeColor = System.Drawing.Color.Green;
            //    else
            //        lblDemo.ForeColor = System.Drawing.Color.Blue;


            RadioButton rbn = (RadioButton)sender;
            lblDemo.ForeColor = System.Drawing.Color.FromName(rbn.Text);
        }
    }
}