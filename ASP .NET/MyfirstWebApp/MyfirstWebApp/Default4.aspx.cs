using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyfirstWebApp
{
    public partial class Default4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) 
            {
                for(int i=0; i<5; i++) {
                    ListItem li = new ListItem();
                    li.Text = "item " + i;
                    li.Value = i.ToString();
                    LstLeft.Items.Add(li);
                }
            }
        }

        protected void LBleft_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void isMoveLtoR_Click(object sender, EventArgs e)
        {
            ListItem li = LstLeft.SelectedItem;
            LstLeft.Items.Remove(li);
            li.Selected = false;
            LstRight.Items.Add(li);
        }

        protected void isMoveRtoL_Click(object sender, EventArgs e)
        {
            ListItem li = LstRight.SelectedItem;
            LstRight.Items.Remove(li);
            li.Selected = false;
            LstLeft.Items.Add(li);
        }
    }
}