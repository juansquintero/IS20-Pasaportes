<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Admin/MostrarAddEmpresa.aspx.cs" Inherits="View_Admin_MostrarAddEmpresa" %>

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
                        <h1>Añadir Empresa</h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False" DataSourceID="ODS_Empresa">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                                <asp:BoundField DataField="Empresa" HeaderText="Empresa" SortExpression="Empresa" />
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
                        <asp:ObjectDataSource ID="ODS_Empresa" runat="server" DataObjectTypeName="E_driver" DeleteMethod="deleteEmpresa" SelectMethod="getEmpresaList" TypeName="DAO_Admin" UpdateMethod="editEmpresa"></asp:ObjectDataSource>
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr align="center">
                <td colspan="2"><strong>Empresa:&nbsp; </strong>
                    <asp:TextBox ID="TB_Empresa" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="BT_Enviar" runat="server" Text="Guardar" OnClick="BT_Enviar_Click" />
                    <asp:Button ID="BT_Salir" runat="server" Text="Salir" OnClick="BT_Salir_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
