﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Driver/CS.aspx.cs" Inherits="_Default" %>

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
        .auto-style1 {
            width: 320px;
        }
        .auto-style2 {
            width: 320px;
            text-decoration: underline;
        }
        .auto-style3 {
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
        width: 320,
        height: 240,
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
    return false;
}
</script>
<form id="form1" runat="server">
<table border="0" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td align="center">
            <u><h1>Camara</h1></u>
        </td>
        <td>
        </td>
        <td align="center" class="auto-style1">
            <u><h1>Codigo QR</h1></u>
        </td>
        <td align="center" class="auto-style2">
            <h1><strong>Informacion</strong></h1>
        </td>
    </tr>
    <tr>
        <td>
            <div id="webcam">
            </div>
        </td>
        <td>
            &nbsp;
        </td>
        <td class="auto-style1">
            <asp:Image ID="imgCapture" runat="server" Style="visibility: hidden; width: 320px;
                height: 240px" />
        </td>
        <td class="auto-style1">
            <table class="auto-style3">
                <tr>
                    <td><strong>Nombre:</strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td><strong>Apellido:</strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td><strong>Pasaportes:</strong></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <strong>Usuario:</strong>
            <asp:Label ID="LB_QRCode" runat="server"></asp:Label>
        </td>
    </tr>
</table>
<br />
<asp:Button ID="btnCapture" Text="Capturar" runat="server" OnClientClick="return Capture();" />
    <asp:Button ID="BT_Escanear" runat="server" OnClick="BT_Escanear_Click" Text="Escanear" />
<br />
<span id="camStatus"></span>
</form>
</body>
</html>