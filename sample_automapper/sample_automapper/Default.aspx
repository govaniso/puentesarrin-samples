<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sample_automapper._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script src="js/jquery-1.4.4.min.js" type="text/javascript"></script>
    <script src="js/jquery.dataTables.min.js" type="text/javascript"></script>
    <style type="text/css" media="screen">
		@import "/css/site_jui.css";
		@import "/css/demo_table_jui.css";
		@import "/css/jquery-ui-1.7.2.custom.css";
		.dataTables_info { padding-top: 0; }
		.dataTables_paginate { padding-top: 0; }
		.css_right { float: right; }
		#tableemployees { width: 100% }
		#tableemployees_wrapper .fg-toolbar { font-size: 0.8em }
		#theme_links span { float: left; padding: 2px 10px; }
	</style>
    <script type="text/javascript">
        $(document).ready(function() {
            $('#tableemployees').dataTable({
                "bJQueryUI": true,
                "sPaginationType": "full_numbers",
                "aoColumns": [
                    null,
                    null,
                    null,
                    { "bSortable": false, "bSearchable": false },
                ]
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="Employees" runat="server">
    </div>
    </form>
</body>
</html>
