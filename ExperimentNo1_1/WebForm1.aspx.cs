using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExperimentNo1_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e) 
        {
            Label1.Text += "<br/>PreInit";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Label1.Text += "<br/>Init";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Label1.Text += "<br/>InitComplete";
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Label1.Text += "<br/>PreLoad";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += "<br/>LoadStarted";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text += "<br/>SubmitButtonClicked";
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label1.Text += "<br/>LoadComplete";
        }
        protected override void OnPreRender(EventArgs e)
        {
            Label1.Text += "<br/>PreRender";
        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
            Label1.Text += "<br/>SaveStateComplete";
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            Label1.Text += "<br/>UnLoad";
        }
    }
}