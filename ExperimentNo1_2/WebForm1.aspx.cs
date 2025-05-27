using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExperimentNo1_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_btn_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedItem != null)
            {
                if (name_txt.Text != null && email_txt.Text != null && address_txt.Text != null && DropDownList1.SelectedItem != null)
                {
                    DisplayInfo.Text = "<h3>Selection Completed</h3>";
                    DisplayInfo.Text += "Name: " + name_txt.Text.ToString();
                    DisplayInfo.Text += "<br>Class: " + DropDownList1.SelectedValue.ToString();
                    DisplayInfo.Text += "<br>Email ID: " + email_txt.Text.ToString();
                    DisplayInfo.Text += "<br>Gender: " + RadioButtonList1.SelectedValue.ToString();
                    DisplayInfo.Text += "<br>Address: " + address_txt.Text.ToString();
                }
                else
                {
                    DisplayInfo.Text = "<br>Please fill above information.";
                }
            }
            else {
                DisplayInfo.Text = "<br>Please select your gender.";
            }
        }
    }
}