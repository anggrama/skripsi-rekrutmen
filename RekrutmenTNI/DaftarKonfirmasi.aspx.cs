using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI
{
    public partial class DaftarKonfirmasi : System.Web.UI.Page
    {
        DataAccess.DataAccessDaftarKonfirmasi oDataAccess = new DataAccess.DataAccessDaftarKonfirmasi();
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if(Session["NoAnimo"] == null)
            {
                Response.Redirect("Default.aspx");
                return;
            }
            DataTable dt = new DataTable();

            try
            {
                dt = oDataAccess.GetDataTableUserPass(Session["NoAnimo"].ToString(), Session[cSession.sPangkat].ToString());

                Session.Remove("NoAnimo");

                lblEmail.Text = dt.Rows[0]["UserEmail"].ToString();
                lblPassword.Text = dt.Rows[0]["Pass"].ToString();
            }
            catch (Exception ex)
            {
                
            }
                
            
        }
    }
}