<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    	var defaultMonth = "Jan";
        var currentMonthElement = null;
        function OnClick(s, e) {
            ClearSelection();
            dde.cpPrevMonth = s.name;
        	s.GetMainElement().style.backgroundColor = "orange";
        	currentMonthElement = s;

        }
        function OnPrevClick(s, e) {
            ClearSelection();
            lblYear.SetText(parseInt(lblYear.GetText()) - 1);
            currentMonthElement = null;
        }
        function OnNextClick(s, e) {
            ClearSelection();
            lblYear.SetText(parseInt(lblYear.GetText()) + 1);
            currentMonthElement = null;
        }
        function OnOkClick(s, e) {

        	var month = !!currentMonthElement ? currentMonthElement.GetText() : defaultMonth;
            dde.SetText(lblYear.GetText() + "-" + month);
            dde.HideDropDown();
        }
        function ClearSelection() {
            if (dde.cpPrevMonth != null) {
                var element = document.getElementById(dde.cpPrevMonth);
                element.style.backgroundColor = "inherit";
            }
        }
    </script>

    <style type="text/css">
        .cell .buttonMonth
        {
            border-width: 1px;
            width: 50px;
            text-align: center;
			text-decoration:none;
			color:inherit;
        }
        .tab
        {
            width: 100%;
            border-color: #600;
            border-width: 0 0 1px 1px;
            border-style: solid;
        }
        .cell
        {
            border-color: #600;
            border-width: 1px 1px 0 0;
            border-style: solid;
            margin: 0;
            padding: 4px;
            background-color: #eee6a3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxDropDownEdit ID="DDE" ClientInstanceName="dde" runat="server" OnInit="DDE_Init">
            </dx:ASPxDropDownEdit>
        </div>
    </form>
</body>
</html>