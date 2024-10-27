using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI
{
    public partial class Materi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (DataAccess.DataAccessInfo oDa = new DataAccess.DataAccessInfo())
                {
                    litMateri.Text = oDa.getValue_Settings(Session[cSession.sPangkat].ToString(), "materi seleksi");
                }
            }
            catch (Exception ex)
            {
                litMateri.Text = ex.Message;
            }
        }
    }
}