<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Carousel y Lightbox: Galería de imágenes con jQuery</title>
    <style type="text/css">
        * { margin: 0; padding: 0; border: 0; }
    </style>
    <link href="css/skin.css" rel="stylesheet" type="text/css" />
    <link href="css/jquery.lightbox-0.5.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.4.1.js" type="text/javascript"></script>
    <script src="js/jquery.jcarousel.min.js" type="text/javascript"></script>
    <script src="js/jquery.lightbox-0.5.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
            $('#carousel').jcarousel();
            $('#carousel a').lightBox();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="carousel" runat="server" class="jcarousel-skin-tango">
        </div>
    </form>
</body>
</html>
