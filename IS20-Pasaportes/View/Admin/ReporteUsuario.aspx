<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Admin/ReporteUsuario.aspx.cs" Inherits="View_Admin_ReporteUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-weight: bold;
            text-decoration: underline;
            width: 101px;
        }
        .auto-style3 {
            text-decoration: underline;
        }
        .auto-style4 {
            width: 101px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <h1></h1>
                    </td>
                    <td align="center">
                        <h1 class="auto-style3">Reporte</h1>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td align="center"><strong>Fecha:
                        <asp:DropDownList ID="DDL_Reporte" runat="server">
                        </asp:DropDownList>
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td align="center">
                        <asp:Button ID="BT_Salir" runat="server" Text="Salir" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
