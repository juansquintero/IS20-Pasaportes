<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Driver/CS.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        .auto-style8 {
            height: 37px;
        }
        .auto-style9 {
            width: 478px;
            height: 37px;
        }
        .auto-style11 {
            width: 100%;
        }
    </style>
</head>
<body>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script src='<%=ResolveUrl("~/Webcam_Plugin/jquery.webcam.js") %>' type="text/javascript"></script>
<script type="text/javascript">
var pageUrl = '<%=ResolveUrl("~/View/Driver/CS.aspx") %>';
$(function () {
    jQuery("#webcam").webcam({
        width: 400,
        height: 280,
        mode: "save",
        swffile: '<%=ResolveUrl("~/Webcam_Plugin/jscam.swf") %>',
        debug: function (type, status) {
            $('#camStatus').append(type + ": " + status + '<br /><br />');
        },
        onSave: function (data) {
            $.ajax({
                type: "POST",
                url: pageUrl + "/GetCapturedImage",
                data: '',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    $("[id*=imgCapture]").css("visibility", "visible");
                    $("[id*=imgCapture]").attr("src", r.d);
                },
                failure: function (response) {
                    alert(response.d);
                }
            });
        },
        onCapture: function () {
            webcam.save(pageUrl);            
        }
    });
});
function Capture() {
    webcam.capture();
    alert("Presione escanear");
    return false;
}
</script>
<form id="form1" runat="server">
<table border="0" cellpadding="0" cellspacing="0" class="auto-style11">
    <tr>
        <td align="center" class="auto-style8">
            <u><h1>Camara</h1></u>
        </td>
        <td class="auto-style8">
        </td>
        <td align="center" class="auto-style9">
            <u><h1>Usuario</h1></u>
        </td>
        
    <tr>
        <td>
            <div align="center" id="webcam">
            </div>
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            <br />
            <table class="auto-style11">
                <tr>
                    <td><strong>Nombre:</strong></td>
                    <td><asp:Label ID="LB_Name" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong>Apellido:</strong></td>
                    <td><asp:Label ID="LB_LastName" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong>Codigo:</strong></td>
                    <td><asp:Label ID="LB_Code" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong>Pasaportes:</strong></td>
                    <td>
                        <asp:Label ID="LB_Bonos" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<br />
    <table class="auto-style11">
        <tr>
            <td align="center">
<asp:Button ID="btnCapture" Text="Capturar" runat="server" OnClientClick="return Capture();" OnClick="BT_Escanear_Click" />
    <asp:Button ID="BT_Escanear" runat="server" OnClick="BT_Escanear_Click" Text="Escanear" />
    <asp:Button ID="BT_Salir" runat="server" OnClick="BT_Salir_Click" Text="Salir" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
<br />
<span id="camStatus"></span>
</form>
</body>
</html>
