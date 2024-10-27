using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI
{
    public partial class Beranda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pangkat = Server.HtmlEncode(Request.QueryString["p"]);
            if (pangkat == null)
                return;

            if (pangkat.ToLower() == "taruna" || pangkat.ToLower() == "tamtama" || pangkat.ToLower() == "bintara")
                Session[cSession.sPangkat] = Request.QueryString["p"];
            else
                Session[cSession.sPangkat] = "bintara";
        }
    }
}