using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExperimentNo1_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void proceed_btn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Display.aspx?Name= "+name_txt.Text+"&Work=Mobile App Developer");
        }
    }
}