<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Admin/AddUser.aspx.cs" Inherits="View_Admin_AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 422px;
        }
        .auto-style3 {
            width: 295px;
        }
        .auto-style4 {
            width: 422px;
            height: 23px;
        }
        .auto-style5 {
            width: 295px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            font-weight: normal;
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="3">
                        <h1 class="auto-style7"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BIENVENIDO AL REGISTRO</strong></h1>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <strong>Rol:</strong></td>
                    <td class="auto-style3">
                        Administrador</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <p>
                            <strong>
                        <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
                            :</strong></p>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_Nombre" runat="server" ToolTip="Nombre" ValidateRequestMode="Enabled"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" id="RFV" controltovalidate="TB_Nombre" errormessage="!Este campo es obligatorio!" />
                    </td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <strong>
                        <asp:Label ID="Label5" runat="server" Text="Apellido"></asp:Label>
                        :</strong></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_Apellido" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" id="RFV2" controltovalidate="TB_Apellido" errormessage="!Este campo es obligatorio!" />

                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <strong>
                        <asp:Label ID="Label6" runat="server" Text="Usuario"></asp:Label>
                        :</strong></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_User" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" id="RFV3" controltovalidate="TB_User" errormessage="!Este campo es obligatorio!" />

                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <strong>
                        <asp:Label ID="Label7" runat="server" Text="Contraseña"></asp:Label>
                        :</strong></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_Pass" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" id="RFV4" controltovalidate="TB_Pass" errormessage="!Este campo es obligatorio!" />
                        <asp:CompareValidator ID="cv" runat="server" ControlToValidate="TB_Pass" Type="Integer"
                        Operator="DataTypeCheck" ErrorMessage="!Solo se admiten numeros!" />

                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <strong>
                        <asp:Label ID="Label12" runat="server" Text="Correo"></asp:Label>
                        :</strong></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_Correo" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="TB_Correo" errormessage="!Este campo es obligatorio!" />

                        <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TB_Correo" ErrorMessage="Formato de correo invalido"></asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="BT_Enviar" runat="server" OnClick="BT_Enviar_Click" Text="Enviar" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="BT_Salir" runat="server" OnClick="BT_Salir_Click" Text="Salir" CausesValidation="False" />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
