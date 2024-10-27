using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DataAccess;

namespace RekrutmenTNI.Admin
{
    public partial class Outbox : System.Web.UI.Page
    {

        DataAccessInfo oDataAccess = new DataAccessInfo();
        cSessionAdmin adminStruct;
        protected void Page_Load(object sender, EventArgs e)
        {

            gvMessage.DataBind();
        }

        private void LoadData()
        {
            try
            {
                adminStruct = (cSessionAdmin)Session[cSession.sAdminStruct];
                if (adminStruct.AdminType.ToLower().Contains("admin"))
                    gvMessage.DataSource = oDataAccess.getDataTable_Outbox("");
                else if (adminStruct.AdminType.ToLower() == "lanud")
                    gvMessage.DataSource = oDataAccess.getDataTable_Outbox(adminStruct.Panda);

               
            }
            catch (Exception)
            {

            }
        }

        protected void gvMessage_DataBinding(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}