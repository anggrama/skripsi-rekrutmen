using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace RekrutmenTNI.Administrator
{
    public partial class ucFilter : System.Web.UI.UserControl
    {
        public string Pangkat
        {
            get { return Convert.ToString(Session[cSession.sFilter_Pangkat]); }
        }
        public string Tahun
        {
            get { return Convert.ToString(Session[cSession.sFilter_Tahun]); }
        }
        public string Gelombang
        {
            
            get {
                Session[cSession.sFilter_Gelombang] = cboGelombang.Value;
                return Convert.ToString(Session[cSession.sFilter_Gelombang]);
            }
        }

        DataAccess.DataAccessMain oDataAccess = new DataAccess.DataAccessMain();
        private void LoadTahunPendaftaran()
        {
            DataTable dtTahunPendaftaran;
            try
            {
                dtTahunPendaftaran = oDataAccess.getDataTable_TahunPendaftaran(Session[cSession.sFilter_Pangkat].ToString());

                if (dtTahunPendaftaran.Rows.Count == 0)
                {
                    cboTahun.Value = null;
                    cboGelombang.DataSource = null;
                    cboGelombang.Value = null;
                }
                else
                {
                    cboTahun.DataSource = dtTahunPendaftaran;
                    cboTahun.TextField = "TahunPendaftaran";
                    cboTahun.ValueField = "TahunPendaftaran";
                    cboTahun.DataBind();
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void LoadGelombang()
        {
            DataTable dtData;
            try
            {
                
                dtData = oDataAccess.getDataTable_Gelombang(Session[cSession.sFilter_Tahun].ToString(), Session[cSession.sFilter_Pangkat].ToString());

                if (dtData.Rows.Count != 0)
                {
                    cboGelombang.DataSource = null;
                    cboGelombang.DataSource = dtData;
                    cboGelombang.TextField = "GelombangKe";
                    cboGelombang.ValueField = "GelombangID";
                    cboGelombang.DataBind();
                    
                }
              
            }
            catch (Exception)
            {

            }
        }
        protected void callFilter_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            //tahun; pangkat, gelombang
            string[] parameter = e.Parameter.Split(';');

            if (parameter[0] == "pangkat")
            {
                Session[cSession.sFilter_Pangkat] = parameter[1];
                LoadTahunPendaftaran();
                cboTahun.SelectedIndex = 0;
                LoadGelombang();
            }

            if (parameter[0] == "tahun")
            {
                Session[cSession.sFilter_Tahun] = parameter[1];
                LoadGelombang();
            }

            drpPangkat.Value = Session[cSession.sFilter_Pangkat];
            cboTahun.Value = Session[cSession.sFilter_Tahun];
            cboGelombang.Value = null;
            if (cboGelombang.Items.Count != 0)
            {
                cboGelombang.SelectedIndex = 0;
                Session[cSession.sFilter_Gelombang] = cboGelombang.Value.ToString();
            }


        }
        protected override void OnInit(EventArgs e)
        {

            if (!IsPostBack && !Page.IsCallback)
            {
                //cek apakah sudah ada session filter pangkat ( default )
                if (Session[cSession.sFilter_Pangkat] == null)
                    Session[cSession.sFilter_Pangkat] = "Bintara";
                else
                    drpPangkat.Value = Session[cSession.sFilter_Pangkat];

                LoadTahunPendaftaran();
                LoadGelombang();

                if (cboTahun.Items.Count != 0)
                {
                    cboTahun.SelectedIndex = 0;
                    Session[cSession.sFilter_Tahun] = cboTahun.Value.ToString();
                }

                if (cboGelombang.Items.Count != 0)
                {
                    cboGelombang.SelectedIndex = 0;
                    Session[cSession.sFilter_Gelombang] = cboGelombang.Value.ToString();
                }
            }
        }
      
    }
}