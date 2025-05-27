<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ExperimentNo3_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CRUD | Bhawarth Padwal</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 52px;
        }
        .auto-style4 {
            height: 50px;
        }
        .auto-style5 {
            height: 50px;
            width: 226px;
        }
        .auto-style7 {
            height: 208px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Employee Form."></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text="Employee Id"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="eid_txt" runat="server" Height="35px" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label3" runat="server" Text="Employee Name"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="ename_txt" runat="server" Height="35px" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label4" runat="server" Text="Employee Designation"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="edesign_txt" runat="server" Height="35px" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label5" runat="server" Text="Employee Contact"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="econtact_txt" runat="server" Height="35px" Width="250px" style="margin-left: 0px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label6" runat="server" Text="Employee Address"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="eaddress_txt" runat="server" Height="35px" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Button ID="insert_btn" runat="server" Font-Bold="True" Text="Insert" Height="35px" Width="100px" OnClick="insert_btn_Click" />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="update_btn" runat="server" Font-Bold="True" Text="Update" Height="35px" Width="100px" OnClick="update_btn_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="delete_btn" runat="server" Font-Bold="True" Text="Delete" Height="35px" Width="100px" OnClick="delete_btn_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="show_btn" runat="server" Font-Bold="True" Text="Show Data" Height="35px" Width="100px" OnClick="show_btn_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" BorderColor="Black" BorderWidth="1px" CellPadding="5">
                        </asp:GridView>
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
