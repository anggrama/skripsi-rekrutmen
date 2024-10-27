using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class DataAnimo : AdminPageBase
    {
        DataAccess.DataAccessDataAnimo oDataAccess = new DataAccess.DataAccessDataAnimo();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }

        }
        private void loadgvAnimo()
        {
            DataTable dt = new DataTable();
            string pandaId = ((cSessionAdmin)Session[cSession.sAdminStruct]).Panda;

            try
            {
                dt = oDataAccess.getDataTable_Animo(pandaId, ucFilter.Pangkat, ucFilter.Gelombang,ucFilter.Tahun);
                gvAnimo.DataSource = dt;
            }
            catch (Exception ex)
            {
                //lblError.Text = ex.Message;
            }
        }
        private void loadgvPeserta()
        {
            DataTable dt = new DataTable();
            string pandaId = ((cSessionAdmin)Session[cSession.sAdminStruct]).Panda;

            try
            {
                dt = oDataAccess.getDataTable_Peserta(pandaId, ucFilter.Pangkat, ucFilter.Gelombang,ucFilter.Tahun);
                gvAnimo.DataSource = dt;

            }
            catch (Exception ex)
            {

            }


        }
        protected void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
                string panda = Convert.ToString(adminStruct.Panda);
                bool isPeserta = true;
                string dataType = Request.QueryString["type"];
                if (dataType == "ani")
                    isPeserta = false;

                DataTable dtData = oDataAccess.getDataTable_DataPendaftar(panda, ucFilter.Gelombang, ucFilter.Pangkat, isPeserta,ucFilter.Tahun);
                if (panda != "")
                    dtData.Columns.Remove("Telp");

                if (dtData.Rows.Count > 0)
                    ExportToExcel(dtData, "DataDiriPeserta");
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        protected void gvAnimo_DataBinding(object sender, EventArgs e)
        {
            string dataType = Request.QueryString["type"];
            if (dataType == "ani")
                loadgvAnimo();
            else
                loadgvPeserta();
        }
        protected void LoadData()
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
            lblPangkat.Text = ucFilter.Pangkat;

            string dataType = Request.QueryString["type"];
            if (dataType == "ani")
            {
                lblJenisData.Text = "Animo";
                loadgvAnimo();
            }
            else
            {
                lblJenisData.Text = "Peserta";
                loadgvPeserta();
            }

            gvAnimo.DataBind();

           
        }
        protected void callData_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            if (e.Parameter == "load")
            {
                LoadData();
            }
        }
    }
}