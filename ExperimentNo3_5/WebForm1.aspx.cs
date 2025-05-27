using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExperimentNo3_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // No specific logic needed for this demo.
        }

        // RowDataBound event to format price
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Format the price column with a currency format
                e.Row.Cells[2].Text = string.Format("{0:C}", Convert.ToDouble(e.Row.Cells[2].Text));
            }
        }

    }
}