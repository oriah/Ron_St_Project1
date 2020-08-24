<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Write Something : " ></asp:Label>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
            <asp:Button OnClick="OnClick" Text="Click Me !!" runat="server"/>
        </div>
    </form>
</body>
</html>
