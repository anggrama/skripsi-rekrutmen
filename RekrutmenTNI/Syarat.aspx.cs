using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI
{
    public partial class Syarat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (DataAccess.DataAccessInfo oDa = new DataAccess.DataAccessInfo())
                {
                    litPersyaratan.Text = oDa.getValue_Settings(Session[cSession.sPangkat].ToString(), "persyaratan");
                }


            }
            catch (Exception ex)
            {
                litPersyaratan.Text = ex.Message;
            }
        }
    }
}