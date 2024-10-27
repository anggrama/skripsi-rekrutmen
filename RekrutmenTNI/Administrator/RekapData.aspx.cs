using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class RekapDataAnimo : AdminPageBase
    {
        DataAccess.DataAccessRekapData oDataAccess = new DataAccess.DataAccessRekapData();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];

            radioList.SelectedIndex = 0;
            //if (Request.QueryString["id"] == null)
            //{
            //    Response.Redirect("rekapdata.aspx?id=animo");
            //}

            LoadgvAnimo(radioList.Value.ToString());
            gvAnimo.Columns[0].Caption = radioList.SelectedItem.Text;

            if (!IsPostBack)
                lblError.Text = "";
        }

        private void LoadgvAnimo(string Parameter)
        {
            

            //DataTable dt = new DataTable();
            //string pangkat, pandaId, param;
            //param = Request.QueryString["id"].ToString();
            //pangkat = Session[cSession.sFilter_Pangkat].ToString();
            //pandaId = adminStruct.Panda;
            //if (param == "animo")
            //{
            //    param = "IS";
            //}
            //else if (param == "peserta")
            //{
            //    param = "IS NOT";
            //}
            //else
            //{
            //    Response.Redirect("rekapdata.aspx?id=animo");
            //    return;
            //}

            //    try
            //    {
            //             dt = oDataAccess.GetDataTableRekapData(Session[cSession.sDefault_Gelombang].ToString(), pangkat, Parameter, pandaId, param);
            //    }
            //    catch (Exception ex)
            //    {
                    
            //        throw ex;
            //    }
            

            //dt.Columns[0].ColumnName = "Parameter";

            //gvAnimo.DataSource = dt;
            //gvAnimo.DataBind();

            DataTable dt = new DataTable();
            string pangkat, pandaId, param;
            pangkat = ucFilter.Pangkat;
            pandaId = adminStruct.Panda;

            try
            {
                dt = oDataAccess.GetDataTableRekapData(ucFilter.Gelombang, pangkat, Parameter, pandaId);
                dt.Columns[0].ColumnName = "Parameter";
                gvAnimo.DataSource = dt;
                gvAnimo.DataBind();
            }
            catch (Exception ex)
            {
                
            }


        }


        protected void callbackgv_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            LoadgvAnimo(e.Parameter.ToString());
            gvAnimo.Columns[0].Caption = radioList.Items.FindByValue(e.Parameter).Text;
        }

        protected void callData_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            if (e.Parameter == "load")
            {
                LoadgvAnimo(radioList.Value.ToString());
            }
        }
    }
}