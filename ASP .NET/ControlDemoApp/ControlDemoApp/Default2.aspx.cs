using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemoApp
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 4; i < 10; i++)
                {
                    ListItem li = new ListItem("Item " + i, i.ToString());
                    ddlDemo.Items.Add(li);
                    lbDemo.Items.Add(li);
                    cblDemo.Items.Add(li);
                    rdlDemo.Items.Add(li);
                }
            }
        }

        protected void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";
            if (sender is DropDownList)
                Response.Write(ddlDemo.SelectedValue);
            else if (sender is ListBox)
            {
                foreach (int index in lbDemo.GetSelectedIndices())
                {
                    str += index + " ";
                }
                Response.Write(str);
            }
            else if (sender is CheckBoxList)
            {
                foreach (ListItem li in cblDemo.Items)
                {
                    if (li.Selected)
                        str += li.Value + " ";
                }
                Response.Write(str);
            }
            else if (sender is RadioButtonList)
                Response.Write(rdlDemo.SelectedValue);
        }
    }
}