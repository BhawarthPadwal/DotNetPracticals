using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExperimentNo1_3
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null) {
                welcome_name_txt.Text = Request.QueryString["Name"];
                work_txt.Text = Request.QueryString["Work"];
            }
        }
    }
}