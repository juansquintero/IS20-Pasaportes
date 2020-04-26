<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/User/UserInfo.aspx.cs" Inherits="View_User_UserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td><b></b></td>
                    <td align="center">
            <u><h1>Informacion usuario</h1></u></td>
                    <td><b></b></td>
                </tr>
                <tr>
                    <td><b></b></td>
                    <td><b></b></td>
                    <td><b></b></td>
                </tr>
                <tr>
                    <td><b></b></td>
                    <td><b>Nombre:
                        <asp:Label ID="LB_Nombre" runat="server" Font-Bold="False"></asp:Label>
                        </b></td>
                    <td><b></b></td>
                </tr>
                <tr>
                    <td><b></b></td>
                    <td><b>Apellido:
                        <asp:Label ID="LB_Apellido" runat="server" Font-Bold="False" Font-Italic="False"></asp:Label>
                        </b></td>
                    <td><b></b></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><strong>Pasaportes disponibles:
                        <asp:Label ID="LB_PasDisponibles" runat="server" CssClass="auto-style2">No disponible</asp:Label>
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="BT_PassChange" runat="server" OnClick="BT_PassChange_Click" Text="Cambiar contraseña" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td align="center">
                        <asp:Button ID="BT_Salir" runat="server" Text="Salir" OnClick="BT_Salir_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
