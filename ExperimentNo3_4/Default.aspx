<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExperimentNo3_4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stored Procedure | Shruti Dalvi</title>
    </head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3" style="font-size: larger"><strong>Employee Form</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">Employee ID</td>
                <td class="auto-style6">:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="278px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Employee Name</td>
                <td class="auto-style6">:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="278px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Employee City</td>
                <td class="auto-style7">:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="26px" Width="278px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style6"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Height="42px" Text="Insert" Width="216px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Height="39px" Text="Update" Width="131px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Font-Bold="True" Height="39px" Text="Delete" Width="130px" OnClick="Button3_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style6"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridView1" runat="server" Height="214px" Width="521px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <div>
        </div></form></body>

</html>
