using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI.Admin
{
    public partial class Users : AdminPageBase
    {
        DataAccess.DataAccessUsers oDataAccess = new DataAccess.DataAccessUsers();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];

            if (!IsPostBack)
            {
                if (adminStruct.AdminType.ToLower() != "superadmin")
                {
                    Response.Redirect("MainAdm.aspx");
                    return;
                }
                gvUsers.DataBind();
            }
           

        }

        private void LoadgvUsers()
        {
            
            try
            {
                gvUsers.DataSource = oDataAccess.GetDataTableUsers();
            }
            catch (Exception)
            {
                
            }
            

            
        }

        protected void gvUsers_DataBinding(object sender, EventArgs e)
        {
            LoadgvUsers();
        }
    }
}