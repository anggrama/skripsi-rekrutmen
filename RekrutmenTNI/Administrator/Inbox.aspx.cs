using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

namespace RekrutmenTNI.Admin
{
    public partial class Inbox : AdminPageBase
    {
        DataAccessInfo oDataAccess = new DataAccessInfo();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
            
                if (!IsPostBack)
                {
                gvMessage.DataBind();
                }
            
        }

        private void bindGrid()
        {
            try
            {
                if (adminStruct.AdminType.ToLower().Contains ("admin"))
                    gvMessage.DataSource = oDataAccess.getDataTable_Inbox("");
                else if (adminStruct.AdminType.ToLower() == "lanud")
                    gvMessage.DataSource = oDataAccess.getDataTable_Inbox(adminStruct.Panda);

               
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
           

        }

        protected void btnCreateNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("inboxcreate.aspx");
        }

      

        protected void gvMessage_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            try
            {
                oDataAccess.delete_Message_Inbox(e.Values["Id"].ToString());
                e.Cancel = true;
                gvMessage.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void gvMessage_DataBinding(object sender, EventArgs e)
        {
            bindGrid();
        }
    }
}