using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class UsersEdit : AdminPageBase
    {
        DataAccess.DataAccessUsers oDataAccess = new DataAccess.DataAccessUsers();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];

            if (adminStruct.AdminType.ToLower() != "superadmin")
            {
                Response.Redirect("MainAdm.aspx");
            }

            if(Request.QueryString["id"] == null)
            {
                txtUserId.Enabled = true;
                lblTitle.Text = "Tambah User Baru";
            }
            else
            {
                txtUserId.Enabled = false;
                lblTitle.Text = "Edit User";
                txtPassword.ValidationSettings.RequiredField.IsRequired = false;
                txtConfPassword.ValidationSettings.RequiredField.IsRequired = false;

                if(IsPostBack ==  false)
                {
                    LoadUsers();
                }
            }

            if(IsPostBack == false)
            {
                LoadcboPanda();
            }
        }

        private void LoadUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = oDataAccess.GetDataTableUsers(Request.QueryString["id"].ToString());
            }
            catch (Exception ex)
            {
                
            }

            if (dt == null)
            {
                return;
            }

            txtUserId.Text = Request.QueryString["id"].ToString();
            txtUserName.Text = dt.Rows[0]["UserName"].ToString();
            cboUserRole.Value = dt.Rows[0]["UserRole"].ToString();
            //cboPangkat.Value = dt.Rows[0]["Pangkat"].ToString();
            cboPanda.Value = dt.Rows[0]["PandaId"].ToString();
            chkIsActive.Value = dt.Rows[0]["IsActive"];

            ViewState["Password"] = dt.Rows[0]["Pass"].ToString();
        }
        
        private void LoadcboPanda()
        {
            try
            {
                cboPanda.DataSource = oDataAccess.GetDataTablePanda();
            }
            catch (Exception ex)
            {
                
            }

            cboPanda.TextField = "WilayahName";
            cboPanda.ValueField = "WilayahId";
            cboPanda.DataBind();
        }

        protected void btnSimpan_Click(object sender, EventArgs e)
        {
            DataStruct.DataStructUsers args = new DataStruct.DataStructUsers();
            InsertStruct(args);

            try
            {
                oDataAccess.SaveUsers(args);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Response.Redirect("Users.aspx");
            }
        }

        private void InsertStruct(DataStruct.DataStructUsers args)
        {
            args.UserId = txtUserId.Text;
            args.UserName = txtUserName.Text;
            if(txtPassword.Text == "" || txtConfPassword.Text == "")
            {
                args.Password = ViewState["Password"].ToString();
            }
            else
            {
                args.Password = txtPassword.Text;
            }

            args.UserRole = cboUserRole.Value.ToString();
            //args.Pangkat = cboPangkat.Value.ToString();
            args.PandaId = Convert.ToString(cboPanda.Value);
            args.IsActive = chkIsActive.Checked;
            args.CreatedBy = adminStruct.UserID;
        }

        protected void cboPanda_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            cboBehavior(e.Parameter.ToLower());
            LoadcboPanda();

            //cboPangkat.SelectedIndex = -1;
            cboPanda.SelectedIndex = -1;
        }

        protected void btnBatal_Click(object sender, EventArgs e)
        {
            Response.Redirect("Users.aspx");
        }

        private void cboBehavior(string role)
        {
            if (role == "admin")
            {
                //cboPangkat.Enabled = true;
                cboPanda.Enabled = false;
            }
            else if (role == "lanud")
            {
                //cboPangkat.Enabled = false;
                cboPanda.Enabled = true;
            }
        }

        protected void cboPangkat_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            cboBehavior(e.Parameter.ToString());

            //cboPangkat.SelectedIndex = -1;
            cboPanda.SelectedIndex = -1;
        }
    }
}