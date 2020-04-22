<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Reports/Report.aspx.cs" Inherits="View_Reports_Report" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reporte</title>
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
                        <CR:CrystalReportViewer ID="CRV_Beneficiario" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="50px" ReportSourceID="CRS_Beneficiario" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="1104px" />
                        <CR:CrystalReportSource ID="CRS_Beneficiario" runat="server">
                            <Report FileName="C:\Users\Sebastian Quintero\source\repos\IS20-Pasaportes\IS20-Pasaportes\ReportCr\ReportOne.rpt">
                            </Report>
                        </CR:CrystalReportSource>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
