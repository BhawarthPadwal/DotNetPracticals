<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExperimentNo2_4.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Link Pages | Bhawarth Padwal</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server" Height="230px" Width="119px">
                <Nodes>
                    <asp:TreeNode NavigateUrl="~/Home.aspx" Text="Home" Value="Home"></asp:TreeNode>
                    <asp:TreeNode Text="Employee" Value="Employee">
                        <asp:TreeNode NavigateUrl="~/ProfilePage.aspx" Text="Profile" Value="Profile"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Resume.aspx" Text="Upload Resume" Value="Upload Resume"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Admin" Value="Admin">
                        <asp:TreeNode NavigateUrl="~/AddUser.aspx" Text="Add User" Value="Add User"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
            </asp:TreeView>
        </div>
    </form>
</body>
</html>

