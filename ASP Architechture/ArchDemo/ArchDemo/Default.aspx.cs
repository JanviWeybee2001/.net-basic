using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArchDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            TextBox1.Text = "Init";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("LOADing.. <br>");
            TextBox1.Text = "Load";
            Response.Write(Demo.SayHello());
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    //Response.Write("ONLOADing.. <br>");
        //    //base.OnLoad(e);
        //}

        //protected void Page_PreRender(object sender, EventArgs e)
        //{
        //    TextBox1.Text = "PreRender";
        //}
        //public Default()
        //{
        //    //    TextBox1.Text = " ";
        //}
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.ForeColor = System.Drawing.Color.Red;
            // beacause of this button 2 's text is also showing red
            // if we set the property enableStateView = False , then it'll become black.
            // onnly color property come eith viewState, not text property.. UNDERSTAND
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("text has Changed");
        }
    }
}