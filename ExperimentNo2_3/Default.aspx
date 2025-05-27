<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExperimentNo2_3.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar | Bhawarth Padwal</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="text-align: center">
                <b></b>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Black" 
                    Font-Size="Medium" ForeColor="#0066FF">
                    Indian List of Holidays 2025
                </asp:Label>
                <br />
                <b></b>
            </p>
            
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" 
                BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
                ForeColor="#663399" ShowGridLines="True" OnDayRender="Calendar1_DayRender" 
                OnSelectionChanged="Calendar1_SelectionChanged" OnVisibleMonthChanged="Calendar1_VisibleMonthChanged">
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            </asp:Calendar>
            
            <br />
            <b></b>
            <asp:Label ID="LabelAction" runat="server"></asp:Label>
            <br />
            <b></b>
        </div>
    </form>
</body>
</html>

