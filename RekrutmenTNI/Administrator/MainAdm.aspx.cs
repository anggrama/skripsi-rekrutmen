using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class MainAdm : AdminPageBase
    {
        
        DataAccess.DataAccessMainAdm oDataAccess = new DataAccess.DataAccessMainAdm();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                gvStats.DataBind();
                TotalNasional();
            }

            if (IsCallback)
            {
                gvStats.DataBind();
                TotalNasional();
            }
            
            
        }
        private void Loadgv()
        {
            string pandaId = ((cSessionAdmin)Session[cSession.sAdminStruct]).Panda;
            string role = ((cSessionAdmin)Session[cSession.sAdminStruct]).AdminType.ToLower();

            DataTable dt = new DataTable();
            int jmlAnimo = 0, jmlPeserta = 0, LulusDaerah = 0, LulusPusat = 0;
            int jmlAnimoL = 0, jmlAnimoP = 0, jmlPesertaL = 0, jmlPesertaP = 0;

            if (role == "admin" || role == "superadmin")
                pandaId = "%";

            try
            {
                dt = oDataAccess.GetDataTableLanud(pandaId, ucFilter.Pangkat, ucFilter.Gelombang);
                gvStats.DataSource = dt;
            }
            catch (Exception)
            {

            }
            

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                jmlAnimo = jmlAnimo + (int)dt.Rows[i]["Animo"];
                jmlPeserta = jmlPeserta + (int)dt.Rows[i]["Peserta"];
                LulusDaerah = LulusDaerah + (int)dt.Rows[i]["LulusD"];
                LulusPusat = LulusPusat + (int)dt.Rows[i]["LulusP"];

                jmlAnimoL += (int)dt.Rows[i]["AnimoL"];
                jmlAnimoP += (int)dt.Rows[i]["AnimoP"];
                jmlPesertaL += (int)dt.Rows[i]["PesertaL"];
                jmlPesertaP += (int)dt.Rows[i]["PesertaP"];
            }

            lblTotAnimo.Text = jmlAnimo.ToString();
            lblTotPeserta.Text = jmlPeserta.ToString();
            lblTotLulusDaerah.Text = LulusDaerah.ToString();
            lblTotLulusPeserta.Text = LulusPusat.ToString();

            lblTotAnimoL.Text = jmlAnimoL.ToString();
            lblTotAnimoP.Text = jmlAnimoP.ToString();
            lblTotPesertaL.Text = jmlPesertaL.ToString();
            lblTotPesertaP.Text = jmlPesertaP.ToString();

        }
        private void TotalNasional()
        {
            try
            {
                lblTotNasAnimo.Text = oDataAccess.GetCount_TotNasAnimo(ucFilter.Pangkat, ucFilter.Gelombang).ToString();
                lblTotNasPeserta.Text = oDataAccess.GetCount_TotNasPeserta(ucFilter.Pangkat, ucFilter.Gelombang).ToString();
                lblTotNasLulusDaerah.Text = oDataAccess.GetCount_TotLulusDaerah(ucFilter.Pangkat, ucFilter.Gelombang).ToString();
                lblTotNasLulusPeserta.Text = oDataAccess.GetCount_TotLulusPeserta(ucFilter.Pangkat, ucFilter.Gelombang).ToString();
            }
            catch (Exception)
            {
                
            }
          
        }
        protected void gvStats_DataBinding(object sender, EventArgs e)
        {
            Loadgv();
        }
        protected void callData_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            if (e.Parameter == "load")
            {
                gvStats.DataBind();
                TotalNasional();
            }
           
        }
    }
}