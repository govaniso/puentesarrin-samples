<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sample_webpagebitmap._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUrl" runat="server" AssociatedControlID="txtUrl">Url:</asp:Label>
        <asp:TextBox ID="txtUrl" runat="server"></asp:TextBox>
        <asp:Button ID="btnCapturar" runat="server" Text="Capturar" OnClick="btnCapturar_Click" />
    </div>
    <hr />
    <ul ID="ulImagenes" runat="server"></ul>
    </form>
</body>
</html>
