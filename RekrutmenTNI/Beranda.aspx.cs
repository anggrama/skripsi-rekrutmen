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

            if (pangkat.ToLower() == "taruna")
            {
                Session[cSession.sPangkat] = "taruna/taruni tni";
            }

            if (pangkat.ToLower() == "papk")
            {
                Session[cSession.sPangkat] = "pa pk tni";
            }

            if (pangkat.ToLower() == "psdp")
            {
                Session[cSession.sPangkat] = "pa psdp pnb tni";
            }


            if (pangkat.ToLower() == "bintaraad")
            {
                Session[cSession.sPangkat] = "bintara tni ad";
            }

            if (pangkat.ToLower() == "bintaraal")
            {
                Session[cSession.sPangkat] = "bintara tni al";
            }
            if (pangkat.ToLower() == "bintaraau")
            {
                Session[cSession.sPangkat] = "bintara tni au";
            }

            if (pangkat.ToLower() == "tamtamaad")
            {
                Session[cSession.sPangkat] = "tamtama tni ad";
            }
            if (pangkat.ToLower() == "tamtamaal")
            {
                Session[cSession.sPangkat] = "tamtama tni al";
            }
            if (pangkat.ToLower() == "tamtamaau")
            {
                Session[cSession.sPangkat] = "tamtama tni au";
            }

        }
    }
}