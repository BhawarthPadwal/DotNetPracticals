<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExperimentNo2_5.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Files | Bhawarth Padwal
    </title>
</head>
<body>
    <form id="upload" runat="server">
        <div>
            <p>Browse to Upload File</p>
            <asp:FileUpload ID="FileUpload" runat="server" />
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Upload File" OnClick="Button_Click" />
        </p>
        <p>
            <asp:Label runat="server" ID="UploadStatus"></asp:Label>
        </p>
        Click on the button to download a file
        <br /><br />       
        <asp:Label ID="lblFilename" runat="server"></asp:Label>
        <asp:Button ID="downloadButton" runat="server" Text="Download" OnClick="downloadButton_Click" />
        <br />
        <br />
        <asp:Label ID="downloadLabel" runat="server"></asp:Label>
    </form>
</body>
</html>

