using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI
{
    public partial class Jadwal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (DataAccess.DataAccessInfo oDa = new DataAccess.DataAccessInfo())
                {
                    litJadwal.Text = oDa.getValue_Settings(Session[cSession.sPangkat].ToString(), "jadwal");
                    litLokasi.Text = oDa.getValue_Settings(Session[cSession.sPangkat].ToString(), "lokasi");
                }
            }
            catch (Exception ex)
            {
                litJadwal.Text = ex.Message;
            }
        }
    }
}