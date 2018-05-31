<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LineBot001.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Height="72px" OnClick="Button1_Click" Text="發送文字" Width="138px" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="75px" OnClick="Button2_Click" Text="發送貼圖" Width="137px" />
        </p>
    </form>
</body>
</html>
