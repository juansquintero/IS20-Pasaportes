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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Bienvenido al registro" Width="100%"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TB_Id" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Numero de ruta"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DDL_NumRuta" runat="server" DataSourceID="ODS_Ruta" DataTextField="Ruta" DataValueField="Id">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ODS_Ruta" runat="server" SelectMethod="getRuta" TypeName="DAO_Admin"></asp:ObjectDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_Nombre" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label5" runat="server" Text="Apellido"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_Apellido" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label6" runat="server" Text="Usuario"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_User" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label7" runat="server" Text="Contraseña"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_Pass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label9" runat="server" Text="Activo"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="CB_Activo" runat="server" />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label10" runat="server" Text="Rol"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DDL_Rol" runat="server" DataSourceID="ODS_Rol" DataTextField="Rol_name" DataValueField="Id">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ODS_Rol" runat="server" SelectMethod="getRol" TypeName="DAO_Admin"></asp:ObjectDataSource>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label11" runat="server" Text="Identificacion de conductor"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DDL_IdeConductor" runat="server" DataSourceID="OBS_Conductor" DataTextField="Empresa" DataValueField="Id">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="OBS_Conductor" runat="server" SelectMethod="getDriver" TypeName="DAO_Admin"></asp:ObjectDataSource>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label12" runat="server" Text="Correo"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TB_Correo" runat="server"></asp:TextBox>
                    </td>
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
                        <asp:Button ID="BT_Salir" runat="server" OnClick="BT_Salir_Click" Text="Salir" />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
