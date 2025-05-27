<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ExperimentNo1_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page | Bhawarth Padwal</title>
    <style type="text/css">
        .auto-style1 {
            width: 409px;
        }
        .auto-style2 {
            width: 251px;
        }
    </style>
</head>
<body style="border-style: solid; border-width: 2px; padding: 1px 1px">
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td colspan="3" class="auto-style1">
                    <h2 style="width: 100%">&nbsp; PERSONAL INFORMATION</h2>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Name  of the student</strong></td>
                <td><strong>:</strong></td>
                <td>
                    <asp:TextBox ID="name_txt" runat="server" Width="250px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Class</strong></td>
                <td><strong>:</strong></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
                        <asp:ListItem Selected="True" Value="None">Select Class</asp:ListItem>
                        <asp:ListItem>FYMCA-A</asp:ListItem>
                        <asp:ListItem>FYMCA-B</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Email ID</strong></td>
                <td><strong>:</strong></td>
                <td>
                    <asp:TextBox ID="email_txt" runat="server" Width="250px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Gender</strong></td>
                <td><strong>:</strong></td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Address</strong></td>
                <td><strong>:</strong></td>
                <td>
                    <asp:TextBox ID="address_txt" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="3"></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="submit_btn" runat="server" Text="Submit" Width="250px" OnClick="submit_btn_Click" /></td>
            </tr>
             <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="DisplayInfo" runat="server"></asp:Label>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
