using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace RekrutmenTNI
{
    public partial class ucData : System.Web.UI.UserControl
    {
        DataAccess.DataAccessDataProfil oDataAccess = new DataAccess.DataAccessDataProfil();
        public string Email {get; set; }
        public string Panda { get; set; }
        public DataStruct.DataStructDataProfil Profil {
            get
            {
                string[] tglLahir = txtTglLahir.Value.ToString().Split('-');
                var date = Convert.ToDateTime(tglLahir[2].ToString() + '-' + tglLahir[1].ToString() + '-' + tglLahir[0].ToString());
                var args = new DataStruct.DataStructDataProfil
                {
                    Agama = Convert.ToInt32(cboAgama.Value),
                    Alamat = txtAlamat.Text,
                    AlamatBpk = txtAlamatBapak.Text,
                    AlamatIbu = txtAlamatIbu.Text,
                    AlamatWali = txtAlamatWali.Text,
                    BeratBadan = Convert.ToInt32(spnBeratBadan.Value),
                    JabatanBpk = txtJabatanBpk.Text,
                    JabatanIbu = txtJabatanIbu.Text,
                    JabatanWali = txtJabatanWali.Text,
                    JenisKelamin = Convert.ToInt32(cboJenisKelamin.Value),
                    JuaraKe1 = Convert.ToInt32(cboPrestasi1_Juara.Value),
                    JuaraKe2 = Convert.ToInt32(cboPrestasi2_Juara.Value),
                    JuaraKe3 = Convert.ToInt32(cboPrestasi3_Juara.Value),
                    Jurusan = txtJurusan.Text,
                    Kabupaten = txtKabupaten.Text,
                    KotaAsalSD = txtKotaAsalSD.Text,
                    KotaAsalSMP = txtKotaAsalSMP.Text,
                    KotaAsalSMA = txtKotaAsalSMA.Text,
                    Nama = txtNama.Text,
                    NamaBpk = txtNamaBpk.Text,
                    NamaIbu = txtNamaIbu.Text,
                    NamaKantorBpk = txtNamaKantorBpk.Text,
                    NamaKantorIbu = txtNamaKantorIbu.Text,
                    NamaKantorWali = txtNamaKantorWali.Text,
                    NamaSD = txtNamaSD.Text,
                    NamaSMP = txtNamaSMP.Text,
                    NamaSMA = txtNamaSMA.Text,
                    NamaWali = txtNamaWali.Text,
                    NEMSD = Convert.ToDouble(spnNemSD.Value),
                    NEMSMP = Convert.ToDouble(spnNemSMP.Value),
                    NEMSMA = Convert.ToDouble(spnNemSMA.Value),
                    NilaiUN = Convert.ToDouble(spnNilaiUN.Value),
                    NoKTP = txtNoKTP.Text,
                    PekerjaanBpk = txtPekerjaanBpk.Text,
                    PekerjaanIbu = txtPekerjaanIbu.Text,
                    PekerjaanWali = txtPekerjaanWali.Text,
                    PendaftaranDari = Convert.ToInt32(cboPendaftaranDari.Value),
                    PendaftaranKe = Convert.ToInt32(cboPendaftaranKe.Value),
                    Pendidikan = Convert.ToInt32(cboPendidikanSMA.Value),
                    Prestasi1 = txtPrestasi1.Text,
                    Prestasi2 = txtPrestasi2.Text,
                    Prestasi3 = txtPrestasi3.Text,
                    Propinsi = txtPropinsi.Text,
                    PropinsiSD = txtPropinsiSD.Text,
                    PropinsiSMP = txtPropinsiSMP.Text,
                    PropinsiSMA = txtPropinsiSMA.Text,
                    StatusSD = Convert.ToString(cboStatusSD.Value),
                    StatusSMP = Convert.ToString(cboStatusSMP.Value),
                    StatusSMA = Convert.ToString(cboStatusSMA.Value),
                    Suku = txtSuku.Text,
                    TahunLulusSD = Convert.ToString(spnTahunLulusSD.Value),
                    TahunLulusSMP = Convert.ToString(spnTahunLulusSMP.Value),
                    TahunLulusSMA = Convert.ToString(spnTahunLulusSMA.Value),
                    TanggalLahir = date,
                    Telp = txtNoTelp.Text,
                    TempatLahir = txtTempatLahir.Text,
                    TinggiBadan = Convert.ToInt32(spnTinggiBadan.Value),
                    Tingkatan1 = Convert.ToInt32(cboPrestasi1_Tingkat.Value),
                    Tingkatan2 = Convert.ToInt32(cboPrestasi2_Tingkat.Value),
                    Tingkatan3 = Convert.ToInt32(cboPrestasi3_Tingkat.Value),
                    IsActive = true,
                    email = Email
                };
                return args;
            }
        }

        public ucData()
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadDataProfil();
        }

        private void LoadDataProfil()
        {
            DataTable dtPendidikan, dt, dtAgama, dtWilayah, dtJK, dtPendDari, dtPendKe, dtJuara, dtTingkat, dtPJ;
            string page = "";
            try
            {

                dt = oDataAccess.getDataTable_DataProfil_byEmail(Email,Panda);
                page = dt.Rows[0]["Pangkat"].ToString();

                dtPendidikan = oDataAccess.GetDataTableParameter("Pendidikan", page);
                dtAgama = oDataAccess.GetDataTableParameter("Agama", page);
                dtJK = oDataAccess.GetDataTableParameter("JK", page);
                dtPendDari = oDataAccess.GetDataTableParameter("PendaftaranDari", page);
                dtPendKe = oDataAccess.GetDataTableParameter("PendaftaranKe", page);
                dtJuara = oDataAccess.GetDataTableParameter("PrestasiJuara", page);
                dtTingkat = oDataAccess.GetDataTableParameter("Tingkat", page);
                dtWilayah = oDataAccess.GetDataTablePanda(dt.Rows[0]["PandaId"].ToString());
                string noAnimo = dt.Rows[0]["NoAnimo"].ToString();
                txtNoAnimo.Text = noAnimo;

                spnTinggiBadan.MinValue = oDataAccess.getMinTinggiBadan(Convert.ToChar(cboJenisKelamin.Value));

                txtNama.Text = dt.Rows[0]["Nama"].ToString();
                spnTinggiBadan.Text = dt.Rows[0]["TinggiBadan"].ToString();
                spnBeratBadan.Text = dt.Rows[0]["BeratBadan"].ToString();
                txtTempatLahir.Text = dt.Rows[0]["TempatLahir"].ToString();
                txtTglLahir.Text = Convert.ToDateTime(dt.Rows[0]["TanggalLahir"]).ToString("dd-MM-yyyy");
                txtSuku.Text = dt.Rows[0]["Suku"].ToString();
                txtAlamat.Text = dt.Rows[0]["Alamat"].ToString();
                txtKabupaten.Text = dt.Rows[0]["Kabupaten"].ToString();
                txtPropinsi.Text = dt.Rows[0]["Propinsi"].ToString();
                txtNoTelp.Text = dt.Rows[0]["Telp"].ToString();
                txtNoKTP.Text = dt.Rows[0]["NoKTP"].ToString();
                txtNamaSD.Text = dt.Rows[0]["NamaSD"].ToString();
                txtKotaAsalSD.Text = dt.Rows[0]["KotaAsalSD"].ToString();
                txtPropinsiSD.Text = dt.Rows[0]["PropinsiSD"].ToString();
                spnTahunLulusSD.Text = dt.Rows[0]["TahunLulusSD"].ToString();
                spnNemSD.Text = dt.Rows[0]["NEMSD"].ToString();
                txtNamaSMP.Text = dt.Rows[0]["NamaSMP"].ToString();
                txtKotaAsalSMP.Text = dt.Rows[0]["KotaAsalSMP"].ToString();
                txtPropinsiSMP.Text = dt.Rows[0]["PropinsiSMP"].ToString();
                spnTahunLulusSMP.Text = dt.Rows[0]["TahunLulusSMP"].ToString();
                spnNemSMP.Text = dt.Rows[0]["NEMSMP"].ToString();
                txtNamaSMA.Text = dt.Rows[0]["NamaSMA"].ToString();
                txtKotaAsalSMA.Text = dt.Rows[0]["KotaAsalSMA"].ToString();
                txtPropinsiSMA.Text = dt.Rows[0]["PropinsiSMA"].ToString();
                spnTahunLulusSMA.Text = dt.Rows[0]["TahunLulusSMA"].ToString();
                spnNemSMA.Text = dt.Rows[0]["NEMSMA"].ToString();
                spnNilaiUN.Text = dt.Rows[0]["NilaiUN"].ToString();
                txtJurusan.Text = dt.Rows[0]["Jurusan"].ToString();
                txtNamaBpk.Text = dt.Rows[0]["NamaBpk"].ToString();
                txtNamaIbu.Text = dt.Rows[0]["NamaIbu"].ToString();
                txtNamaWali.Text = dt.Rows[0]["NamaWali"].ToString();
                txtPekerjaanBpk.Text = dt.Rows[0]["PekerjaanBpk"].ToString();
                txtPekerjaanIbu.Text = dt.Rows[0]["PekerjaanIbu"].ToString();
                txtPekerjaanWali.Text = dt.Rows[0]["PekerjaanWali"].ToString();
                txtJabatanBpk.Text = dt.Rows[0]["JabatanBpk"].ToString();
                txtJabatanIbu.Text = dt.Rows[0]["JabatanIbu"].ToString();
                txtJabatanWali.Text = dt.Rows[0]["JabatanWali"].ToString();
                txtNamaKantorBpk.Text = dt.Rows[0]["NamaKantorBpk"].ToString();
                txtNamaKantorIbu.Text = dt.Rows[0]["NamaKantorIbu"].ToString();
                txtNamaKantorWali.Text = dt.Rows[0]["NamaKantorWali"].ToString();
                txtPrestasi1.Text = dt.Rows[0]["Prestasi1"].ToString();
                txtPrestasi2.Text = dt.Rows[0]["Prestasi2"].ToString();
                txtPrestasi3.Text = dt.Rows[0]["Prestasi3"].ToString();
                txtAlamatBapak.Text = dt.Rows[0]["AlamatBpk"].ToString();
                txtAlamatIbu.Text = dt.Rows[0]["AlamatIbu"].ToString();
                txtAlamatWali.Text = dt.Rows[0]["AlamatWali"].ToString();

                cboAgama.DataSource = dtAgama;
                cboPendidikanSMA.DataSource = dtPendidikan;
                cboJenisKelamin.DataSource = dtJK;
                cboPendaftaranDari.DataSource = dtPendDari;
                cboPendaftaranKe.DataSource = dtPendKe;
                cboPrestasi1_Juara.DataSource = dtJuara;
                cboPrestasi2_Juara.DataSource = dtJuara;
                cboPrestasi3_Juara.DataSource = dtJuara;
                cboPrestasi1_Tingkat.DataSource = dtTingkat;
                cboPrestasi2_Tingkat.DataSource = dtTingkat;
                cboPrestasi3_Tingkat.DataSource = dtTingkat;

                cboAgama.TextField = "ParameterName";
                cboPendidikanSMA.TextField = "ParameterName";
                cboJenisKelamin.TextField = "ParameterName";
                cboPendaftaranDari.TextField = "ParameterName";
                cboPendaftaranKe.TextField = "ParameterName";
                cboPrestasi1_Juara.TextField = "ParameterName";
                cboPrestasi1_Tingkat.TextField = "ParameterName";
                cboPrestasi2_Juara.TextField = "ParameterName";
                cboPrestasi2_Tingkat.TextField = "ParameterName";
                cboPrestasi3_Juara.TextField = "ParameterName";
                cboPrestasi3_Tingkat.TextField = "ParameterName";

                cboAgama.ValueField = "ParameterID";
                cboPendidikanSMA.ValueField = "ParameterID";
                cboJenisKelamin.ValueField = "ParameterID";
                cboPendaftaranDari.ValueField = "ParameterID";
                cboPendaftaranKe.ValueField = "ParameterID";
                cboPrestasi1_Juara.ValueField = "ParameterID";
                cboPrestasi1_Tingkat.ValueField = "ParameterID";
                cboPrestasi2_Juara.ValueField = "ParameterID";
                cboPrestasi2_Tingkat.ValueField = "ParameterID";
                cboPrestasi3_Juara.ValueField = "ParameterID";
                cboPrestasi3_Tingkat.ValueField = "ParameterID";

                cboAgama.DataBind();
                cboPendidikanSMA.DataBind();
                cboJenisKelamin.DataBind();
                cboPendaftaranDari.DataBind();
                cboPendaftaranKe.DataBind();
                cboPrestasi1_Juara.DataBind();
                cboPrestasi1_Tingkat.DataBind();
                cboPrestasi2_Juara.DataBind();
                cboPrestasi2_Tingkat.DataBind();
                cboPrestasi3_Juara.DataBind();
                cboPrestasi3_Tingkat.DataBind();

                cboAgama.Value = dt.Rows[0]["Agama"].ToString();
                cboJenisKelamin.Value = dt.Rows[0]["JenisKelamin"].ToString();
                cboPendidikanSMA.Value = dt.Rows[0]["Pendidikan"].ToString();
                cboPendaftaranDari.Value = dt.Rows[0]["PendaftaranDari"].ToString();
                if (dt.Rows[0]["PendaftaranKe"].ToString() == "")
                    cboPendaftaranKe.SelectedIndex = 0;
                else
                    cboPendaftaranKe.Value = dt.Rows[0]["PendaftaranKe"].ToString();

                cboPrestasi1_Juara.Value = dt.Rows[0]["JuaraKe1"].ToString();
                cboPrestasi1_Tingkat.Value = dt.Rows[0]["Tingkatan1"].ToString();
                cboPrestasi2_Juara.Value = dt.Rows[0]["JuaraKe2"].ToString();
                cboPrestasi2_Tingkat.Value = dt.Rows[0]["Tingkatan2"].ToString();
                cboPrestasi3_Juara.Value = dt.Rows[0]["JuaraKe3"].ToString();
                cboPrestasi3_Tingkat.Value = dt.Rows[0]["Tingkatan3"].ToString();
                cboStatusSD.Value = dt.Rows[0]["StatusSD"].ToString();
                cboStatusSMP.Value = dt.Rows[0]["StatusSMP"].ToString();
                cboStatusSMA.Value = dt.Rows[0]["StatusSMA"].ToString();

            }
            catch (Exception ex)
            {
                
            }
        }
        
    }
}