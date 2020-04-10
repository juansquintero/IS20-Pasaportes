<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/User/QRCode.aspx.cs" Inherits="View_User_QRCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>QR</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">  
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>  
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>  
    <style type="text/css">
        .auto-style1 {
            width: 1143px;
        }
        .auto-style2 {
            width: 1342px;
            align-self: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2"><h1 style="text-align:center">Codigo QR</h1></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"><asp:PlaceHolder ID="QR_PlaceHolder" runat="server">

                                            </asp:PlaceHolder></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="LB_QR" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
