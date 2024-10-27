using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI
{
    public partial class MainDefault : System.Web.UI.MasterPage
    {

        DataAccess.DataAccessLogin oDa = new DataAccess.DataAccessLogin();
        protected void Page_Load(object sender, EventArgs e)
        {
            navGuest.Visible = false;
            navUser.Visible = false;
            navDefault.Visible = false;

            logoutForm.Visible = false;
            loginForm.Visible = false;


            if (Session[cSession.sPangkat] == null && Session[cSession.sUserType] == null)
            {
                navDefault.Visible = true;
                loginForm.Visible = true;
                return;
            }
                
         
            if (Session[cSession.sUserType] == null)
            {
                loginForm.Visible = true;
                navGuest.Visible = true;
            }
            else
            {
                logoutForm.Visible = true;
                navUser.Visible = true;
            }

            if (Session[cSession.sPangkat] != null)
                litPangkat.Text = Session[cSession.sPangkat].ToString();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string nama;
            try
            {
                nama = oDa.GetDataTable_User(txtEmail.Text, txtPassword.Text);
                if (nama != "")
                {
                    Session[cSession.sUserStruct] = new cSessionUser() { UserEmail = txtEmail.Text, UserName = nama };
                    Session[cSession.sUserType] = "user";
                    Response.Redirect("dashboard.aspx");
                }
                else
                    throw new Exception("User atau password anda salah!!");
            }
            catch (Exception ex)
            {
                lblSalah.Text = ex.Message;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("default.aspx");
        }

        protected void callMail_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            try
            {
                MailClass oMail = new MailClass();
                oMail.SendEmail_ForgotEmail(txtForgetEmail.Text);

                callMail.JSProperties["cp_error"] = "email sudah berhasil dikirim.";
            }
            catch (Exception ex)
            {
                callMail.JSProperties["cp_error"] = ex.Message;
            }
            
        }
    }
}