using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI.Administrator
{
    public partial class ucFilterPangkat : System.Web.UI.UserControl
    {

        public string Pangkat
        {
            get { return Convert.ToString(Session[cSession.sFilter_Pangkat]); }
        }

        protected override void OnInit(EventArgs e)
        {
            if (!IsPostBack && !Page.IsCallback)
            {
                //cek apakah sudah ada session filter pangkat ( default )
                if (Session[cSession.sFilter_Pangkat] == null)
                    Session[cSession.sFilter_Pangkat] = "Bintara";
                else
                    drpPangkat.Value = Session[cSession.sFilter_Pangkat];
            }
        }

    }
}