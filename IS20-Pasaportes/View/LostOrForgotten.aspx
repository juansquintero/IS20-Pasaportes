<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/LostOrForgotten.aspx.cs" Inherits="View_LostOrForgotten" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Recuperar Contraseña</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="L_Correo" runat="server" Text="Digite su Correo:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TB_Correo" runat="server" Height="22px" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_Correo" runat="server" ControlToValidate="TB_Correo" ErrorMessage="Ingrese un correo"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TB_Correo" ErrorMessage="Formato de correo invalido"></asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="B_Generar" runat="server" OnClick="B_Generar_Click" Text="Generar" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
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
