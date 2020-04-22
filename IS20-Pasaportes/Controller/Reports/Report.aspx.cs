using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Reports_Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void showReport()
    {
        CRS_Beneficiario.ReportDocument.SetDataSource(infoReport());
        CRV_Beneficiario.ReportSource = CRS_Beneficiario;
    }

    protected Beneficiario infoReport()
    {
        Beneficiario informe = new Beneficiario();
        List<E_user> listBeneficiario = new DAO_Admin().getUserBeneficiario();

        DataTable data = informe.UsersBenef;
        DataRow fila;

        foreach (E_user registro in listBeneficiario)
        {
            fila = data.NewRow();
            fila["ID"] = registro.Id;
            fila["Nombre"] = registro.Name;
            fila["Apellido"] = registro.Last_name;
            fila["Ruta"] = registro.Name_ruta;
            fila["Pasaportes"] = registro.Pasaporte_numero;
            data.Rows.Add(fila);
        }
        return informe;
    }
}