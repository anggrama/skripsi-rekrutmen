using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RekrutmenTNI
{
    public partial class Video : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string videoType = Request.QueryString["type"];

            try
            {
                string videoLink = System.Configuration.ConfigurationManager.AppSettings["videolink_" + videoType];
                frameVideo.Attributes.Add("src", videoLink);
            }
            catch (Exception)
            {
                throw;
            }
            

            

        }
    }
}