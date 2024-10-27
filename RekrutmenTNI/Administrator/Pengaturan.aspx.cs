using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class Pengaturan : AdminPageBase
    {
        DataAccess.DataAccessPengaturan oDataAccess = new DataAccess.DataAccessPengaturan();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
            
            if (!IsPostBack)
            {
                if (adminStruct.AdminType.ToLower() != "superadmin" && adminStruct.AdminType.ToLower() != "admin")
                {
                    Response.Redirect("mainadm.aspx");
                    return;
                }

                LoadPengaturan();
            }
         

        }

        private void LoadPengaturan()
        {
            DataTable dtHtml;
            //DataTable dtInfoLulus;
            litPangkat.Text = ucFilter.Pangkat;
            try
            {
                dtHtml = oDataAccess.GetDataTableHtml(ucFilter.Pangkat);

                htmlPengumuman.Html = dtHtml.Select("SettingName='Pengumuman'")[0]["SettingValue"].ToString();
                htmlPersyaratan.Html = dtHtml.Select("SettingName='Persyaratan'")[0]["SettingValue"].ToString();
                htmlLokasi.Html = dtHtml.Select("SettingName='Lokasi'")[0]["SettingValue"].ToString();
                htmlJadwal.Html = dtHtml.Select("SettingName='Jadwal'")[0]["SettingValue"].ToString();
                htmlMateri.Html = dtHtml.Select("SettingName='Materi Seleksi'")[0]["SettingValue"].ToString();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void InsertStruct(DataStruct.DataStructPengaturan args)
        {
            args.Pangkat = ucFilter.Pangkat;
            args.Pengumuman = htmlPengumuman.Html;
            args.Persyaratan = htmlPersyaratan.Html;
            args.Lokasi = htmlLokasi.Html;
            args.Jadwal = htmlJadwal.Html;
            args.MateriSeleksi = htmlMateri.Html;
        }

        protected void btnSimpan_Click(object sender, EventArgs e)
        {
            DataStruct.DataStructPengaturan args = new DataStruct.DataStructPengaturan();

            try
            {
                InsertStruct(args);
                oDataAccess.Save(args);
                LoadPengaturan();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void callData_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            Session[cSession.sFilter_Pangkat] = e.Parameter;
                LoadPengaturan();
        }

        protected void uploadPanduan_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e)
        {

            SavePostedFile(e.UploadedFile);
           
        }

        protected void SavePostedFile(DevExpress.Web.UploadedFile uploadedFile)
        {
            
            try
            {
                string filename = uploadedFile.FileName;
                string ext = System.IO.Path.GetExtension(filename);
                string savelocation = Server.MapPath("Upload/Blanko/Blanko_" + ucFilter.Pangkat + ext);
                uploadedFile.SaveAs(savelocation);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}