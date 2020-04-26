<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/User/UserChangePass.aspx.cs" Inherits="View_User_UserChangePass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recuperar Contraseña</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <strong>Digite su nueva contraseña:</strong><asp:TextBox ID="TB_Pass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>Repita la contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                        <asp:TextBox ID="TB_Repeat" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="B_Cambiar" runat="server" OnClick="B_Cambiar_Click" Text="Cambiar" />
                        <asp:Button ID="BT_Salir" runat="server" OnClick="BT_Salir_Click" Text="Salir" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
