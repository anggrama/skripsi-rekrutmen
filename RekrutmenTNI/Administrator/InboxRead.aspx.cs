using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using System.Data 
;
namespace RekrutmenTNI.Admin
{
    public partial class InboxRead : AdminPageBase
    {
        DataAccessInfo oDataAccess = new DataAccessInfo();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
             adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];

            string InfoId = Request.QueryString["InfoId"];
            string readType = Request.QueryString["rt"];
            try
            {
                DataTable dtData = oDataAccess.getDataTable_ReadMessage(InfoId,adminStruct.Panda,readType);
                if (dtData.Rows.Count>0)
                {
                    //get message
                    litJudul.Text = dtData.Rows[0]["Judul"].ToString();
                    litMessage.Text = dtData.Rows[0]["Isi"].ToString();

                    Guid gInfoId = new Guid(InfoId);
                    oDataAccess.dbLinq.usp_M_Info_Pesan_UpdateRead(gInfoId, adminStruct.Panda);

                    //get files
                    DataTable dtFiles = oDataAccess.getDataTable_ReadFiles(InfoId);
                    string listFiles = "";
                    string tagfile = "<li><a href='{0}' target='_blank'>{1}</li>";
                    foreach (DataRow row in dtFiles.Rows)
                    {
                        listFiles += string.Format(tagfile, row["Filepath"].ToString(), row["CaptionName"].ToString());
                    }
                    litFiles.Text = "<ul>" + listFiles + "</ul>";
                }
                else
                {
                    litJudul.Text = "Data tidak ada!!";
                }
            }
            catch (Exception ex)
            {
                litMessage.Text = ex.Message;
            }
        }
    }
}