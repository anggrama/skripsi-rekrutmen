using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class DataProfil : AdminPageBase
    {
        DataAccess.DataAccessDataProfil oDataAccess = new DataAccess.DataAccessDataProfil();

     
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string email = oDataAccess.getEmailPendaftar(Request.QueryString["ida"]);
                ucDataProfil.Email = email;
                ucDataProfil.Panda = ((cSessionAdmin)Session[cSession.sAdminStruct]).Panda;
            }
        }

        protected void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var args = ucDataProfil.Profil;
                string email = oDataAccess.getEmailPendaftar(Request.QueryString["ida"]);
                args.email = email;
                oDataAccess.DataUpdate(args);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
                btnSimpan_Click(null, null);
                oDataAccess.AddPeserta(Request.QueryString["ida"], ((cSessionAdmin)Session[cSession.sAdminStruct]).UserID);

                //string noAnimo = Request.QueryString["ida"];
                //ScriptManager.RegisterStartupScript(Page, typeof(Page), "OpenWindow", string.Format("window.open('../ReportViewer.aspx?id={0}&type=Surat');", noAnimo), true);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            
        }

        protected void printCallback_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            btnSimpan_Click(null, null);
            oDataAccess.AddPeserta(Request.QueryString["ida"], ((cSessionAdmin)Session[cSession.sAdminStruct]).UserID);
            string noAnimo = Request.QueryString["ida"];
            e.Result = noAnimo;
        }
    }
}