using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI.Admin
{
    public partial class Gelombang : AdminPageBase
    {
        DataAccess.DataAccessGelombang oDataAccess = new DataAccess.DataAccessGelombang();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
            if (!IsPostBack)
            {
                if (adminStruct.AdminType.ToLower() != "superadmin" && adminStruct.AdminType.ToLower() != "admin")
                {
                    Response.Redirect("MainAdm.aspx");
                    return;
                }

                //litPangkat.Text = Convert.ToString(Session[cSession.sFilter_Pangkat]);
                gvGelombang.DataBind();
            }
            
        }

        private void LoadgvGelombang()
        {
            litPangkat.Text = ucFilter.Pangkat;
            string pangkat = Convert.ToString(ucFilter.Pangkat);
            try
            {
                gvGelombang.DataSource = oDataAccess.GetDataTableGelombang(pangkat);
            }
            catch (Exception)
            {
                
            }
        }

        protected void gvGelombang_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            DataStruct.DataStructGelombang args = new DataStruct.DataStructGelombang();
            try
            {
                DevExpress.Web.ASPxGridView grdGel = (DevExpress.Web.ASPxGridView)sender;

            	 args.GelombangKe = Convert.ToInt32(e.NewValues["GelombangKe"]);
                 args.TahunPendaftaran = e.NewValues["TahunPendaftaran"].ToString();
                 args.RangeFrom = Convert.ToDateTime(e.NewValues["RangeFrom"]);
                 args.RangeTo = Convert.ToDateTime(e.NewValues["RangeTo"]);
                 args.BornFrom = Convert.ToDateTime(e.NewValues["BornFrom"]);
                 args.BornTo = Convert.ToDateTime(e.NewValues["BornTo"]);
                 args.Pangkat = ucFilter.Pangkat;
                 args.IsActive = Convert.ToBoolean(e.NewValues["IsActive"]);

                 oDataAccess.SaveGelombang(args);

                 e.Cancel = true;
                 grdGel.CancelEdit();
                 
            }
            catch (Exception ex)
            {
            	
            }
           
        }

        protected void gvGelombang_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            DataStruct.DataStructGelombang args = new DataStruct.DataStructGelombang();
            try
            {
                DevExpress.Web.ASPxGridView grdGel = (DevExpress.Web.ASPxGridView)sender;

                args.GelombangID = Convert.ToInt32(e.Keys[0]);
                args.GelombangKe = Convert.ToInt32(e.NewValues["GelombangKe"]);
                args.TahunPendaftaran = e.NewValues["TahunPendaftaran"].ToString();
                args.RangeFrom = Convert.ToDateTime(e.NewValues["RangeFrom"]);
                args.RangeTo = Convert.ToDateTime(e.NewValues["RangeTo"]);
                args.BornFrom = Convert.ToDateTime(e.NewValues["BornFrom"]);
                args.BornTo = Convert.ToDateTime(e.NewValues["BornTo"]);
                args.Pangkat = ucFilter.Pangkat;
                args.IsActive = Convert.ToBoolean(e.NewValues["IsActive"]);

                oDataAccess.SaveGelombang(args);

                e.Cancel = true;
                grdGel.CancelEdit();
            }
            catch (Exception ex)
            {

            }
        }
        protected void callData_Callback(object sender, CallbackEventArgsBase e)
        {
                gvGelombang.DataBind();
        }

    

        protected void gvGelombang_DataBinding(object sender, EventArgs e)
        {
            LoadgvGelombang();
        }
    }
}