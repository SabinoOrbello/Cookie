<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondPage.aspx.cs" Inherits="WebApplication1.SecondPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Benvenuto</h2>
            <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>
