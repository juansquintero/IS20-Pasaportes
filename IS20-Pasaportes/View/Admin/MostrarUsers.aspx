<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Admin/MostrarUsers.aspx.cs" Inherits="View_Admin_MostrarUsers" %>

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
                    <td>
                        <asp:ObjectDataSource ID="ODS_UsersMostrar" runat="server" SelectMethod="getUserBeneficiario" TypeName="DAO_Admin"></asp:ObjectDataSource>
                        <asp:GridView ID="GV_Mostrar" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ODS_UsersMostrar" Width="100%">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                                <asp:BoundField DataField="Name_rol" HeaderText="Rol" SortExpression="Name_rol" />
                                <asp:BoundField DataField="Name" HeaderText="Nombre" SortExpression="Name" />
                                <asp:BoundField DataField="Last_name" HeaderText="Apellido" SortExpression="Last_name" />
                                <asp:BoundField DataField="User" HeaderText="Usuario" SortExpression="User" />
                                <asp:BoundField DataField="Pass" HeaderText="Contraseña" SortExpression="Pass" />
                                <asp:BoundField DataField="Name_ruta" HeaderText="Ruta" SortExpression="Name_ruta" />
                                <asp:BoundField DataField="Pasaporte_numero" HeaderText="Pasaportes" SortExpression="Pasaporte_numero" />
                                <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" />
                                <asp:BoundField DataField="Qr_hash" HeaderText="Identificador" SortExpression="Qr_hash" />
                            </Columns>
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                            <RowStyle BackColor="White" ForeColor="#330099" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                            <SortedAscendingCellStyle BackColor="#FEFCEB" />
                            <SortedAscendingHeaderStyle BackColor="#AF0101" />
                            <SortedDescendingCellStyle BackColor="#F6F0C0" />
                            <SortedDescendingHeaderStyle BackColor="#7E0000" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
