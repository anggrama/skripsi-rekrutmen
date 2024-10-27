using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class Panda : AdminPageBase
    {
        DataAccess.DataAccessPanda oDataAccess = new DataAccess.DataAccessPanda();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
            if (!IsPostBack)
                LoadgvPanda();
        }

        private void LoadgvPanda()
        {
            try
            {
                DataTable dt = oDataAccess.GetDataTablePanda();
                dt.Columns["WilayahId"].Unique = true;
                ViewState["Panda"] = dt;
                gvPanda.DataSource = ViewState["Panda"];
                gvPanda.DataBind();
            }
            catch (Exception)
            {
                
            }
        }

        protected void gvPanda_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            DataStruct.DataStructPanda args = new DataStruct.DataStructPanda();

            try
            {
                DevExpress.Web.ASPxGridView grdPanda = (DevExpress.Web.ASPxGridView)sender;

                args.CreatedBy = adminStruct.UserID;
                args.wilayahId = Convert.ToString(e.NewValues["WilayahId"]);
                args.wilayahName = Convert.ToString(e.NewValues["WilayahName"]);
                args.IsActive = Convert.ToBoolean(e.NewValues["IsActive"]);
                args.isTaruna = Convert.ToBoolean(e.NewValues["IsTaruna"]);
                args.isBintara = Convert.ToBoolean(e.NewValues["IsBintara"]);
                args.isTamtama = Convert.ToBoolean(e.NewValues["IsTamtama"]);
                args.isLakiTaruna = Convert.ToBoolean(e.NewValues["IsLakiTaruna"]);
                args.isPerempuanTaruna = Convert.ToBoolean(e.NewValues["IsPerempuanTaruna"]);
                args.isLakiBintara = Convert.ToBoolean(e.NewValues["IsLakiBintara"]);
                args.isPerempuanBintara = Convert.ToBoolean(e.NewValues["IsPerempuanBintara"]);
                args.isLakiTamtama = Convert.ToBoolean(e.NewValues["IsLakiTamtama"]);
                args.isPerempuanTamtama = Convert.ToBoolean(e.NewValues["IsPerempuanTamtama"]);
                args.kotama = Convert.ToString(e.NewValues["kotama"]);
                oDataAccess.PandaSave(args);

                e.Cancel = true;
                grdPanda.CancelEdit();
                LoadgvPanda();
            }
            catch (Exception ex)
            {

            }
        }

        protected void gvPanda_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {

            
            DataStruct.DataStructPanda args = new DataStruct.DataStructPanda();
            DevExpress.Web.ASPxGridView grdPanda = (DevExpress.Web.ASPxGridView)sender;
            try
            {
                args.CreatedBy = adminStruct.UserID;
                args.wilayahId = Convert.ToString(e.Keys["WilayahId"]);
                args.wilayahName = Convert.ToString(e.NewValues["WilayahName"]);
                args.IsActive = Convert.ToBoolean(e.NewValues["IsActive"]);
                args.isTaruna = Convert.ToBoolean(e.NewValues["IsTaruna"]);
                args.isBintara = Convert.ToBoolean(e.NewValues["IsBintara"]);
                args.isTamtama = Convert.ToBoolean(e.NewValues["IsTamtama"]);
                args.isLakiTaruna = Convert.ToBoolean(e.NewValues["IsLakiTaruna"]);
                args.isPerempuanTaruna = Convert.ToBoolean(e.NewValues["IsPerempuanTaruna"]);
                args.isLakiBintara = Convert.ToBoolean(e.NewValues["IsLakiBintara"]);
                args.isPerempuanBintara = Convert.ToBoolean(e.NewValues["IsPerempuanBintara"]);
                args.isLakiTamtama = Convert.ToBoolean(e.NewValues["IsLakiTamtama"]);
                args.isPerempuanTamtama = Convert.ToBoolean(e.NewValues["IsPerempuanTamtama"]);
                args.kotama = Convert.ToString(e.NewValues["Kotama"]);
                oDataAccess.PandaSave(args);

                e.Cancel = true;
                grdPanda.CancelEdit();

                LoadgvPanda();
            }
            catch (Exception ex)
            {
                
            }
        }

     
    }
}