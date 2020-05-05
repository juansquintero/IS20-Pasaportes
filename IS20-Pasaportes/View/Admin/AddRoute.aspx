<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Admin/AddRoute.aspx.cs" Inherits="View_Admin_AddRoute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td align="center">
                        <h1 class="auto-style2">Añadir Ruta</h1>
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
                    <td align="center"><strong>Ruta:&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TB_Ruta" runat="server"></asp:TextBox>
                        </strong>
                        <asp:RequiredFieldValidator runat="server" id="reqNam" controltovalidate="TB_Ruta" errormessage="¡Por favor ingrese una ruta!" />
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
                        <asp:Button ID="BT_Guardar" runat="server" OnClick="BT_Guardar_Click" Text="Guardar" />
                        <asp:Button ID="BT_Salir" runat="server" Text="Salir" OnClick="BT_Salir_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
