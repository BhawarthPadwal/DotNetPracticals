<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ExperimentNo3_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADO.NET | Bhawarth Padwal</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 66px;
        }
        .auto-style3 {
            height: 50px;
        }
        .auto-style5 {
            width: 297px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Employee Data."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="eid" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="eid" HeaderText="eid" ReadOnly="True" SortExpression="eid" />
                            <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                            <asp:BoundField DataField="edesignation" HeaderText="edesignation" SortExpression="edesignation" />
                            <asp:BoundField DataField="econtact" HeaderText="econtact" SortExpression="econtact" />
                            <asp:BoundField DataField="eaddress" HeaderText="eaddress" SortExpression="eaddress" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [EmployeeData]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
