using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class Seleksi : AdminPageBase
    {

        DataAccessNilai oDataAccess = new DataAccessNilai();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
            bindGrid();

            if (!IsPostBack)
                lblError.Text = "";
        }
        private void bindGrid()
        {
            try
            {
                DataTable dtData = oDataAccess.getDataTable_Peserta_Pusat(adminStruct.Panda, ucFilter.Gelombang, ucFilter.Pangkat);
                gvNilai.DataSource = dtData;
                gvNilai.DataBind();

                lblError.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void callData_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            if (e.Parameter == "load")
            {
                bindGrid();
            }
        }
    }

}