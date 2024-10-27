using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI
{
    public partial class Daftar : System.Web.UI.Page
    {
        DataAccess.DataAccessDaftar oDataAccess = new DataAccess.DataAccessDaftar();
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string pangkat = Convert.ToString(Session[cSession.sPangkat]);
                    if (pangkat.ToLower() != "taruna" && pangkat.ToLower() != "bintara" && pangkat.ToLower() != "tamtama")
                    {
                        Response.Redirect("Beranda.aspx");
                        return;
                    }
                    dt = oDataAccess.getDataTable_GelombangAktif(pangkat);
                    if (dt.Rows.Count == 0)
                    {
                        Response.Redirect("NotFound.aspx?err=1");
                        return;
                    }

                    LoadAgama();
                    LoadPendidikan();
                    LoadJenisKelamin();
                    LoadDateBorn(Convert.ToInt32(Convert.ToString(dt.Rows[0]["GelombangID"])));
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
        protected void btnDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!captchaValid.IsValid)
                    return;
                string pangkat = Convert.ToString(Session[cSession.sPangkat]);
                if (pangkat.ToLower() != "taruna" && pangkat.ToLower() != "bintara" && pangkat.ToLower() != "tamtama")
                {
                    Response.Redirect("Beranda.aspx");
                    return;
                }
                DataStruct.DataStructDaftar args = new DataStruct.DataStructDaftar();

                dt = oDataAccess.getDataTable_GelombangAktif(Session[cSession.sPangkat].ToString());
                if (oDataAccess.EmailValidate(txtEmail.Text, dt.Rows[0]["GelombangID"].ToString(), cboWilayah.Value.ToString()) == true)
                {
                    lblError.InnerHtml = "Pendaftaran Gagal!!<br/>Email telah terdaftar sebelumnya pada gelombang pendaftaran & lanud yang sama.";
                    //JsClass.MessageBox("Email anda telah terdaftar sebelumnya di gelombang ini.");
                    return;
                }

                string noAnimo = "";

                InsertStruct(args);
                bool isEmailExist = oDataAccess.getEmailExists(args.Email);
                noAnimo = oDataAccess.InsertDaftar(args);

                if (isEmailExist)
                {
                    Response.Redirect(string.Format("DaftarLogin.aspx?eid={0}",args.Email),true);
                }
                else
                {
                    Session["NoAnimo"] = noAnimo;
                    Session[cSession.sUserType] = "user";
                    Session[cSession.sUserStruct] = new cSessionUser() { UserEmail = txtEmail.Text, UserName = txtNama.Text };
                    Response.Redirect("DaftarKonfirmasi.aspx",true);
                }
            }
            catch (Exception)
            {
                lblError.InnerHtml = "Pendaftaran Gagal!! Data tidak benar.";
                //lblError.InnerHtml = ex.Message;
            }
        }
        protected void InsertStruct(DataStruct.DataStructDaftar args)
        {
            try
            {
                string pangkat = Convert.ToString(Session[cSession.sPangkat]);
                if (pangkat == "")
                    throw new Exception();
                dt = oDataAccess.getDataTable_GelombangAktif(pangkat);
                args.GelombangID = Convert.ToInt32(Convert.ToString(dt.Rows[0]["GelombangID"]));
                args.TahunPendaftaran = Convert.ToString(dt.Rows[0]["TahunPendaftaran"]);
                args.Nama = txtNama.Text;
                args.Pendidikan = Convert.ToInt32(cboPendidikan.Value);
                args.NamaSekolah = txtNamaSekolah.Text;
                args.KotaAsalSMA = txtKotaAsalSMA.Text;
                args.PropinsiSMA = txtPropinsiSMA.Text;
                args.TahunLulusSMA = txtTahunLulusSMA.Text;
                args.TempatLahir = txtTempatLahir.Text;
                args.TanggalLahir = Convert.ToDateTime(dteTglLahir.Value);
                args.NoKTP = txtNomorKTP.Text;
                args.Email = txtEmail.Text;
                string wilayahId = Convert.ToString(cboWilayah.Value);
                if (oDataAccess.IsValidWilayah(wilayahId) != true)
                    throw new Exception();
                args.Wilayah = wilayahId;
                args.Pangkat = pangkat;
                args.JenisKelamin = Convert.ToInt32(cboJenisKelamin.Value);

                args.Alamat = txtAlamat.Text;
                args.Kota = txtKabupaten.Text;
                args.Propinsi = txtPropinsi.Text;
                args.NoTelepon = txtNoTelp.Text;
                args.Agama = Convert.ToInt32(cboAgama.Value);
                args.Suku = txtSuku.Text;
                args.TinggiBadan = Convert.ToInt32(spnTinggiBadan.Value);
                args.BeratBadan = Convert.ToInt32(spnBeratBadan.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void cboWilayah_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            try
            {
                if (Convert.ToString(Session[cSession.sPangkat]) == "")
                    return;
                cboWilayah.DataSource = oDataAccess.getDataTable_Wilayah(Convert.ToString(Session[cSession.sPangkat]), e.Parameter);
                cboWilayah.TextField = "WilayahName";
                cboWilayah.ValueField = "WilayahId";
                cboWilayah.DataBind();
            }
            catch (Exception)
            {
                
            }
        }
        protected void LoadPendidikan()
        {
            try
            {
                cboPendidikan.DataSource = oDataAccess.getDataTable_Pendidikan(Session[cSession.sPangkat].ToString());
                cboPendidikan.TextField = "ParameterName";
                cboPendidikan.ValueField = "ParameterID";
                cboPendidikan.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void LoadJenisKelamin()
        {
            try
            {
                cboJenisKelamin.DataSource = oDataAccess.getDataTable_JenisKelamin(Session[cSession.sPangkat].ToString());
                cboJenisKelamin.TextField = "ParameterName";
                cboJenisKelamin.ValueField = "ParameterID";
                cboJenisKelamin.DataBind();
            }
            catch (Exception)
            {
            }
        }
        protected void LoadAgama()
        {
            try
            {
                var oDa = new DataAccess.DataAccessDataProfil();
                cboAgama.DataSource = oDa.GetDataTableParameter("Agama", Session[cSession.sPangkat].ToString());
                cboAgama.TextField = "ParameterName";
                cboAgama.ValueField = "ParameterID";
                cboAgama.DataBind();
                cboAgama.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }
        protected void LoadDateBorn(int gelombangId)
        {
            try
            {
                DataTable dtDateBorn = oDataAccess.getDataTable_MinMaxDate(gelombangId);
                dteTglLahir.MinDate = Convert.ToDateTime(dtDateBorn.Rows[0]["BornFrom"]);
                dteTglLahir.MaxDate = Convert.ToDateTime(dtDateBorn.Rows[0]["BornTo"]);
            }
            catch (Exception)
            {

            }
        }

        protected void lnkDownload_Click(object sender, EventArgs e)
        {
            string fileUrl = "~/Administrator/Upload/Blanko/";
            string filePath = Server.MapPath(fileUrl);
            string[] filename = System.IO.Directory.GetFiles(filePath, string.Format("Blanko_{0}*", Session[cSession.sPangkat]));
            if (filename.Length > 0)
            {
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=blanko_adm.pdf");
                Response.TransmitFile(filename[0]);
                Response.End();
            }
          
        }
    }
}