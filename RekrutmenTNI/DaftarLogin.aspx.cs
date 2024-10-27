using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI
{
    public partial class DaftarLogin : System.Web.UI.Page
    {
        DataAccess.DataAccessLogin oDa = new DataAccess.DataAccessLogin();
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Convert.ToString(Request.QueryString["eid"]);
            txtEmail.Text = email;
        }

        private void Login()
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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}