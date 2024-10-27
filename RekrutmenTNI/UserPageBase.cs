using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RekrutmenTNI
{
    public class UserPageBase : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            cSession.checkUserSession();

        }
    }
}