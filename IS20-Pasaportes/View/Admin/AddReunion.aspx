<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Admin/AddReunion.aspx.cs" Inherits="View_Admin_AddReunion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script src="../../Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<script src="../../Scripts/jquery.dynDateTime.min.js" type="text/javascript"></script>
<script src="../../Scripts/calendar-en.min.js" type="text/javascript"></script>
<link href="../../Styles/calendar-blue.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(document).ready(function () {
        $("#<%=TextBox1.ClientID %>").dynDateTime({
            showsTime: true,
            ifFormat: "%Y/%m/%d %H:%M",
            daFormat: "%l;%M %p, %e %m,  %Y",
            align: "BR",
            electric: false,
            singleClick: false,
            displayArea: ".siblings('.dtcDisplayArea')",
            button: ".next()"
        });
    });
</script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
&nbsp;<table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td align="center">
                    <h1>Añadir reunion</h1>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td align="center">
<asp:TextBox ID="TextBox1" runat="server" ReadOnly = "true"></asp:TextBox>
<img src="calender.png" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td align="center">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td align="center"><asp:Button ID="btnSave" runat="server" Text="Guardar" onclick="btnSave_Click" />
                    <asp:Button ID="BT_Salir" runat="server" Text="Salir" OnClick="BT_Salir_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
