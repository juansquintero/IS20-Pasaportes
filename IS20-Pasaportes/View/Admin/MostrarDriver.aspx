﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Admin/MostrarDriver.aspx.cs" Inherits="View_Admin_MostrarDriver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                    <td align="center"><h1>Conductores registrados</h1></td>
                </tr>
            </table>
            <br />
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:ObjectDataSource ID="ODS_UsersMostrar" runat="server" SelectMethod="getUserDriver" TypeName="DAO_Admin" DataObjectTypeName="E_user" DeleteMethod="deleteUser" InsertMethod="addUser" OnSelecting="ODS_UsersMostrar_Selecting" UpdateMethod="editUser"></asp:ObjectDataSource>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ODS_UsersMostrar" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="100%" AllowPaging="True" DataKeyNames="Id">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Id" ReadOnly="True" />
                                <asp:BoundField DataField="Name" HeaderText="Nombre" SortExpression="Name" />
                                <asp:BoundField DataField="Last_name" HeaderText="Apellido" SortExpression="Last_name" />
                                <asp:BoundField DataField="User_name" HeaderText="Usuario" SortExpression="User_name" />
                                <asp:BoundField DataField="Pass" HeaderText="Contraseña" SortExpression="Pass" />
                                <asp:BoundField DataField="Id_ruta" HeaderText="Identificacion de ruta" SortExpression="Id_ruta" />
                                <asp:BoundField DataField="Name_ruta" HeaderText="Ruta" SortExpression="Name_ruta" />
                                <asp:BoundField DataField="Mail" HeaderText="Correo" SortExpression="Mail" />
                                <asp:BoundField DataField="Id_driver" HeaderText="Identificacion de conductor" SortExpression="Id_driver" />
                                <asp:BoundField DataField="Name_empresa" HeaderText="Empresa" SortExpression="Name_empresa" />
                                <asp:BoundField DataField="Driver_total_pasaporte" HeaderText="Pasaporte recibido" SortExpression="Driver_total_pasaporte" />
                                <asp:CommandField CancelText="Cancelar" DeleteText="Borrar" EditText="Editar" HeaderText="Editar" ShowEditButton="True" UpdateText="Actualizar" />
                                <asp:CommandField CancelText="Cancelar" DeleteText="Borrar" HeaderText="Borrar" ShowDeleteButton="True" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td align="center">
                    <asp:Button ID="BT_Salir" runat="server" Text="Salir" OnClick="BT_Salir_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

