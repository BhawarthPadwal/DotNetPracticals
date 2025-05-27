<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdsData.aspx.cs" Inherits="ExperimentNo2_2.AdsData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdRotator | Bhawarth Padwal</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile1.xml" Height="600px" Width="1500px"/>
        </div>
    </form>
</body>
</html>
