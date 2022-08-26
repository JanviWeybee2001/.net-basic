using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoTry
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Display_Data(object sender, EventArgs e)
        {
            fullNameDisplay.Text = txtFN.Text + " " + txtLN.Text;
            GenderDisplay.Text = genderList.SelectedValue;
            string str = "";
            foreach (ListItem li in HobbyList.Items)
            {
                if (li.Selected)
                    str += li.Value + ", ";
            }
            HobbyDisplay.Text = str;
            StudyDisplay.Text = StudyList.SelectedValue;
            //BDateDisplay.Text = Calendar2.SelectedDate.ToLongDateString();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            BDateDisplay.Text = Calendar2.SelectedDate.ToLongDateString();
        }
    }
}