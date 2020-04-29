﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Admin/AddPasaportes.aspx.cs" Inherits="View_Admin_AddPasaportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
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
                    <td align="center">
                        <h1 class="auto-style2"><strong>Añadir Pasaportes</strong></h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="OBS_Pasaportes" ForeColor="#333333" GridLines="None" Width="100%">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" SortExpression="Id" />
                                <asp:BoundField DataField="Name" HeaderText="Nombre" ReadOnly="True" SortExpression="Name" />
                                <asp:BoundField DataField="Last_name" HeaderText="Quintero" ReadOnly="True" SortExpression="Last_name" />
                                <asp:BoundField DataField="User_name" HeaderText="Usuario" ReadOnly="True" SortExpression="User_name" />
                                <asp:BoundField DataField="Pasaporte_numero" HeaderText="Pasaportes" SortExpression="Pasaporte_numero" />
                                <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" ReadOnly="True" />
                                <asp:CommandField EditText="Editar" HeaderText="Editar" ShowEditButton="True" />
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
                        <asp:ObjectDataSource ID="OBS_Pasaportes" runat="server" DataObjectTypeName="E_user" SelectMethod="getUserBeneficiario" TypeName="DAO_Admin" UpdateMethod="editUser"></asp:ObjectDataSource>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="BT_Salir" runat="server" Text="Salir" OnClick="BT_Salir_Click" style="height: 26px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
