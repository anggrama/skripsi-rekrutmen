using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class MainAdministrator : System.Web.UI.MasterPage
    {
        DataAccess.DataAccessMain oDataAccess = new DataAccess.DataAccessMain();
        DataAccess.DataAccessLoginAdm oDaLogin = new DataAccess.DataAccessLoginAdm();
        DataAccess.DataAccessInfo oDaInfo = new DataAccess.DataAccessInfo();


        protected void Page_Load(object sender, EventArgs e)
        {
            navLanud.Visible = false;
            navSuperAdmin.Visible = false;
            navAdminGuest.Visible = false;
            logoutForm.Visible = false;
            badge.Visible = false;

            cSessionAdmin adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];

            if (adminStruct == null)
            {
                navAdminGuest.Visible = true;
                return;
            }
            else if (adminStruct.AdminType.ToLower() == "superadmin")
                navSuperAdmin.Visible = true;
            else if (adminStruct.AdminType.ToLower() == "admin")
            {
                navSuperAdmin.Visible = true;
                navMaster.Visible = false;
                //NavbarAdmin.Groups[0].Visible = false;
                //NavbarAdmin.Groups[1].Visible = true;
                //NavbarAdmin.Groups[2].Visible = false;
            }
            else if (adminStruct.AdminType.ToLower() == "lanud")
            {
                navLanud.Visible = true;

                int messageCount = oDaInfo.getInt_UnreadMessage(adminStruct.Panda);
                if (messageCount > 0)
                {
                    litMessage.Text = messageCount.ToString("N0");
                    badge.Visible = true;
                }
                    
            }

            loginForm.Visible = false;

            litHello.Text = string.Format("Selamat Datang {0} {1}",adminStruct.AdminType,adminStruct.Panda);
            logoutForm.Visible = true;
         
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("default.aspx");
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtgelombang = new DataTable();

            try
            {
                dt = oDaLogin.GetDataTableUserInfo(txtUsername.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                lblSalah.Text = ex.Message;
            }

            if (dt.Rows.Count == 0)
            {
                lblSalah.Visible = true;
                return;
            }

            try
            {
                dtgelombang = oDaLogin.GetDataTableGelombang();
            }
            catch (Exception ex)
            {
                lblSalah.Text = ex.Message;
            }

            cSessionAdmin admin = new cSessionAdmin();
            admin.AdminType = dt.Rows[0]["UserRole"].ToString();
            admin.Panda = dt.Rows[0]["PandaId"].ToString();
            admin.UserID = dt.Rows[0]["UserId"].ToString();
            admin.UserName = dt.Rows[0]["UserName"].ToString();
            Session[cSession.sAdminStruct] = admin;
            Session[cSession.sUserType] = "admin";
            Session[cSession.sFilter_Tahun] = dtgelombang.Rows[0]["TahunPendaftaran"].ToString();
            Session[cSession.sFilter_Gelombang] = dtgelombang.Rows[0]["GelombangID"].ToString();

            Response.Redirect("mainadm.aspx");
        }
    }
}