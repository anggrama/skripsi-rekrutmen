using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraReports.Security;
using DevExpress.XtraReports.UI;

namespace RekrutmenTNI
{
    public partial class ReportPreview : System.Web.UI.Page
    {
        reportAdapter oReport;
        protected void Page_Init(object sender, EventArgs e)
        {
            ScriptPermissionManager.GlobalInstance = new ScriptPermissionManager(ExecutionMode.Unrestricted);

            string path = Server.MapPath(".");
            oReport = new reportAdapter(path);
            string id;
            if (Convert.ToString(Request.QueryString["id"]) == "")
                return;
            else
                id = Convert.ToString(Request.QueryString["id"]);

            string type = Convert.ToString(Request.QueryString["type"]);
            XtraReport report = null;
                switch (type)
                {
                    case "Pendaftaran":
                        report = oReport.getRptPendaftaran(id);
                        break;
                    case "Surat":
                        DataAccess.DataAccessDataProfil oDataAccess = new DataAccess.DataAccessDataProfil();
                        oDataAccess.AddPeserta(id, ((cSessionAdmin)Session[cSession.sAdminStruct]).UserID);
                        report = oReport.getRptSurat(id);
                        break;
                    default:
                        return;
                }
                viewer.Report = report;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}