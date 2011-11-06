<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sample_easycallback.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EasyCallback: Facilitando el uso de llamadas asíncronas en ASP.NET</title>
    <script type="text/javascript">
        function EasyCallback() {
            DoubleCallback(document.getElementById('number').value, function (output) {
                alert(output);
            });
            return false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="text" id="number" /><br />
        <a href="#" onclick="return EasyCallback();">EasyCallback!</a>
    </div>
    </form>
</body>
</html>
