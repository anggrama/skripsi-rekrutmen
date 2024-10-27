using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI
{
    public partial class Dashboard : UserPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            try
            {
                using (DataAccess.DataAccessDashboardUser oDa = new DataAccess.DataAccessDashboardUser())
                {
                    gvHistory.DataSource = oDa.getDataTable_Riwayat(((cSessionUser)Session[cSession.sUserStruct]).UserEmail);
                    gvHistory.DataBind();
                }
            }
            catch (Exception ex)
            {
                
            }
         
        }

        protected void gvHistory_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
        {
            string noAnimo = e.Parameters;
            ScriptManager.RegisterStartupScript(Page, typeof(Page), "OpenWindow", string.Format("window.open('../ReportViewer.aspx?id={0}&type=Pendaftaran');", noAnimo), true);
        }
    }
}