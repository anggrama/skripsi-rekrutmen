using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string isStart = Request.QueryString["isStart"];
            if (isStart != null)
                Session.RemoveAll();

            Response.Redirect("Beranda.aspx");
        }
    }
}