<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ExperimentNo1_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page | Bhawarth Padwal</title>
    <style type="text/css">
        .auto-style1 {
            width: 300px;
        }
        .auto-style2 {
            width: 433px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Hello there!</h2>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Enter your name to proceed: </td>
                <td class="auto-style2">
                    <asp:TextBox ID="name_txt" runat="server" Width="350px"></asp:TextBox></td>
                <td>
                    <asp:Button ID="proceed_btn" runat="server" Text="Proceed" OnClick="proceed_btn_Click" style="margin-left: 0px" Width="250px" /></td>
            </tr>
            </table> 
    </form>
</body>
</html>
