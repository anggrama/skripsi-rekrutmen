using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

namespace RekrutmenTNI.Admin
{
    public partial class InboxCreate : AdminPageBase
    {
        DataAccessInfo oDataAccess = new DataAccessInfo();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];

            if (!IsPostBack)
                if (adminStruct.AdminType.ToLower().Contains("admin"))
                    bindCheck();
                else if (adminStruct.AdminType.ToLower() == "lanud")
                {
                    tokenTo.DataSource = null;
                    tokenTo.Items.Add("Admin Pusat", null);
                    tokenTo.Tokens.Add("Admin Pusat");
                    
                }
        }
       
        private void bindCheck()
        {
            try
            {
                tokenTo.DataSource = oDataAccess.getDataTable_Panda();
                tokenTo.ValueField = "WilayahId";
                tokenTo.TextField = "WilayahName";
                tokenTo.DataBind();
            }
            catch (Exception ex)
            {
                
            }
        }

        protected void callMessage_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            try
            {

                if (txtPesan.Html == "")
                    throw new Exception("Pesan belum diisi...");

                Guid? InfoId = null;
                oDataAccess.dbLinq.usp_M_Info_Pesan_Insert(ref InfoId, txtJudul.Text, txtPesan.Html, adminStruct.UserID);

                string[] selectedToken = tokenTo.Value.ToString().Split(new char[] { ',' });

                if (adminStruct.AdminType.ToLower().Contains("admin"))
                    foreach (string oValue in selectedToken)
                    {
                        oDataAccess.dbLinq.usp_M_Info_Pesan_Panda_Insert(InfoId, null, oValue.ToString());
                    }
                else if (adminStruct.AdminType.ToLower() == "lanud")
                    oDataAccess.dbLinq.usp_M_Info_Pesan_Panda_Insert(InfoId, adminStruct.Panda, null);

                callMessage.JSProperties["cp_InfoId"] = InfoId;
                e.Result = "Pesan berhasil dikirim.;success";
            }
            catch (Exception ex)
            {
                e.Result = ex.Message + ";error";
            }
        }
        protected void uploadInfo_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e)
        { 

            string urlUpload = "~/Administrator/Upload/Message/" + hfMessage.Get("InfoId").ToString();
                string path = Server.MapPath(urlUpload);
                if (System.IO.Directory.Exists(path) == false)
                    System.IO.Directory.CreateDirectory(path);

            string pathFile = path + "\\" + e.UploadedFile.FileName;
                e.UploadedFile.SaveAs(pathFile);

            Guid infoId = Guid.Parse(hfMessage.Get("InfoId").ToString());
            oDataAccess.dbLinq.usp_M_Info_Pesan_File_Insert(infoId, e.UploadedFile.FileName, urlUpload.Remove (0,16) + "/" + e.UploadedFile.FileName);

        }

    }
}