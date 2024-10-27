using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI
{
    public partial class DataProfil : UserPageBase
    {

        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            ucDataProfil.Email = ((cSessionUser)Session[cSession.sUserStruct]).UserEmail;
        }
        
        protected void btnSimpan_Click(object sender, EventArgs e)
        {

            try
            {
                var oDataAccess = new DataAccess.DataAccessDataProfil();
                var args = ucDataProfil.Profil;
                args.email = ((cSessionUser)Session[cSession.sUserStruct]).UserEmail;
                oDataAccess.DataUpdate(args);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            //DataStruct.DataStructDataProfil args = new DataStruct.DataStructDataProfil();

            //try
            //{
            //    UpdateStruct(args);
            //    oDataAccess.DataUpdate(args);
            //}
            //catch (Exception ex)
            //{
            //    lblError.Text = ex.Message;
            //}
        }
        //protected void btnLogOut_Click(object sender, EventArgs e)
        //{
        //    Session.RemoveAll();
        //    Response.Redirect("Default.aspx");
        //}

        //private void UpdateStruct(DataStruct.DataStructDataProfil args)
        //{


        //    //args.email = ((cSessionUser)Session[cSession.sUserStruct]).UserEmail;
        //    //args.Nama = txtNama.Text;
        //    //args.TinggiBadan = Convert.ToInt32(spnTinggiBadan.Text);
        //    //args.BeratBadan = Convert.ToInt32(spnBeratBadan.Text);
        //    //args.JenisKelamin = Convert.ToInt32(cboJenisKelamin.Value);
        //    //args.TempatLahir = txtTempatLahir.Text;
        //    //string tglLahir = String.Format("{0}-{1}-{2}", txtTglLahir.Text.Substring(6), txtTglLahir.Text.Substring(3, 2), txtTglLahir.Text.Substring(0, 2));
        //    //args.TanggalLahir = Convert.ToDateTime(tglLahir);
        //    //args.Agama = Convert.ToInt32(cboAgama.Value);
        //    //args.Suku = txtSuku.Text;
        //    //args.Alamat = txtAlamat.Text;
        //    //args.Kabupaten = txtKabupaten.Text;
        //    //args.Propinsi = txtPropinsi.Text;
        //    //args.Telp = txtNoTelp.Text;
        //    //args.NoKTP = txtNoKTP.Text;
        //    //args.StatusSD = Convert.ToString(cboStatusSD.Value);
        //    //args.NamaSD = txtNamaSD.Text;
        //    //args.KotaAsalSD = txtKotaAsalSD.Text;
        //    //args.PropinsiSD = txtPropinsiSD.Text;
        //    //args.TahunLulusSD = spnTahunLulusSD.Text;
        //    //args.NEMSD = Convert.ToDouble(spnNemSD.Value);
        //    //args.StatusSMP = Convert.ToString(cboStatusSMP.Value);
        //    //args.NamaSMP = txtNamaSMP.Text;
        //    //args.KotaAsalSMP = txtKotaAsalSMP.Text;
        //    //args.PropinsiSMP = txtPropinsiSMP.Text;
        //    //args.TahunLulusSMP = spnTahunLulusSMP.Text;
        //    //args.NEMSMP = Convert.ToDouble(spnNemSMP.Value);
        //    //args.StatusSMA = Convert.ToString(cboStatusSMA.Value);
        //    //args.NamaSMA = txtNamaSMA.Text;
        //    //args.KotaAsalSMA = txtKotaAsalSMA.Text;
        //    //args.PropinsiSMA = txtPropinsiSMA.Text;
        //    //args.TahunLulusSMA = spnTahunLulusSMA.Text;
        //    //args.NEMSMA = Convert.ToDouble(spnNemSMA.Value);
        //    //args.NilaiUN = Convert.ToDouble(spnNilaiUN.Value);
        //    //args.Pendidikan = Convert.ToInt32(cboPendidikanSMA.Value);
        //    //args.Jurusan = txtJurusan.Text;
        //    //args.NamaBpk = txtNamaBpk.Text;
        //    //args.AlamatBpk = txtAlamatBapak.Text;
        //    //args.NamaIbu = txtNamaIbu.Text;
        //    //args.AlamatIbu = txtAlamatIbu.Text;
        //    //args.NamaWali = txtNamaWali.Text;
        //    //args.AlamatWali = txtAlamatWali.Text;
        //    //args.PekerjaanBpk = txtPekerjaanBpk.Text;
        //    //args.PekerjaanIbu = txtPekerjaanIbu.Text;
        //    //args.PekerjaanWali = txtPekerjaanWali.Text;
        //    //args.JabatanBpk = txtJabatanBpk.Text;
        //    //args.JabatanIbu = txtJabatanIbu.Text;
        //    //args.JabatanWali = txtJabatanWali.Text;
        //    //args.NamaKantorBpk = txtNamaKantorBpk.Text;
        //    //args.NamaKantorIbu = txtNamaKantorIbu.Text;
        //    //args.NamaKantorWali = txtNamaKantorWali.Text;
        //    //args.PendaftaranKe = Convert.ToInt32(cboPendaftaranKe.Value);
        //    //args.PendaftaranDari = Convert.ToInt32(cboPendaftaranDari.Value);
        //    //args.Prestasi1 = txtPrestasi1.Text;
        //    //args.JuaraKe1 = Convert.ToInt32(cboPrestasi1_Juara.Value);
        //    //args.Tingkatan1 = Convert.ToInt32(cboPrestasi1_Tingkat.Value);
        //    //args.Prestasi2 = txtPrestasi2.Text;
        //    //args.JuaraKe2 = Convert.ToInt32(cboPrestasi2_Juara.Value);
        //    //args.Tingkatan2 = Convert.ToInt32(cboPrestasi2_Tingkat.Value);
        //    //args.Prestasi3 = txtPrestasi3.Text;
        //    //args.JuaraKe3 = Convert.ToInt32(cboPrestasi3_Juara.Value);
        //    //args.Tingkatan3 = Convert.ToInt32(cboPrestasi3_Tingkat.Value);
        //    //args.ModifiedBy = ((cSessionUser)Session[cSession.sUserStruct]).UserEmail;
        //}

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            btnSimpan_Click(null, null);
            Response.Redirect("dashboard.aspx");
        }

        protected void printCallback_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            btnSimpan_Click(null, null);
            //string noAnimo = Request.QueryString["ida"];
            //((cSessionUser)Session[cSession.sUserStruct]).UserEmail;
            //e.Result = noAnimo;
        }
    }
}