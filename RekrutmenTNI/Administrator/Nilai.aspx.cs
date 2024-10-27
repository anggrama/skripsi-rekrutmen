using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using System.Data;
using DevExpress.Web;
using System.IO;

namespace RekrutmenTNI.Admin
{
    public partial class Nilai : AdminPageBase
    {
        DataAccessNilai oDataAccess = new DataAccessNilai();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];

                if (adminStruct.AdminType.ToLower() == "lanud")
                {
                    bindComboJenisNilai("NilaiLanud");
                    cboJenisNilai.SelectedIndex = 0;

                    boxLanud.Visible = true;
                    gvNilai.DataBind();
                }
                else if (adminStruct.AdminType.Contains("Admin"))
                {
                    bindComboJenisNilai("NilaiPusat");
                    cboJenisNilai.SelectedIndex = 0;

                    boxPusat.Visible = true;
                    gvNilaiPusat.DataBind();
                }
            }
            
        }

        #region "-- lanud --"
        private void bindGrid()
        {
            try
            {
                adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
                DataTable dtData = oDataAccess.getDataTable_Peserta(adminStruct.Panda, ucFilter.Gelombang, ucFilter.Pangkat, cboJenisNilai.Value.ToString());
                gvNilai.DataSource = dtData;

                if (cboJenisNilai.SelectedItem.Value.ToString() == "All")
                    gvNilai.Selection.SelectAll();
                else
                {
                    gvNilai.Selection.UnselectAll();
                    foreach (DataRow row in dtData.Rows)
                    {
                        if (row["Pilih"].ToString() == "LLS")
                            gvNilai.Selection.SetSelectionByKey(row["NoPeserta"], true);
                    }
                }


                lblError.Text = "";
            }
            catch (Exception)
            {
                //lblError.Text = ex.Message;
            }
        }
        protected void btnDownload_Click(object sender, EventArgs e)
        {

            DataTable dtData = CreateDataTable();

            List<object> fieldValues = gvNilai.GetSelectedFieldValues(new string[] { "NoPeserta", "Nama" });
            foreach (object[] item in fieldValues)
            {
                object[] row = new object[] { item[0].ToString(), item[1].ToString(), 0, "", "", "" };
                dtData.Rows.Add(row);
            }

            ExportToExcel(dtData, "DataPeserta");
        }
        protected void gvNilai_DataBinding(object sender, EventArgs e)
        {
            bindGrid();
        }
        private DataTable CreateDataTable()
        {
            DataTable dtData = new DataTable("Data");
            dtData.Columns.Add("NoPeserta", typeof(string));
            dtData.Columns.Add("Nama", typeof(string));
            dtData.Columns.Add("NilaiAngka", typeof(double));
            dtData.Columns.Add("NilaiHuruf", typeof(string));
            dtData.Columns.Add("Status", typeof(string));
            dtData.Columns.Add("Keterangan", typeof(string));

            return dtData;

        }
        #endregion

        #region "-- pusat --"
        private void bindGridPusat()
        {
            try
            {
                DataTable dtData = oDataAccess.getDataTable_Peserta_Pusat(ucFilter.Gelombang, ucFilter.Pangkat, cboJenisNilai.Value.ToString());
                gvNilaiPusat.DataSource = dtData;

                if (cboJenisNilai.SelectedItem.Value.ToString() == "All")
                    gvNilaiPusat.Selection.SelectAll();
                else
                {
                    gvNilaiPusat.Selection.UnselectAll();
                    foreach (DataRow row in dtData.Rows)
                    {
                        if (row["Pilih"].ToString() == "LLS")
                            gvNilaiPusat.Selection.SetSelectionByKey(row["NoPesertaPusat"], true);
                    }
                }
                lblError.Text = "";
            }
            catch (Exception)
            {
                //lblError.Text = ex.Message;
            }
        }
        protected void btnDownloadPusat_Click(object sender, EventArgs e)
        {

            DataTable dtData = CreateDataTablePusat();

            List<object> fieldValues = gvNilaiPusat.GetSelectedFieldValues(new string[] {"NoPesertaPusat", "Nama" });
            foreach (object[] item in fieldValues)
            {
                object[] row = new object[] { item[0].ToString(), item[1].ToString(), 0, "", "", "" };
                dtData.Rows.Add(row);
            }

            ExportToExcel(dtData, "DataPeserta");
        }
        protected void btnDownloadNoPeserta_Click(object sender, EventArgs e)
        {

            DataTable dtData = CreateDataTableNoPeserta();

            List<object> fieldValues = gvNilaiPusat.GetSelectedFieldValues(new string[] { "NoPeserta", "Nama" });
            foreach (object[] item in fieldValues)
            {
                object[] row = new object[] { item[0].ToString(), "",item[1].ToString()};
                dtData.Rows.Add(row);
            }

            ExportToExcel(dtData, "DataPeserta");
        }
        protected void gvNilaiPusat_DataBinding(object sender, EventArgs e)
        {
            bindGridPusat();
        }

        private DataTable CreateDataTablePusat()
        {
            DataTable dtData = new DataTable("Data");
            dtData.Columns.Add("NoPesertaPusat", typeof(string));
            dtData.Columns.Add("Nama", typeof(string));
            dtData.Columns.Add("NilaiAngka", typeof(double));
            dtData.Columns.Add("NilaiHuruf", typeof(string));
            dtData.Columns.Add("Status", typeof(string));
            dtData.Columns.Add("Keterangan", typeof(string));

            return dtData;

        }

        private DataTable CreateDataTableNoPeserta()
        {
            DataTable dtData = new DataTable("Data");
            dtData.Columns.Add("NoPeserta", typeof(string));
            dtData.Columns.Add("NoPesertaPusat", typeof(string));
            dtData.Columns.Add("Nama", typeof(string));

            return dtData;
        }
        #endregion

        private void bindComboJenisNilai(string tipeNilai)
        {
            try
            {
                DataTable dt = oDataAccess.getDataTable_ParameterNilai(tipeNilai);
                DataRow rowAll = dt.NewRow();
                rowAll["ParameterId"] = 0;
                rowAll["ParameterName"] = "All";
                dt.Rows.InsertAt(rowAll, 0);

                cboJenisNilai.DataSource = dt;
                cboJenisNilai.TextField = "ParameterName";
                cboJenisNilai.ValueField = "ParameterName";
                cboJenisNilai.DataBind();
            }
            catch (Exception)
            {

                
            }
        }
        string SavePostedFile(UploadedFile uploadedFile,string savedFilename)
        {
            if (!uploadedFile.IsValid)
                return string.Empty;

            string fileName = Path.Combine(MapPath("~/Administrator/Upload/Nilai/"), savedFilename);
            uploadedFile.SaveAs(fileName);

            return fileName;
            
        }
        protected void uploadNilai_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
        {
            string filename = String.Format("{0}.xls", Session.SessionID);
            string path = string.Empty;

            try
            {
                path = SavePostedFile(e.UploadedFile, filename);
				//DataTable dtData = SmartArab.XLSXData.ImportDataTableFromXLSX(path);

				DataTable dtData = null;

				if (hfUploadType["upType"].ToString()=="PesertaPusat")
                    oDataAccess.UpdateNoPesertaPusat(dtData);
                else
                    oDataAccess.SaveNilai(dtData, hfUploadType["upType"].ToString());
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        protected void callData_Callback(object sender, CallbackEventArgsBase e)
        {
            if (e.Parameter == "load")
            {
                adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
                if (adminStruct.AdminType.ToLower() == "lanud")
                {
                    gvNilai.DataBind();
                }

                else if (adminStruct.AdminType.Contains("Admin"))
                {
                    gvNilaiPusat.DataBind();
                }
            }
        }
    }
}