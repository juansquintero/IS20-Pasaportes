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
        .auto-style3 {
            width: 1342px;
            align-self: center;
            height: 26px;
        }
        .auto-style4 {
            width: 916px;
            align-self: center;
        }
        .auto-style5 {
            width: 916px;
            align-self: center;
            height: 26px;
        }
        .auto-style6 {
            width: 861px;
            align-self: center;
        }
        .auto-style7 {
            width: 861px;
            align-self: center;
            height: 26px;
        }
        .auto-style8 {
            align-self: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td align="center" class="auto-style8" colspan="3"><h1 style="text-align:center"><strong>CODIGO QR</strong></h1></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style5">
                        <strong>
                        <asp:Label ID="Label3" runat="server" Text="Nombre:  "></asp:Label>
                        </strong>
                        <asp:Label ID="LB_Usuario" runat="server" Width="100%"></asp:Label>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">
                        <strong>
                        <asp:Label ID="Label4" runat="server" Text="Apellido:  "></asp:Label>
                        </strong>
                        <asp:Label ID="LB_UserApellido" runat="server" Width="100%"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td align="center" class="auto-style4"><asp:PlaceHolder ID="QR_PlaceHolder" runat="server">

                                            </asp:PlaceHolder></td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style4">
                        <strong>
                        <asp:Label ID="Label2" runat="server" Text="Codigo:  "></asp:Label>
                        </strong>
                        <asp:Label ID="LB_QR" runat="server" Width="100%"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td align="center" class="auto-style4">
                        <asp:Button ID="BT_Session" runat="server" OnClick="BT_Session_Click" Text="Salir" />
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
