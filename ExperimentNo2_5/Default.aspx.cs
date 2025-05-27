using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExperimentNo2_5
{
    public partial class Default : System.Web.UI.Page
    {
        protected System.Web.UI.HtmlControls.HtmlInputFile File;
        protected System.Web.UI.HtmlControls.HtmlInputButton Submit;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string filename = string.Empty;
        protected void Button_Click(object sender, EventArgs e)
        {
            if ((FileUpload.PostedFile != null) && (FileUpload.PostedFile.ContentLength > 0))
            {
                filename = System.IO.Path.GetFileName(FileUpload.PostedFile.FileName);
                string SaveLocation = Server.MapPath("upload") + "\\" + filename;
                try
                {
                    FileUpload.PostedFile.SaveAs(SaveLocation);
                    UploadStatus.Text = "The file has been uploaded.";
                    lblFilename.Text = "upload/" + FileUpload.FileName;
                }
                catch (Exception ex)
                {
                    UploadStatus.Text = "Error: " + ex.Message;
                }
            }
            else
            {
                UploadStatus.Text = "Please select a file to upload.";
            }
        }

        protected void downloadButton_Click(object sender, EventArgs e)
        {

            // To download uplaoded file  

            if (lblFilename.Text != string.Empty)
            {
                if (lblFilename.Text.EndsWith(".txt"))
                {
                    Response.ContentType = "application/txt";
                }
                else if (lblFilename.Text.EndsWith(".pdf"))
                {
                    Response.ContentType = "application/pdf";
                }
                else if (lblFilename.Text.EndsWith(".docx"))
                {
                    Response.ContentType = "application/docx";
                }
                else
                {
                    Response.ContentType = "image/jpg";
                }

                string filePath = lblFilename.Text;

                Response.AddHeader("Content-Disposition", "attachment;filename=\"" + filePath + "\"");
                Response.TransmitFile(Server.MapPath(filePath));
                Response.End();
            }
        }

    }
}