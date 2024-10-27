using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI
{
    public partial class NotFound : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string errCode = Request.QueryString["err"];
            if (errCode == "1")
            {
                txt1.Text = "Error";
                txt2.Text = "Pendaftaran";
                litMessage.Text = "Mohon Maaf, <br /> Pendaftaran TNI AU belum dilaksanakan, coba lagi pada waktu yang ditentukan... <br/><br/> klik <a href='jadwal.aspx'>disini</a> untuk melihat info jadwal dan lokasi pendaftaran.";
            }
        }
    }
}