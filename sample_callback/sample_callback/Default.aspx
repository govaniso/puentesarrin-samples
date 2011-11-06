<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ICallbackEventHandler</title>
    <script type="text/javascript">
        function callback(arg) {
	        WebForm_DoCallback('__Page', arg, ProcessCallBack, null, null, false);
        }
        function ProcessCallBack(arg) {
            alert(arg);
        }
        function call()
        {
            callback(document.getElementById('number').value);
            return false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Número: <input type="text" id="number" /><br />
    <a href="#" onclick="return call();">Callback!</a>
    </div>
    </form>
</body>
</html>
