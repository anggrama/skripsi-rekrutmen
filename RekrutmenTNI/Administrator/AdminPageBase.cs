using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;

namespace RekrutmenTNI.Admin
{
    public class AdminPageBase : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            cSession.checkAdminSession();

        }

        protected void ExportToExcel(DataTable dt,string filename)
        {
            if (dt.Rows.Count > 0)
            {
                // Export DataTable 

                string path = string.Format("{0}{1}_{2}.xlsx", MapPath("~/Administrator/Upload/Temp/"), Session.SessionID,filename);
                //SmartArab.XLSXData.ExportDataTableToXLSX(dt, "dd/MM/yyyy", path);

                FileInfo file = new FileInfo(path);

                Response.Clear();
                Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0};", file.Name));
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.ContentType = "application/x-unknown";
                Response.TransmitFile(file.FullName);
                Response.Flush();
                Response.Close();

            }
        }
    }
}