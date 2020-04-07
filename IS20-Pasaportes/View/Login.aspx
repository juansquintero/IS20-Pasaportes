<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Login.aspx.cs" Inherits="View_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 14px;
        }
    </style>
</head>

    <body>  
        <form id="form1" runat="server">  
            <div >  
                <table style="width:100%;">  
                    <caption class="style1">  
                        <strong>Bienvenido, inicio de sesion</strong>  
                    </caption>  
                    <tr>  
                        <td class="style2" colspan="3">  
     </td>  
                    </tr>  
                    <tr>  
                        <td class="style2" colspan="3">  
                            <asp:Login ID="LG_Proyecto" runat="server" BackColor="#E3EAEB" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Width="1155px" FailureText="Hubo un error en un inicio de sesion" LoginButtonText="Entrar" OnAuthenticate="LG_Proyecto_Authenticate" PasswordLabelText="Contraseña:" PasswordRequiredErrorMessage="Contraseña requerida" RememberMeText="Recuerdame para la proxima" TextLayout="TextOnTop" TitleText="Inicio de sesion" UserNameLabelText="Usuario:" UserNameRequiredErrorMessage="Usuario requerido">
                                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                                <LayoutTemplate>
                                    <table cellpadding="4" cellspacing="0" style="border-collapse:collapse;">
                                        <tr>
                                            <td>
                                                <table cellpadding="0" style="width:1155px;">
                                                    <tr>
                                                        <td align="center" class="auto-style2" style="color:White;background-color:#1C5E55;font-size:0.9em;font-weight:bold;">Inicio de sesion</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuario:</asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="Usuario requerido" ToolTip="Usuario requerido" ValidationGroup="LG_Proyecto">*</asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Contraseña requerida" ToolTip="Contraseña requerida" ValidationGroup="LG_Proyecto">*</asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style2">
                                                            
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:CheckBox ID="RememberMe" runat="server" Text="Recuerdame para la proxima" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" style="color:Red;border-style:Solid;">
                                                            <asp:Label ID="L_Mensaje" runat="server"></asp:Label>
                                                            <asp:Literal ID="L_Adevertencia" runat="server" EnableViewState="False"></asp:Literal>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right">
                                                            <asp:Button ID="LoginButton" runat="server" BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" CommandName="Login" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" Text="Entrar" ValidationGroup="LG_Proyecto" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                                <FailureTextStyle BorderStyle="Solid" />
                                <LoginButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
                                <TextBoxStyle Font-Size="0.8em" />
                                <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                            </asp:Login>
     </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style1">  
                            &nbsp;</td>  
                        <td class="auto-style1">  
                            &nbsp;</td>  
                        <td class="auto-style1">  
                            &nbsp;</td>  
                    </tr>  
                    <tr>  
                        <td class="style2">  
                            &nbsp;</td>  
                        <td>  
                            &nbsp;</td>  
                        <td>  
                            &nbsp;</td>  
                    </tr>  
                    <tr>  
                        <td class="style2">  
                            &nbsp;</td>  
                    </tr>  
                    <tr>  
                        <td class="style2">  
     </td>  
                        <td>  
                            &nbsp;</td>  
                        <td>  
                            &nbsp;</td>  
                    </tr>  
                </table>  
            </div>  
        </form>  
    </body> 
</html>
