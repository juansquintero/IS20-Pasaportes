<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Admin/MostrarRoutes.aspx.cs" Inherits="View_Admin_MostrarRoutes" %>

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
                    <td align="center">
                        <h1>Modificar Rutas</h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False" DataSourceID="OSD_Ruta">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                                <asp:BoundField DataField="Ruta" HeaderText="Ruta" SortExpression="Ruta" />
                                <asp:CommandField DeleteText="Eliminar" EditText="Editar" ShowDeleteButton="True" ShowEditButton="True" />
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
                        <asp:ObjectDataSource ID="OSD_Ruta" runat="server" DataObjectTypeName="E_ruta" DeleteMethod="deleteRuta" SelectMethod="getRuta" TypeName="DAO_Admin" UpdateMethod="editRutas"></asp:ObjectDataSource>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="BT_Salir" runat="server" Text="Salir" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
