using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RekrutmenTNI
{
    public partial class Pengumuman : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (DataAccess.DataAccessInfo oDa = new DataAccess.DataAccessInfo())
                {
                    litPengumuman.Text = oDa.getValue_Settings(Session[cSession.sPangkat].ToString(), "pengumuman");
                }
                    
                   
            }
            catch (Exception ex)
            {
                litPengumuman.Text = ex.Message;
            }
        }

     
    }
}